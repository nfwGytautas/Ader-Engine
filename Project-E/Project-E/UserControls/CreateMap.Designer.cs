namespace Project_E.UserControls
{
    partial class CreateMap
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
            this.Panels = new System.Windows.Forms.TableLayoutPanel();
            this.ToolsPanel = new System.Windows.Forms.Panel();
            this.gridCheck = new System.Windows.Forms.CheckBox();
            this.RectangleTool = new System.Windows.Forms.CheckBox();
            this.UploadPBMI = new System.Windows.Forms.Button();
            this.SaveMap = new System.Windows.Forms.Button();
            this.SetupCollision = new System.Windows.Forms.Button();
            this.loadTileSet = new System.Windows.Forms.Button();
            this.addMap = new System.Windows.Forms.Button();
            this.LogTileClick = new System.Windows.Forms.CheckBox();
            this.TileSetPanel = new System.Windows.Forms.Panel();
            this.Tiles = new System.Windows.Forms.PictureBox();
            this.Map = new System.Windows.Forms.DoubleBufferedPanel();
            this.Panels.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.TileSetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tiles)).BeginInit();
            this.SuspendLayout();
            // 
            // Panels
            // 
            this.Panels.ColumnCount = 2;
            this.Panels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.Panels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panels.Controls.Add(this.ToolsPanel, 0, 0);
            this.Panels.Controls.Add(this.Map, 1, 0);
            this.Panels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panels.Location = new System.Drawing.Point(0, 0);
            this.Panels.Name = "Panels";
            this.Panels.RowCount = 1;
            this.Panels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Panels.Size = new System.Drawing.Size(1063, 549);
            this.Panels.TabIndex = 1;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ToolsPanel.Controls.Add(this.gridCheck);
            this.ToolsPanel.Controls.Add(this.RectangleTool);
            this.ToolsPanel.Controls.Add(this.UploadPBMI);
            this.ToolsPanel.Controls.Add(this.SaveMap);
            this.ToolsPanel.Controls.Add(this.SetupCollision);
            this.ToolsPanel.Controls.Add(this.loadTileSet);
            this.ToolsPanel.Controls.Add(this.addMap);
            this.ToolsPanel.Controls.Add(this.LogTileClick);
            this.ToolsPanel.Controls.Add(this.TileSetPanel);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolsPanel.Location = new System.Drawing.Point(3, 3);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Size = new System.Drawing.Size(194, 543);
            this.ToolsPanel.TabIndex = 1;
            // 
            // gridCheck
            // 
            this.gridCheck.AutoSize = true;
            this.gridCheck.Checked = true;
            this.gridCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridCheck.Location = new System.Drawing.Point(95, 115);
            this.gridCheck.Name = "gridCheck";
            this.gridCheck.Size = new System.Drawing.Size(79, 73);
            this.gridCheck.TabIndex = 2;
            this.gridCheck.Text = "Toggle grid";
            this.gridCheck.UseVisualStyleBackColor = true;
            this.gridCheck.CheckedChanged += new System.EventHandler(this.gridCheck_CheckedChanged);
            // 
            // RectangleTool
            // 
            this.RectangleTool.AutoSize = true;
            this.RectangleTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectangleTool.Location = new System.Drawing.Point(0, 115);
            this.RectangleTool.Name = "RectangleTool";
            this.RectangleTool.Size = new System.Drawing.Size(95, 73);
            this.RectangleTool.TabIndex = 7;
            this.RectangleTool.Text = "Rectangle tool";
            this.RectangleTool.UseVisualStyleBackColor = true;
            this.RectangleTool.CheckedChanged += new System.EventHandler(this.RectangleTool_CheckedChanged);
            // 
            // UploadPBMI
            // 
            this.UploadPBMI.Dock = System.Windows.Forms.DockStyle.Top;
            this.UploadPBMI.Location = new System.Drawing.Point(0, 92);
            this.UploadPBMI.Name = "UploadPBMI";
            this.UploadPBMI.Size = new System.Drawing.Size(190, 23);
            this.UploadPBMI.TabIndex = 0;
            this.UploadPBMI.Text = "Upload a map image";
            this.UploadPBMI.UseVisualStyleBackColor = true;
            this.UploadPBMI.Click += new System.EventHandler(this.UploadPBMI_Click);
            // 
            // SaveMap
            // 
            this.SaveMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.SaveMap.Location = new System.Drawing.Point(0, 69);
            this.SaveMap.Name = "SaveMap";
            this.SaveMap.Size = new System.Drawing.Size(190, 23);
            this.SaveMap.TabIndex = 2;
            this.SaveMap.Text = "Save map";
            this.SaveMap.UseVisualStyleBackColor = true;
            this.SaveMap.Click += new System.EventHandler(this.SaveMap_Click);
            // 
            // SetupCollision
            // 
            this.SetupCollision.Dock = System.Windows.Forms.DockStyle.Top;
            this.SetupCollision.Location = new System.Drawing.Point(0, 46);
            this.SetupCollision.Name = "SetupCollision";
            this.SetupCollision.Size = new System.Drawing.Size(190, 23);
            this.SetupCollision.TabIndex = 6;
            this.SetupCollision.Text = "Setup collision";
            this.SetupCollision.UseVisualStyleBackColor = true;
            this.SetupCollision.Click += new System.EventHandler(this.SetupCollision_Click);
            // 
            // loadTileSet
            // 
            this.loadTileSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadTileSet.Location = new System.Drawing.Point(0, 23);
            this.loadTileSet.Name = "loadTileSet";
            this.loadTileSet.Size = new System.Drawing.Size(190, 23);
            this.loadTileSet.TabIndex = 5;
            this.loadTileSet.Text = "Load tile set";
            this.loadTileSet.UseVisualStyleBackColor = true;
            this.loadTileSet.Click += new System.EventHandler(this.loadTileSet_Click);
            // 
            // addMap
            // 
            this.addMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMap.Location = new System.Drawing.Point(0, 0);
            this.addMap.Name = "addMap";
            this.addMap.Size = new System.Drawing.Size(190, 23);
            this.addMap.TabIndex = 4;
            this.addMap.Text = "Add a new map";
            this.addMap.UseVisualStyleBackColor = true;
            this.addMap.Click += new System.EventHandler(this.addMap_Click);
            // 
            // LogTileClick
            // 
            this.LogTileClick.AutoSize = true;
            this.LogTileClick.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogTileClick.Location = new System.Drawing.Point(0, 188);
            this.LogTileClick.Name = "LogTileClick";
            this.LogTileClick.Size = new System.Drawing.Size(190, 17);
            this.LogTileClick.TabIndex = 0;
            this.LogTileClick.Text = "Show selected tile coord in loger";
            this.LogTileClick.UseVisualStyleBackColor = true;
            this.LogTileClick.CheckedChanged += new System.EventHandler(this.LogTileClick_CheckedChanged);
            // 
            // TileSetPanel
            // 
            this.TileSetPanel.AutoScroll = true;
            this.TileSetPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TileSetPanel.Controls.Add(this.Tiles);
            this.TileSetPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TileSetPanel.Location = new System.Drawing.Point(0, 205);
            this.TileSetPanel.Name = "TileSetPanel";
            this.TileSetPanel.Size = new System.Drawing.Size(190, 334);
            this.TileSetPanel.TabIndex = 2;
            // 
            // Tiles
            // 
            this.Tiles.Location = new System.Drawing.Point(0, 0);
            this.Tiles.Name = "Tiles";
            this.Tiles.Size = new System.Drawing.Size(194, 50);
            this.Tiles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Tiles.TabIndex = 0;
            this.Tiles.TabStop = false;
            this.Tiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tiles_MouseClick);
            // 
            // Map
            // 
            this.Map.AutoScroll = true;
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(203, 3);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(857, 543);
            this.Map.TabIndex = 2;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.Map.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Map_MouseClick);
            this.Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDown);
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            this.Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Map_MouseUp);
            // 
            // CreateMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panels);
            this.Name = "CreateMap";
            this.Size = new System.Drawing.Size(1063, 549);
            this.Load += new System.EventHandler(this.CreateMap_Load);
            this.Panels.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.ToolsPanel.PerformLayout();
            this.TileSetPanel.ResumeLayout(false);
            this.TileSetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Panels;
        private System.Windows.Forms.Panel ToolsPanel;
        private System.Windows.Forms.Panel TileSetPanel;
        private System.Windows.Forms.PictureBox Tiles;
        private System.Windows.Forms.DoubleBufferedPanel Map;
        private System.Windows.Forms.CheckBox LogTileClick;
        private System.Windows.Forms.Button loadTileSet;
        private System.Windows.Forms.Button addMap;
        private System.Windows.Forms.Button SetupCollision;
        private System.Windows.Forms.Button SaveMap;
        private System.Windows.Forms.CheckBox RectangleTool;
        private System.Windows.Forms.CheckBox gridCheck;
        private System.Windows.Forms.Button UploadPBMI;
    }
}
