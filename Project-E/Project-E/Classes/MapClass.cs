using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class MapClass
    {
        public struct TileCode
        {
            public int Rectangle;
            public CodeFileClass Code;
            
            public TileCode(int index, CodeFileClass code)
            {
                Rectangle = index; Code = code;
            }
        }

        #region Variable definitions

        public UserControls.Logger Loger { get; set; }

        List<TileCode> TileCodes = new List<TileCode>();
        List<Rectangle> MapRectangles = new List<Rectangle>();
        List<bool> CollisionMap = new List<bool>();


        Bitmap MapImage = null;

        int TileSize = 0;
        int ColCount = 0;
        int RowCount = 0;
        int MaxTiles = 0;
        int CodeAmmount = 0;
        int OffSet = 0;

        bool StartMap = false;

        string mapName;

        #endregion

        #region Getters & Setters

        public List<TileCode> getTileCodes()
        {
            return TileCodes;
        }

        public List<Rectangle> getRectangles()
        {
            return MapRectangles;
        }

        public List<bool> getCollisionMap()
        {
            return CollisionMap;
        }
        public void setCollisionMap(List<bool> argument)
        {
            CollisionMap = argument;
        }
        public void addCollision(bool argument)
        {
            CollisionMap.Add(argument);
        }

        public Bitmap getMapImage()
        {
            return MapImage;
        }
        public void setMapImage(Bitmap argument)
        {
            MapImage = argument;
        }

        public int getTileSize()
        {
            return TileSize;
        }
        public void setTileSize(int argument)
        {
            TileSize = argument;
        }

        public int getColCount()
        {
            return ColCount;
        }
        public void setColCount(int argument)
        {
            ColCount = argument;
        }

        public int getRowCount()
        {
            return RowCount;
        }
        public void setRowCount(int argument)
        {
            RowCount = argument;
        }

        public int getMaxTiles()
        {
            return MaxTiles;
        }
        public void setMaxTiles(int argument)
        {
            MaxTiles = argument;
        }

        public int getCodeAmmount()
        {
            return CodeAmmount;
        }
        public void setCodeAmmount(int argument)
        {
            CodeAmmount = argument;
        }

        public int getOffSet()
        {
            return OffSet;
        }
        public void setOffSet(int argument)
        {
            OffSet = argument;
        }

        public bool getStartMap()
        {
            return StartMap;
        }
        public void setStartMap(bool argument)
        {
            StartMap = argument;
        }

        public string getMapName()
        {
            return mapName;           
        }
        public void setMapName(string argument)
        {
            mapName = argument;
        }

        #endregion

    }
}
