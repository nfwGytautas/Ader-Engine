namespace Project_E.UserControls
{
    partial class MapLogistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapLogistics));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolSelectionBox = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectionStripDDB = new System.Windows.Forms.ToolStripDropDownButton();
            this.enableCodeAssignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableCodeAssignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrentTool = new System.Windows.Forms.ToolStripLabel();
            this.UsePanel = new System.Windows.Forms.DoubleBufferedPanel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSelectionBox,
            this.toolStripSeparator2,
            this.SelectionStripDDB,
            this.toolStripSeparator1,
            this.CurrentTool});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolSelectionBox
            // 
            this.ToolSelectionBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolSelectionBox.Image = ((System.Drawing.Image)(resources.GetObject("ToolSelectionBox.Image")));
            this.ToolSelectionBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSelectionBox.Name = "ToolSelectionBox";
            this.ToolSelectionBox.Size = new System.Drawing.Size(75, 22);
            this.ToolSelectionBox.Text = "Select tool";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectionStripDDB
            // 
            this.SelectionStripDDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SelectionStripDDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableCodeAssignToolStripMenuItem,
            this.disableCodeAssignToolStripMenuItem});
            this.SelectionStripDDB.Image = ((System.Drawing.Image)(resources.GetObject("SelectionStripDDB.Image")));
            this.SelectionStripDDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectionStripDDB.Name = "SelectionStripDDB";
            this.SelectionStripDDB.Size = new System.Drawing.Size(75, 22);
            this.SelectionStripDDB.Text = "Code view";
            // 
            // enableCodeAssignToolStripMenuItem
            // 
            this.enableCodeAssignToolStripMenuItem.Name = "enableCodeAssignToolStripMenuItem";
            this.enableCodeAssignToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.enableCodeAssignToolStripMenuItem.Text = "Enable code view";
            this.enableCodeAssignToolStripMenuItem.Click += new System.EventHandler(this.enableCodeAssignToolStripMenuItem_Click);
            // 
            // disableCodeAssignToolStripMenuItem
            // 
            this.disableCodeAssignToolStripMenuItem.Name = "disableCodeAssignToolStripMenuItem";
            this.disableCodeAssignToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.disableCodeAssignToolStripMenuItem.Text = "Disable code view";
            this.disableCodeAssignToolStripMenuItem.Click += new System.EventHandler(this.disableCodeAssignToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CurrentTool
            // 
            this.CurrentTool.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CurrentTool.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CurrentTool.Name = "CurrentTool";
            this.CurrentTool.Size = new System.Drawing.Size(32, 22);
            this.CurrentTool.Text = "label";
            // 
            // UsePanel
            // 
            this.UsePanel.AutoScroll = true;
            this.UsePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsePanel.Location = new System.Drawing.Point(0, 25);
            this.UsePanel.Name = "UsePanel";
            this.UsePanel.Size = new System.Drawing.Size(1008, 557);
            this.UsePanel.TabIndex = 1;
            this.UsePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UsePanel_Paint);
            this.UsePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsePanel_MouseClick);
            // 
            // MapLogistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsePanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MapLogistics";
            this.Size = new System.Drawing.Size(1008, 582);
            this.Load += new System.EventHandler(this.MapLogistics_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton SelectionStripDDB;
        private System.Windows.Forms.ToolStripMenuItem enableCodeAssignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableCodeAssignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DoubleBufferedPanel UsePanel;
        private System.Windows.Forms.ToolStripDropDownButton ToolSelectionBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel CurrentTool;
    }
}
