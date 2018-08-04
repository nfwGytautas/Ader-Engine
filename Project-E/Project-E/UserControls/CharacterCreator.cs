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
    public partial class CharacterCreator : UserControl
    {
        public Logger Loger { get; set; }

        public TreeView MainTreeView { get; set; }

        public List<Classes.SpriteSheet> SpriteHandler { get; set; }

        public CharacterCreator()
        {
            InitializeComponent();
        }


        Bitmap OnTop;
        Bitmap SelectedSheet;

        List<Rectangle> SpriteSheet = new List<Rectangle>();
        List<Coloring> SpriteSheetActivator = new List<Coloring>();

        Label mapboundlabel;

        Classes.SpriteSheet FillerSprite = new Classes.SpriteSheet();

        int TileSize = 64;
        int TickRate = 500;

        bool UpTool = false;
        bool DownTool = false;
        bool LeftTool = false;
        bool RightTool = false;
        bool ProjectileTool = false;
        bool working = false;
        bool Compiled = false;


        //==========================================================================
        //Load event
        //==========================================================================
        private void CharacterCreator_Load(object sender, EventArgs e)
        {
            SpriteViewer.Loger = Loger;

            mapboundlabel = new Label()
            {
                Text = "",
            };
            UsePanel.Controls.Add(mapboundlabel);
        }

        //==========================================================================
        //Saves work to SpriteHandler
        //==========================================================================
        private void button6_Click(object sender, EventArgs e)
        {
            if (Compiled)
            {
                HelperForms.MessageBoxWithOneLineInput asker = new HelperForms.MessageBoxWithOneLineInput();
                string value = "";
                asker.value = value;
                asker.ShowDialog();
                value = asker.value;
                FillerSprite.Name = value + ".csf";
                FillerSprite.TickRate = TickRate;
                SpriteHandler.Add(FillerSprite);
                MainTreeView.Nodes[0].Nodes[2].Nodes.Add(FillerSprite.Name);
                Reset();
            } 
        }


        //==========================================================================
        //Upload a sprite sheet to work with
        //==========================================================================
        private void uploadSpriteSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectDir = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (selectDir.ShowDialog() == DialogResult.OK)
            {
                SelectedSheet = new Bitmap(Image.FromFile(selectDir.FileName));

                SpriteSheet.Clear();
                SpriteSheetActivator.Clear();

                working = true;

                OnTop = new Bitmap(SelectedSheet.Size.Width, SelectedSheet.Size.Height);


                mapboundlabel.Location = new Point(SelectedSheet.Size.Width + 1, SelectedSheet.Size.Height + 1);

                Loger.write(mapboundlabel.Location.ToString());

                for (int i = 0; i < SelectedSheet.Width / TileSize; i++)
                {
                    for(int j = 0; j < SelectedSheet.Height / TileSize; j++)
                    {
                        SpriteSheet.Add(new Rectangle(0 + i * TileSize, 0 + j * TileSize, TileSize, TileSize));
                        SpriteSheetActivator.Add(new Coloring(false)); 
                    }
                }

                UsePanel.Invalidate();
            }
        }


        #region Tool select

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpTool = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            DownTool = radioButton2.Checked;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RightTool = radioButton3.Checked;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            LeftTool = radioButton4.Checked;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ProjectileTool = radioButton5.Checked;
        }

        #endregion


        #region Editers

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Coloring x in SpriteSheetActivator)
            {
                if (x.up == true)
                {
                    Graphics g = Graphics.FromImage(OnTop);
                    g.FillRectangle(new SolidBrush(UsePanel.BackColor), x.rect);
                    g.FillRectangle(new TextureBrush(SelectedSheet, x.rect), x.rect);
                    x.change(5, false, x.rect);
                    UsePanel.Invalidate();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Coloring x in SpriteSheetActivator)
            {
                if (x.down == true)
                {
                    Graphics g = Graphics.FromImage(OnTop);
                    g.FillRectangle(new SolidBrush(UsePanel.BackColor), x.rect);
                    g.FillRectangle(new TextureBrush(SelectedSheet, x.rect), x.rect);
                    x.change(5, false, x.rect);
                    UsePanel.Invalidate();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Coloring x in SpriteSheetActivator)
            {
                if (x.right == true)
                {
                    Graphics g = Graphics.FromImage(OnTop);
                    g.FillRectangle(new SolidBrush(UsePanel.BackColor), x.rect);
                    g.FillRectangle(new TextureBrush(SelectedSheet, x.rect), x.rect);
                    x.change(5, false, x.rect);
                    UsePanel.Invalidate();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Coloring x in SpriteSheetActivator)
            {
                if (x.left == true)
                {
                    Graphics g = Graphics.FromImage(OnTop);
                    g.FillRectangle(new SolidBrush(UsePanel.BackColor), x.rect);
                    g.FillRectangle(new TextureBrush(SelectedSheet, x.rect), x.rect);
                    x.change(5, false, x.rect);
                    UsePanel.Invalidate();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Coloring x in SpriteSheetActivator)
            {
                if (x.attack == true)
                {
                    Graphics g = Graphics.FromImage(OnTop);
                    g.FillRectangle(new SolidBrush(UsePanel.BackColor), x.rect);
                    g.FillRectangle(new TextureBrush(SelectedSheet, x.rect), x.rect);
                    x.change(5, false, x.rect);
                    UsePanel.Invalidate();
                }
            }
        }

        #endregion      


        //==========================================================================
        //Compiles selections into visual representation
        //==========================================================================
        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FillerSprite.Image = new Bitmap(SelectedSheet);

                List<TextureBrush> Up = new List<TextureBrush>();
                List<Rectangle> UpRect = new List<Rectangle>();
                List<TextureBrush> Down = new List<TextureBrush>();
                List<Rectangle> DownRect = new List<Rectangle>();
                List<TextureBrush> Left = new List<TextureBrush>();
                List<Rectangle> LeftRect = new List<Rectangle>();
                List<TextureBrush> Right = new List<TextureBrush>();
                List<Rectangle> RightRect = new List<Rectangle>();
                List<TextureBrush> Attack = new List<TextureBrush>();
                List<Rectangle> AttackRect = new List<Rectangle>();

                foreach (Coloring x in SpriteSheetActivator)
                {
                    if (x.up)
                    {
                        Up.Add(new TextureBrush(SelectedSheet, x.rect));
                        UpRect.Add(x.rect);
                    }
                    else if (x.down)
                    {
                        Down.Add(new TextureBrush(SelectedSheet, x.rect));
                        DownRect.Add(x.rect);
                    }
                    else if (x.left)
                    {
                        Left.Add(new TextureBrush(SelectedSheet, x.rect));
                        LeftRect.Add(x.rect);
                    }
                    else if (x.right)
                    {
                        Right.Add(new TextureBrush(SelectedSheet, x.rect));
                        RightRect.Add(x.rect);
                    }
                    else if (x.attack)
                    {
                        Attack.Add(new TextureBrush(SelectedSheet, x.rect));
                        AttackRect.Add(x.rect);
                    }
                }

                FillerSprite.Up = Up;
                FillerSprite.Down = Down;
                FillerSprite.Left = Left;
                FillerSprite.Right = Right;
                FillerSprite.Attack = Attack;

                FillerSprite.UpRect = UpRect;
                FillerSprite.DownRect = DownRect;
                FillerSprite.LeftRect = LeftRect;
                FillerSprite.RightRect = RightRect;
                FillerSprite.AttackRect = AttackRect;


                Compiled = true;

                SpriteViewer.Compiled = true;
                SpriteViewer.FillerSprite = FillerSprite;
            }
            catch(Exception err)
            {
                Loger.write(err.ToString(),2);
                Compiled = false;
            }



        }


        //==========================================================================
        //Selects a rectangle
        //==========================================================================
        private void UsePanel_MouseClick(object sender, MouseEventArgs e)
        {
            int i = 0;
            Point pt = new Point(e.Location.X - UsePanel.AutoScrollPosition.X, e.Location.Y - UsePanel.AutoScrollPosition.Y);
            foreach (Rectangle x in SpriteSheet)
                if (x.Contains(pt))
                { 
                    Graphics g = Graphics.FromImage(OnTop);                   
                    if (UpTool && !SpriteSheetActivator[i].up)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Green)), x);
                        SpriteSheetActivator[i].change(0, true, x);
                        UsePanel.Invalidate();
                        return;
                    }
                    else if (DownTool && !SpriteSheetActivator[i].down)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Yellow)), x);
                        SpriteSheetActivator[i].change(1, true, x);
                        UsePanel.Invalidate();
                        return;

                    }
                    else if (LeftTool && !SpriteSheetActivator[i].left)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Blue)), x);
                        SpriteSheetActivator[i].change(2, true, x);
                        UsePanel.Invalidate();
                        return;
                    }
                    else if (RightTool && !SpriteSheetActivator[i].right)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Purple)), x);
                        SpriteSheetActivator[i].change(3, true, x);
                        UsePanel.Invalidate();
                        return;
                    }
                    else if (ProjectileTool && !SpriteSheetActivator[i].attack)
                    {
                        g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Red)), x);
                        SpriteSheetActivator[i].change(4, true, x);
                        UsePanel.Invalidate();
                        return;
                    }
                }
                else i++;
        }


        //==========================================================================
        //Paint event
        //==========================================================================
        private void UsePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt = new Point(UsePanel.AutoScrollPosition.X, UsePanel.AutoScrollPosition.Y);
            if (working)
            {
                g.DrawImage(SelectedSheet, pt);
                g.DrawImage(OnTop, pt); 
            }
        }


        //==========================================================================
        //Value changers
        //==========================================================================
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TileSize = (int)numericUpDown1.Value;
            SpriteSheet.Clear();
            SpriteSheetActivator.Clear();
            for (int i = 0; i < SelectedSheet.Width / TileSize; i++)
            {
                for (int j = 0; j < SelectedSheet.Height / TileSize; j++)
                {
                    SpriteSheet.Add(new Rectangle(0 + i * TileSize, 0 + j * TileSize, TileSize, TileSize));
                    SpriteSheetActivator.Add(new Coloring(false));
                }
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            TickRate = (int)numericUpDown2.Value;
            SpriteViewer.SetInterval(TickRate);
        }


        //==========================================================================
        //Resets after saving
        //==========================================================================
        private void Reset()
        {
            FillerSprite = new Classes.SpriteSheet();
            SpriteViewer.Compiled = false;
        }
    }








    public class Coloring
    {
        public bool up;
        public bool down;
        public bool left;
        public bool right;
        public bool attack;
        public Rectangle rect;

        public Coloring(bool x)
        {
            left = x;
            attack = x;
            down = x;
            right = x;
            up = x;
            rect = new Rectangle();
        }

        public void change(int argument1, bool argument2, Rectangle argument3)
        {
            switch (argument1)
            {
                case 0:
                    up = argument2;
                    down = !argument2;
                    left = !argument2;
                    right = !argument2;
                    attack = !argument2;
                    break;
                case 1:
                    up = !argument2;
                    down = argument2;
                    left = !argument2;
                    right = !argument2;
                    attack = !argument2;
                    break;
                case 2:
                    up = !argument2;
                    down = !argument2;
                    left = argument2;
                    right = !argument2;
                    attack = !argument2;
                    break;
                case 3:
                    up = !argument2;
                    down = !argument2;
                    left = !argument2;
                    right = argument2;
                    attack = !argument2;
                    break;
                case 4:
                    up = !argument2;
                    down = !argument2;
                    left = !argument2;
                    right = !argument2;
                    attack = argument2;
                    break;
                case 5:
                    up = argument2;
                    down = argument2;
                    left = argument2;
                    right = argument2;
                    attack = argument2;
                    break;

            }
            rect = argument3;
        }

    }


}
