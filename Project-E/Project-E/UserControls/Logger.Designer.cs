namespace Project_E.UserControls
{
    partial class Logger
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
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.Settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSize = new System.Windows.Forms.ToolStripTextBox();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.INFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WARNINGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ERRORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputBox
            // 
            this.OutputBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OutputBox.ContextMenuStrip = this.Settings;
            this.OutputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(0, 0);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(1000, 150);
            this.OutputBox.TabIndex = 0;
            this.OutputBox.Text = "";
            this.OutputBox.TextChanged += new System.EventHandler(this.OutputBox_TextChanged);
            // 
            // Settings
            // 
            this.Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(117, 26);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem1,
            this.errorsToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fontToolStripMenuItem.Text = "Settings";
            // 
            // fontToolStripMenuItem1
            // 
            this.fontToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSize});
            this.fontToolStripMenuItem1.Name = "fontToolStripMenuItem1";
            this.fontToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.fontToolStripMenuItem1.Text = "Font size";
            // 
            // FontSize
            // 
            this.FontSize.BackColor = System.Drawing.SystemColors.Menu;
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(100, 23);
            this.FontSize.Text = "12";
            this.FontSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FontSize_KeyDown);
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.INFOToolStripMenuItem,
            this.WARNINGToolStripMenuItem,
            this.ERRORToolStripMenuItem});
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.errorsToolStripMenuItem.Text = "Shown errors";
            // 
            // INFOToolStripMenuItem
            // 
            this.INFOToolStripMenuItem.Checked = true;
            this.INFOToolStripMenuItem.CheckOnClick = true;
            this.INFOToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.INFOToolStripMenuItem.Name = "INFOToolStripMenuItem";
            this.INFOToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.INFOToolStripMenuItem.Text = "INFO";
            this.INFOToolStripMenuItem.Click += new System.EventHandler(this.INFOToolStripMenuItem_Click);
            // 
            // WARNINGToolStripMenuItem
            // 
            this.WARNINGToolStripMenuItem.Checked = true;
            this.WARNINGToolStripMenuItem.CheckOnClick = true;
            this.WARNINGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WARNINGToolStripMenuItem.Name = "WARNINGToolStripMenuItem";
            this.WARNINGToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.WARNINGToolStripMenuItem.Text = "WARNING";
            this.WARNINGToolStripMenuItem.Click += new System.EventHandler(this.WARNINGToolStripMenuItem_Click);
            // 
            // ERRORToolStripMenuItem
            // 
            this.ERRORToolStripMenuItem.Checked = true;
            this.ERRORToolStripMenuItem.CheckOnClick = true;
            this.ERRORToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ERRORToolStripMenuItem.Name = "ERRORToolStripMenuItem";
            this.ERRORToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ERRORToolStripMenuItem.Text = "ERROR";
            this.ERRORToolStripMenuItem.Click += new System.EventHandler(this.ERRORToolStripMenuItem_Click);
            // 
            // Logger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OutputBox);
            this.Name = "Logger";
            this.Size = new System.Drawing.Size(1000, 150);
            this.Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.ContextMenuStrip Settings;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox FontSize;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem INFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WARNINGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ERRORToolStripMenuItem;
    }
}
