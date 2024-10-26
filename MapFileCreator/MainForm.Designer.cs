namespace MapFileCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            LoadMapButton = new Button();
            SaveMapAsButton = new Button();
            MapListView = new ListView();
            IsInCityHeader = new ColumnHeader();
            TypeHeader = new ColumnHeader();
            CoordinateXHeader = new ColumnHeader();
            CoordinateYHeader = new ColumnHeader();
            FacetHeader = new ColumnHeader();
            LabelHeader = new ColumnHeader();
            TypeLabel = new Label();
            XLabel = new Label();
            YLabel = new Label();
            FacetLabel = new Label();
            LabelLabel = new Label();
            TypeTextBox = new TextBox();
            CoordinateXUpDown = new NumericUpDown();
            CoordinateYUpDown = new NumericUpDown();
            FacetUpDown = new NumericUpDown();
            LabelTextBox = new TextBox();
            DeleteSelectedItemButton = new Button();
            UpdateSelectedItemButton = new Button();
            AddItemButton = new Button();
            IsInCityCheckBox = new CheckBox();
            statusStrip1 = new StatusStrip();
            MapIndexNumberHelpButton = new Button();
            VersioningLabel = new Label();
            VersionNumberLabel = new Label();
            lastupdatedLabel = new Label();
            lastupdateddateLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            info_button = new Button();
            label1 = new Label();
            installationHelpButton = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)CoordinateXUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CoordinateYUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FacetUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // LoadMapButton
            // 
            LoadMapButton.Location = new Point(751, 342);
            LoadMapButton.Name = "LoadMapButton";
            LoadMapButton.Size = new Size(135, 23);
            LoadMapButton.TabIndex = 0;
            LoadMapButton.Text = "Load .MAP File";
            LoadMapButton.UseVisualStyleBackColor = true;
            LoadMapButton.Click += LoadMapButton_Click;
            // 
            // SaveMapAsButton
            // 
            SaveMapAsButton.Location = new Point(751, 382);
            SaveMapAsButton.Name = "SaveMapAsButton";
            SaveMapAsButton.Size = new Size(135, 23);
            SaveMapAsButton.TabIndex = 2;
            SaveMapAsButton.Text = "Save .MAP File";
            SaveMapAsButton.UseVisualStyleBackColor = true;
            SaveMapAsButton.Click += SaveMapAsButton_Click;
            // 
            // MapListView
            // 
            MapListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MapListView.Columns.AddRange(new ColumnHeader[] { IsInCityHeader, TypeHeader, CoordinateXHeader, CoordinateYHeader, FacetHeader, LabelHeader });
            MapListView.FullRowSelect = true;
            MapListView.Location = new Point(12, 64);
            MapListView.Name = "MapListView";
            MapListView.Size = new Size(580, 347);
            MapListView.TabIndex = 3;
            MapListView.UseCompatibleStateImageBehavior = false;
            MapListView.View = View.Details;
            MapListView.SelectedIndexChanged += MapListView_SelectedIndexChanged;
            // 
            // IsInCityHeader
            // 
            IsInCityHeader.Text = "In City?";
            IsInCityHeader.Width = 52;
            // 
            // TypeHeader
            // 
            TypeHeader.Text = "Type";
            TypeHeader.Width = 120;
            // 
            // CoordinateXHeader
            // 
            CoordinateXHeader.Text = "X";
            // 
            // CoordinateYHeader
            // 
            CoordinateYHeader.Text = "Y";
            // 
            // FacetHeader
            // 
            FacetHeader.Text = "Facet";
            // 
            // LabelHeader
            // 
            LabelHeader.Text = "Label";
            LabelHeader.Width = 200;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(598, 64);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(135, 15);
            TypeLabel.TabIndex = 5;
            TypeLabel.Text = "Assign Icon To Location:";
            // 
            // XLabel
            // 
            XLabel.AutoSize = true;
            XLabel.Location = new Point(598, 119);
            XLabel.Name = "XLabel";
            XLabel.Size = new Size(14, 15);
            XLabel.TabIndex = 6;
            XLabel.Text = "X";
            // 
            // YLabel
            // 
            YLabel.AutoSize = true;
            YLabel.Location = new Point(751, 119);
            YLabel.Name = "YLabel";
            YLabel.Size = new Size(14, 15);
            YLabel.TabIndex = 7;
            YLabel.Text = "Y";
            // 
            // FacetLabel
            // 
            FacetLabel.AutoSize = true;
            FacetLabel.Location = new Point(598, 179);
            FacetLabel.Name = "FacetLabel";
            FacetLabel.Size = new Size(117, 15);
            FacetLabel.TabIndex = 8;
            FacetLabel.Text = "Facet Index Number:";
            // 
            // LabelLabel
            // 
            LabelLabel.AutoSize = true;
            LabelLabel.Location = new Point(598, 235);
            LabelLabel.Name = "LabelLabel";
            LabelLabel.Size = new Size(119, 15);
            LabelLabel.TabIndex = 9;
            LabelLabel.Text = "Location Description:";
            // 
            // TypeTextBox
            // 
            TypeTextBox.CharacterCasing = CharacterCasing.Upper;
            TypeTextBox.Location = new Point(598, 83);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(135, 23);
            TypeTextBox.TabIndex = 10;
            // 
            // CoordinateXUpDown
            // 
            CoordinateXUpDown.Location = new Point(598, 138);
            CoordinateXUpDown.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            CoordinateXUpDown.Name = "CoordinateXUpDown";
            CoordinateXUpDown.Size = new Size(135, 23);
            CoordinateXUpDown.TabIndex = 11;
            // 
            // CoordinateYUpDown
            // 
            CoordinateYUpDown.Location = new Point(751, 138);
            CoordinateYUpDown.Maximum = new decimal(new int[] { 16384, 0, 0, 0 });
            CoordinateYUpDown.Name = "CoordinateYUpDown";
            CoordinateYUpDown.Size = new Size(135, 23);
            CoordinateYUpDown.TabIndex = 12;
            // 
            // FacetUpDown
            // 
            FacetUpDown.Location = new Point(598, 198);
            FacetUpDown.Name = "FacetUpDown";
            FacetUpDown.Size = new Size(135, 23);
            FacetUpDown.TabIndex = 13;
            // 
            // LabelTextBox
            // 
            LabelTextBox.Location = new Point(598, 256);
            LabelTextBox.Name = "LabelTextBox";
            LabelTextBox.Size = new Size(288, 23);
            LabelTextBox.TabIndex = 14;
            // 
            // DeleteSelectedItemButton
            // 
            DeleteSelectedItemButton.Anchor = AnchorStyles.None;
            DeleteSelectedItemButton.Location = new Point(598, 385);
            DeleteSelectedItemButton.Name = "DeleteSelectedItemButton";
            DeleteSelectedItemButton.Size = new Size(135, 23);
            DeleteSelectedItemButton.TabIndex = 15;
            DeleteSelectedItemButton.Text = "Delete Selected Item";
            DeleteSelectedItemButton.UseVisualStyleBackColor = true;
            DeleteSelectedItemButton.Click += DeleteSelectedItemButton_Click;
            // 
            // UpdateSelectedItemButton
            // 
            UpdateSelectedItemButton.Anchor = AnchorStyles.None;
            UpdateSelectedItemButton.Location = new Point(598, 345);
            UpdateSelectedItemButton.Name = "UpdateSelectedItemButton";
            UpdateSelectedItemButton.Size = new Size(135, 23);
            UpdateSelectedItemButton.TabIndex = 16;
            UpdateSelectedItemButton.Text = "Update Selected Item";
            UpdateSelectedItemButton.UseVisualStyleBackColor = true;
            UpdateSelectedItemButton.Click += UpdateSelectedItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.None;
            AddItemButton.Location = new Point(598, 304);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(135, 23);
            AddItemButton.TabIndex = 17;
            AddItemButton.Text = "Add A Location Entry";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // IsInCityCheckBox
            // 
            IsInCityCheckBox.AutoSize = true;
            IsInCityCheckBox.Location = new Point(751, 84);
            IsInCityCheckBox.Name = "IsInCityCheckBox";
            IsInCityCheckBox.Size = new Size(143, 19);
            IsInCityCheckBox.TabIndex = 19;
            IsInCityCheckBox.Text = "Is Location In A Town?";
            IsInCityCheckBox.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(900, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // MapIndexNumberHelpButton
            // 
            MapIndexNumberHelpButton.Location = new Point(751, 198);
            MapIndexNumberHelpButton.Name = "MapIndexNumberHelpButton";
            MapIndexNumberHelpButton.Size = new Size(135, 23);
            MapIndexNumberHelpButton.TabIndex = 22;
            MapIndexNumberHelpButton.Text = "Facet Index # Help";
            MapIndexNumberHelpButton.UseVisualStyleBackColor = true;
            MapIndexNumberHelpButton.Click += MapIndexNumberHelpButton_Click;
            // 
            // VersioningLabel
            // 
            VersioningLabel.AutoSize = true;
            VersioningLabel.Font = new Font("Segoe UI", 10F);
            VersioningLabel.ForeColor = SystemColors.ControlDarkDark;
            VersioningLabel.Location = new Point(12, 426);
            VersioningLabel.Name = "VersioningLabel";
            VersioningLabel.Size = new Size(57, 19);
            VersioningLabel.TabIndex = 23;
            VersioningLabel.Text = "Version:";
            // 
            // VersionNumberLabel
            // 
            VersionNumberLabel.AutoSize = true;
            VersionNumberLabel.Font = new Font("Segoe UI", 10F);
            VersionNumberLabel.ForeColor = Color.Blue;
            VersionNumberLabel.Location = new Point(65, 426);
            VersionNumberLabel.Name = "VersionNumberLabel";
            VersionNumberLabel.Size = new Size(28, 19);
            VersionNumberLabel.TabIndex = 24;
            VersionNumberLabel.Text = "2.0";
            // 
            // lastupdatedLabel
            // 
            lastupdatedLabel.AutoSize = true;
            lastupdatedLabel.Font = new Font("Segoe UI", 10F);
            lastupdatedLabel.ForeColor = SystemColors.ControlDarkDark;
            lastupdatedLabel.Location = new Point(712, 426);
            lastupdatedLabel.Name = "lastupdatedLabel";
            lastupdatedLabel.Size = new Size(94, 19);
            lastupdatedLabel.TabIndex = 25;
            lastupdatedLabel.Text = "Last Updated:";
            // 
            // lastupdateddateLabel
            // 
            lastupdateddateLabel.AutoSize = true;
            lastupdateddateLabel.Font = new Font("Segoe UI", 10F);
            lastupdateddateLabel.ForeColor = Color.Blue;
            lastupdateddateLabel.Location = new Point(804, 426);
            lastupdateddateLabel.Name = "lastupdateddateLabel";
            lastupdateddateLabel.Size = new Size(83, 19);
            lastupdateddateLabel.TabIndex = 26;
            lastupdateddateLabel.Text = "10/26/2024";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // info_button
            // 
            info_button.Image = (Image)resources.GetObject("info_button.Image");
            info_button.Location = new Point(841, 12);
            info_button.Name = "info_button";
            info_button.Size = new Size(45, 43);
            info_button.TabIndex = 29;
            info_button.UseVisualStyleBackColor = true;
            info_button.Click += info_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(267, 427);
            label1.Name = "label1";
            label1.Size = new Size(285, 15);
            label1.TabIndex = 30;
            label1.Text = "This Utility Was Designed For ClassicUO's World Map\r\n";
            // 
            // installationHelpButton
            // 
            installationHelpButton.Location = new Point(752, 304);
            installationHelpButton.Name = "installationHelpButton";
            installationHelpButton.Size = new Size(135, 23);
            installationHelpButton.TabIndex = 31;
            installationHelpButton.Text = "Installation Help";
            installationHelpButton.UseVisualStyleBackColor = true;
            installationHelpButton.Click += installationHelpButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(53, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 19);
            label2.TabIndex = 32;
            label2.Text = "Developed For:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 447);
            Controls.Add(label2);
            Controls.Add(installationHelpButton);
            Controls.Add(label1);
            Controls.Add(info_button);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lastupdateddateLabel);
            Controls.Add(lastupdatedLabel);
            Controls.Add(VersionNumberLabel);
            Controls.Add(VersioningLabel);
            Controls.Add(MapIndexNumberHelpButton);
            Controls.Add(statusStrip1);
            Controls.Add(IsInCityCheckBox);
            Controls.Add(AddItemButton);
            Controls.Add(UpdateSelectedItemButton);
            Controls.Add(DeleteSelectedItemButton);
            Controls.Add(LabelTextBox);
            Controls.Add(FacetUpDown);
            Controls.Add(CoordinateYUpDown);
            Controls.Add(CoordinateXUpDown);
            Controls.Add(TypeTextBox);
            Controls.Add(LabelLabel);
            Controls.Add(FacetLabel);
            Controls.Add(YLabel);
            Controls.Add(XLabel);
            Controls.Add(TypeLabel);
            Controls.Add(MapListView);
            Controls.Add(SaveMapAsButton);
            Controls.Add(LoadMapButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = ".MAP File Creator";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)CoordinateXUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)CoordinateYUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)FacetUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoadMapButton;
        private Button SaveMapAsButton;
        private ListView MapListView;
        private ColumnHeader TypeHeader;
        private ColumnHeader CoordinateXHeader;
        private ColumnHeader CoordinateYHeader;
        private ColumnHeader FacetHeader;
        private ColumnHeader LabelHeader;
        private Label TypeLabel;
        private Label XLabel;
        private Label YLabel;
        private Label FacetLabel;
        private Label LabelLabel;
        private TextBox TypeTextBox;
        private NumericUpDown CoordinateXUpDown;
        private NumericUpDown CoordinateYUpDown;
        private NumericUpDown FacetUpDown;
        private TextBox LabelTextBox;
        private Button DeleteSelectedItemButton;
        private Button UpdateSelectedItemButton;
        private Button AddItemButton;
        private ColumnHeader IsInCityHeader;
        private CheckBox IsInCityCheckBox;
        private StatusStrip statusStrip1;
        private Button MapIndexNumberHelpButton;
        private Label VersioningLabel;
        private Label VersionNumberLabel;
        private Label lastupdatedLabel;
        private Label lastupdateddateLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button info_button;
        private Label label1;
        private Button installationHelpButton;
        private Label label2;
    }
}
