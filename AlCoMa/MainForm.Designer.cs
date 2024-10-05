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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            collectionToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            missingCardsToolStripMenuItem = new ToolStripMenuItem();
            surplusCardsToolStripMenuItem = new ToolStripMenuItem();
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
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CollectionDataSet = new DataSet1();
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
            tabPage2 = new TabPage();
            LogTextBox = new TextBox();
            toolTip1 = new ToolTip(components);
            TextFilterTimer = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CollectionDataSet).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tabPage2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, collectionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1412, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(157, 34);
            closeToolStripMenuItem.Text = "Close";
            // 
            // collectionToolStripMenuItem
            // 
            collectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importToolStripMenuItem, exportToolStripMenuItem });
            collectionToolStripMenuItem.Name = "collectionToolStripMenuItem";
            collectionToolStripMenuItem.Size = new Size(106, 29);
            collectionToolStripMenuItem.Text = "Collection";
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(169, 34);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += importToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { missingCardsToolStripMenuItem, surplusCardsToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(169, 34);
            exportToolStripMenuItem.Text = "Export";
            // 
            // missingCardsToolStripMenuItem
            // 
            missingCardsToolStripMenuItem.Name = "missingCardsToolStripMenuItem";
            missingCardsToolStripMenuItem.Size = new Size(225, 34);
            missingCardsToolStripMenuItem.Text = "Missing Cards";
            missingCardsToolStripMenuItem.Click += missingCardsToolStripMenuItem_Click;
            // 
            // surplusCardsToolStripMenuItem
            // 
            surplusCardsToolStripMenuItem.Name = "surplusCardsToolStripMenuItem";
            surplusCardsToolStripMenuItem.Size = new Size(225, 34);
            surplusCardsToolStripMenuItem.Text = "Surplus Cards";
            surplusCardsToolStripMenuItem.Click += surplusCardsToolStripMenuItem_Click;
            // 
            // CollectionDataGrid
            // 
            CollectionDataGrid.AllowUserToAddRows = false;
            CollectionDataGrid.AllowUserToDeleteRows = false;
            CollectionDataGrid.AllowUserToOrderColumns = true;
            CollectionDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollectionDataGrid.AutoGenerateColumns = false;
            CollectionDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CollectionDataGrid.Columns.AddRange(new DataGridViewColumn[] { FactionSymbol, dataGridViewTextBoxColumn1, inMyCollectionDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, Set, Faction, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, ImagePath, iDDataGridViewTextBoxColumn });
            CollectionDataGrid.DataMember = "Masterdata";
            CollectionDataGrid.DataSource = CollectionDataSet;
            CollectionDataGrid.Location = new Point(5, 131);
            CollectionDataGrid.Name = "CollectionDataGrid";
            CollectionDataGrid.ReadOnly = true;
            CollectionDataGrid.RowHeadersVisible = false;
            CollectionDataGrid.RowHeadersWidth = 62;
            CollectionDataGrid.ShowEditingIcon = false;
            CollectionDataGrid.Size = new Size(1403, 683);
            CollectionDataGrid.TabIndex = 1;
            CollectionDataGrid.CellFormatting += CollectionDataGrid_CellFormatting;
            CollectionDataGrid.CellMouseEnter += CollectionDataGrid_CellMouseEnter;
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
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // CollectionDataSet
            // 
            CollectionDataSet.DataSetName = "CollectionDataSet";
            CollectionDataSet.Namespace = "http://tempuri.org/DataSet1.xsd";
            CollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 36);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1412, 885);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FilterTextBox);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(CollectionDataGrid);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1404, 847);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Collection";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FilterTextBox
            // 
            FilterTextBox.DataBindings.Add(new Binding("Text", storageManagerBindingSource, "FilterText", true, DataSourceUpdateMode.OnPropertyChanged));
            FilterTextBox.Location = new Point(6, 94);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.PlaceholderText = "Type to filer....";
            FilterTextBox.Size = new Size(644, 31);
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
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 85);
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
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 39);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1398, 43);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // AxiomCheckBox
            // 
            AxiomCheckBox.Checked = true;
            AxiomCheckBox.CheckState = CheckState.Checked;
            AxiomCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeAxiom", true, DataSourceUpdateMode.OnPropertyChanged));
            AxiomCheckBox.ImageIndex = 0;
            AxiomCheckBox.ImageList = imageList1;
            AxiomCheckBox.Location = new Point(3, 3);
            AxiomCheckBox.Name = "AxiomCheckBox";
            AxiomCheckBox.Size = new Size(50, 29);
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
            BravosCheckBox.Location = new Point(59, 3);
            BravosCheckBox.Name = "BravosCheckBox";
            BravosCheckBox.Size = new Size(50, 29);
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
            LyraCheckBox.Location = new Point(115, 3);
            LyraCheckBox.Name = "LyraCheckBox";
            LyraCheckBox.Size = new Size(50, 29);
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
            MunaCheckBox.Location = new Point(171, 3);
            MunaCheckBox.Name = "MunaCheckBox";
            MunaCheckBox.Size = new Size(50, 29);
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
            OrdisCheckBox.Location = new Point(227, 3);
            OrdisCheckBox.Name = "OrdisCheckBox";
            OrdisCheckBox.Size = new Size(50, 29);
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
            YzmirCheckBox.Location = new Point(283, 3);
            YzmirCheckBox.Name = "YzmirCheckBox";
            YzmirCheckBox.Size = new Size(50, 29);
            YzmirCheckBox.TabIndex = 5;
            YzmirCheckBox.UseVisualStyleBackColor = true;
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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1398, 39);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // MergeKSCheckBox
            // 
            MergeKSCheckBox.AutoSize = true;
            MergeKSCheckBox.Checked = true;
            MergeKSCheckBox.CheckState = CheckState.Checked;
            MergeKSCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "MergeKS", true, DataSourceUpdateMode.OnPropertyChanged));
            MergeKSCheckBox.Location = new Point(3, 3);
            MergeKSCheckBox.Name = "MergeKSCheckBox";
            MergeKSCheckBox.Size = new Size(148, 29);
            MergeKSCheckBox.TabIndex = 0;
            MergeKSCheckBox.Text = "Merge BTG KS";
            MergeKSCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(157, 0);
            label1.Name = "label1";
            label1.Size = new Size(2, 27);
            label1.TabIndex = 8;
            // 
            // RareCheckBox
            // 
            RareCheckBox.AutoSize = true;
            RareCheckBox.Checked = true;
            RareCheckBox.CheckState = CheckState.Checked;
            RareCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeRare", true, DataSourceUpdateMode.OnPropertyChanged));
            RareCheckBox.Location = new Point(165, 3);
            RareCheckBox.Name = "RareCheckBox";
            RareCheckBox.Size = new Size(81, 29);
            RareCheckBox.TabIndex = 1;
            RareCheckBox.Text = "Rares";
            RareCheckBox.UseVisualStyleBackColor = true;
            // 
            // CommonCheckBox
            // 
            CommonCheckBox.AutoSize = true;
            CommonCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeCommon", true, DataSourceUpdateMode.OnPropertyChanged));
            CommonCheckBox.Location = new Point(252, 3);
            CommonCheckBox.Name = "CommonCheckBox";
            CommonCheckBox.Size = new Size(121, 29);
            CommonCheckBox.TabIndex = 2;
            CommonCheckBox.Text = "Commons";
            CommonCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(379, 0);
            label2.Name = "label2";
            label2.Size = new Size(2, 27);
            label2.TabIndex = 9;
            // 
            // CharacterCheckbox
            // 
            CharacterCheckbox.AutoSize = true;
            CharacterCheckbox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeCharacter", true, DataSourceUpdateMode.OnPropertyChanged));
            CharacterCheckbox.Location = new Point(387, 3);
            CharacterCheckbox.Name = "CharacterCheckbox";
            CharacterCheckbox.Size = new Size(112, 29);
            CharacterCheckbox.TabIndex = 3;
            CharacterCheckbox.Text = "Character";
            CharacterCheckbox.UseVisualStyleBackColor = true;
            // 
            // SpellCheckBox
            // 
            SpellCheckBox.AutoSize = true;
            SpellCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeSpell", true, DataSourceUpdateMode.OnPropertyChanged));
            SpellCheckBox.Location = new Point(505, 3);
            SpellCheckBox.Name = "SpellCheckBox";
            SpellCheckBox.Size = new Size(76, 29);
            SpellCheckBox.TabIndex = 4;
            SpellCheckBox.Text = "Spell";
            SpellCheckBox.UseVisualStyleBackColor = true;
            // 
            // PermanentCheckBox
            // 
            PermanentCheckBox.AutoSize = true;
            PermanentCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludePermanent", true, DataSourceUpdateMode.OnPropertyChanged));
            PermanentCheckBox.Location = new Point(587, 3);
            PermanentCheckBox.Name = "PermanentCheckBox";
            PermanentCheckBox.Size = new Size(122, 29);
            PermanentCheckBox.TabIndex = 5;
            PermanentCheckBox.Text = "Permanent";
            PermanentCheckBox.UseVisualStyleBackColor = true;
            // 
            // HeroCheckBox
            // 
            HeroCheckBox.AutoSize = true;
            HeroCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeHero", true, DataSourceUpdateMode.OnPropertyChanged));
            HeroCheckBox.Location = new Point(715, 3);
            HeroCheckBox.Name = "HeroCheckBox";
            HeroCheckBox.Size = new Size(77, 29);
            HeroCheckBox.TabIndex = 6;
            HeroCheckBox.Text = "Hero";
            HeroCheckBox.UseVisualStyleBackColor = true;
            // 
            // TokenCharacterCheckBox
            // 
            TokenCharacterCheckBox.AutoSize = true;
            TokenCharacterCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeTokenCharacter", true, DataSourceUpdateMode.OnPropertyChanged));
            TokenCharacterCheckBox.Location = new Point(798, 3);
            TokenCharacterCheckBox.Name = "TokenCharacterCheckBox";
            TokenCharacterCheckBox.Size = new Size(92, 29);
            TokenCharacterCheckBox.TabIndex = 7;
            TokenCharacterCheckBox.Text = "Tokens";
            TokenCharacterCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(896, 0);
            label3.Name = "label3";
            label3.Size = new Size(2, 27);
            label3.TabIndex = 10;
            // 
            // KSCheckBox
            // 
            KSCheckBox.AutoSize = true;
            KSCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeKS", true, DataSourceUpdateMode.OnPropertyChanged));
            KSCheckBox.Location = new Point(904, 3);
            KSCheckBox.Name = "KSCheckBox";
            KSCheckBox.Size = new Size(58, 29);
            KSCheckBox.TabIndex = 11;
            KSCheckBox.Text = "KS";
            KSCheckBox.UseVisualStyleBackColor = true;
            // 
            // BTGCheckBox
            // 
            BTGCheckBox.AutoSize = true;
            BTGCheckBox.DataBindings.Add(new Binding("Checked", storageManagerBindingSource, "IncludeBTG", true, DataSourceUpdateMode.OnPropertyChanged));
            BTGCheckBox.Location = new Point(968, 3);
            BTGCheckBox.Name = "BTGCheckBox";
            BTGCheckBox.Size = new Size(67, 29);
            BTGCheckBox.TabIndex = 12;
            BTGCheckBox.Text = "BTG";
            BTGCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(LogTextBox);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1404, 847);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Log";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            LogTextBox.Dock = DockStyle.Fill;
            LogTextBox.Location = new Point(3, 3);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(1398, 841);
            LogTextBox.TabIndex = 0;
            // 
            // toolTip1
            // 
            toolTip1.OwnerDraw = true;
            // 
            // TextFilterTimer
            // 
            TextFilterTimer.Interval = 1000;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 889);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1412, 32);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(33, 25);
            StatusLabel.Text = "---";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 24);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1412, 921);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "AlCoMa - Altered Collection Manager";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)CollectionDataSet).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storageManagerBindingSource).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
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
        private System.Windows.Forms.Timer TextFilterTimer;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem missingCardsToolStripMenuItem;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inCollectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rarityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
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
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
    }
}
