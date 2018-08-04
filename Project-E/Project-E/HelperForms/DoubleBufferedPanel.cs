namespace System.Windows.Forms
{
    public class DoubleBufferedPanel : Panel {
        public DoubleBufferedPanel() : base() { DoubleBuffered = true; }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}