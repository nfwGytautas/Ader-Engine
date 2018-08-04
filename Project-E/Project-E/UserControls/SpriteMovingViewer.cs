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
    public partial class SpriteMovingViewer : UserControl
    {
        public SpriteMovingViewer()
        {
            InitializeComponent();
        }

        public bool Compiled = false;
        public Classes.SpriteSheet FillerSprite {get;set;}
        public Logger Loger { get; set; }

        public void SetInterval(int tickRate)
        {
            MainTick.Interval = tickRate;
        }

        //==========================================================================
        //Ticks the spritesheet change
        //==========================================================================
        private void MainTick_Tick(object sender, EventArgs e)
        {
            if (Compiled)
            {
                UpSprite.Invalidate();
                DownSprite.Invalidate();
                LeftSprite.Invalidate();
                RightSprite.Invalidate();
                ProjectileSprite.Invalidate();
            }
        }

        #region Sprite changes

        private void UpSprite_Paint(object sender, PaintEventArgs e)
        {
            if (Compiled && FillerSprite.Up.Count > 0)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FillerSprite.getCycle("Up", false).Image, 0, 0);
            }
        }

        private void DownSprite_Paint(object sender, PaintEventArgs e)
        {
            if (Compiled && FillerSprite.Down.Count > 0)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FillerSprite.getCycle("Down", false).Image, 0, 0);
            }
        }

        private void LeftSprite_Paint(object sender, PaintEventArgs e)
        {
            if (Compiled && FillerSprite.Left.Count > 0)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FillerSprite.getCycle("Left", false).Image, 0, 0);
            }
        }

        private void RightSprite_Paint(object sender, PaintEventArgs e)
        {
            if (Compiled && FillerSprite.Right.Count > 0)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FillerSprite.getCycle("Right", false).Image, 0, 0);
            }
        }

        private void ProjectileSprite_Paint(object sender, PaintEventArgs e)
        {
            if (Compiled && FillerSprite.Attack.Count > 0)
            {
                Graphics g = e.Graphics;
                g.DrawImage(FillerSprite.getCycle("Attack", false).Image, 0, 0);
            }
        }

        #endregion


    }
}
