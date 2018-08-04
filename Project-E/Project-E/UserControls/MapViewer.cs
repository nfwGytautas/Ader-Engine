using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Project_E.UserControls
{
    public partial class MapViewer : UserControl
    {
        public MapViewer()
        {
            InitializeComponent();
        }

        public Logger Loger { get; set; }

        #region Variable definitions

        Image MapImage;
        Bitmap Map_Copy;

        int MaxTiles;
        int TileSize;

        bool MapProvided = false;
        bool MouseDownC = false;

        int LastX, LastY;

        Point viewPoint = new Point(0, 0);

        #endregion

        #region Getters & Setters

        public Point getViewPoint()
        {
            return viewPoint;
        }

        #endregion


        //==========================================================================
        //Load a map to the viewer
        //==========================================================================
        public void Load_Map(Classes.MapClass TheMap)
        {
            Map.Focus();
            MapImage = TheMap.getMapImage();
            MaxTiles = TheMap.getMaxTiles();
            TileSize = TheMap.getTileSize();    
            
            Map_Copy = (Bitmap)MapImage;    

            MapProvided = true;

            Map.Focus();

            Map.Invalidate();
        }

        //==========================================================================
        //Map painting event
        //==========================================================================
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            if(MapProvided)
            {      
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawImage(Map_Copy, viewPoint);
            }
        }


        #region Mouse handler

        //==========================================================================
        //Gives focus on hover
        //==========================================================================
        private void Map_MouseHover(object sender, EventArgs e)
        {
            Map.Focus();
        }


        //==========================================================================
        //Handles mouse moving
        //==========================================================================
        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownC = true;
                LastX = e.X;
                LastY = e.Y;
            }
        }
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownC = false;
        }      
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if(MouseDownC)
            {
                viewPoint.X += e.X - LastX;
                viewPoint.Y += e.Y - LastY;
                LastX = e.X;
                LastY = e.Y;

                Map.Invalidate();
            }
        }

        #endregion



    }
}
