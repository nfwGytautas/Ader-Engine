namespace Project_E.UserControls
{
    partial class CodingWindow
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
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.RightClickForCoding = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightClickForCoding.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeBox
            // 
            this.CodeBox.ContextMenuStrip = this.RightClickForCoding;
            this.CodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeBox.Location = new System.Drawing.Point(0, 0);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(1065, 636);
            this.CodeBox.TabIndex = 0;
            this.CodeBox.Text = "";
            // 
            // RightClickForCoding
            // 
            this.RightClickForCoding.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem});
            this.RightClickForCoding.Name = "RightClickForCoding";
            this.RightClickForCoding.Size = new System.Drawing.Size(120, 26);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // CodingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CodeBox);
            this.Name = "CodingWindow";
            this.Size = new System.Drawing.Size(1065, 636);
            this.RightClickForCoding.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.ContextMenuStrip RightClickForCoding;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
    }
}
