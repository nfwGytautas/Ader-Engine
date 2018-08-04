namespace Project_E.UserControls
{
    partial class DebugWindow
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
            this.DebugStrip = new System.Windows.Forms.ToolStrip();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Pause = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.End = new System.Windows.Forms.ToolStripButton();
            this.GamePanel = new System.Windows.Forms.DoubleBufferedPanel();
            this.HUD = new Project_E.UserControls.HUD();
            this.DebugStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DebugStrip
            // 
            this.DebugStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.toolStripSeparator1,
            this.Pause,
            this.toolStripSeparator2,
            this.End});
            this.DebugStrip.Location = new System.Drawing.Point(0, 0);
            this.DebugStrip.Name = "DebugStrip";
            this.DebugStrip.Size = new System.Drawing.Size(1113, 25);
            this.DebugStrip.TabIndex = 0;
            this.DebugStrip.Text = "toolStrip1";
            // 
            // Start
            // 
            this.Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Start.Image = global::Project_E.Properties.Resources.Debugstart;
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(23, 22);
            this.Start.Text = "toolStripButton1";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Pause
            // 
            this.Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pause.Image = global::Project_E.Properties.Resources.Pause;
            this.Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(23, 22);
            this.Pause.Text = "toolStripButton1";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // End
            // 
            this.End.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.End.Image = global::Project_E.Properties.Resources.Debugstop;
            this.End.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(23, 22);
            this.End.Text = "toolStripButton1";
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.AutoSize = true;
            this.GamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel.Location = new System.Drawing.Point(0, 25);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(863, 603);
            this.GamePanel.TabIndex = 1;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // HUD
            // 
            this.HUD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HUD.Dock = System.Windows.Forms.DockStyle.Right;
            this.HUD.Location = new System.Drawing.Point(863, 25);
            this.HUD.MinimumSize = new System.Drawing.Size(250, 0);
            this.HUD.Name = "HUD";
            this.HUD.Size = new System.Drawing.Size(250, 603);
            this.HUD.TabIndex = 2;
            // 
            // DebugWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GamePanel);
            this.Controls.Add(this.HUD);
            this.Controls.Add(this.DebugStrip);
            this.Name = "DebugWindow";
            this.Size = new System.Drawing.Size(1113, 628);
            this.DebugStrip.ResumeLayout(false);
            this.DebugStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip DebugStrip;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton End;
        private System.Windows.Forms.DoubleBufferedPanel GamePanel;
        private System.Windows.Forms.ToolStripButton Pause;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private HUD HUD;
    }
}
