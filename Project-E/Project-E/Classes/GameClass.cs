using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_E.Classes
{
    public class GameClass
    {

        #region Variable definitions

        public List<MapClass> MapHandler;

        public List<SpriteSheet> SpriteHandler;

        public CharacterMovement Character;

        public Bitmap MapOutput;

        int StartX = 0;
        int StartY = 0;
        int CurrentMapIndex = 0;
        int StartMapIndex = 0;
        int PlayerSprite = -1;

        bool INITIALIZED = false;
        bool STARTMAPFOUND = false;
        bool RUNNING = false;

        #endregion

        #region Getters & Setters

        public int getStartX()
        {
            return StartX;
        }
        public void setStartX(int argument)
        {
            StartX = argument;
        }

        public int getStartY()
        {
            return StartY;
        }
        public void setStartY(int argument)
        {
            StartY = argument;
        }

        public int getCurrentMapIndex()
        {
            return CurrentMapIndex;
        }
        public void setCurrentMapIndex(int argument)
        {
            CurrentMapIndex = argument;
        }

        public void setPlayerSprite(int argument)
        {
            PlayerSprite = argument;
        }

        public bool getRUNNING()
        {
            return RUNNING;
        }
        public void setRUNNING(bool argument)
        {
            RUNNING = argument;
        }

        #endregion


        //==========================================================================
        //Pass the game screen objects
        //==========================================================================
        public Graphics GameGraphics { get; set; }
        public DoubleBufferedPanel Canvas { get; set; }

        public UserControls.Logger Loger { get; set; }   


        //==========================================================================
        //Check status
        //==========================================================================
        public void Check()
        {
            //TODO: STATUS CHECK
        }


        //==========================================================================
        //Find start map
        //==========================================================================
        public void FindStartMap()
        {
            for (int i = 0; i < MapHandler.Count; i++)
                if (MapHandler[i].getStartMap())
                {
                    StartMapIndex = i;
                    CurrentMapIndex = i;
                    Loger.write("Start map found " + MapHandler[i].getMapName(), 0);
                    STARTMAPFOUND = true;
                    break;
                }
        }


        //==========================================================================
        //Draw map
        //==========================================================================
        public void DrawMap()
        {
            if(INITIALIZED && RUNNING)
            {
                GameGraphics.SmoothingMode = SmoothingMode.AntiAlias;
                GameGraphics.DrawImage(MapOutput, Character.GetPoint(Canvas));
                GameGraphics.DrawImage(Character.OImage, Canvas.Width / 2, Canvas.Height / 2); 
            }
        }


        //==========================================================================
        //Handle movement
        //==========================================================================
        private void Canvas_KeyDown(object sender, KeyPressEventArgs e)
        {
            HandleMovement(e);
        }
        private void HandleMovement(KeyPressEventArgs e)
        {
            if (INITIALIZED && RUNNING)
            {
                Character.Movement(e.KeyChar);
                HandleCode();
                Canvas.Invalidate();
            }
        }


        //==========================================================================
        //Initiliaze game
        //==========================================================================
        public bool Initialize()
        {
            if(STARTMAPFOUND)
            {
                Canvas.Focus();
                CharecterINIT(MapHandler[CurrentMapIndex], StartX, StartY);
                MapOutput = new Bitmap(MapHandler[CurrentMapIndex].getMapImage());

                int MaxTiles = MapHandler[CurrentMapIndex].getMaxTiles();
                int TileSize = MapHandler[CurrentMapIndex].getTileSize();

                Canvas.Focus();
                (Canvas as Control).KeyPress += new KeyPressEventHandler(Canvas_KeyDown);

                INITIALIZED = true;
            }
            return true;
        }       
        private void CharecterINIT(MapClass x, int X, int Y)
        {
            Character = new Classes.CharacterMovement
            {
                Xloc = X,
                Yloc = Y,
                MaxTiles = x.getMaxTiles(),
                RowCount = x.getRowCount(),
                ColCount = x.getColCount(),
                TileSize = x.getTileSize(),
                Loger = Loger
            };
            Character.setCollissionMap(x.getCollisionMap());
    
            if(PlayerSprite > -1) Character.loadCharacter(SpriteHandler[PlayerSprite],true, false);
            else Character.loadCharacter(SpriteHandler[0], false, false);
        }


        //==========================================================================
        //Uninitiliaze game
        //==========================================================================
        public void Uninitiliaze()
        {
            (Canvas as Control).KeyPress -= new KeyPressEventHandler(Canvas_KeyDown);
            INITIALIZED = false;
        }


        //==========================================================================
        //Get the game stat
        //==========================================================================
        public bool getINITIALIZATION_Status()
        {
            return INITIALIZED;
        }


        //==========================================================================
        //Redraw
        //==========================================================================
        public void Redraw()
        {
            if (INITIALIZED && RUNNING)
            {
                MapOutput = new Bitmap(MapHandler[CurrentMapIndex].getMapImage());
                Canvas.Invalidate();
            }
        }


        //==========================================================================
        //Handle code
        //==========================================================================
        private void HandleCode()
        {
            int index = ((Character.Yloc * MapHandler[CurrentMapIndex].getRowCount()) + Character.Xloc);
            foreach(MapClass.TileCode x in MapHandler[CurrentMapIndex].getTileCodes())
            {
                var a_this = this;
                if (x.Rectangle == index) x.Code.getSequence().Execute(ref a_this);
            }
        }
    };

}
