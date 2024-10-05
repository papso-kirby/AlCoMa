using AlCoMa.types;
using AlCoMa.Types;
using CSharpFunctionalExtensions;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace AlCoMa
{
    public partial class MainForm : Form
    {
        StorageManager storage = new();

        public MainForm() => InitializeComponent();

        private async void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using ImportForm importForm = new();
                var result = importForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                    try
                    {
                        var collection = await WebClient.GetCollection(importForm.Token);
                        collection
                            .Bind(c => UserFiles.Collection.Save(JsonConvert.SerializeObject(c)))
                            .Tap(() => Logger.Log("Collection saved"))
                            .Tap(storage.Load)
                            .TapError(() => Logger.Log("Could not save Collection"));
                    }
                    catch (Exception ex)
                    {
                        Logger.Log(ex.ToString());
                    }
                }
            }
            finally
            {
                toolStripProgressBar1.Style = ProgressBarStyle.Blocks;
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.OnMessage += (s, message) => LogTextBox.Text += (message + "\r\n");
            CollectionDataGrid.DataSource = storage.Data;
            storageManagerBindingSource.DataSource = storage;
            storage.PropertyChanged += (object? sender, PropertyChangedEventArgs e)
                => StatusLabel.Text = $"Cards shown: {storage.CardsShown} - Cards total {storage.TotalCardsInCollection}";

            storage.Load();
        }

        private async void CollectionDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name == "FactionSymbol" && dgv.Rows[e.RowIndex].Cells.Count > 1)
            {
                string imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "symbols", dgv.Rows[e.RowIndex].Cells["Faction"].Value as string + ".png");
                e.Value = !string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath)
                    ? await ImageCache.GetImage(imagePath, new Size(32, 32))
                    : (object?)null;
            }
        }

        private async void CollectionDataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            toolTip1?.Dispose();
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                string imagePath = CollectionDataGrid.Rows[e.RowIndex].Cells["ImagePath"].Value as string;
                if (imagePath == null)
                {
                    return;
                }
                Image image = await ImageCache.GetImage(imagePath, new Size(744 / 2, 1039 / 2));

                float dpiScaleX, dpiScaleY;
                using (Graphics g = this.CreateGraphics())
                {
                    dpiScaleX = g.DpiX / 96.0f; // Default DPI is 96
                    dpiScaleY = g.DpiY / 96.0f;
                }
                int scaledWidth = (int)(image.Width * dpiScaleX);
                int scaledHeight = (int)(image.Height * dpiScaleY);
                toolTip1 = new ToolTip();
                toolTip1.OwnerDraw = true;
                toolTip1.Draw += (s, args) =>
                {
                    args.Graphics.DrawImage(image, new Rectangle(0, 0, scaledWidth, scaledHeight));
                };
                toolTip1.Popup += (s, args) =>
                {

                    args.ToolTipSize = new Size(scaledWidth, scaledHeight);
                };
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;

                toolTip1.Show("Image", this, this.PointToClient(Cursor.Position), 1000);
            }
        }

        private void missingCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = storage.Data.ToTable();
            dt.DefaultView.RowFilter = "[inMyCollection] < 3";
            dt.DefaultView.Sort = "faction ASC";
            string downloadPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads\\Missing_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

            using (StreamWriter sw = new StreamWriter(downloadPath))
            {
                foreach (DataRowView row in dt.DefaultView)
                {
                    string line = storage.MergeKS
                        ? $"[{row["Faction"]}] {3 - int.Parse(row["InMyCollection"].ToString())}x {row["Name"]}"
                        : $"[{row["Faction"]}] {3 - int.Parse(row["InMyCollection"].ToString())}x {row["Name"]} ({row["Set"]})";
                    sw.WriteLine(line);
                }
            }
            Process.Start(new ProcessStartInfo(downloadPath) { UseShellExecute = true });
        }

        private void surplusCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = storage.Data.ToTable();
            dt.DefaultView.RowFilter = "[inMyCollection] > 3";
            dt.DefaultView.Sort = "faction ASC";
            string downloadPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads\\Surplus_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

            using (StreamWriter sw = new StreamWriter(downloadPath))
            {
                foreach (DataRowView row in dt.DefaultView)
                {
                    string line = storage.MergeKS
                        ? $"[{row["Faction"]}] {-3 + int.Parse(row["InMyCollection"].ToString())}x {row["Name"]}"
                        : $"[{row["Faction"]}] {-3 + int.Parse(row["InMyCollection"].ToString())}x {row["Name"]} ({row["Set"]})";
                    sw.WriteLine(line);
                }
            }
            Process.Start(new ProcessStartInfo(downloadPath) { UseShellExecute = true });
        }
    }
}