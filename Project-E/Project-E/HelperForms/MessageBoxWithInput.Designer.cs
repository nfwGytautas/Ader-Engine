namespace Project_E.HelperForms
{
    partial class MessageBoxWithInput
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
            this.Buttons = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Name_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buttons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Buttons
            // 
            this.Buttons.Controls.Add(this.Cancel);
            this.Buttons.Controls.Add(this.Confirm);
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons.Location = new System.Drawing.Point(0, 175);
            this.Buttons.Name = "Buttons";
            this.Buttons.Size = new System.Drawing.Size(227, 32);
            this.Buttons.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.Location = new System.Drawing.Point(0, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(113, 32);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Confirm
            // 
            this.Confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.Confirm.Location = new System.Drawing.Point(114, 0);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(113, 32);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Ok";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name_int,
            this.Value});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(227, 175);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGrid_CellBeginEdit);
            this.DataGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGrid_EditingControlShowing);
            // 
            // Name_int
            // 
            this.Name_int.Frozen = true;
            this.Name_int.HeaderText = "Integer name";
            this.Name_int.Name = "Name_int";
            this.Name_int.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Value
            // 
            this.Value.Frozen = true;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MessageBoxWithInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 207);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MessageBoxWithInput";
            this.Load += new System.EventHandler(this.MessageBoxWithInput_Load);
            this.Buttons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Buttons;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}