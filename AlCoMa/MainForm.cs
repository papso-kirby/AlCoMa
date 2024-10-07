using AlCoMa.types;
using AlCoMa.Types;
using CSharpFunctionalExtensions;
using CsvHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.CodeDom.Compiler;
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
                using GetAccessTokenDialog dialog = new();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                    try
                    {
                        var collection = await WebClient.GetCollection(dialog.Token);
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
            CollectionDataGrid.DataMember = null;
            CollectionDataGrid.DataSource = storage.Data;
            GiveListGridView.DataMember = null;
            GiveListGridView.DataSource = storage.Givelist;
            storageManagerBindingSource.DataSource = storage;
            storage.PropertyChanged += (object? sender, PropertyChangedEventArgs e)
                => StatusLabel.Text = $"Cards shown: {storage.CardsShown} - Cards total {storage.TotalCardsInCollection}";

            storage.Load();
        }

        private async void CollectionDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex].Name.StartsWith("FactionSymbol") && dgv.Rows[e.RowIndex].Cells.Count > 1)
            {
                string? columnValue = (dgv.Columns.Contains("Faction")
                    ? dgv.Rows[e.RowIndex].Cells["Faction"]
                    : dgv.Rows[e.RowIndex].Cells["Faction1"])?.Value as string;

                string? imagePath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath)!, "symbols", columnValue + ".png");
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
                string? imagePath = CollectionDataGrid.Rows[e.RowIndex].Cells["ImagePath"].Value as string;
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

        private void missingCardsToolStripMenuItem_Click(object sender, EventArgs e) => ExportHuman("[inMyCollection] < 3", "Missing", x => 3 - x);

        private void surplusCardsToolStripMenuItem_Click(object sender, EventArgs e) => ExportHuman("[inMyCollection] > 3", "Surplus", x => x - 3);

        private void missingCardstechToolStripMenuItem_Click(object sender, EventArgs e) => ExportMachine("[inMyCollection] < 3", "Missing", x => 3 - x);

        private void surplusCardstechToolStripMenuItem_Click(object sender, EventArgs e) => ExportMachine("[inMyCollection] > 3", "Missing", x => x - 3);

        private void ExportHuman(string filter, string filename, Func<int, int> mod) =>
            Export(filter, filename, (mergeKS, row) => mergeKS
                ? $"[{row["Faction"]}] {mod.Invoke(int.Parse(row["InMyCollection"].ToString()!))}x {row["Name"]}"
                : $"[{row["Faction"]}] {mod.Invoke(int.Parse(row["InMyCollection"].ToString()!))}x {row["Name"]} ({row["Set"]})");

        private void ExportMachine(string filter, string filename, Func<int, int> mod) =>
            Export(filter, filename, (mergeKS, row) => mergeKS
                ? $"{mod.Invoke(int.Parse(row["InMyCollection"].ToString()!))} {row["ID"].ToString()!.Replace("CORE_", "COREKS_")}"
                : $"{mod.Invoke(int.Parse(row["InMyCollection"].ToString()!))} {row["ID"]}");

        private void Export(string filter, string filename, Func<bool, DataRowView, string> lineWriter)
        {
            var dt = storage.Data.ToTable();
            dt.DefaultView.RowFilter = filter;
            dt.DefaultView.Sort = "faction ASC";
            string downloadPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads\\{filename}_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";

            using (StreamWriter sw = new StreamWriter(downloadPath))
            {
                foreach (DataRowView row in dt.DefaultView)
                {
                    string line = lineWriter.Invoke(storage.MergeKS, row);
                    sw.WriteLine(line);
                }
            }
            Process.Start(new ProcessStartInfo(downloadPath) { UseShellExecute = true });
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e) =>
            Export("", "All", (mergeKS, row) => mergeKS
                ? $"{int.Parse(row["InMyCollection"].ToString()!)} {row["ID"].ToString()!.Replace("CORE_", "COREKS_")}"
                : $"{int.Parse(row["InMyCollection"].ToString()!)} {row["ID"]}");

        private void allhumanToolStripMenuItem_Click(object sender, EventArgs e) =>
            Export("", "All", (mergeKS, row) => mergeKS
                ? $"[{row["Faction"]}] {int.Parse(row["InMyCollection"].ToString()!)}x {row["Name"]}"
                : $"[{row["Faction"]}] {int.Parse(row["InMyCollection"].ToString()!)}x {row["Name"]} ({row["Set"]})");

        private void CollectionDataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = CollectionDataGrid.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0)
                {
                    CollectionDataGrid.ClearSelection();
                    CollectionDataGrid.Rows[hit.RowIndex].Selected = true;
                    CardContextMenuStrip.Show(CollectionDataGrid, e.Location);
                }
            }
        }

        private void CardContextMenuStrip_Click(object sender, EventArgs e)
        {
            DataRow row = ((DataRowView)CollectionDataGrid.SelectedRows[0].DataBoundItem).Row;
            storage.AddCardToGiveList(row);
            MessageBox.Show(row["ID"].ToString() + " added");
        }

        private void ClearGiftListButton_Click(object sender, EventArgs e) => storage.ClearGivelist();

        private async void GiveButton_Click(object sender, EventArgs e)
        {
            try
            {
                using GetAccessTokenDialog dialog = new();
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                    try
                    {
                        var friends = await WebClient.GetFriends(dialog.Token);
                        var tmp = friends
                            .Tap(() => Logger.Log("Friends loaded"))
                            .Map(f =>
                            {
                                using GiveDialog giveDialog = new();
                                giveDialog.SetFriends(f.OrderBy(x => x.Name).ToList());
                                giveDialog.SetCards(String.Join("\r\n",
                                    storage.Givelist.Table!.AsEnumerable().Select(row => $"{row["ID"]} ({row["Faction"]} - {row["Name"]})")));
                                if (giveDialog.ShowDialog() == DialogResult.OK)
                                {
                                    return giveDialog.SelectedFriend;
                                }
                                return null;
                            })
                            .Ensure(friend => friend != null, "Aborted")
                            .TapError(() => Logger.Log("Could not give cards")); ;

                        if (tmp.IsSuccess)
                        {
                            var giveResult = await WebClient.GiveCards(dialog.Token, tmp.Value, storage.Givelist.Table!.AsEnumerable().Select(row => row["ID"].ToString()).ToList());
                            giveResult.Tap(() =>
                            {
                                MessageBox.Show("Cards gifted");
                                storage.ClearGivelist();
                            })
                            .TapError(() => Logger.Log("Could not give cards"));
                        }
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
    }
}
