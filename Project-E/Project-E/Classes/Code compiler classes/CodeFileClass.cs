using Project_E.Classes.Code_compiler_classes.Acf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class CodeFileClass
    {
        #region Variable definitions

        public ActionSequence Sequence = new ActionSequence();

        List<string> rawCode = new List<string>();
        string codeType = "null";
        string name = "codefile";

        #endregion

        #region Getters & Setters
         
        public List<string> getRawCode()
        {
            return rawCode;
        }
        public void setRawCode(List<string> argument)
        {
            rawCode = argument;
        }

        public string getCodeType()
        {
            return codeType;
        }

        public string getName()
        {
            return name;
        }

        public ActionSequence getSequence()
        {
            return Sequence;
        }
        public void SetSequence(ActionSequence argument)
        {
            Sequence = argument;
        }

        #endregion


        //==========================================================================
        //Diffrent constructors
        //==========================================================================
        public CodeFileClass()
        {
        }
        public CodeFileClass(List<string> raw, string type, string Fname)
        {
            rawCode = raw; codeType = type; name = Fname;
        }
        public CodeFileClass(string type, string Fname)
        {
            codeType = type; name = Fname;
        }

    }
}
