using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class GameObject
    {
        public int TileSize { get; set; }
        public int MaxTiles { get; set; }
        public int ColCount { get; set; }
        public int RowCount { get; set; }
        public int Xloc { get; set; }
        public int Yloc { get; set; }
        public Bitmap OImage { get; set; }
        public UserControls.Logger Loger { get; set; }
    }
}
