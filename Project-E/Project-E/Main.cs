using Project_E.HelperForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_E
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }


        #region Variable definitions



        UserControls.MapViewer MapViewer = new UserControls.MapViewer();

        List<Classes.MapClass> MapHandler = new List<Classes.MapClass>();

        UserControls.GameLogistics GameLogistics = new UserControls.GameLogistics();

        UserControls.DebugWindow DebugWind = new UserControls.DebugWindow();

        Classes.GameClass Game = new Classes.GameClass();

        Classes.FileManager fileManager = new Classes.FileManager();

        List<Classes.CodeFileClass> CodeHandler = new List<Classes.CodeFileClass>();

        Classes.CodeCompiler CodeCompiler = new Classes.CodeCompiler();

        UserControls.CodingWindow CodeVariables = new UserControls.CodingWindow();

        UserControls.CodingWindow CodeWindow = new UserControls.CodingWindow();

        UserControls.MapLogistics MapLogisticsEditer = new UserControls.MapLogistics();

        UserControls.CreateMap MapCreator = new UserControls.CreateMap();

        List<Classes.SpriteSheet> SpriteHandler = new List<Classes.SpriteSheet>();

        UserControls.SpriteMovingViewer SpriteViewer = new UserControls.SpriteMovingViewer();

        string projectName = "TestProject";

        string originalFilePath;


        #endregion

    
        #region On startup

        private void MainFrame_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);

            Loger.write("Engine boot succsessfull!", 0);

            MapViewer.Loger = Loger;
            GameLogistics.Loger = Loger;
            DebugWind.Loger = Loger;
            Game.Loger = Loger;
            fileManager.Loger = Loger;            
            CodeCompiler.Loger = Loger;
            MapLogisticsEditer.Loger = Loger;


            fileManager.CodeHandler = CodeHandler;
            CodeCompiler.fileManager = fileManager;

            originalFilePath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AderEngine\";

            fileManager.setProjectPath(originalFilePath + projectName);
        }



        #endregion


        #region Tab select


        //==========================================================================
        //Close tab
        //==========================================================================
        private void EngineTabs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < EngineTabs.TabCount; i++)
                {
                    Rectangle r = EngineTabs.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        Loger.write("Closing tab: " + EngineTabs.TabPages[i].Name.ToString(), 0);
                        EngineTabs.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }


        #endregion


        #region Tree view


        //==========================================================================
        //Node single click
        //==========================================================================
        private void MainTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MainTreeView.SelectedNode = MainTreeView.GetNodeAt(e.X, e.Y);

                if (MainTreeView.SelectedNode != null)
                {
                    TreeViewCStrip.Show(MainTreeView, e.Location);
                }
            }

        }


        //==========================================================================
        //Node double click
        //==========================================================================
        private void MainTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Substring(e.Node.Text.Length - 3) == "mxt") ifMap(e);
            else if (e.Node.Text.Substring(e.Node.Text.Length - 3) == "acf") ifCode(e);
            else if (e.Node.Text.Substring(e.Node.Text.Length - 3) == "csf") ifSprite(e);
        }
        private void ifMap(TreeNodeMouseClickEventArgs e)
        {
            if(EngineTabs.TabCount > 0)
            {
                if (EngineTabs.SelectedTab.Name == "Map logistics")
                {
                    MapLogisticsEditer.AssignMap(e.Node.Text);
                    return;
                } 
                else if (EngineTabs.SelectedTab.Name == "Map creator")
                {
                    MapCreator.LoadMap(MapHandler[Classes.DataHandlerForProgram.LocateMap(e.Node.Text, MapHandler)]);
                    return;
                }
            }

            if (!FindTab("Map viewer")) createMapTester();

            foreach (Classes.MapClass x in MapHandler)
            {
                if (e.Node.Text == x.getMapName()) { MapViewer.Load_Map(x); break; }
            }
        }
        private void ifCode(TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "code_variables.acf") CheckCodeVariableTab();
            else if(!FindTab(e.Node.Text)) addNewCodeFile(e.Node.Text);
        }
        private void ifSprite(TreeNodeMouseClickEventArgs e)
        {
            Classes.SpriteSheet loader = new Classes.SpriteSheet();

            foreach (Classes.SpriteSheet x in SpriteHandler)
            {
                if (x.Name == e.Node.Text)
                {
                    loader = x;
                    break;
                }
            }

            loader.reset();

            if (!FindTab("Sprite viewer"))
            {
                var page = new TabPage("Sprite viewer")
                {
                    Name = "Sprite viewer"
                };

                SpriteViewer = new UserControls.SpriteMovingViewer
                {
                    Loger = Loger,
                    FillerSprite = loader,
                    Dock = DockStyle.Fill,
                    Compiled = true
                };

                SpriteViewer.SetInterval(250);

                page.Controls.Add(SpriteViewer);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page;
            }
        }


        //==========================================================================
        //Rename node
        //==========================================================================
        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTreeView.SelectedNode.Name != "MappingRoot" &&
               MainTreeView.SelectedNode.Name != "CodeRoot" &&
               MainTreeView.SelectedNode.Name != "ProjectRoot" &&
               MainTreeView.SelectedNode.Name != "SpriteRoot")
            {
                MessageBoxWithOneLineInput asker = new MessageBoxWithOneLineInput
                {
                    value = MainTreeView.SelectedNode.Name
                };
                asker.ShowDialog();
                if (asker.getStatus())
                {
                    string name = asker.value;
                    if (name != "")
                    {
                        MainTreeView.SelectedNode.Name = name;
                        MainTreeView.SelectedNode.Text = name + ".mxt";
                    } 
                }
            }
        }


        //==========================================================================
        //Delete node
        //==========================================================================
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTreeView.SelectedNode.Name != "MappingRoot" &&
               MainTreeView.SelectedNode.Name != "CodeRoot" &&
               MainTreeView.SelectedNode.Name != "ProjectRoot" &&
               MainTreeView.SelectedNode.Name != "SpriteRoot") MainTreeView.SelectedNode.Remove();
        }

        #endregion


        #region Code file


        //==========================================================================
        //Create a new code file
        //==========================================================================
        private void addNewCodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperForms.MessageBoxWithOneLineInput input = new MessageBoxWithOneLineInput();
            input.ShowDialog();
            if (input.getStatus())
            {
                addBlankCodeFile(input.value + ".acf");
                MainTreeView.Nodes[0].Nodes[0].Nodes.Add(input.value + ".acf"); 
            }
        }
        private void addBlankCodeFile(string name)
        {
            CodeHandler.Add(new Classes.CodeFileClass("code",name));
            addNewCodeFile(name);
        }

        //==========================================================================
        //Creates a new tab with the selected code file
        //==========================================================================
        private void addNewCodeFile(string name)
        {
            var page = new TabPage(name)
            {
                Name = name
            };

            CodeWindow = new UserControls.CodingWindow
            {
                Loger = Loger,
                CodeHandler = CodeCompiler,
                CodeFile = CodeHandler[Classes.DataHandlerForProgram.LocateACF(name, CodeHandler)],
                Dock = DockStyle.Fill
            };
            page.Controls.Add(CodeWindow);
            CodeWindow.UpdateCode(CodeHandler[Classes.DataHandlerForProgram.LocateACF(name, CodeHandler)].getRawCode());
            EngineTabs.TabPages.Add(page);
            EngineTabs.SelectedTab = page;
        }


        //==========================================================================
        //Run a test .acf file
        //==========================================================================
        private void assignacfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> Data = new List<string>();
            foreach (Classes.CodeFileClass x in CodeHandler)
                Data.Add(x.getName());

            int returnvalue = -1;

            DataShower Show = new DataShower
            {
                Data = Data,
                returnInt = returnvalue
            };

            Show.ShowDialog();

            returnvalue = Show.returnInt;

            if(returnvalue != -1)CodeHandler[returnvalue].Sequence.Execute(ref Game);
        }


        //==========================================================================
        //Open game coding variables
        //==========================================================================
        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckCodeVariableTab();
        }


        //==========================================================================
        //Check if code variable tab exists
        //==========================================================================
        private void CheckCodeVariableTab()
        {
            if (!FindTab("Code variables"))
            {
                var page = new TabPage("Code variables")
                {
                    Name = "Code variables"
                };

                CodeVariables = new UserControls.CodingWindow
                {
                    Loger = Loger,
                    CodeHandler = CodeCompiler,
                    CodeFile = CodeHandler[Classes.DataHandlerForProgram.variableFileID],
                    Dock = DockStyle.Fill
                };

                page.Controls.Add(CodeVariables);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page;
                CodeVariables.UpdateCode(CodeHandler[Classes.DataHandlerForProgram.variableFileID].getRawCode());
                MainTreeView.ExpandAll();
            }
        }

        #endregion


        #region Menu strip items


        //==========================================================================
        //Load project
        //==========================================================================
        private void loadProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Filter = "Project files(*.apf) | *.apf"
            };

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                projectName = Path.GetFileName(fileDialog.FileName);
                projectName = projectName.Substring(0, projectName.Length - 4);
                fileManager.setProjectPath(originalFilePath + projectName);
                Loger.write(projectName);
            }
            else return;

            Loger.clear();

            CodeHandler.Clear();

            if (fileManager.GetProjectFiles(ref MapHandler, ref CodeHandler, CodeCompiler, ref SpriteHandler))
            {
                if (MainTreeView.Nodes[0].Nodes[1].Nodes.Count > 0)
                {
                    for (int i = MainTreeView.Nodes[0].Nodes[1].Nodes.Count - 1; i >= 0; i--)
                    {
                        MainTreeView.Nodes[0].Nodes[1].Nodes[i].Remove();
                    }
                }

                foreach (Classes.MapClass x in MapHandler)
                {
                    //var childNode = textBox1.Text.Trim();
                    if (!string.IsNullOrEmpty(x.getMapName()))
                    {
                        if (MainTreeView.Nodes[0].Nodes[1] != null)
                        {
                            MainTreeView.Nodes[0].Nodes[1].Nodes.Add(x.getMapName());
                            MainTreeView.ExpandAll();
                        }
                    }
                }

                if (MainTreeView.Nodes[0].Nodes[2].Nodes.Count > 0)
                {
                    for (int i = MainTreeView.Nodes[0].Nodes[2].Nodes.Count - 1; i >= 0; i--)
                    {
                        MainTreeView.Nodes[0].Nodes[2].Nodes[i].Remove();
                    }
                }

                foreach (Classes.SpriteSheet x in SpriteHandler)
                {
                    //var childNode = textBox1.Text.Trim();
                    if (!string.IsNullOrEmpty(x.Name))
                    {
                        if (MainTreeView.Nodes[0].Nodes[2] != null)
                        {
                            MainTreeView.Nodes[0].Nodes[2].Nodes.Add(x.Name);
                            MainTreeView.ExpandAll();
                        }
                    }
                }

                if (MainTreeView.Nodes[0].Nodes[0].Nodes.Count > 0)
                {
                    for (int i = MainTreeView.Nodes[0].Nodes[0].Nodes.Count - 1; i >= 0; i--)
                    {
                        MainTreeView.Nodes[0].Nodes[0].Nodes[i].Remove();
                    }
                }

                foreach (Classes.CodeFileClass x in CodeHandler)
                {
                    MainTreeView.Nodes[0].Nodes[0].Nodes.Add(x.getName());                   
                }


                MainTreeView.ExpandAll();

                if (GameLogistics.IsCreated) GameLogistics.ExternalReload();
                
            }
        }


        //==========================================================================
        //Create a new project
        //==========================================================================
        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelperForms.MessageBoxWithOneLineInput asker = new MessageBoxWithOneLineInput();
            asker.ShowDialog();
            string name ;
            if (asker.getStatus())
            {
                name = asker.value;
                Directory.CreateDirectory(originalFilePath + name);
                var myFile = File.Create(originalFilePath + "\\" + name + "\\" + name + ".apf");
                myFile.Close();

                projectName = name;

                fileManager.setProjectPath(originalFilePath + name);
            }
        }


        //==========================================================================
        //Settings
        //==========================================================================
        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: SETTINGS
        }


        //==========================================================================
        //Add a new map
        //==========================================================================
        private void addNewMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FindTab("Map creator"))
            {
                var page = new TabPage("Map creator")
                {
                    Name = "Map creator"
                };

                MapCreator = new UserControls.CreateMap
                {
                    Loger = Loger,
                    Dock = DockStyle.Fill,
                    MainTreeView = MainTreeView,
                    fileManager = fileManager,
                    projectPath = originalFilePath,
                    MapHandler = MapHandler,
                };

                page.Controls.Add(MapCreator);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page;
            }
        }


        //==========================================================================
        //Character creator
        //==========================================================================
        private void characterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControls.CharacterCreator characterCreator = new UserControls.CharacterCreator
            {
                Loger = Loger,
                SpriteHandler = SpriteHandler,
                MainTreeView = MainTreeView
            };
            characterCreator.Dock = DockStyle.Fill;

            var page = new TabPage("Character creator")
            {
                Name = "Character creator"
            };

            page.Controls.Add(characterCreator);
            EngineTabs.TabPages.Add(page);
            EngineTabs.SelectedTab = page;
        }

        #endregion


        #region Debug mode

        //==========================================================================
        //Debug mode window creator
        //==========================================================================
        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!FindTab("Debug"))
            {
                var page = new TabPage("Debug")
                {
                    Name = "Debug"
                };

                DebugWind = new UserControls.DebugWindow
                {
                    Loger = Loger,
                    Game = Game,
                    Dock = DockStyle.Fill,
                    MapHandler = MapHandler,
                    SpriteHandler = SpriteHandler
                };

                page.Controls.Add(DebugWind);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page; 
            }
        }


        //==========================================================================
        //Map encoder
        //==========================================================================
        private void testAMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FindTab("Map logistics"))
            {
                var page = new TabPage("Map logistics")
                {
                    Name = "Map logistics"
                };

                MapLogisticsEditer.CodeHandler = CodeHandler;
                MapLogisticsEditer.MapHandler = MapHandler;
                MapLogisticsEditer.Dock = DockStyle.Fill;

                page.Controls.Add(MapLogisticsEditer);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page;
            }
        }


        //==========================================================================
        //Create game logistics window
        //==========================================================================
        private void gameLogisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FindTab("Game logistics"))
            {
                var page = new TabPage("Game logistics")
                {
                    Name = "Game logistics"
                };

                GameLogistics = new UserControls.GameLogistics
                {
                    Loger = Loger,
                    IsCreated = true,
                    Game = Game,
                    Dock = DockStyle.Fill,
                    MapHandler = MapHandler,
                    SpriteHandler = SpriteHandler,
                    CodeHandler = CodeHandler
                };

                page.Controls.Add(GameLogistics);
                EngineTabs.TabPages.Add(page);
                EngineTabs.SelectedTab = page;
            }
        }


        //==========================================================================
        //Map viewer
        //==========================================================================
        private void createMapTester()
        {
            var page = new TabPage("Map viewer")
            {
                Name = "Map viewer"
            };
            MapViewer.Dock = DockStyle.Fill;
            page.Controls.Add(MapViewer);
            EngineTabs.TabPages.Add(page);
            EngineTabs.SelectedTab = page;
        }


        #endregion


        #region Helper functions

        private bool FindTab(string name)
        {
            foreach (TabPage z in EngineTabs.TabPages)
                if (z.Name == name)
                { EngineTabs.SelectedTab = z; return true;}
            return false;
        }


        //==========================================================================
        //Save project before closing
        //==========================================================================
        private void MainFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason != CloseReason.TaskManagerClosing)
                fileManager.SaveProject(MapHandler,CodeHandler,SpriteHandler);
        }

        #endregion


    }
}
