using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class DataHandlerForProgram
    {
        public static int variableFileID = -1;


        //==========================================================================
        //Locates an acf in a codefile list
        //==========================================================================
        public static int LocateACF(string name, List<CodeFileClass> codeFiles)
        {
            for(int i = 0; i < codeFiles.Count();i++)
                if(codeFiles[i].getName() == name) return i;
            return 0;
        }


        //==========================================================================
        //Locates a map in a maphandler list
        //==========================================================================
        public static int LocateMap(string name, List<MapClass> Maps)
        {
            for (int i = 0; i < Maps.Count(); i++)
                if (Maps[i].getMapName() == name) return i;
            return 0;
        }
    }
}
