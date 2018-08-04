namespace Project_E.UserControls
{
    partial class CharacterCreator
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
            this.MainCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadSpriteSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sprites = new System.Windows.Forms.DoubleBufferedPanel();
            this.SpriteViewer = new Project_E.UserControls.SpriteMovingViewer();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.UsePanel = new System.Windows.Forms.DoubleBufferedPanel();
            this.MainCMS.SuspendLayout();
            this.Sprites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainCMS
            // 
            this.MainCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadSpriteSheetToolStripMenuItem,
            this.compileToolStripMenuItem});
            this.MainCMS.Name = "MainCMS";
            this.MainCMS.Size = new System.Drawing.Size(176, 48);
            // 
            // uploadSpriteSheetToolStripMenuItem
            // 
            this.uploadSpriteSheetToolStripMenuItem.Name = "uploadSpriteSheetToolStripMenuItem";
            this.uploadSpriteSheetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.uploadSpriteSheetToolStripMenuItem.Text = "Upload sprite sheet";
            this.uploadSpriteSheetToolStripMenuItem.Click += new System.EventHandler(this.uploadSpriteSheetToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // Sprites
            // 
            this.Sprites.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sprites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sprites.ContextMenuStrip = this.MainCMS;
            this.Sprites.Controls.Add(this.SpriteViewer);
            this.Sprites.Controls.Add(this.button6);
            this.Sprites.Controls.Add(this.label2);
            this.Sprites.Controls.Add(this.numericUpDown2);
            this.Sprites.Controls.Add(this.button5);
            this.Sprites.Controls.Add(this.button4);
            this.Sprites.Controls.Add(this.button3);
            this.Sprites.Controls.Add(this.button2);
            this.Sprites.Controls.Add(this.button1);
            this.Sprites.Controls.Add(this.label1);
            this.Sprites.Controls.Add(this.numericUpDown1);
            this.Sprites.Controls.Add(this.radioButton5);
            this.Sprites.Controls.Add(this.radioButton4);
            this.Sprites.Controls.Add(this.radioButton3);
            this.Sprites.Controls.Add(this.radioButton2);
            this.Sprites.Controls.Add(this.radioButton1);
            this.Sprites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprites.Location = new System.Drawing.Point(509, 0);
            this.Sprites.Name = "Sprites";
            this.Sprites.Size = new System.Drawing.Size(562, 637);
            this.Sprites.TabIndex = 1;
            // 
            // SpriteViewer
            // 
            this.SpriteViewer.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpriteViewer.Location = new System.Drawing.Point(0, 0);
            this.SpriteViewer.Name = "SpriteViewer";
            this.SpriteViewer.Size = new System.Drawing.Size(558, 504);
            this.SpriteViewer.TabIndex = 16;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(173, 555);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Save to sprite handler";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 557);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "TickRate";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(60, 555);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(107, 20);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(335, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Edit projectile";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(416, 526);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Edit left";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Edit right";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Edit down";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "TileSize";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(47, 529);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Red;
            this.radioButton5.Location = new System.Drawing.Point(295, 506);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(88, 17);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Projectile tool";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.Blue;
            this.radioButton4.Location = new System.Drawing.Point(150, 506);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(63, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Left tool";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.Purple;
            this.radioButton3.Location = new System.Drawing.Point(219, 506);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Right tool";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton2.Location = new System.Drawing.Point(71, 506);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Down tool";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Green;
            this.radioButton1.Location = new System.Drawing.Point(6, 506);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Up tool";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // UsePanel
            // 
            this.UsePanel.AutoScroll = true;
            this.UsePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UsePanel.ContextMenuStrip = this.MainCMS;
            this.UsePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.UsePanel.Location = new System.Drawing.Point(0, 0);
            this.UsePanel.Name = "UsePanel";
            this.UsePanel.Size = new System.Drawing.Size(509, 637);
            this.UsePanel.TabIndex = 0;
            this.UsePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.UsePanel_Paint);
            this.UsePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsePanel_MouseClick);
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sprites);
            this.Controls.Add(this.UsePanel);
            this.Name = "CharacterCreator";
            this.Size = new System.Drawing.Size(1071, 637);
            this.Load += new System.EventHandler(this.CharacterCreator_Load);
            this.MainCMS.ResumeLayout(false);
            this.Sprites.ResumeLayout(false);
            this.Sprites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip MainCMS;
        private System.Windows.Forms.ToolStripMenuItem uploadSpriteSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.DoubleBufferedPanel UsePanel;
        private System.Windows.Forms.DoubleBufferedPanel Sprites;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button6;
        private SpriteMovingViewer SpriteViewer;
    }
}
