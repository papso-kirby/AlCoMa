namespace AlCoMa
{
    partial class GiveDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveDialog));
            FriendsListBox = new ListBox();
            FriendFilterTextBox = new TextBox();
            CardsToGIveTextBox = new TextBox();
            GiveCancelButton = new Button();
            GiveButton = new Button();
            SuspendLayout();
            // 
            // FriendsListBox
            // 
            FriendsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FriendsListBox.FormattingEnabled = true;
            FriendsListBox.ItemHeight = 20;
            FriendsListBox.Location = new Point(612, 54);
            FriendsListBox.Name = "FriendsListBox";
            FriendsListBox.Size = new Size(176, 344);
            FriendsListBox.TabIndex = 0;
            FriendsListBox.SelectedIndexChanged += FriendsListBox_SelectedIndexChanged;
            // 
            // FriendFilterTextBox
            // 
            FriendFilterTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FriendFilterTextBox.Location = new Point(612, 12);
            FriendFilterTextBox.Name = "FriendFilterTextBox";
            FriendFilterTextBox.PlaceholderText = "Filter...";
            FriendFilterTextBox.Size = new Size(176, 27);
            FriendFilterTextBox.TabIndex = 1;
            FriendFilterTextBox.TextChanged += FriendFilterTextBox_TextChanged;
            // 
            // CardsToGIveTextBox
            // 
            CardsToGIveTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CardsToGIveTextBox.Location = new Point(12, 12);
            CardsToGIveTextBox.Multiline = true;
            CardsToGIveTextBox.Name = "CardsToGIveTextBox";
            CardsToGIveTextBox.Size = new Size(594, 386);
            CardsToGIveTextBox.TabIndex = 2;
            // 
            // GiveCancelButton
            // 
            GiveCancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GiveCancelButton.DialogResult = DialogResult.Cancel;
            GiveCancelButton.Location = new Point(698, 412);
            GiveCancelButton.Margin = new Padding(2);
            GiveCancelButton.Name = "GiveCancelButton";
            GiveCancelButton.Size = new Size(90, 27);
            GiveCancelButton.TabIndex = 5;
            GiveCancelButton.Text = "Cancel";
            GiveCancelButton.UseVisualStyleBackColor = true;
            // 
            // GiveButton
            // 
            GiveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            GiveButton.DialogResult = DialogResult.OK;
            GiveButton.Enabled = false;
            GiveButton.Location = new Point(603, 412);
            GiveButton.Margin = new Padding(2);
            GiveButton.Name = "GiveButton";
            GiveButton.Size = new Size(90, 27);
            GiveButton.TabIndex = 4;
            GiveButton.Text = "Give";
            GiveButton.UseVisualStyleBackColor = true;
            // 
            // GiveDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GiveCancelButton);
            Controls.Add(GiveButton);
            Controls.Add(CardsToGIveTextBox);
            Controls.Add(FriendFilterTextBox);
            Controls.Add(FriendsListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GiveDialog";
            Text = "Give cards to a friend";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox FriendsListBox;
        private TextBox FriendFilterTextBox;
        private TextBox CardsToGIveTextBox;
        private Button GiveCancelButton;
        private Button GiveButton;
    }
}