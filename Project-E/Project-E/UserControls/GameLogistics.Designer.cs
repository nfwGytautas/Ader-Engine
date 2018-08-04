namespace Project_E.UserControls
{
    partial class GameLogistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SingleSettings = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SpriteSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MapStartingSettings = new System.Windows.Forms.Panel();
            this.StartingMapName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MapChain = new System.Windows.Forms.Panel();
            this.CodeChainViewer = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CharacterStartY = new System.Windows.Forms.NumericUpDown();
            this.CharacterStartX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartingLocation = new System.Windows.Forms.GroupBox();
            this.StartLocations = new System.Windows.Forms.TableLayoutPanel();
            this.Confirm = new System.Windows.Forms.Button();
            this.MapName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MapChainString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MapStartingSettings.SuspendLayout();
            this.MapChain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeChainViewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStartX)).BeginInit();
            this.StartingLocation.SuspendLayout();
            this.StartLocations.SuspendLayout();
            this.SuspendLayout();
            // 
            // SingleSettings
            // 
            this.SingleSettings.Controls.Add(this.panel1);
            this.SingleSettings.Controls.Add(this.MapStartingSettings);
            this.SingleSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.SingleSettings.Location = new System.Drawing.Point(0, 0);
            this.SingleSettings.Name = "SingleSettings";
            this.SingleSettings.Size = new System.Drawing.Size(879, 115);
            this.SingleSettings.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SpriteSelector);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 23);
            this.panel1.TabIndex = 1;
            // 
            // SpriteSelector
            // 
            this.SpriteSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.SpriteSelector.FormattingEnabled = true;
            this.SpriteSelector.Location = new System.Drawing.Point(109, 0);
            this.SpriteSelector.Name = "SpriteSelector";
            this.SpriteSelector.Size = new System.Drawing.Size(200, 21);
            this.SpriteSelector.TabIndex = 6;
            this.SpriteSelector.SelectedIndexChanged += new System.EventHandler(this.SpriteSelector_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Main character sprite:";
            // 
            // MapStartingSettings
            // 
            this.MapStartingSettings.Controls.Add(this.StartingMapName);
            this.MapStartingSettings.Controls.Add(this.label1);
            this.MapStartingSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.MapStartingSettings.Location = new System.Drawing.Point(0, 0);
            this.MapStartingSettings.Name = "MapStartingSettings";
            this.MapStartingSettings.Size = new System.Drawing.Size(879, 23);
            this.MapStartingSettings.TabIndex = 0;
            // 
            // StartingMapName
            // 
            this.StartingMapName.Dock = System.Windows.Forms.DockStyle.Left;
            this.StartingMapName.FormattingEnabled = true;
            this.StartingMapName.Location = new System.Drawing.Point(69, 0);
            this.StartingMapName.Name = "StartingMapName";
            this.StartingMapName.Size = new System.Drawing.Size(200, 21);
            this.StartingMapName.TabIndex = 6;
            this.StartingMapName.SelectedIndexChanged += new System.EventHandler(this.StartingMapName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Starting map:";
            // 
            // MapChain
            // 
            this.MapChain.Controls.Add(this.CodeChainViewer);
            this.MapChain.Dock = System.Windows.Forms.DockStyle.Left;
            this.MapChain.Location = new System.Drawing.Point(0, 115);
            this.MapChain.Name = "MapChain";
            this.MapChain.Size = new System.Drawing.Size(464, 351);
            this.MapChain.TabIndex = 2;
            // 
            // CodeChainViewer
            // 
            this.CodeChainViewer.AllowUserToAddRows = false;
            this.CodeChainViewer.AllowUserToDeleteRows = false;
            this.CodeChainViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CodeChainViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MapName,
            this.MapChainString});
            this.CodeChainViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeChainViewer.Location = new System.Drawing.Point(0, 0);
            this.CodeChainViewer.Name = "CodeChainViewer";
            this.CodeChainViewer.ReadOnly = true;
            this.CodeChainViewer.Size = new System.Drawing.Size(464, 351);
            this.CodeChainViewer.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 25;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 25;
            // 
            // CharacterStartY
            // 
            this.CharacterStartY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CharacterStartY.Location = new System.Drawing.Point(26, 50);
            this.CharacterStartY.Name = "CharacterStartY";
            this.CharacterStartY.Size = new System.Drawing.Size(200, 20);
            this.CharacterStartY.TabIndex = 8;
            this.CharacterStartY.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // CharacterStartX
            // 
            this.CharacterStartX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CharacterStartX.Location = new System.Drawing.Point(26, 10);
            this.CharacterStartX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CharacterStartX.Name = "CharacterStartX";
            this.CharacterStartX.Size = new System.Drawing.Size(200, 20);
            this.CharacterStartX.TabIndex = 10;
            this.CharacterStartX.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Y:";
            // 
            // StartingLocation
            // 
            this.StartingLocation.Controls.Add(this.StartLocations);
            this.StartingLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartingLocation.Location = new System.Drawing.Point(464, 115);
            this.StartingLocation.Name = "StartingLocation";
            this.StartingLocation.Size = new System.Drawing.Size(415, 100);
            this.StartingLocation.TabIndex = 3;
            this.StartingLocation.TabStop = false;
            this.StartingLocation.Text = "Starting location";
            // 
            // StartLocations
            // 
            this.StartLocations.ColumnCount = 2;
            this.StartLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartLocations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.StartLocations.Controls.Add(this.CharacterStartX, 1, 0);
            this.StartLocations.Controls.Add(this.label3, 0, 0);
            this.StartLocations.Controls.Add(this.CharacterStartY, 1, 1);
            this.StartLocations.Controls.Add(this.label4, 0, 1);
            this.StartLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartLocations.Location = new System.Drawing.Point(3, 16);
            this.StartLocations.Name = "StartLocations";
            this.StartLocations.RowCount = 2;
            this.StartLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartLocations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StartLocations.Size = new System.Drawing.Size(409, 81);
            this.StartLocations.TabIndex = 13;
            // 
            // Confirm
            // 
            this.Confirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Confirm.Location = new System.Drawing.Point(464, 443);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(415, 23);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Confirm changes";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // MapName
            // 
            this.MapName.HeaderText = "File name";
            this.MapName.Name = "MapName";
            this.MapName.ReadOnly = true;
            this.MapName.Width = 220;
            // 
            // MapChainString
            // 
            this.MapChainString.HeaderText = "Value";
            this.MapChainString.Name = "MapChainString";
            this.MapChainString.ReadOnly = true;
            this.MapChainString.Width = 200;
            // 
            // GameLogistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.StartingLocation);
            this.Controls.Add(this.MapChain);
            this.Controls.Add(this.SingleSettings);
            this.Name = "GameLogistics";
            this.Size = new System.Drawing.Size(879, 466);
            this.Load += new System.EventHandler(this.GameLogistics_Load);
            this.SingleSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MapStartingSettings.ResumeLayout(false);
            this.MapStartingSettings.PerformLayout();
            this.MapChain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeChainViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStartX)).EndInit();
            this.StartingLocation.ResumeLayout(false);
            this.StartLocations.ResumeLayout(false);
            this.StartLocations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SingleSettings;
        private System.Windows.Forms.Panel MapChain;
        private System.Windows.Forms.DataGridView CodeChainViewer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel MapStartingSettings;
        private System.Windows.Forms.ComboBox StartingMapName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CharacterStartY;
        private System.Windows.Forms.NumericUpDown CharacterStartX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox StartingLocation;
        private System.Windows.Forms.TableLayoutPanel StartLocations;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SpriteSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MapChainString;
    }
}
