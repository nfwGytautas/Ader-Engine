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
    public partial class DebugWindow : UserControl
    {
        public DebugWindow()
        {
            InitializeComponent();
        }

        #region Variable definitions

        public Classes.GameClass Game { get; set; }

        public UserControls.Logger Loger { get; set; }
        
        public List<Classes.MapClass> MapHandler { get; set; }

        public List<Classes.SpriteSheet> SpriteHandler { get; set; }

        bool wasPaused = false;

        #endregion


        //==========================================================================
        //Start debug
        //==========================================================================
        private void Start_Click(object sender, EventArgs e)
        {          
            GamePanel.Focus();
            if(!Game.getRUNNING())
            {
                if (!wasPaused)
                {
                    loadGame();
                }
                else wasPaused = false;

                Game.setRUNNING(true);
                Loger.write("Starting game debug", 0);
                GamePanel.Invalidate(); 
            }
        }


        //==========================================================================
        //Pause debug
        //==========================================================================
        private void Pause_Click(object sender, EventArgs e)
        {
            wasPaused = true;
            Game.setRUNNING(false);
            Loger.write("Pausing game debug", 0);
        }


        //==========================================================================
        //Stop debug
        //==========================================================================
        private void End_Click(object sender, EventArgs e)
        {
            Game.setRUNNING(false);
            Game.Uninitiliaze();
            Loger.write("Stoping game debug", 0);
        }


        //==========================================================================
        //Draw game
        //==========================================================================
        private void GamePanel_Paint(object sender, PaintEventArgs e)
        {
            Game.GameGraphics = e.Graphics;
            Game.DrawMap();
        }


        //==========================================================================
        //Load game
        //==========================================================================
        public void loadGame()
        {
            Game.setRUNNING(false);
            Game.Canvas = GamePanel;
            Game.Loger = Loger;
            Game.MapHandler = MapHandler;
            Game.SpriteHandler = SpriteHandler;
            Game.FindStartMap();
            Game.Initialize();
        }
    }
}
