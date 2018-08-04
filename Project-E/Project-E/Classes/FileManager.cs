using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class FileManager
    {
        #region Variable definitions

        public UserControls.Logger Loger { get; set; }

        public List<Classes.CodeFileClass> CodeHandler { get; set; }

        public List<Classes.MapClass> MapHandler { get; set; }

        public List<Classes.SpriteSheet> SpriteHandler { get; set; }


        string originalFilePath;
        public string MapsFilePath;
        public string ACFFilePath;
        public string SpriteFilePath;
        public string globalVariablesPath;

        #endregion


        #region Project

        //==========================================================================
        //Sets a project path
        //==========================================================================
        public void setProjectPath(string ProjectPath)
        {
            originalFilePath = ProjectPath;

            MapsFilePath = originalFilePath + @"\Maps\";
            ACFFilePath = originalFilePath + @"\Code files\";
            SpriteFilePath = originalFilePath + @"\Sprites\";
            globalVariablesPath = ACFFilePath + "code_variables.acf";

            System.IO.Directory.CreateDirectory(ACFFilePath);
            System.IO.Directory.CreateDirectory(MapsFilePath);
        }


        //==========================================================================
        //Gets project files
        //==========================================================================
        public bool GetProjectFiles(ref List<Classes.MapClass> MapHandler, ref List<CodeFileClass> CodeHandler, CodeCompiler Compiler, ref List<SpriteSheet> SpriteHandler)
        {
            try
            {
                //CODE FILES
                int i = 0;
                string[] fileArray2 = Directory.GetFiles(ACFFilePath, "*.acf");
                foreach (string x in fileArray2)
                {
                    Loger.write(x, 0);

                    if (x == (ACFFilePath + "code_variables.acf"))
                    {
                        CodeHandler.Add(new CodeFileClass(ReadACFV("code_variables.acf"), "variables", "code_variables.acf"));
                        DataHandlerForProgram.variableFileID = i;
                        Loger.write("Loading of code variables complete!", 0);
                    }
                    else
                    {
                        if(ReadNCompileACF(Compiler, x)) Loger.write("Loading of code file complete!", 0);
                        else Loger.write("Loading of code file failed!", 0);
                    }

                    i++;
                }

                //MAPS
                MapHandler.Clear();

                string[] fileArray = Directory.GetFiles(MapsFilePath, "*.mxt");

                foreach (string x in fileArray)
                {
                    Loger.write(x, 0);

                    Classes.MapClass MapHandlerFiller = new Classes.MapClass()
                    {
                        Loger = Loger,
                    };
                    LoadMap(x, ref MapHandlerFiller);
                    MapHandler.Add(MapHandlerFiller);
                }

                //Sprites
                SpriteHandler.Clear();

                string[] fileArray3 = Directory.GetFiles(SpriteFilePath, "*.csf");

                foreach (string x in fileArray3)
                {
                    Loger.write(x, 0);
                    Classes.SpriteSheet SpriteSheetFiller = new Classes.SpriteSheet();
                    LoadSpriteSheet(x, ref SpriteSheetFiller);
                    SpriteHandler.Add(SpriteSheetFiller);
                }

                return true; 
            }
            catch (DirectoryNotFoundException)
            {
                if (!Directory.Exists(SpriteFilePath)) Directory.CreateDirectory(SpriteFilePath);
                if (!Directory.Exists(MapsFilePath)) Directory.CreateDirectory(MapsFilePath);
                if (!Directory.Exists(ACFFilePath)) Directory.CreateDirectory(ACFFilePath);
                return false;
            }
            catch (Exception e)
            {
                Loger.write(e.ToString(), 2);
                return false;
            }
        }


        //==========================================================================
        //Saves project
        //==========================================================================
        public bool SaveProject(List<Classes.MapClass> MapHandler,List<CodeFileClass> CodeHandler,List<SpriteSheet> SpriteHandler)
        {
            foreach (MapClass x in MapHandler)
                SaveMap(x.getMapName(), x);
            foreach (CodeFileClass x in CodeHandler)
                WriteACF(x.getRawCode(), x.getName());
            foreach (SpriteSheet x in SpriteHandler)
                SaveSpriteSheet(x.Name, x);

            return true;
        }


        #endregion


        #region Map

        //==========================================================================
        //Saves a map
        //==========================================================================
        public bool SaveMap(string fileName, MapClass Map)
        {
            try
            {
                if (!File.Exists(MapsFilePath + fileName))
                {
                    File.Create(MapsFilePath + fileName).Close();
                }

                using (StreamWriter writer = new StreamWriter(File.Open(MapsFilePath + fileName, FileMode.Open)))
                {
                    writer.WriteLine(Map.getTileCodes().Count());

                    foreach(MapClass.TileCode x in Map.getTileCodes())
                    {
                        writer.WriteLine(x.Rectangle);
                        writer.WriteLine(x.Code.getName());
                    }

                    writer.WriteLine(Map.getColCount());
                    writer.WriteLine(Map.getRowCount());

                    writer.WriteLine(Map.getTileSize());
                    writer.WriteLine(Map.getMaxTiles());
                    writer.WriteLine(Map.getOffSet());

                    foreach (bool x in Map.getCollisionMap())
                        writer.WriteLine(x);

                    Map.getMapImage().Save(MapsFilePath + fileName + "_texture" + ".bmp");
                }                          

                return true;
            }
            catch (Exception e)
            {
                Loger.write(e.ToString(), 2);
                Loger.write(MapsFilePath,2);
                Loger.write(ACFFilePath, 2);
                return false;
            }
        }


        //==========================================================================
        //Loads a map
        //==========================================================================
        public bool LoadMap(string FilePath, ref MapClass Map)
        {
            //for (int count = 0; count < System.IO.Directory.GetFiles(ProjectFilePath + @"\Maps\").Length; count++) Loger.write(count.ToString(), 0);
            using (StreamReader writer = new StreamReader(File.Open(FilePath, FileMode.Open)))
            {
                Map.setCodeAmmount(Int32.Parse(writer.ReadLine()));

                for (int i = 0; i < Map.getCodeAmmount(); i++)
                {
                    int index = Int32.Parse(writer.ReadLine());
                    string name = writer.ReadLine();
                    foreach (CodeFileClass x in CodeHandler)
                        if (x.getName() == name) { MapClass.TileCode filler = new MapClass.TileCode(index, x); Map.getTileCodes().Add(filler); break; }                    

                }

                int CollCount = Int32.Parse(writer.ReadLine());
                int RowCount = Int32.Parse(writer.ReadLine());

                Map.setColCount(CollCount);
                Map.setRowCount(RowCount);

                int TileSize = Int32.Parse(writer.ReadLine());
                int MaxTiles = Int32.Parse(writer.ReadLine());
                int OffSet = Int32.Parse(writer.ReadLine());

                Map.setTileSize(TileSize);
                Map.setMaxTiles(MaxTiles);
                Map.setOffSet(OffSet);

                List<bool> coll = new List<bool>();
                List<byte> rawmap = new List<byte>();

                for (int i = 0; i < RowCount; i++)
                    for (int j = 0; j < CollCount; j++)
                    {
                        Map.getRectangles().Add(new Rectangle(0 + j * TileSize, 0 + i * TileSize, TileSize, TileSize));
                        Map.addCollision(Boolean.Parse(writer.ReadLine()));
                    }

                Map.setMapImage((Bitmap)Image.FromFile(FilePath + "_texture" + ".bmp", true));

                Map.setMapName(Path.GetFileName(FilePath));

                Loger.write("Loading of map " + Map.getMapName() + " complete!", 0);

            }

            return true;
        }

        #endregion


        #region acf

        //==========================================================================
        //Saves an acf
        //==========================================================================
        public bool WriteACF(List<string> Code, string fileName)
        {
            try
            {
                if (!File.Exists(ACFFilePath + fileName))
                {
                    File.Create(ACFFilePath + fileName).Close();
                }
                File.WriteAllLines(ACFFilePath + fileName, Code.ToArray());
                return true;
            }
            catch(Exception e)
            {
                Loger.write(e.ToString(), 2);
                return false;
            }
        }


        //==========================================================================
        //Loads an acfv file
        //==========================================================================
        public List<string> ReadACFV(string FileName)
        {
            try
            {
                return File.ReadAllLines(ACFFilePath + FileName).ToList();
            }
            catch (Exception e)
            {
                Loger.write(e.ToString(), 2);
                return null;
            }
        }


        //==========================================================================
        //Loads an acf
        //==========================================================================
        public List<string> ReadACF(string FileName)
        {
            try
            {
                return File.ReadAllLines(FileName).ToList();
            }
            catch (Exception e)
            {
                Loger.write(e.ToString(), 2);
                return null;
            }
        }


        //==========================================================================
        //Loads and compiles acf
        //==========================================================================
        public bool ReadNCompileACF(CodeCompiler Compiler, string FileName)
        {
            try
            {              
                CodeFileClass x = new CodeFileClass(ReadACF(FileName), "code", Path.GetFileName(FileName));
                Compiler.Compile(x);
                CodeHandler.Add(x);
                return true;
            }
            catch (Exception e)
            {
                Loger.write(e.ToString(), 2);
                return false;
            }
        }

        #endregion


        #region Sprites

        public bool SaveSpriteSheet(string fileName, SpriteSheet Sprite)
        {
            try
            {
                if (!File.Exists(SpriteFilePath + fileName))
                {
                    File.Create(SpriteFilePath + fileName).Close();
                }

                using (StreamWriter writer = new StreamWriter(File.Open(SpriteFilePath + fileName, FileMode.Open)))
                {
                    writer.WriteLine(Sprite.Name);
                    //Up
                    writer.WriteLine(Sprite.UpRect.Count());
                    foreach(Rectangle x in Sprite.UpRect)
                    {
                        writer.WriteLine(x.X);
                        writer.WriteLine(x.Y);
                        writer.WriteLine(x.Width);
                        writer.WriteLine(x.Height);
                    }
                    //Down
                    writer.WriteLine(Sprite.DownRect.Count());
                    foreach (Rectangle x in Sprite.DownRect)
                    {
                        writer.WriteLine(x.X);
                        writer.WriteLine(x.Y);
                        writer.WriteLine(x.Width);
                        writer.WriteLine(x.Height);
                    }
                    //Left
                    writer.WriteLine(Sprite.LeftRect.Count());
                    foreach (Rectangle x in Sprite.LeftRect)
                    {
                        writer.WriteLine(x.X);
                        writer.WriteLine(x.Y);
                        writer.WriteLine(x.Width);
                        writer.WriteLine(x.Height);
                    }
                    //Right
                    writer.WriteLine(Sprite.RightRect.Count());
                    foreach (Rectangle x in Sprite.RightRect)
                    {
                        writer.WriteLine(x.X);
                        writer.WriteLine(x.Y);
                        writer.WriteLine(x.Width);
                        writer.WriteLine(x.Height);
                    }
                    //Attack
                    writer.WriteLine(Sprite.AttackRect.Count());
                    foreach (Rectangle x in Sprite.AttackRect)
                    {
                        writer.WriteLine(x.X);
                        writer.WriteLine(x.Y);
                        writer.WriteLine(x.Width);
                        writer.WriteLine(x.Height);
                    }

                    Sprite.Image.Save(SpriteFilePath + fileName + "_texture" + ".bmp");
                }

                return true;
            }
            catch(Exception e)
            {
                Loger.write(e.ToString());
            }


            return false;
        }

        public bool LoadSpriteSheet(string fileName, ref SpriteSheet Sprite)
        {
            try
            {
                //for (int count = 0; count < System.IO.Directory.GetFiles(ProjectFilePath + @"\Maps\").Length; count++) Loger.write(count.ToString(), 0);
                using (StreamReader reader = new StreamReader(File.Open(fileName, FileMode.Open)))
                {
                    Sprite.Name = reader.ReadLine();

                    int indexer = Int32.Parse(reader.ReadLine());
                    //Up
                    for (int i = 0; i < indexer; i++)
                    {
                        Sprite.UpRect.Add(new Rectangle(Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine())));
                    }

                    indexer = Int32.Parse(reader.ReadLine());
                    //Down
                    for (int i = 0; i < indexer; i++)
                    {
                        Sprite.DownRect.Add(new Rectangle(Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine())));
                    }

                    indexer = Int32.Parse(reader.ReadLine());
                    //Left
                    for (int i = 0; i < indexer; i++)
                    {
                        Sprite.LeftRect.Add(new Rectangle(Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine())));
                    }

                    indexer = Int32.Parse(reader.ReadLine());
                    //Right
                    for (int i = 0; i < indexer; i++)
                    {
                        Sprite.RightRect.Add(new Rectangle(Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine())));
                    }

                    indexer = Int32.Parse(reader.ReadLine());
                    //Right
                    for (int i = 0; i < indexer; i++)
                    {
                        Sprite.AttackRect.Add(new Rectangle(Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine()), Int32.Parse(reader.ReadLine())));
                    }


                    Sprite.Image = (Bitmap)Image.FromFile(fileName + "_texture" + ".bmp", true);

                    for (int i = 0; i < Sprite.UpRect.Count(); i++)
                        Sprite.Up.Add(new TextureBrush(Sprite.Image, Sprite.UpRect[i]));
                    for (int i = 0; i < Sprite.DownRect.Count(); i++)
                        Sprite.Down.Add(new TextureBrush(Sprite.Image, Sprite.DownRect[i]));
                    for (int i = 0; i < Sprite.LeftRect.Count(); i++)
                        Sprite.Left.Add(new TextureBrush(Sprite.Image, Sprite.LeftRect[i]));
                    for (int i = 0; i < Sprite.RightRect.Count(); i++)
                        Sprite.Right.Add(new TextureBrush(Sprite.Image, Sprite.RightRect[i]));
                    for (int i = 0; i < Sprite.AttackRect.Count(); i++)
                        Sprite.Attack.Add(new TextureBrush(Sprite.Image, Sprite.AttackRect[i]));

                    reader.Close();

                    Loger.write("Loading of sprite " + Sprite.Name + " complete!", 0);
                }

                return true;
            }
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory(SpriteFilePath);
            }
            catch(Exception e)
            {
                Loger.write(e.ToString(),2);
            }

            return false;
        }


        #endregion

    }
}
