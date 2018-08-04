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
using Project_E.HelperForms;

namespace Project_E.UserControls
{
    public partial class CreateMap : UserControl
    {
        public CreateMap()
        {
            InitializeComponent();
        }

        #region Variable definitions

        public TreeView MainTreeView { get; set; }
        public string projectPath { get; set; }
        public List<Classes.MapClass> MapHandler { get; set; }
        public Classes.FileManager fileManager { get;set; }
        public Logger Loger { get; set; }


        List<Rectangle> TileSets = new List<Rectangle>();
        List<Rectangle> MapRectangles = new List<Rectangle>();
        List<bool> CollisionMap = new List<bool>();

        Rectangle SelectedTile = new Rectangle(0, 0, 0, 0);

        Bitmap BMP;
        Bitmap Combination;
        Bitmap Grid;


        int TileSize = 0;
        int MaxTiles = 0;
        int RowCount = 0;
        int ColCount = 0;
        int timesCreated = 0;
        int OffSet = 0;
        int FirstRectangle = 0;
        int SecondRectangle = 0;
        

        bool SAVING_DEBUG = false;
        bool _MouseDown = false;
        bool logClick = false;
        bool EnabledCreator = false;
        bool MapCreated = false;
        bool EnabledCol = false;
        bool MapNamed = false;
        bool RectangleDraw = false;
        bool ShowGrid = true;


        string nameOfMap = "unnamed";

        #endregion       

        #region Getters & Setters

        public int getTileSize()
        {
            return TileSize;
        }

        public int getMaxTiles()
        {
            return MaxTiles;
        }

        public void setTileSize(int aTileSize)
        {
            TileSize = aTileSize;
        }

        public void setMaxTiles(int aMaxTiles)
        {
            MaxTiles = aMaxTiles;
        }

        #endregion


        //==========================================================================
        //Select tile sheet
        //==========================================================================
        private void loadTileSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectDir = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (selectDir.ShowDialog() == DialogResult.OK)
            {
                Tiles.Image = Image.FromFile(selectDir.FileName);
                Tiles.Visible = true;

                for (int Rows = 0; Rows < Tiles.Height / (TileSize + OffSet); Rows++)
                    for (int Collumns = 0; Collumns < Tiles.Width / (TileSize + OffSet); Collumns++)
                    {
                        TileSets.Add(new Rectangle(0 + Collumns * (TileSize + OffSet), 0 + Rows * (TileSize + OffSet), (TileSize + OffSet), (TileSize + OffSet)));
                    }

                Loger.write("MAP CREATOR: Tileset loading complete", 0);
                Loger.write("MAP CREATOR: Dimensions are as follows: Rows " + (Tiles.Height / (TileSize + OffSet)).ToString() 
                    + " ;Collumns " + (Tiles.Width / (TileSize + OffSet)).ToString(), 0);
            }

            Map.Invalidate();
        }


        #region Graphics functions


        //==========================================================================
        //Draw a grid
        //==========================================================================
        private void DrawMap()
        {
            Graphics g = Graphics.FromImage(Grid);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, Grid.Size.Width, Grid.Size.Height);
            // draw the "map"
            Pen pen = new Pen(Color.Black);

            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColCount; j++)
                {
                    g.DrawRectangle(pen, 0 + j * TileSize, 0 + i * TileSize, TileSize, TileSize);
                    MapRectangles.Add(new Rectangle(0 + j * TileSize, 0 + i * TileSize, TileSize, TileSize));
                    CollisionMap.Add(false);
                }
        }


        //==========================================================================
        //Map paint
        //==========================================================================
        private void Map_Paint(object sender, PaintEventArgs e)
        {
            if(MapCreated)
            {
                Graphics g = e.Graphics;
                Point pt = new Point(Map.AutoScrollPosition.X, Map.AutoScrollPosition.Y);
                g.DrawImage(BMP, pt);
                if (ShowGrid) g.DrawImage(Grid, pt);
                if (EnabledCol) g.DrawImage(Combination, pt);
            }
        }       


        //==========================================================================
        //Draw texture & collision
        //==========================================================================
        private void Draw(MouseEventArgs e)
        {
            if (Tiles.Visible && MapCreated)
            {
                Graphics g = Graphics.FromImage(BMP);
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Point pt = new Point(e.Location.X - Map.AutoScrollPosition.X, e.Location.Y - Map.AutoScrollPosition.Y);
                foreach (Rectangle z in MapRectangles)
                    if (z.Contains(pt))
                    {                      
                        Rectangle select = new Rectangle(SelectedTile.X + OffSet, SelectedTile.Y + OffSet, 
                            z.Width, z.Height);
   
                        using (TextureBrush TBrush = new TextureBrush(Tiles.Image, select))
                            g.FillRectangle(TBrush, z);
                        Map.Invalidate();
                        break;
                    }
            }
        }
        private void DrawCollision(MouseEventArgs e, bool _action)
        {
            if (Tiles.Visible && MapCreated)
            {
                Point pt = new Point(e.Location.X - Map.AutoScrollPosition.X, e.Location.Y - Map.AutoScrollPosition.Y);
                Graphics g = Graphics.FromImage(Combination);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < MapRectangles.Count; i++)
                {
                    if (MapRectangles[i].Contains(pt) && EnabledCol)
                    {
                        switch (_action)
                        {
                            case true: //Left
                                if (!CollisionMap[i])
                                {
                                    CollisionMap[i] = true;
                                    g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Red)), MapRectangles[i]);
                                }
                                break;
                            case false: //Right
                                if (CollisionMap[i])
                                {
                                    CollisionMap[i] = false;
                                    g.FillRectangle(new TextureBrush(BMP, MapRectangles[i]), MapRectangles[i]);
                                }
                                break;
                        }
                        Map.Invalidate();
                        break;
                    }
                }
            }
        }


        //==========================================================================
        //Rectangle drawing
        //==========================================================================
        private void SetFirst(MouseEventArgs e)
        {
            if (MapCreated)
            {
                Point pt = new Point(e.Location.X - Map.AutoScrollPosition.X, e.Location.Y - Map.AutoScrollPosition.Y);
                int i = 0;
                foreach (Rectangle z in MapRectangles)
                    if (z.Contains(pt))
                    {
                        FirstRectangle = i;
                        Loger.write("First rectangle chosen: " + MapRectangles[FirstRectangle].ToString());
                        break;
                    }
                    else i++;
            }
        }
        private void SetSecond(MouseEventArgs e)
        {
            if (MapCreated)
            {
                Point pt = new Point(e.Location.X - Map.AutoScrollPosition.X, e.Location.Y - Map.AutoScrollPosition.Y);
                int i = 0;
                foreach (Rectangle z in MapRectangles)
                    if (z.Contains(pt))
                    {
                        SecondRectangle = i;
                        Loger.write("Second rectangle chosen: " + MapRectangles[SecondRectangle].ToString());

                        Graphics g = Graphics.FromImage(BMP);
                        g.SmoothingMode = SmoothingMode.AntiAlias;



                        Rectangle draw = new Rectangle();

                        if (MapRectangles[FirstRectangle].X <= MapRectangles[SecondRectangle].X &&
                            MapRectangles[FirstRectangle].Y <= MapRectangles[SecondRectangle].Y)
                        {
                            draw = new Rectangle(MapRectangles[FirstRectangle].X,
                                                    MapRectangles[FirstRectangle].Y,
                                                    MapRectangles[SecondRectangle].X - MapRectangles[FirstRectangle].X + TileSize,
                                                    MapRectangles[SecondRectangle].Y - MapRectangles[FirstRectangle].Y + TileSize);
                        }
                        else if (MapRectangles[FirstRectangle].X >= MapRectangles[SecondRectangle].X &&
                            MapRectangles[FirstRectangle].Y >= MapRectangles[SecondRectangle].Y)
                        {
                            draw = new Rectangle(MapRectangles[SecondRectangle].X,
                                                    MapRectangles[SecondRectangle].Y,
                                                    MapRectangles[FirstRectangle].X - MapRectangles[SecondRectangle].X + TileSize,
                                                    MapRectangles[FirstRectangle].Y - MapRectangles[SecondRectangle].Y + TileSize);
                        }
                        else if (MapRectangles[FirstRectangle].X >= MapRectangles[SecondRectangle].X &&
                            MapRectangles[FirstRectangle].Y <= MapRectangles[SecondRectangle].Y)
                        {
                            draw = new Rectangle(MapRectangles[SecondRectangle].X,
                                                    MapRectangles[FirstRectangle].Y,
                                                    MapRectangles[FirstRectangle].X - MapRectangles[SecondRectangle].X + TileSize,
                                                    MapRectangles[SecondRectangle].Y - MapRectangles[FirstRectangle].Y + TileSize);
                        }
                        else if (MapRectangles[FirstRectangle].X <= MapRectangles[SecondRectangle].X &&
                            MapRectangles[FirstRectangle].Y >= MapRectangles[SecondRectangle].Y)
                        {
                            draw = new Rectangle(MapRectangles[FirstRectangle].X,
                                                    MapRectangles[SecondRectangle].Y,
                                                    MapRectangles[SecondRectangle].X - MapRectangles[FirstRectangle].X + TileSize,
                                                    MapRectangles[FirstRectangle].Y - MapRectangles[SecondRectangle].Y + TileSize);
                        }


                        Rectangle select = new Rectangle(SelectedTile.X + OffSet, SelectedTile.Y + OffSet,
                        z.Width, z.Height);

                        using (TextureBrush TBrush = new TextureBrush(Tiles.Image, select))
                            g.FillRectangle(TBrush, draw);
                        Map.Invalidate();



                        break;
                    }
                    else i++;
            }
        }


        #endregion


        #region Mouse events


        //==========================================================================
        //Handle mouse input
        //==========================================================================
        private void Tiles_MouseClick(object sender, MouseEventArgs e)
        {
            //Point pt = new Point(e.Location.X - TileSetPanel.AutoScrollPosition.X, e.Location.Y - TileSetPanel.AutoScrollPosition.Y);
            foreach (Rectangle z in TileSets)
                if (z.Contains(e.Location))
                {
                    SelectedTile = z;
                    if (logClick) Loger.write(z.X.ToString() + z.Y.ToString(), 0);
                    EnabledCreator = true;
                    break;
                }
        }


        //==========================================================================
        //Function for left or right mouse click for collision
        //==========================================================================
        private void MouseDetermination(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawCollision(e, true);
                    break;
                case MouseButtons.Right:
                    DrawCollision(e, false);
                    break;
            }
        }


        //==========================================================================
        //Map click
        //==========================================================================
        private void Map_MouseClick(object sender, MouseEventArgs e)
        {
            CommonDraw(e);
        }


        //==========================================================================
        //Mouse drag draw
        //==========================================================================
        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            _MouseDown = true;
        }
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            CommonDraw(e);
        }
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            _MouseDown = false;
        }


        //==========================================================================
        //Handler of status
        //==========================================================================
        private void CommonDraw(MouseEventArgs e)
        {
            if (_MouseDown && e.Button == MouseButtons.Left && EnabledCreator && !EnabledCol && !RectangleDraw) Draw(e);
            else if (_MouseDown && e.Button == MouseButtons.Left && EnabledCreator && RectangleDraw) SetFirst(e);
            else if (_MouseDown && e.Button == MouseButtons.Right && EnabledCreator && RectangleDraw) SetSecond(e);
            else if ((e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) && EnabledCreator && EnabledCol) MouseDetermination(e);
        }

        #endregion


        //==========================================================================
        //Handle loging
        //==========================================================================
        private void LogTileClick_CheckedChanged(object sender, EventArgs e)
        {
            logClick = LogTileClick.Checked;
        }


        //==========================================================================
        //Get values
        //==========================================================================
        private void addMap_Click(object sender, EventArgs e)
        {
            MessageBoxWithInput test = new MessageBoxWithInput();
            List<string> rty = new List<string>
            {
                "Collumn amount",
                "Row amount",
                "Tile width & height",
                "Map name",
                "Offset"
            };
            test.Names = rty;

            test.ShowDialog();
  
            if(test.getStatus())
            {
                ColCount = Int32.Parse(test.Values[0]);
                RowCount = Int32.Parse(test.Values[1]);
                MaxTiles = ColCount * RowCount;
                TileSize = Int32.Parse(test.Values[2]);
                nameOfMap = test.Values[3];
                OffSet = Int32.Parse(test.Values[4]);
                MapNamed = true;
                constructMap();
            }
        }


        //==========================================================================
        //Create the map
        //==========================================================================
        private void constructMap()
        {
            Loger.write((ColCount * TileSize) + 1);
            Loger.write((RowCount * TileSize) + 1);
            BMP = new Bitmap((ColCount * TileSize) + 1, (RowCount * TileSize) + 1);
            Combination = new Bitmap((ColCount * TileSize) + 1, (RowCount * TileSize) + 1);
            Grid = new Bitmap((ColCount * TileSize) + 1, (RowCount * TileSize) + 1);
            Label l = new Label
            {
                Text = "",
                Location = new Point((ColCount * TileSize) + 1, (RowCount * TileSize) + 1) //784,448 is a point outside of the viewable area
            };

            Map.Controls.Add(l);
            DrawMap();
            MapCreated = true;
            Map.Invalidate();
        }


        //==========================================================================
        //Setup collision
        //==========================================================================
        private void SetupCollision_Click(object sender, EventArgs e)
        {
            EnabledCol = !EnabledCol;
            switch (EnabledCol)
            {
                case true:
                    Loger.write("Enabled",0);
                    break;
                case false:
                    Loger.write("Disabled",0);
                    break;
            }
            Map.Invalidate();
        }


        //==========================================================================
        //Save the map
        //==========================================================================
        private void SaveMap_Click(object sender, EventArgs e)
        {
            string name = nameOfMap + timesCreated + ".mxt";
            if(MapNamed) name = nameOfMap + ".mxt";
            if (!SAVING_DEBUG)
            {

                Classes.MapClass MapHandlerFiller = new Classes.MapClass()
                {
                    Loger = Loger,
                };
                MapHandlerFiller.setMapName(name);
                MapHandlerFiller.setTileSize(TileSize);
                MapHandlerFiller.setRowCount(RowCount);
                MapHandlerFiller.setColCount(ColCount);
                MapHandlerFiller.setMapImage(new Bitmap(BMP));
                MapHandlerFiller.setMaxTiles(MaxTiles);
                MapHandlerFiller.setCollisionMap(new List<bool>(CollisionMap));
                MapHandlerFiller.setOffSet(OffSet);

                fileManager.SaveMap(name, MapHandlerFiller);
                MapHandler.Add(MapHandlerFiller);
            }
            add_child_node_map(name);


            timesCreated++;
        }


        //==========================================================================
        //Load the map
        //==========================================================================
        public void LoadMap(Classes.MapClass argument)
        {
            nameOfMap = argument.getMapName().Substring(0, argument.getMapName().Length-4);
            TileSize = argument.getTileSize();
            OffSet = argument.getOffSet();
            RowCount = argument.getRowCount();
            ColCount = argument.getColCount();
            BMP = argument.getMapImage();
            MaxTiles = argument.getMaxTiles();
            CollisionMap = argument.getCollisionMap();
            MapRectangles = argument.getRectangles();
            Combination = new Bitmap((ColCount * TileSize) + 1, (RowCount * TileSize) + 1);
            Label l = new Label
            {
                Text = "",
                Location = new Point((ColCount * TileSize) + 1, (RowCount * TileSize) + 1) //784,448 is a point outside of the viewable area
            };
            Map.Controls.Add(l);
            MapCreated = true;
            MapNamed = true;

            int i = 0;
            Graphics g = Graphics.FromImage(Combination);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (bool x in CollisionMap)
            {
                if(x)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Red)), MapRectangles[i]);
                i++;
            }

            Grid = new Bitmap((ColCount * TileSize) + 1, (RowCount * TileSize) + 1);

            Graphics gg = Graphics.FromImage(Grid);
            Pen pen = new Pen(Color.Black);
            gg.SmoothingMode = SmoothingMode.AntiAlias;
            gg.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, Grid.Size.Width, Grid.Size.Height);
            for (int z = 0; z < RowCount; z++)
                for (int j = 0; j < ColCount; j++)
                    gg.DrawRectangle(pen, 0 + j * TileSize, 0 + z * TileSize, TileSize, TileSize);

            Map.Invalidate();
        }


        //==========================================================================
        //Add the map to treeview
        //==========================================================================
        private void add_child_node_map(string NodeName)
        {
            if (!string.IsNullOrEmpty(NodeName))
            {
                TreeNode parentNode = MainTreeView.Nodes[0].Nodes[1];               
                if (parentNode != null)
                {
                    bool exists = false;
                    foreach(TreeNode x in parentNode.Nodes)
                    {
                        if (x.Text == NodeName) exists = true;
                    }
                    if(!exists) parentNode.Nodes.Add(NodeName);
                    MainTreeView.ExpandAll();
                }
            }
        }


        //==========================================================================
        //Initialize
        //==========================================================================
        private void CreateMap_Load(object sender, EventArgs e)
        {

        }


        //==========================================================================
        //Enables rectangle tool
        //==========================================================================
        private void RectangleTool_CheckedChanged(object sender, EventArgs e)
        {
            RectangleDraw = RectangleTool.Checked;
        }

        private void gridCheck_CheckedChanged(object sender, EventArgs e)
        {
            ShowGrid = gridCheck.Checked;
            Map.Invalidate();
        }

        //==========================================================================
        //Allows to put in a prebuilt map image
        //==========================================================================
        private void UploadPBMI_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectDir = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };

            if (selectDir.ShowDialog() == DialogResult.OK)
            {
                BMP = (Bitmap)Image.FromFile(selectDir.FileName);                
            }

            Map.Invalidate();
        }
    }
}
