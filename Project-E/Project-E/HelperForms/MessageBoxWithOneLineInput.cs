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
    public partial class MessageBoxWithOneLineInput : Form
    {
        public MessageBoxWithOneLineInput()
        {
            InitializeComponent();
        }

        #region Variable definitions

        public string value { get; set; }

        bool Filled = false;

        #endregion

        #region Getters & Setters

        public bool getStatus()
        {
            return Filled;
        }

        #endregion

        //==========================================================================
        //Confirm entered value
        //==========================================================================
        private void Ok_Click(object sender, EventArgs e)
        {
            CommonFunction();
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CommonFunction();
            }
        }
        private void CommonFunction()
        {
            value = Input.Text;
            Filled = true;
            this.Close();
        }


        //==========================================================================
        //Cancel task
        //==========================================================================
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
