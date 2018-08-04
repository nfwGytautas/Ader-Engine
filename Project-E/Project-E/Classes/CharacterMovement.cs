using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*TBrush = new TextureBrush(Movement, new Rectangle(0, 32, 32, 32));
PlayerLocation.Image = TBrush.Image;
TBrush = new TextureBrush(Movement, new Rectangle(0, 64, 32, 32));
PlayerLocation.Image = TBrush.Image;*/


namespace Project_E.Classes
{
    public class CharacterMovement : GameObject
    {
        #region Variable definitions

        List<List<bool>> RefCollissionMap = new List<List<bool>>();
        List<bool> CollissionMap;

        SpriteSheet spriteSheet;

        bool hasSprite = false;

        #endregion

        #region Getters & Setters

        public Point GetPoint(DoubleBufferedPanel Map)
        {
            return new Point(Map.Width / 2 - Xloc * TileSize, Map.Height / 2 - Yloc * TileSize);
        }

        public List<bool> getCollissionMap()
        {
            return CollissionMap;
        }
        public void setCollissionMap(List<bool> argument)
        {
            CollissionMap = argument;
        }


        #endregion


        //==========================================================================
        //Loads a black rectangle
        //==========================================================================
        private void loadCharacterBlank()
        {
            OImage = new Bitmap(TileSize, TileSize);
            Graphics g = Graphics.FromImage(OImage);
            g.FillRectangle(Brushes.Black, 0, 0, TileSize, TileSize);          
        }

        public void loadCharacter(SpriteSheet argument1, bool argument2, bool argument3)
        {
            hasSprite = argument2;
            if (!argument2) loadCharacterBlank();

            spriteSheet = argument1;
            spriteSheet.skipLast(argument3);

            OImage = (Bitmap)spriteSheet.Down[0].Image;

            setColissionMap();
        }


        //==========================================================================
        //Refines a collisionmap
        //==========================================================================
        public void RefineCollissionMap(int aTileSize, int aMaxTiles, int aColCount, int aRowCount)
        {
            RefCollissionMap.Clear();
            TileSize = aTileSize;           
            MaxTiles = aMaxTiles;
            ColCount = aColCount;
            RowCount = aRowCount;
            setColissionMap();
        }


        //==========================================================================
        //Sets the colissionMap()
        //==========================================================================
        private void setColissionMap()
        {
            for (int i = 0; i < RowCount; i++)
            {
                List<bool> fillList = new List<bool>();
                for (int j = 0; j < ColCount; j++)
                {
                    fillList.Add(CollissionMap[j + i * ColCount]);
                }
                RefCollissionMap.Add(fillList.ToList());
                fillList.Clear();
            }
        }


        //==========================================================================
        //Handles movement
        //==========================================================================
        public void Movement(char e)
        {
            try
            {
                if ((e == 'W' || e == 'w') && RefCollissionMap[Yloc - 1][Xloc] == false)
                {
                    if(hasSprite) OImage = (Bitmap)spriteSheet.getCycle("Up", true).Image;
                    Yloc--;
                }
                if ((e == 'S' || e == 's') && RefCollissionMap[Yloc + 1][Xloc] == false)
                {
                    if (hasSprite) OImage = (Bitmap)spriteSheet.getCycle("Down", true).Image;
                    Yloc++;
                }
                if ((e == 'D' || e == 'd') && RefCollissionMap[Yloc][Xloc + 1] == false)
                {
                    if (hasSprite) OImage = (Bitmap)spriteSheet.getCycle("Right", true).Image;
                    Xloc++;
                }
                if ((e == 'A' || e == 'a') && RefCollissionMap[Yloc][Xloc - 1] == false)
                {
                    if (hasSprite) OImage = (Bitmap)spriteSheet.getCycle("Left", true).Image;
                    Xloc--;
                } 
            }
            catch(System.ArgumentOutOfRangeException)
            {      
            }
        }


        //==========================================================================
        //Clears the refined collisionmap
        //==========================================================================
        public void Clear()
        {
            RefCollissionMap.Clear();
        }

    }
}
