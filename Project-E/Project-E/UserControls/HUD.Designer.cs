namespace Project_E.UserControls
{
    partial class HUD
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
            this.HP_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Hp_text = new System.Windows.Forms.RichTextBox();
            this.HP_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HP_Panel
            // 
            this.HP_Panel.Controls.Add(this.label1);
            this.HP_Panel.Controls.Add(this.Hp_text);
            this.HP_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HP_Panel.Location = new System.Drawing.Point(0, 0);
            this.HP_Panel.Name = "HP_Panel";
            this.HP_Panel.Size = new System.Drawing.Size(250, 83);
            this.HP_Panel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Quartz MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "HP:";
            // 
            // Hp_text
            // 
            this.Hp_text.Dock = System.Windows.Forms.DockStyle.Right;
            this.Hp_text.Location = new System.Drawing.Point(142, 0);
            this.Hp_text.Name = "Hp_text";
            this.Hp_text.ReadOnly = true;
            this.Hp_text.Size = new System.Drawing.Size(108, 83);
            this.Hp_text.TabIndex = 2;
            this.Hp_text.Text = "";
            // 
            // HUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HP_Panel);
            this.MinimumSize = new System.Drawing.Size(250, 0);
            this.Name = "HUD";
            this.Size = new System.Drawing.Size(250, 600);
            this.HP_Panel.ResumeLayout(false);
            this.HP_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HP_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Hp_text;
    }
}
