namespace AlCoMa
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            AppMainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            collectionToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            missingCardsToolStripMenuItem = new ToolStripMenuItem();
            missingCardstechToolStripMenuItem = new ToolStripMenuItem();
            surplusCardsToolStripMenuItem = new ToolStripMenuItem();
            surplusCardstechToolStripMenuItem = new ToolStripMenuItem();
            allhumanToolStripMenuItem = new ToolStripMenuItem();
            allToolStripMenuItem = new ToolStripMenuItem();
            CollectionDataGrid = new DataGridView();
            FactionSymbol = new DataGridViewImageColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inMyCollectionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Set = new DataGridViewTextBoxColumn();
            Faction = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            ImagePath = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            CollectionDataSet = new DataSet1();
            CardContextMenuStrip = new ContextMenuStrip(components);
            AddToGiftListMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            FilterTextBox = new TextBox();
            storageManagerBindingSource = new BindingSource(components);
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            AxiomCheckBox = new CheckBox();
            imageList1 = new ImageList(components);
            BravosCheckBox = new CheckBox();
            LyraCheckBox = new CheckBox();
            MunaCheckBox = new CheckBox();
            OrdisCheckBox = new CheckBox();
            YzmirCheckBox = new CheckBox();
            label4 = new Label();
            SurplusCheckBox = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            MergeKSCheckBox = new CheckBox();
            label1 = new Label();
            RareCheckBox = new CheckBox();
            CommonCheckBox = new CheckBox();
            label2 = new Label();
            CharacterCheckbox = new CheckBox();
            SpellCheckBox = new CheckBox();
            PermanentCheckBox = new CheckBox();
            HeroCheckBox = new CheckBox();
            TokenCharacterCheckBox = new CheckBox();
            label3 = new Label();
            KSCheckBox = new CheckBox();
            BTGCheckBox = new CheckBox();
            tabPage3 = new TabPage();
            GiveListGridView = new DataGridView();
            FactionSymbol1 = new DataGridViewImageColumn();
            Name1 = new DataGridViewTextBoxColumn();
            Number1 = new DataGridViewTextBoxColumn();
            Faction1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            ID1 = new DataGridViewTextBoxColumn();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ClearGiftListButton = new Button();
            tabPage2 = new TabPage();
            LogTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            MainStatusStrip = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            GiveButton = new Button();
            AppMainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollectionDataSet).BeginInit();
            CardContextMenuStrip.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GiveListGridView).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            tabPage2.SuspendLayout();
            MainStatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            AppMainMenuStrip.ImageScalingSize = new Size(24, 24);
            AppMainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, collectionToolStripMenuItem });
            AppMainMenuStrip.Location = new Point(0, 0);
            AppMainMenuStrip.Name = "MainMenuStrip";
            AppMainMenuStrip.Padding = new Padding(5, 2, 0, 2);
            AppMainMenuStrip.Size = new Size(1177, 28);
            AppMainMenuStrip.TabIndex = 0;
            AppMainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(128, 26);
            closeToolStripMenuItem.Text = "Close";
            // 
            // collectionToolStripMenuItem
            // 
            collectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            collectionToolStripMenuItem.Size = new Size(90, 24);
            collectionToolStripMenuItem.Text = "Collection";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(137, 26);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { missingCardsToolStripMenuItem, missingCardstechToolStripMenuItem, surplusCardsToolStripMenuItem, surplusCardstechToolStripMenuItem, allhumanToolStripMenuItem, allToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(137, 26);
            exportToolStripMenuItem.Text = "Export";
            // 
            // missingCardsToolStripMenuItem
            // 
            missingCardsToolStripMenuItem.Name = "missingCardsToolStripMenuItem";
            missingCardsToolStripMenuItem.Size = new Size(242, 26);
            missingCardsToolStripMenuItem.Text = "Missing Cards (human)";
            missingCardsToolStripMenuItem.Click += missingCardsToolStripMenuItem_Click;
            // 
            // missingCardstechToolStripMenuItem
            // 
            missingCardstechToolStripMenuItem.Name = "missingCardstechToolStripMenuItem";
            missingCardstechToolStripMenuItem.Size = new Size(242, 26);
            missingCardstechToolStripMenuItem.Text = "Missing Cards (tech)";
            missingCardstechToolStripMenuItem.Click += missingCardstechToolStripMenuItem_Click;
            // 
            // surplusCardsToolStripMenuItem
            // 
            surplusCardsToolStripMenuItem.Name = "surplusCardsToolStripMenuItem";
            surplusCardsToolStripMenuItem.Size = new Size(242, 26);
            surplusCardsToolStripMenuItem.Text = "Surplus Cards (human)";
            surplusCardsToolStripMenuItem.Click += surplusCardsToolStripMenuItem_Click;
            // 
            // surplusCardstechToolStripMenuItem
            // 
            surplusCardstechToolStripMenuItem.Name = "surplusCardstechToolStripMenuItem";
            surplusCardstechToolStripMenuItem.Size = new Size(242, 26);
            surplusCardstechToolStripMenuItem.Text = "Surplus Cards (tech)";
            surplusCardstechToolStripMenuItem.Click += surplusCardstechToolStripMenuItem_Click;
            // 
            // allhumanToolStripMenuItem
            // 
            allhumanToolStripMenuItem.Name = "allhumanToolStripMenuItem";
            allhumanToolStripMenuItem.Size = new Size(242, 26);
            allhumanToolStripMenuItem.Text = "All (human)";
            allhumanToolStripMenuItem.Click += allhumanToolStripMenuItem_Click;
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(242, 26);
            allToolStripMenuItem.Text = "All (tech)";
            allToolStripMenuItem.Click += allToolStripMenuItem_Click;
            // 
            // CollectionDataGrid
            // 
            CollectionDataGrid.AllowUserToAddRows = false;
            CollectionDataGrid.AllowUserToDeleteRows = false;
            CollectionDataGrid.AllowUserToOrderColumns = true;
            CollectionDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollectionDataGrid.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            CollectionDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            CollectionDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CollectionDataGrid.Columns.AddRange(new DataGridViewColumn[] { FactionSymbol, dataGridViewTextBoxColumn1, inMyCollectionDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, Set, Faction, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, ImagePath, ID });
            CollectionDataGrid.DataMember = "Masterdata";
            CollectionDataGrid.DataSource = CollectionDataSet;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            CollectionDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            CollectionDataGrid.Location = new Point(4, 98);
            CollectionDataGrid.Margin = new Padding(2);
            CollectionDataGrid.Name = "CollectionDataGrid";
            CollectionDataGrid.ReadOnly = true;
            CollectionDataGrid.RowHeadersVisible = false;
            CollectionDataGrid.RowHeadersWidth = 62;
            CollectionDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CollectionDataGrid.ShowEditingIcon = false;
            CollectionDataGrid.Size = new Size(1169, 580);
            CollectionDataGrid.TabIndex = 1;
            CollectionDataGrid.CellFormatting += CollectionDataGrid_CellFormatting;
            CollectionDataGrid.CellMouseEnter += CollectionDataGrid_CellMouseEnter;
            CollectionDataGrid.MouseDown += CollectionDataGrid_MouseDown;
            // 
            // FactionSymbol
            // 
            FactionSymbol.HeaderText = "";
            FactionSymbol.MinimumWidth = 8;
            FactionSymbol.Name = "FactionSymbol";
            FactionSymbol.ReadOnly = true;
            FactionSymbol.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // inMyCollectionDataGridViewTextBoxColumn
            // 
            inMyCollectionDataGridViewTextBoxColumn.DataPropertyName = "InMyCollection";
            inMyCollectionDataGridViewTextBoxColumn.HeaderText = "InMyCollection";
            inMyCollectionDataGridViewTextBoxColumn.MinimumWidth = 8;
            inMyCollectionDataGridViewTextBoxColumn.Name = "inMyCollectionDataGridViewTextBoxColumn";
            inMyCollectionDataGridViewTextBoxColumn.ReadOnly = true;
            inMyCollectionDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Number";
            dataGridViewTextBoxColumn2.HeaderText = "Number";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Set
            // 
            Set.DataPropertyName = "Set";
            Set.HeaderText = "Set";
            Set.MinimumWidth = 8;
            Set.Name = "Set";
            Set.ReadOnly = true;
            Set.Width = 150;
            // 
            // Faction
            // 
            Faction.DataPropertyName = "Faction";
            Faction.HeaderText = "Faction";
            Faction.MinimumWidth = 8;
            Faction.Name = "Faction";
            Faction.ReadOnly = true;
            Faction.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Rarity";
            dataGridViewTextBoxColumn4.HeaderText = "Rarity";
            dataGridViewTextBoxColumn4.MinimumWidth = 8;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Type";
            dataGridViewTextBoxColumn5.HeaderText = "Type";
            dataGridViewTextBoxColumn5.MinimumWidth = 8;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "ForestPower";
            dataGridViewTextBoxColumn6.HeaderText = "ForestPower";
            dataGridViewTextBoxColumn6.MinimumWidth = 8;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "MountainPower";
            dataGridViewTextBoxColumn7.HeaderText = "MountainPower";
            dataGridViewTextBoxColumn7.MinimumWidth = 8;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "WaterPower";
            dataGridViewTextBoxColumn8.HeaderText = "WaterPower";
            dataGridViewTextBoxColumn8.MinimumWidth = 8;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "HandCost";
            dataGridViewTextBoxColumn9.HeaderText = "HandCost";
            dataGridViewTextBoxColumn9.MinimumWidth = 8;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "ReserveCost";
            dataGridViewTextBoxColumn10.HeaderText = "ReserveCost";
            dataGridViewTextBoxColumn10.MinimumWidth = 8;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Abilities";
            dataGridViewTextBoxColumn11.HeaderText = "Abilities";
            dataGridViewTextBoxColumn11.MinimumWidth = 8;
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "SupportAbility";
            dataGridViewTextBoxColumn12.HeaderText = "SupportAbility";
            dataGridViewTextBoxColumn12.MinimumWidth = 8;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 150;
            // 
            // ImagePath
            // 
            ImagePath.DataPropertyName = "ImagePath";
            ImagePath.HeaderText = "ImagePath";
            ImagePath.MinimumWidth = 8;
            ImagePath.Name = "ImagePath";
            ImagePath.ReadOnly = true;
            ImagePath.Visible = false;
            ImagePath.Width = 150;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 150;
            // 
            // CollectionDataSet
            // 
            CollectionDataSet.DataSetName = "CollectionDataSet";
            CollectionDataSet.Namespace = "http://tempuri.org/DataSet1.xsd";
            CollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CardContextMenuStrip
            // 
            CardContextMenuStrip.ImageScalingSize = new Size(20, 20);
            CardContextMenuStrip.Items.AddRange(new ToolStripItem[] { AddToGiftListMenuItem });
            CardContextMenuStrip.Name = "CardContextMenuStrip";
            CardContextMenuStrip.Size = new Size(176, 28);
            CardContextMenuStrip.Click += CardContextMenuStrip_Click;
            // 
            // AddToGiftListMenuItem
            // 
            AddToGiftListMenuItem.Name = "AddToGiftListMenuItem";
            AddToGiftListMenuItem.Size = new Size(175, 24);
            AddToGiftListMenuItem.Text = "Add to Gift list";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 30);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1177, 738);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FilterTextBox);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(CollectionDataGrid);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1169, 705);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Collection";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            FilterTextBox.DataBindings.Add(new Binding("Text", storageManagerBindingSource, "FilterText", true, DataSourceUpdateMode.OnPropertyChanged));
            FilterTextBox.Location = new Point(4, 67);
            FilterTextBox.Margin = new Padding(2);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.PlaceholderText = "Type to filer....";
            FilterTextBox.Size = new Size(537, 27);
            FilterTextBox.TabIndex = 3;
            // 
            // storageManagerBindingSource
            // 
            storageManagerBindingSource.DataSource = typeof(StorageManager);
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1165, 61);
            panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(AxiomCheckBox);
            flowLayoutPanel2.Controls.Add(BravosCheckBox);
            flowLayoutPanel2.Controls.Add(LyraCheckBox);
            flowLayoutPanel2.Controls.Add(MunaCheckBox);
            flowLayoutPanel2.Controls.Add(OrdisCheckBox);
            flowLayoutPanel2.Controls.Add(YzmirCheckBox);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(SurplusCheckBox);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 32);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1165, 26);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // AxiomCheckBox
            // 
            AxiomCheckBox.Checked = true;
            AxiomCheckBox.CheckState = CheckState.Checked;
            AxiomCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeAxiom", true, DataSourceUpdateMode.OnPropertyChanged));
            AxiomCheckBox.ImageIndex = 0;
            AxiomCheckBox.ImageList = imageList1;
            AxiomCheckBox.Location = new Point(2, 2);
            AxiomCheckBox.Margin = new Padding(2);
            AxiomCheckBox.Name = "AxiomCheckBox";
            AxiomCheckBox.Size = new Size(42, 24);
            AxiomCheckBox.TabIndex = 0;
            AxiomCheckBox.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Axiom.png");
            imageList1.Images.SetKeyName(1, "Bravos.png");
            imageList1.Images.SetKeyName(2, "Lyra.png");
            imageList1.Images.SetKeyName(3, "Muna.png");
            imageList1.Images.SetKeyName(4, "Ordis.png");
            imageList1.Images.SetKeyName(5, "Yzmir.png");
            // 
            // BravosCheckBox
            // 
            BravosCheckBox.Checked = true;
            BravosCheckBox.CheckState = CheckState.Checked;
            BravosCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeBravos", true, DataSourceUpdateMode.OnPropertyChanged));
            BravosCheckBox.ImageIndex = 1;
            BravosCheckBox.ImageList = imageList1;
            BravosCheckBox.Location = new Point(48, 2);
            BravosCheckBox.Margin = new Padding(2);
            BravosCheckBox.Name = "BravosCheckBox";
            BravosCheckBox.Size = new Size(42, 24);
            BravosCheckBox.TabIndex = 1;
            BravosCheckBox.UseVisualStyleBackColor = true;
            // 
            // LyraCheckBox
            // 
            LyraCheckBox.Checked = true;
            LyraCheckBox.CheckState = CheckState.Checked;
            LyraCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeLyra", true, DataSourceUpdateMode.OnPropertyChanged));
            LyraCheckBox.ImageIndex = 2;
            LyraCheckBox.ImageList = imageList1;
            LyraCheckBox.Location = new Point(94, 2);
            LyraCheckBox.Margin = new Padding(2);
            LyraCheckBox.Name = "LyraCheckBox";
            LyraCheckBox.Size = new Size(42, 24);
            LyraCheckBox.TabIndex = 2;
            LyraCheckBox.UseVisualStyleBackColor = true;
            // 
            // MunaCheckBox
            // 
            MunaCheckBox.Checked = true;
            MunaCheckBox.CheckState = CheckState.Checked;
            MunaCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeMuna", true, DataSourceUpdateMode.OnPropertyChanged));
            MunaCheckBox.ImageIndex = 3;
            MunaCheckBox.ImageList = imageList1;
            MunaCheckBox.Location = new Point(140, 2);
            MunaCheckBox.Margin = new Padding(2);
            MunaCheckBox.Name = "MunaCheckBox";
            MunaCheckBox.Size = new Size(42, 24);
            MunaCheckBox.TabIndex = 3;
            MunaCheckBox.UseVisualStyleBackColor = true;
            // 
            // OrdisCheckBox
            // 
            OrdisCheckBox.Checked = true;
            OrdisCheckBox.CheckState = CheckState.Checked;
            OrdisCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeOrdis", true, DataSourceUpdateMode.OnPropertyChanged));
            OrdisCheckBox.ImageIndex = 4;
            OrdisCheckBox.ImageList = imageList1;
            OrdisCheckBox.Location = new Point(186, 2);
            OrdisCheckBox.Margin = new Padding(2);
            OrdisCheckBox.Name = "OrdisCheckBox";
            OrdisCheckBox.Size = new Size(42, 24);
            OrdisCheckBox.TabIndex = 4;
            OrdisCheckBox.UseVisualStyleBackColor = true;
            // 
            // YzmirCheckBox
            // 
            YzmirCheckBox.Checked = true;
            YzmirCheckBox.CheckState = CheckState.Checked;
            YzmirCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeYzmir", true, DataSourceUpdateMode.OnPropertyChanged));
            YzmirCheckBox.ImageIndex = 5;
            YzmirCheckBox.ImageList = imageList1;
            YzmirCheckBox.Location = new Point(232, 2);
            YzmirCheckBox.Margin = new Padding(2);
            YzmirCheckBox.Name = "YzmirCheckBox";
            YzmirCheckBox.Size = new Size(42, 24);
            YzmirCheckBox.TabIndex = 5;
            YzmirCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(278, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(2, 22);
            label4.TabIndex = 11;
            // 
            // SurplusCheckBox
            // 
            SurplusCheckBox.AutoSize = true;
            SurplusCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "Surplus", true, DataSourceUpdateMode.OnPropertyChanged));
            SurplusCheckBox.Location = new Point(284, 2);
            SurplusCheckBox.Margin = new Padding(2);
            SurplusCheckBox.Name = "SurplusCheckBox";
            SurplusCheckBox.Size = new Size(79, 24);
            SurplusCheckBox.TabIndex = 13;
            SurplusCheckBox.Text = "Surplus";
            SurplusCheckBox.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(MergeKSCheckBox);
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(RareCheckBox);
            flowLayoutPanel1.Controls.Add(CommonCheckBox);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(CharacterCheckbox);
            flowLayoutPanel1.Controls.Add(SpellCheckBox);
            flowLayoutPanel1.Controls.Add(PermanentCheckBox);
            flowLayoutPanel1.Controls.Add(HeroCheckBox);
            flowLayoutPanel1.Controls.Add(TokenCharacterCheckBox);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(KSCheckBox);
            flowLayoutPanel1.Controls.Add(BTGCheckBox);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1165, 32);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // MergeKSCheckBox
            // 
            MergeKSCheckBox.AutoSize = true;
            MergeKSCheckBox.Checked = true;
            MergeKSCheckBox.CheckState = CheckState.Checked;
            MergeKSCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "MergeKS", true, DataSourceUpdateMode.OnPropertyChanged));
            MergeKSCheckBox.Location = new Point(2, 2);
            MergeKSCheckBox.Margin = new Padding(2);
            MergeKSCheckBox.Name = "MergeKSCheckBox";
            MergeKSCheckBox.Size = new Size(124, 24);
            MergeKSCheckBox.TabIndex = 0;
            MergeKSCheckBox.Text = "Merge BTG KS";
            MergeKSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(130, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(2, 22);
            label1.TabIndex = 8;
            // 
            // RareCheckBox
            // 
            RareCheckBox.AutoSize = true;
            RareCheckBox.Checked = true;
            RareCheckBox.CheckState = CheckState.Checked;
            RareCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeRare", true, DataSourceUpdateMode.OnPropertyChanged));
            RareCheckBox.Location = new Point(136, 2);
            RareCheckBox.Margin = new Padding(2);
            RareCheckBox.Name = "RareCheckBox";
            RareCheckBox.Size = new Size(67, 24);
            RareCheckBox.TabIndex = 1;
            RareCheckBox.Text = "Rares";
            RareCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommonCheckBox
            // 
            CommonCheckBox.AutoSize = true;
            CommonCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeCommon", true, DataSourceUpdateMode.OnPropertyChanged));
            CommonCheckBox.Location = new Point(207, 2);
            CommonCheckBox.Margin = new Padding(2);
            CommonCheckBox.Name = "CommonCheckBox";
            CommonCheckBox.Size = new Size(98, 24);
            CommonCheckBox.TabIndex = 2;
            CommonCheckBox.Text = "Commons";
            CommonCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(309, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(2, 22);
            label2.TabIndex = 9;
            // 
            // CharacterCheckbox
            // 
            CharacterCheckbox.AutoSize = true;
            CharacterCheckbox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeCharacter", true, DataSourceUpdateMode.OnPropertyChanged));
            CharacterCheckbox.Location = new Point(315, 2);
            CharacterCheckbox.Margin = new Padding(2);
            CharacterCheckbox.Name = "CharacterCheckbox";
            CharacterCheckbox.Size = new Size(94, 24);
            CharacterCheckbox.TabIndex = 3;
            CharacterCheckbox.Text = "Character";
            CharacterCheckbox.UseVisualStyleBackColor = true;
            // 
            // SpellCheckBox
            // 
            SpellCheckBox.AutoSize = true;
            SpellCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeSpell", true, DataSourceUpdateMode.OnPropertyChanged));
            SpellCheckBox.Location = new Point(413, 2);
            SpellCheckBox.Margin = new Padding(2);
            SpellCheckBox.Name = "SpellCheckBox";
            SpellCheckBox.Size = new Size(64, 24);
            SpellCheckBox.TabIndex = 4;
            SpellCheckBox.Text = "Spell";
            SpellCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermanentCheckBox
            // 
            PermanentCheckBox.AutoSize = true;
            PermanentCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludePermanent", true, DataSourceUpdateMode.OnPropertyChanged));
            PermanentCheckBox.Location = new Point(481, 2);
            PermanentCheckBox.Margin = new Padding(2);
            PermanentCheckBox.Name = "PermanentCheckBox";
            PermanentCheckBox.Size = new Size(101, 24);
            PermanentCheckBox.TabIndex = 5;
            PermanentCheckBox.Text = "Permanent";
            PermanentCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeroCheckBox
            // 
            HeroCheckBox.AutoSize = true;
            HeroCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeHero", true, DataSourceUpdateMode.OnPropertyChanged));
            HeroCheckBox.Location = new Point(586, 2);
            HeroCheckBox.Margin = new Padding(2);
            HeroCheckBox.Name = "HeroCheckBox";
            HeroCheckBox.Size = new Size(64, 24);
            HeroCheckBox.TabIndex = 6;
            HeroCheckBox.Text = "Hero";
            HeroCheckBox.UseVisualStyleBackColor = true;
            // 
            // TokenCharacterCheckBox
            // 
            TokenCharacterCheckBox.AutoSize = true;
            TokenCharacterCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeTokenCharacter", true, DataSourceUpdateMode.OnPropertyChanged));
            TokenCharacterCheckBox.Location = new Point(654, 2);
            TokenCharacterCheckBox.Margin = new Padding(2);
            TokenCharacterCheckBox.Name = "TokenCharacterCheckBox";
            TokenCharacterCheckBox.Size = new Size(76, 24);
            TokenCharacterCheckBox.TabIndex = 7;
            TokenCharacterCheckBox.Text = "Tokens";
            TokenCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(734, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(2, 22);
            label3.TabIndex = 10;
            // 
            // KSCheckBox
            // 
            KSCheckBox.AutoSize = true;
            KSCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeKS", true, DataSourceUpdateMode.OnPropertyChanged));
            KSCheckBox.Location = new Point(740, 2);
            KSCheckBox.Margin = new Padding(2);
            KSCheckBox.Name = "KSCheckBox";
            KSCheckBox.Size = new Size(48, 24);
            KSCheckBox.TabIndex = 11;
            KSCheckBox.Text = "KS";
            KSCheckBox.UseVisualStyleBackColor = true;
            // 
            // BTGCheckBox
            // 
            BTGCheckBox.AutoSize = true;
            BTGCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeBTG", true, DataSourceUpdateMode.OnPropertyChanged));
            BTGCheckBox.Location = new Point(792, 2);
            BTGCheckBox.Margin = new Padding(2);
            BTGCheckBox.Name = "BTGCheckBox";
            BTGCheckBox.Size = new Size(56, 24);
            BTGCheckBox.TabIndex = 12;
            BTGCheckBox.Text = "BTG";
            BTGCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(GiveListGridView);
            tabPage3.Controls.Add(flowLayoutPanel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1169, 705);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Gift List";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // GiveListGridView
            // 
            GiveListGridView.AllowUserToAddRows = false;
            GiveListGridView.AllowUserToDeleteRows = false;
            GiveListGridView.AutoGenerateColumns = false;
            GiveListGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GiveListGridView.Columns.AddRange(new DataGridViewColumn[] { FactionSymbol1, Name1, Number1, Faction1, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, ID1 });
            GiveListGridView.DataMember = "Givelist";
            GiveListGridView.DataSource = CollectionDataSet;
            GiveListGridView.Dock = DockStyle.Fill;
            GiveListGridView.Location = new Point(3, 38);
            GiveListGridView.Name = "GiveListGridView";
            GiveListGridView.RowHeadersVisible = false;
            GiveListGridView.RowHeadersWidth = 51;
            GiveListGridView.RowTemplate.Height = 29;
            GiveListGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GiveListGridView.Size = new Size(1163, 664);
            GiveListGridView.TabIndex = 1;
            GiveListGridView.CellFormatting += CollectionDataGrid_CellFormatting;
            // 
            // FactionSymbol1
            // 
            FactionSymbol1.HeaderText = "";
            FactionSymbol1.MinimumWidth = 6;
            FactionSymbol1.Name = "FactionSymbol1";
            FactionSymbol1.ReadOnly = true;
            FactionSymbol1.Width = 125;
            // 
            // Name1
            // 
            Name1.DataPropertyName = "Name";
            Name1.HeaderText = "Name";
            Name1.MinimumWidth = 6;
            Name1.Name = "Name1";
            Name1.Width = 125;
            // 
            // Number1
            // 
            Number1.DataPropertyName = "Number";
            Number1.HeaderText = "Number";
            Number1.MinimumWidth = 6;
            Number1.Name = "Number1";
            Number1.Width = 125;
            // 
            // Faction1
            // 
            Faction1.DataPropertyName = "Faction";
            Faction1.HeaderText = "Faction";
            Faction1.MinimumWidth = 6;
            Faction1.Name = "Faction1";
            Faction1.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "Rarity";
            dataGridViewTextBoxColumn15.HeaderText = "Rarity";
            dataGridViewTextBoxColumn15.MinimumWidth = 6;
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "Type";
            dataGridViewTextBoxColumn16.HeaderText = "Type";
            dataGridViewTextBoxColumn16.MinimumWidth = 6;
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Width = 125;
            // 
            // ID1
            // 
            ID1.DataPropertyName = "ID";
            ID1.HeaderText = "ID";
            ID1.MinimumWidth = 6;
            ID1.Name = "ID1";
            ID1.Width = 125;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(ClearGiftListButton);
            flowLayoutPanel3.Controls.Add(GiveButton);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(3, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1163, 35);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // ClearGiftListButton
            // 
            ClearGiftListButton.Location = new Point(3, 3);
            ClearGiftListButton.Name = "ClearGiftListButton";
            ClearGiftListButton.Size = new Size(94, 29);
            ClearGiftListButton.TabIndex = 0;
            ClearGiftListButton.Text = "Clear";
            ClearGiftListButton.UseVisualStyleBackColor = true;
            ClearGiftListButton.Click += ClearGiftListButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LogTextBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1169, 705);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            LogTextBox.Dock = DockStyle.Fill;
            LogTextBox.Location = new Point(2, 2);
            LogTextBox.Margin = new Padding(2);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(1165, 701);
            LogTextBox.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.OwnerDraw = true;
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.ImageScalingSize = new Size(24, 24);
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { StatusLabel, toolStripProgressBar1 });
            MainStatusStrip.Location = new Point(0, 740);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Padding = new Padding(1, 0, 12, 0);
            MainStatusStrip.Size = new Size(1177, 28);
            MainStatusStrip.TabIndex = 4;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(27, 22);
            StatusLabel.Text = "---";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(83, 20);
            // 
            // GiveButton
            // 
            GiveButton.Location = new Point(103, 3);
            GiveButton.Name = "GiveButton";
            GiveButton.Size = new Size(94, 29);
            GiveButton.TabIndex = 1;
            GiveButton.Text = "Give";
            GiveButton.UseVisualStyleBackColor = true;
            GiveButton.Click += GiveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1177, 768);
            Controls.Add(MainStatusStrip);
            Controls.Add(AppMainMenuStrip);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "AlCoMa - Altered Collection Manager";
            Load += MainForm_Load;
            AppMainMenuStrip.ResumeLayout(false);
            AppMainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CollectionDataSet).EndInit();
            CardContextMenuStrip.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GiveListGridView).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip AppMainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem collectionToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem;
        private DataGridView CollectionDataGrid;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox LogTextBox;
        private Panel panel1;
        private CheckBox MergeKSCheckBox;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox RareCheckBox;
        private CheckBox CommonCheckBox;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox AxiomCheckBox;
        private ImageList imageList1;
        private CheckBox BravosCheckBox;
        private CheckBox LyraCheckBox;
        private CheckBox MunaCheckBox;
        private CheckBox OrdisCheckBox;
        private CheckBox YzmirCheckBox;
        private TextBox FilterTextBox;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem missingCardsToolStripMenuItem;
        private DataGridViewTextBoxColumn inCollectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn forestPowerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mountainPowerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn waterPowerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn handCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reserveCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn abilitiesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supportAbilityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imageKeyDataGridViewTextBoxColumn;
        private DataSet1 CollectionDataSet;
        private BindingSource storageManagerBindingSource;
        private StatusStrip MainStatusStrip;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
        private CheckBox CharacterCheckbox;
        private CheckBox SpellCheckBox;
        private CheckBox PermanentCheckBox;
        private CheckBox HeroCheckBox;
        private CheckBox TokenCharacterCheckBox;
        private ToolStripMenuItem surplusCardsToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox KSCheckBox;
        private CheckBox BTGCheckBox;
        private ToolStripMenuItem AddToGiftListMenuItem;
        private ToolStripMenuItem missingCardstechToolStripMenuItem;
        private ToolStripMenuItem surplusCardstechToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem allhumanToolStripMenuItem;
        private Label label4;
        private CheckBox SurplusCheckBox;
        private ContextMenuStrip CardContextMenuStrip;
        private DataGridViewImageColumn FactionSymbol;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inMyCollectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Set;
        private DataGridViewTextBoxColumn Faction;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn ImagePath;
        private DataGridViewTextBoxColumn ID;
        private TabPage tabPage3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Button ClearGiftListButton;
        private DataGridView GiveListGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rarityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewImageColumn FactionSymbol1;
        private DataGridViewTextBoxColumn Name1;
        private DataGridViewTextBoxColumn Number1;
        private DataGridViewTextBoxColumn Faction1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn ID1;
        private Button GiveButton;
    }
}
