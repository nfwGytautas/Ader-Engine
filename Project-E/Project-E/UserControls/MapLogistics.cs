using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Project_E.UserControls
{
    public partial class MapLogistics : UserControl
    {
        public MapLogistics()
        {
            InitializeComponent();
        }

        #region Variable definitions

        public Logger Loger { get; set; }

        public List<Classes.CodeFileClass> CodeHandler { get; set; }

        public List<Classes.MapClass> MapHandler { get; set; }

        Label PanelBounds = new Label();

        Bitmap Grid;
        Bitmap CodeVisual;

        int SelectedTool = 0;
        int SelectedMap = -1;
        int SelectedCode = -1;
        int FontSize = 8;

        List<bool> AlreadyDrawnCode = new List<bool>();
        bool MapSelected = false;
        bool ShowCode = true;

        #endregion

        //==========================================================================
        //Set up the window
        //==========================================================================
        private void MapLogistics_Load(object sender, EventArgs e)
        {
            CurrentTool.Text = "";
            ToolSelectionBox.DropDownItems.Clear();


            ToolStripItem subItem1 = new ToolStripMenuItem
            {
                Text = "Code assign tool"
            };
            subItem1.Click += MenuClicked;



            ToolSelectionBox.DropDownItems.Add(subItem1);

            PanelBounds.Text = "";
            
            UsePanel.Controls.Add(PanelBounds);


            if(ShowCode) SelectionStripDDB.ForeColor = Color.Green;
            else if(!ShowCode ) SelectionStripDDB.ForeColor = Color.Red;
        }


        //==========================================================================
        //Select the tool
        //==========================================================================
        private void MenuClicked(object sender, EventArgs e)
        {          
            if (((ToolStripMenuItem)sender).Text == "Code assign tool")
            {
                SelectedTool = 1;

                List<string> Data = new List<string>();
                foreach (Classes.CodeFileClass x in CodeHandler)
                    Data.Add(x.getName());

                HelperForms.DataShower Show = new HelperForms.DataShower
                {
                    Data = Data,
                    returnInt = SelectedCode
                };
                Show.ShowDialog();

                SelectedCode = Show.returnInt;

                if (SelectedCode < 0) SelectedTool = 0;
                else CurrentTool.Text = ((ToolStripMenuItem)sender).Text;

                CurrentTool.ForeColor = SystemColors.Highlight;
            }
        }


        //==========================================================================
        //Choose a map to code
        //==========================================================================
        public void AssignMap(string Map)
        {
            for (int i = 0; i < MapHandler.Count; i++)
                if (MapHandler[i].getMapName() == Map)
                {
                    SelectedMap = i;
                    PanelBounds.Location = new Point((MapHandler[SelectedMap].getColCount() * MapHandler[SelectedMap].getTileSize()) + 1, (MapHandler[SelectedMap].getRowCount() * MapHandler[SelectedMap].getTileSize()) + 1);
                    MapSelected = true;

                    Grid = new Bitmap((MapHandler[SelectedMap].getColCount() * MapHandler[SelectedMap].getTileSize()), (MapHandler[SelectedMap].getRowCount() * MapHandler[SelectedMap].getTileSize()));

                    Pen pen = new Pen(Color.Black);


                    Graphics g = Graphics.FromImage(Grid);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, Grid.Size.Width, Grid.Size.Height);

                    StringFormat format = new StringFormat()
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };

                    Font font = new Font("Tahoma", FontSize);

                    //Draws a grid and tile numbers
                    for (int r = 0; r < MapHandler[SelectedMap].getRowCount(); r++)
                        for (int c = 0; c < MapHandler[SelectedMap].getColCount(); c++)
                        {
                            Rectangle rect = new Rectangle(
                                0 + c * MapHandler[SelectedMap].getTileSize(),
                                0 + r * MapHandler[SelectedMap].getTileSize(),
                                MapHandler[SelectedMap].getTileSize(),
                                MapHandler[SelectedMap].getTileSize());

                            g.DrawRectangle(pen, rect);
                            g.DrawString((r * MapHandler[SelectedMap].getRowCount() + c).ToString(), font, Brushes.Black, rect, format);
                        }

                    CodeVisual = new Bitmap((MapHandler[SelectedMap].getColCount() * MapHandler[SelectedMap].getTileSize()), (MapHandler[SelectedMap].getRowCount() * MapHandler[SelectedMap].getTileSize()));

                    g = Graphics.FromImage(CodeVisual);
                    g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, CodeVisual.Size.Width, CodeVisual.Size.Height);

                    for(int j = 0; j < MapHandler[SelectedMap].getRectangles().Count(); j++)
                    {
                        AlreadyDrawnCode.Add(false);
                        foreach (Classes.MapClass.TileCode x in MapHandler[SelectedMap].getTileCodes())
                        {
                            if (j == x.Rectangle)
                            {
                                AlreadyDrawnCode[j] = true;
                                g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Aqua)), MapHandler[SelectedMap].getRectangles()[j]);
                                break;
                            }
                        }

                    }


                    UsePanel.Invalidate();
                    break;
                }

        }


        //==========================================================================
        //Panel draw function
        //==========================================================================
        private void UsePanel_Paint(object sender, PaintEventArgs e)
        {
            if(MapSelected)
            {
                Graphics g = e.Graphics;
                Point pt = new Point(UsePanel.AutoScrollPosition.X, UsePanel.AutoScrollPosition.Y);
                g.DrawImage(MapHandler[SelectedMap].getMapImage(), pt);
                if (ShowCode) g.DrawImage(CodeVisual, pt);
                g.DrawImage(Grid, pt);
            }
        }


        //==========================================================================
        //Mouse handler
        //==========================================================================
        private void UsePanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (MapSelected)
            {
                int index = FindRectangle(e);
                if (e.Button == MouseButtons.Left)
                {                    
                    if(index > -1)
                    {
                        switch (SelectedTool)
                        {
                            case 1:
                                AssignCodeFile(index, e, true);
                                return;
                        } 
                    }
                }
                if(e.Button == MouseButtons.Right)
                {
                    if (index > -1)
                    {
                        switch (SelectedTool)
                        {
                            case 1:
                                AssignCodeFile(index, e, false);
                                return;
                        }
                    }
                }
            }
        }
        private int FindRectangle(MouseEventArgs e)
        {
            Point pt = new Point(e.Location.X - UsePanel.AutoScrollPosition.X, e.Location.Y - UsePanel.AutoScrollPosition.Y);
            int i = 0;
            foreach (Rectangle x in MapHandler[SelectedMap].getRectangles())
                if (x.Contains(pt)) { return i;} else i++;

            return -1;
        }

        private void AssignCodeFile(int index, MouseEventArgs e, bool draw)
        {
            Point pt = new Point(e.Location.X - UsePanel.AutoScrollPosition.X, e.Location.Y - UsePanel.AutoScrollPosition.Y);
            Graphics g = Graphics.FromImage(CodeVisual);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if(draw)MapHandler[SelectedMap].getTileCodes().Add(new Classes.MapClass.TileCode(index, CodeHandler[SelectedCode]));
            else if(!draw)
            {
                for(int i = 0;i < MapHandler[SelectedMap].getTileCodes().Count(); i++)
                {
                    if (MapHandler[SelectedMap].getTileCodes()[i].Rectangle == index) { MapHandler[SelectedMap].getTileCodes().RemoveAt(i); break; }
                }
            }

            if (draw && !AlreadyDrawnCode[index]) { g.FillRectangle(new SolidBrush(Color.FromArgb(75, Color.Aqua)), MapHandler[SelectedMap].getRectangles()[index]); AlreadyDrawnCode[index] = true; }
            else if (!draw) { g.FillRectangle(new TextureBrush(MapHandler[SelectedMap].getMapImage(), MapHandler[SelectedMap].getRectangles()[index]), MapHandler[SelectedMap].getRectangles()[index]); AlreadyDrawnCode[index] = false; }

            UsePanel.Invalidate();
        }


        #region View enablers

        private void enableCodeAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCode = true;
            SelectionStripDDB.ForeColor = Color.Green;
            UsePanel.Invalidate();
        }

        private void disableCodeAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowCode = false;
            SelectionStripDDB.ForeColor = Color.Red;
            UsePanel.Invalidate();
        }





        #endregion
    }
}
