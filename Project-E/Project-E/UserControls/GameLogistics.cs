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
    public partial class GameLogistics : UserControl
    {
        public UserControls.Logger Loger { get; set; }

        public List<Classes.MapClass> MapHandler { get; set; }

        public List<Classes.SpriteSheet> SpriteHandler { get; set; }

        public List<Classes.CodeFileClass> CodeHandler { get; set; }

        public Classes.GameClass Game { get; set; }

        public bool IsCreated = false;


        int prevStartingMapID = 0;
        int startingMapID = 0;
        int startingCharacterSheet = 0;




        public void ExternalReload()
        {
            LoadMaps();
        }

        public GameLogistics()
        {
            InitializeComponent();
        }

        private void GameLogistics_Load(object sender, EventArgs e)
        {
            LoadMaps();
        }

        private void LoadMaps()
        {
            StartingMapName.Items.Clear();
            SpriteSelector.Items.Clear();
            CodeChainViewer.Rows.Clear();

            foreach (Classes.MapClass z in MapHandler)
            {
                StartingMapName.Items.Add(z.getMapName());
            }

            foreach(Classes.CodeFileClass x in CodeHandler)
            {
                if (x.getCodeType() == "variables")
                {
                    foreach (Classes.StringVariable z in x.getSequence().variables.Strings)
                    {                        
                        CodeChainViewer.Rows.Add("String " + z.name, z.getValue());
                    }
                    foreach (Classes.IntegerVariable z in x.getSequence().variables.Ints)
                    {
                        CodeChainViewer.Rows.Add("Int " + z.name, z.getValue());
                    }
                    foreach (Classes.FloatVariable z in x.getSequence().variables.Floats)
                    {
                        CodeChainViewer.Rows.Add("Float " + z.name, z.getValue());
                    }
                    foreach (Classes.BooleanVariable z in x.getSequence().variables.Booleans)
                    {
                        CodeChainViewer.Rows.Add("Boolean " + z.name, z.getValue());
                    }
                    break;
                }
            }

            foreach(Classes.SpriteSheet x in SpriteHandler)
            {
                SpriteSelector.Items.Add(x.Name);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            try
            {
                Game.setStartX(Convert.ToInt32(CharacterStartX.Value));
                Game.setStartY(Convert.ToInt32(CharacterStartY.Value));

                Game.setPlayerSprite(startingCharacterSheet);

                MapHandler[prevStartingMapID].setStartMap(false);
                MapHandler[startingMapID].setStartMap(true);

                prevStartingMapID = startingMapID;

                Loger.write("Changed starting map to " + MapHandler[startingMapID].getMapName(), 0);
                Loger.write("Changed character sprite to " + SpriteHandler[startingMapID].Name, 0);

                if (Game.getINITIALIZATION_Status())
                {
                    Game.setRUNNING(false);
                    Game.FindStartMap();
                    Game.Uninitiliaze();
                } 
            }
            catch(Exception ex)
            {
                Loger.write(ex.ToString());
            }
        }

        private void StartingMapName_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < MapHandler.Count(); i++)
            {
                if(MapHandler[i].getMapName() == StartingMapName.Text)
                {                  
                    startingMapID = i;
                    break; 
                }
            }
        }

        private void SpriteSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SpriteHandler.Count(); i++)
            {
                if (SpriteHandler[i].Name == SpriteSelector.Text)
                {
                    startingCharacterSheet = i;
                    break;
                }
            }
        }
    }
}
