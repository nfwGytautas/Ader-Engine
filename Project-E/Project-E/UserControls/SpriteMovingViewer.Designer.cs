namespace Project_E.UserControls
{
    partial class SpriteMovingViewer
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
            this.components = new System.ComponentModel.Container();
            this.Sprites = new System.Windows.Forms.DoubleBufferedPanel();
            this.ProjectileSprite = new System.Windows.Forms.DoubleBufferedPanel();
            this.RightSprite = new System.Windows.Forms.DoubleBufferedPanel();
            this.LeftSprite = new System.Windows.Forms.DoubleBufferedPanel();
            this.DownSprite = new System.Windows.Forms.DoubleBufferedPanel();
            this.UpSprite = new System.Windows.Forms.DoubleBufferedPanel();
            this.MainTick = new System.Windows.Forms.Timer(this.components);
            this.Sprites.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sprites
            // 
            this.Sprites.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sprites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sprites.Controls.Add(this.ProjectileSprite);
            this.Sprites.Controls.Add(this.RightSprite);
            this.Sprites.Controls.Add(this.LeftSprite);
            this.Sprites.Controls.Add(this.DownSprite);
            this.Sprites.Controls.Add(this.UpSprite);
            this.Sprites.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sprites.Location = new System.Drawing.Point(0, 0);
            this.Sprites.Name = "Sprites";
            this.Sprites.Size = new System.Drawing.Size(841, 504);
            this.Sprites.TabIndex = 2;
            // 
            // ProjectileSprite
            // 
            this.ProjectileSprite.BackColor = System.Drawing.Color.Red;
            this.ProjectileSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProjectileSprite.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProjectileSprite.Location = new System.Drawing.Point(0, 400);
            this.ProjectileSprite.Name = "ProjectileSprite";
            this.ProjectileSprite.Size = new System.Drawing.Size(837, 100);
            this.ProjectileSprite.TabIndex = 4;
            this.ProjectileSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.ProjectileSprite_Paint);
            // 
            // RightSprite
            // 
            this.RightSprite.BackColor = System.Drawing.Color.Purple;
            this.RightSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RightSprite.Dock = System.Windows.Forms.DockStyle.Top;
            this.RightSprite.Location = new System.Drawing.Point(0, 300);
            this.RightSprite.Name = "RightSprite";
            this.RightSprite.Size = new System.Drawing.Size(837, 100);
            this.RightSprite.TabIndex = 3;
            this.RightSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.RightSprite_Paint);
            // 
            // LeftSprite
            // 
            this.LeftSprite.BackColor = System.Drawing.Color.Blue;
            this.LeftSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LeftSprite.Dock = System.Windows.Forms.DockStyle.Top;
            this.LeftSprite.Location = new System.Drawing.Point(0, 200);
            this.LeftSprite.Name = "LeftSprite";
            this.LeftSprite.Size = new System.Drawing.Size(837, 100);
            this.LeftSprite.TabIndex = 2;
            this.LeftSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.LeftSprite_Paint);
            // 
            // DownSprite
            // 
            this.DownSprite.BackColor = System.Drawing.Color.Yellow;
            this.DownSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DownSprite.Dock = System.Windows.Forms.DockStyle.Top;
            this.DownSprite.Location = new System.Drawing.Point(0, 100);
            this.DownSprite.Name = "DownSprite";
            this.DownSprite.Size = new System.Drawing.Size(837, 100);
            this.DownSprite.TabIndex = 1;
            this.DownSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.DownSprite_Paint);
            // 
            // UpSprite
            // 
            this.UpSprite.BackColor = System.Drawing.Color.Green;
            this.UpSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpSprite.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpSprite.Location = new System.Drawing.Point(0, 0);
            this.UpSprite.Name = "UpSprite";
            this.UpSprite.Size = new System.Drawing.Size(837, 100);
            this.UpSprite.TabIndex = 0;
            this.UpSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.UpSprite_Paint);
            // 
            // MainTick
            // 
            this.MainTick.Enabled = true;
            this.MainTick.Tick += new System.EventHandler(this.MainTick_Tick);
            // 
            // SpriteMovingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sprites);
            this.Name = "SpriteMovingViewer";
            this.Size = new System.Drawing.Size(841, 504);
            this.Sprites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DoubleBufferedPanel Sprites;
        private System.Windows.Forms.DoubleBufferedPanel ProjectileSprite;
        private System.Windows.Forms.DoubleBufferedPanel RightSprite;
        private System.Windows.Forms.DoubleBufferedPanel LeftSprite;
        private System.Windows.Forms.DoubleBufferedPanel DownSprite;
        private System.Windows.Forms.DoubleBufferedPanel UpSprite;
        private System.Windows.Forms.Timer MainTick;
    }
}
