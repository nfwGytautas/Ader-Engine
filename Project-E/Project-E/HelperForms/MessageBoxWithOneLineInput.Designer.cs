namespace Project_E.HelperForms
{
    partial class MessageBoxWithOneLineInput
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.Input.Location = new System.Drawing.Point(0, 0);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(284, 20);
            this.Input.TabIndex = 0;
            this.Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // Ok
            // 
            this.Ok.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ok.Location = new System.Drawing.Point(209, 20);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 31);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel.Location = new System.Drawing.Point(134, 20);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // MessageBoxWithOneLineInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 51);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageBoxWithOneLineInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}