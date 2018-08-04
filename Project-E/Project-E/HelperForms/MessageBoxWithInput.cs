using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_E.HelperForms
{
    public partial class MessageBoxWithInput : Form
    {
        public MessageBoxWithInput()
        {
            InitializeComponent();
        }

        #region Variable definitions

        public List<string> Names { get; set; }
        public List<string> Values { get; } = new List<string>();

        bool Filled = false;

        #endregion

        #region Getters & Setters

        public bool getStatus()
        {
            return Filled;
        }

        #endregion


        //==========================================================================
        //On load
        //==========================================================================
        private void MessageBoxWithInput_Load(object sender, EventArgs e)
        {
            Filled = false;

            for (int i = 0; i < Names.Count(); i++)
                DataGrid.Rows.Add(Names[i]);
        }


        //==========================================================================
        //Button clicks
        //==========================================================================
        private void Cancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }


        //==========================================================================
        //Confirm selection
        //==========================================================================
        private void Confirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].Cells[1].Value != null)
                    Values.Add(DataGrid.Rows[i].Cells[1].Value.ToString());
            }

            if(Values.Count > 0) Filled = true;

            ((Form)this.TopLevelControl).Close();
        }


        //==========================================================================
        //Allow cell editing
        //==========================================================================
        TextBox editBox = null;
        private void DataGrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string yourValue = "0";
                DataGrid.Rows[e.RowIndex].Cells[1].Value = yourValue;
                if (editBox != null) editBox.Text = yourValue;
            }
        }
        private void DataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox) editBox = e.Control as TextBox;
        }

    }
}
