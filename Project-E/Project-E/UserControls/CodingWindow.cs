using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_E.UserControls
{
    public partial class CodingWindow : UserControl
    {
        public CodingWindow()
        {
            InitializeComponent();
        }


        #region Variable definitions

        public Logger Loger { get; set; }
        public Classes.CodeCompiler CodeHandler { get; set; }
        public Classes.CodeFileClass CodeFile { get; set; }

        #endregion

        #region Getters & Setters

        List<string> getCode()
        {
            return CodeFile.getRawCode();
        }

        #endregion


        //==========================================================================
        //Compile code
        //==========================================================================
        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CodeFile.getRawCode().Clear();

            for(int i = 0; i < CodeBox.Lines.Count(); i++)
            {
                CodeFile.getRawCode().Add(CodeBox.Lines[i]);
            }

            CodeHandler.Compile(CodeFile);
        }


        //==========================================================================
        //Update text
        //==========================================================================
        public void UpdateCode(List<string> text)
        {
            for(int i = 0; i < text.Count(); i++)
            {
                CodeBox.AppendText(text[i]);
                if (i + 1 < text.Count()) CodeBox.AppendText(Environment.NewLine);
            }

        }

    }
}
