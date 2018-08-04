using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_E.Classes
{
    public class SpriteSheet
    {
        public Bitmap Image { get; set; }

        public List<TextureBrush> Up = new List<TextureBrush>();
        public List<Rectangle> UpRect = new List<Rectangle>();

        public List<TextureBrush> Down = new List<TextureBrush>();
        public List<Rectangle> DownRect = new List<Rectangle>();

        public List<TextureBrush> Left = new List<TextureBrush>();
        public List<Rectangle> LeftRect = new List<Rectangle>();

        public List<TextureBrush> Right = new List<TextureBrush>();
        public List<Rectangle> RightRect = new List<Rectangle>();

        public List<TextureBrush> Attack = new List<TextureBrush>();
        public List<Rectangle> AttackRect = new List<Rectangle>();

        public int CurrentUp = 0;
        public int CurrentDown = 0;
        public int CurrentLeft = 0;
        public int CurrentRight = 0;
        public int CurrentAttack = 0;
        public int TickRate = 100;

        public string Name;

        bool skiplast = false;

        public TextureBrush getCycle(string argument1, bool argument2)
        {
            switch (argument1)
            {
                case "Up":
                    if (argument2)
                        {CurrentDown = 1;CurrentLeft = 1;CurrentRight = 1;CurrentAttack = 1;}
                    CurrentUp++;
                    if (CurrentUp > Up.Count())
                        { CurrentUp = 1;return Up[0]; }
                    if (CurrentUp == Up.Count() && skiplast)
                        { CurrentUp = 1; return Up[CurrentUp]; }
                    else return Up[CurrentUp - 1];
                case "Down":
                    if (argument2)
                        { CurrentUp = 1; CurrentLeft = 1; CurrentRight = 1; CurrentAttack = 1; }
                    CurrentDown++;
                    if (CurrentDown > Down.Count())
                        { CurrentDown = 1; return Down[0]; }
                    if (CurrentDown == Down.Count() && skiplast)
                        { CurrentDown = 1; return Down[CurrentDown]; }
                    else return Down[CurrentDown - 1];
                case "Left":
                    if (argument2)
                        { CurrentDown = 1; CurrentUp = 1; CurrentRight = 1; CurrentAttack = 1; }
                    CurrentLeft++;
                    if (CurrentLeft > Left.Count())
                        { CurrentLeft = 1; return Left[0]; }
                    if (CurrentLeft == Left.Count() && skiplast)
                        { CurrentLeft = 1; return Left[CurrentLeft]; }
                    else return Left[CurrentLeft - 1];
                case "Right":
                    if (argument2)
                        { CurrentDown = 1; CurrentLeft = 1; CurrentUp = 1; CurrentAttack = 1; }
                    CurrentRight++;
                    if (CurrentRight > Right.Count())
                        { CurrentRight = 1; return Right[0]; }
                    if (CurrentRight == Right.Count() && skiplast)
                        { CurrentRight = 1; return Right[CurrentRight]; }
                    else return Right[CurrentRight - 1];
                case "Attack":
                    if (argument2)
                        { CurrentDown = 1; CurrentLeft = 1; CurrentRight = 1; CurrentUp = 1; }
                    CurrentAttack++;
                    if (CurrentAttack > Attack.Count())
                        { CurrentAttack = 1; return Attack[0]; }
                    if (CurrentAttack == Attack.Count() && skiplast)
                        { CurrentAttack = 1; return Attack[CurrentAttack]; }
                    else return Attack[CurrentAttack - 1];
            }
            return new TextureBrush(Image);
        }

        public void reset()
        {
            CurrentUp = 0;
            CurrentDown = 0;
            CurrentLeft = 0;
            CurrentRight = 0;
            CurrentAttack = 0;
        }

        public void skipLast(bool argument)
        {
            skiplast = argument;
        }
    }
}
