using CSharpFunctionalExtensions;

namespace AlCoMa
{
    public partial class GetAccessTokenDialog : Form
    {
        public GetAccessTokenDialog() => InitializeComponent();
        private bool asyncCloseHack = true;

        private void TokenTextBox_TextChanged(object sender, EventArgs e) =>
            ImportButton.Enabled = !string.IsNullOrWhiteSpace(TokenTextBox.Text) && TokenTextBox.Text.Length > 20;

        private async void ImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (asyncCloseHack)
            {
                e.Cancel = true;
                if (this.DialogResult == DialogResult.OK)
                {
                    var ok = await WebClient.CheckToken(TokenTextBox.Text);
                    if (ok)
                    {
                        Logger.Log("Saving token");
                        UserFiles.Token.Save(TokenTextBox.Text);
                        asyncCloseHack = false;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        Logger.Log("Token invalid");
                        MessageBox.Show("The token is invalid");
                    }
                }
                else
                {
                    e.Cancel = false;
                }
                if (!asyncCloseHack)
                {
                    Close();
                }
            }
        }

        private void ImportForm_Load(object sender, EventArgs e) =>
            UserFiles.Token.Load().Tap(x => TokenTextBox.Text = x);

        public String Token => TokenTextBox.Text;
    }
}
