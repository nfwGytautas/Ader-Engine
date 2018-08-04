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
    public partial class BackSideWhait : Form
    {
        public BackSideWhait()
        {
            InitializeComponent();
        }

        private void BackSideWhait_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
