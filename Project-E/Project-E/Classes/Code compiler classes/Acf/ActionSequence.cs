using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_E.Classes.Code_compiler_classes.Acf
{
    public class ActionSequence
    {
        public Classes.VariableVarations variables = new VariableVarations();

        List<int> IntArguments = new List<int>();
        List<int> Sequence = new List<int>();

        List<bool> BoolArguments = new List<bool>();

        List<string> StringArguments = new List<string>();

        public ActionSequence()
        {

        }

        public ActionSequence(ActionSequence argument)
        {
            
        }


        public void AddCommand(int argument, string argument2, bool argument3 = false, int sequenceID = -1)
        {
            IntArguments.Add(argument);
            StringArguments.Add(argument2);
            BoolArguments.Add(argument3);
            Sequence.Add(sequenceID);
        }

        public void ReCompile()
        {
            IntArguments.Clear();
            StringArguments.Clear();
            BoolArguments.Clear();
            Sequence.Clear();
        }


        public bool Execute(ref GameClass Game)
        {
            for(int i = 0; i < Sequence.Count; i++)
            {
                switch (Sequence[i])
                {
                    case 0:
                        PlayerMove(IntArguments[i], StringArguments[i], ref Game);
                        break;
                    case 1:
                        PlayerChangeLocation(StringArguments[i], ref Game);
                        break; 


                    case 100:
                        ChangeMap(StringArguments[i], ref Game);
                        break;


                    case -1:
                        WriteMessage(StringArguments[i], ref Game);
                        break;
                    case -2:
                        WhaitForInput(ref Game);
                        break;
                }
            }
            return true;
        }




        //==========================================================================
        //Player 0-99 (100 commands reserved or used for ) THESE ARE IN ORDER
        //==========================================================================
        void PlayerMove(int ammount, string direction, ref GameClass Game)
        {
            switch (direction)
            {
                case "N":
                    Game.Character.Yloc -= ammount;
                    break;
                case "E":
                    Game.Character.Xloc += ammount;
                    break;
                case "S":
                    Game.Character.Yloc += ammount;
                    break;
                case "W":
                    Game.Character.Xloc -= ammount;
                    break;
            }
            Game.Redraw();
        }

        void PlayerChangeLocation(string line, ref GameClass Game)
        {
            string[] separators = { ":" };
            string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Game.Character.Xloc = Int32.Parse(words[0]);
            Game.Character.Yloc = Int32.Parse(words[1]);

            Game.Redraw();
        }

        //==========================================================================
        //Map 100-199 (100 commands reserved or used for ) THESE ARE IN ORDER
        //==========================================================================
        void ChangeMap(string MapName, ref GameClass Game)
        {
            for(int i = 0; i < Game.MapHandler.Count; i++)
            {
                if (Game.MapHandler[i].getMapName() == (MapName + ".mxt"))
                {
                    Game.setCurrentMapIndex(i);
                    Game.Character.setCollissionMap(Game.MapHandler[Game.getCurrentMapIndex()].getCollisionMap());
                    Game.Character.RefineCollissionMap(Game.MapHandler[Game.getCurrentMapIndex()].getTileSize(), 
                        Game.MapHandler[Game.getCurrentMapIndex()].getMaxTiles(), 
                        Game.MapHandler[Game.getCurrentMapIndex()].getColCount(), 
                        Game.MapHandler[Game.getCurrentMapIndex()].getRowCount());
                    break;
                }
            } 

            Game.Redraw();
        }


        //==========================================================================
        //Loger -5 -1 (5 commands reserved or used for logging ) THESE ARE IN ORDER
        //==========================================================================
        void WriteMessage(string message, ref GameClass Game)
        {
            Game.Loger.write(message);
        }

        void WhaitForInput(ref GameClass Game)
        {
            HelperForms.BackSideWhait whait = new HelperForms.BackSideWhait
            {
                Visible = false,
                TransparencyKey = Color.Magenta,
                BackColor = Color.Magenta
            };
            whait.ShowDialog();           
        }
    }
}
