using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Project_E.UserControls
{
    public partial class Logger : UserControl
    {
        public Logger()
        {
            InitializeComponent();

        }

        #region Variable definitions

        short info = 0;
        bool infoDisplay = true;
        short warning = 1;
        bool warningDisplay = true;
        short error = 2;
        bool errorDisplay = true;

        List<string> text = new List<string>();
        List<short> levels = new List<short>();

        bool rewrite = false;

        #endregion    


        //==========================================================================
        //Write to logger
        //==========================================================================
        public void write(string message, short level)
        {
            if(!rewrite)
            {
                text.Add(message);
                levels.Add(level); 
            }
            
            if (level == info && infoDisplay)
            {
                OutputBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Black);
                OutputBox.AppendText("{INFO}" + message, Color.Blue);
                OutputBox.AppendText(Environment.NewLine);
            }
            else if(level == warning && warningDisplay)
            {
                OutputBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Black);
                OutputBox.AppendText("{WARNING}" + message, Color.Yellow);
                OutputBox.AppendText(Environment.NewLine);
            }
            else if(level == error && errorDisplay)
            {
                OutputBox.AppendText("[" + DateTime.Now.ToShortTimeString() + "]", Color.Black);
                OutputBox.AppendText("{ERROR}" + message, Color.DarkRed);
                OutputBox.AppendText(Environment.NewLine);
            }       
        }
        public void write(string[] messages, short[] levels)
        {
            for (int i = 0; i < messages.Length; i++)
                write(messages[i], levels[i]);
        }
        public void write(int message, short level)
        {
            write(message.ToString(), level);
        }
        public void write(string message)
        {
            write(message, 0);
        }
        public void write(int message)
        {
            write(message.ToString(), 0);
        }


        //==========================================================================
        //Clear logger
        //==========================================================================
        public void clear()
        {
            OutputBox.Text = "";
            write("Engine boot succsessfull!");
        }


        //==========================================================================
        //Change font size
        //==========================================================================
        private void FontSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int Size = Int32.Parse(FontSize.Text);
                if (Size > 0)
                {
                    OutputBox.SelectAll();
                    OutputBox.SelectionFont = new Font(OutputBox.Font.Name, Size);
                }
            }
        }


        //==========================================================================
        //Disable warnings
        //==========================================================================
        private void ERRORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            errorDisplay = ERRORToolStripMenuItem.Checked;
            rewriteText();
        }
        private void WARNINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            warningDisplay = WARNINGToolStripMenuItem.Checked;
            rewriteText();
        }
        private void INFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoDisplay = INFOToolStripMenuItem.Checked;
            rewriteText();
        }

        private void rewriteText()
        {
            rewrite = true;
            OutputBox.Clear();
            write(text.ToArray(), levels.ToArray());
            rewrite = false;
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {
            OutputBox.SelectionStart = OutputBox.Text.Length;
            OutputBox.ScrollToCaret();
        }
    }
}

public static class RichTextBoxExtensions
{
    public static void AppendText(this RichTextBox box, string text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text);
        box.SelectionColor = box.ForeColor;
    }

    public static void AppendText(this RichTextBox box, char text, Color color)
    {
        box.SelectionStart = box.TextLength;
        box.SelectionLength = 0;

        box.SelectionColor = color;
        box.AppendText(text.ToString());
        box.SelectionColor = box.ForeColor;
    }
}
