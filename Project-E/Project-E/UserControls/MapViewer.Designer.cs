namespace Project_E.UserControls
{
    partial class MapViewer
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
            this.Map = new System.Windows.Forms.DoubleBufferedPanel();
            this.SuspendLayout();
            // 
            // Map
            // 
            this.Map.AutoScroll = true;
            this.Map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(814, 434);
            this.Map.TabIndex = 3;
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.Map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Map_MouseDown);
            this.Map.MouseHover += new System.EventHandler(this.Map_MouseHover);
            this.Map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Map_MouseMove);
            this.Map.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Map_MouseUp);
            // 
            // MapViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Map);
            this.Name = "MapViewer";
            this.Size = new System.Drawing.Size(814, 434);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DoubleBufferedPanel Map;
    }
}
