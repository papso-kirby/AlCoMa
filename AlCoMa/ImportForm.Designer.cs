namespace AlCoMa
{
    partial class ImportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TokenTextBox = new TextBox();
            ImportButton = new Button();
            ImportCancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 25);
            label1.TabIndex = 0;
            label1.Text = "Enter your Authentication token here:";
            // 
            // TokenTextBox
            // 
            TokenTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TokenTextBox.Location = new Point(12, 37);
            TokenTextBox.Multiline = true;
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.PlaceholderText = "eyJhb....";
            TokenTextBox.Size = new Size(776, 361);
            TokenTextBox.TabIndex = 1;
            TokenTextBox.TextChanged += TokenTextBox_TextChanged;
            // 
            // ImportButton
            // 
            ImportButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ImportButton.DialogResult = DialogResult.OK;
            ImportButton.Enabled = false;
            ImportButton.Location = new Point(558, 404);
            ImportButton.Name = "ImportButton";
            ImportButton.Size = new Size(112, 34);
            ImportButton.TabIndex = 2;
            ImportButton.Text = "Import";
            ImportButton.UseVisualStyleBackColor = true;
            // 
            // ImportCancelButton
            // 
            ImportCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ImportCancelButton.DialogResult = DialogResult.Cancel;
            ImportCancelButton.Location = new Point(676, 404);
            ImportCancelButton.Name = "ImportCancelButton";
            ImportCancelButton.Size = new Size(112, 34);
            ImportCancelButton.TabIndex = 3;
            ImportCancelButton.Text = "Cancel";
            ImportCancelButton.UseVisualStyleBackColor = true;
            // 
            // ImportForm
            // 
            AcceptButton = ImportButton;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ImportCancelButton);
            Controls.Add(ImportButton);
            Controls.Add(TokenTextBox);
            Controls.Add(label1);
            Name = "ImportForm";
            Text = "ImportForm";
            FormClosing += ImportForm_FormClosing;
            Load += ImportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TokenTextBox;
        private Button ImportButton;
        private Button ImportCancelButton;
    }
}