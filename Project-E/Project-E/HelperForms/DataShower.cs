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
    public partial class DataShower : Form
    {
        public DataShower()
        {
            InitializeComponent();
            this.DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }

        #region Variable definitions

        public List<string> Data { get; set; }

        public int returnInt { get; set; }

        #endregion


        //==========================================================================
        //Load data
        //==========================================================================
        private void DataShower_Load(object sender, EventArgs e)
        {
            DGV.Rows.Clear();

            foreach (string x in Data)
                DGV.Rows.Add(x);

            this.DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }


        //==========================================================================
        //Select data
        //==========================================================================
        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGV.Rows.Count > 0)
            {
                returnInt = DGV.CurrentCell.RowIndex;
            }
            this.Close();
        }
    }
}
