using NCalc;
using Project_E.Classes.Code_compiler_classes.Acf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_E.Classes
{
    public class CodeCompiler : VariableVarations
    {
        #region Variable definitions

        public UserControls.Logger Loger { get; set; }
        public Classes.FileManager fileManager { get; set; }

        List<string> Errors = new List<string>();
        List<string> Warnings = new List<string>();
        List<string> Code;

        #endregion



        //==========================================================================
        //Copy code
        //==========================================================================
        private void ReplicateCode(List<string> RawCode)
        {
            Code = RawCode;
        }


        //==========================================================================
        //Set compiler setting
        //==========================================================================
        public void Compile(CodeFileClass CodeFile)
        {
            ReplicateCode(CodeFile.getRawCode());

            if (CodeFile.getCodeType() == "variables")
            {
                CompileVariables(CodeFile.getSequence());                              
            }
            else if (CodeFile.getCodeType() == "code") CompileCode(CodeFile.getSequence());

            fileManager.WriteACF(Code, CodeFile.getName());

            Loger.write("Compilation complete! " + CodeFile.getName(),0);
        }

        //==========================================================================
        //Compiles code
        //==========================================================================
        private void CompileVariables(ActionSequence x)
        {
            Reset();

            DoSteps( x);

            if (Errors.Count != 0) { printErrors(); Reset(); }
            if (Warnings.Count != 0) printWarnings();            
        }

        void DoSteps(ActionSequence sequence)
        {
            string[] separators = { " " };

            int lineNumber = 1;

            foreach (string x in Code)
            {

                List<string> Line = new List<string>();

                //Remove all blank spaces and leave what matters
                string[] words = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string wrd in words)
                    Line.Add(wrd);

                string theEquation = "";
                if (Line.Count < 3) return;
                switch (defineVariable(Line[0]))
                {
                    case 1: //String
                        if (Strings.Any(prod => prod.getName() == Line[1]))
                        {
                            Errors.Add("Same name and type variables not allowed at line " + lineNumber.ToString());
                            return;
                        }
                        break;
                    case 2: //Int
                        if (Ints.Any(prod => prod.getName() == Line[1]))
                        {
                            Errors.Add("Same name and type variables not allowed at line " + lineNumber.ToString());
                            return;
                        }
                        break;
                    case 3: //Float                            
                        if (Floats.Any(prod => prod.getName() == Line[1]))
                        {
                            Errors.Add("Same name and type variables not allowed at line " + lineNumber.ToString());
                            return;
                        }
                        break;
                    case 4: //Boolean
                        if (Booleans.Any(prod => prod.getName() == Line[1]))
                        {
                            Errors.Add("Same name and type variables not allowed at line " + lineNumber.ToString());
                            return;
                        }
                        break;
                }


                for (int i = 3; i < Line.Count(); i++)
                {
                    theEquation += Line[i];
                }

                try
                {
                    Line[3] = theEquation;
                }
                catch (System.ArgumentOutOfRangeException e)
                {
                    Errors.Add(e.Message.ToString() + " At line: " + lineNumber.ToString());
                    Warnings.Add("Possibly 1 or more standart variable rules are not applied At line: " + lineNumber.ToString());
                    break;
                }


                try
                {
                    switch (defineVariable(Line[0]))
                    {
                        case 1: //String
                            sequence.variables.Strings.Add(new StringVariable(Line[1], Line[3]));
                            break;
                        case 2: //Int
                            sequence.variables.Ints.Add(new IntegerVariable(Line[1], Int32.Parse(CheckForOperators(Line[3], lineNumber))));
                            break;
                        case 3: //Float                            
                            sequence.variables.Floats.Add(new FloatVariable(Line[1], float.Parse(CheckForOperators(Line[3], lineNumber), CultureInfo.InvariantCulture.NumberFormat)));
                            break;
                        case 4: //Boolean
                            sequence.variables.Booleans.Add(new BooleanVariable(Line[1], bool.Parse(CheckForOperators(Line[3], lineNumber))));
                            break;


                        default:
                            Errors.Add("Could not define the variable in line " + lineNumber.ToString());
                            break;
                    }
                }
                catch (System.FormatException e)
                {
                    Errors.Add(e.Message.ToString() + " At line: " + lineNumber.ToString());
                }

                lineNumber++;
            }
        }

        string CheckForOperators(string variable, int lineNumber)
        {
            Expression formula = new Expression(variable);

            try { return formula.Evaluate().ToString(); }
            catch (System.InvalidOperationException e) { Errors.Add(e.Message.ToString() + " At line: " + lineNumber.ToString()); }
            catch (NCalc.EvaluationException e) { Errors.Add(e.Message.ToString() + " At line: " + lineNumber.ToString()); }
            catch (System.ArgumentException e) { Errors.Add(e.Message.ToString() + " At line: " + lineNumber.ToString()); Warnings.Add("A variable can't point to another variable at initialization At line: " + lineNumber.ToString()); }
            return "0";
        }




        private void CompileCode(ActionSequence sequence)
        {
            sequence.ReCompile();


            string[] separators = { ".","(",")"};

            int lineNumber = 1;

            //Iterate through each line of code
            foreach (string x in Code)
            {

                List<string> Line = new List<string>();

                //Remove all blank spaces and leave what matters
                string[] words = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (string wrd in words)
                    Line.Add(wrd);

                int SequenceID = 0;

                if(Line.Count > 1)
                {
                    //Determine the object
                    switch (Line[0])
                    {
                        case "player":
                            SequenceID = 0;
                            HandlePlayer(Line, SequenceID, lineNumber,sequence);
                            break;

                        case "map":
                            SequenceID = 100;
                            HandleMap(Line, SequenceID, lineNumber, sequence);
                            break;

                        case "log":
                            SequenceID = -1;
                            HandleMessages(Line, SequenceID, lineNumber, sequence);
                            break;


                        default:
                            Errors.Add("Unknown object at line " + lineNumber);
                            break;
                    }   
                                   


                }             

                lineNumber++;
            }

            if (Errors.Count != 0) { printErrors(); Reset(); }
            if (Warnings.Count != 0) printWarnings();
        }

        void HandlePlayer(List<string> Line, int SequenceID, int lineNumber, ActionSequence sequence)
        {
            if (Line[1] == "move")
            {
                SequenceID += 0;
                sequence.AddCommand(Int32.Parse(Line[2].Substring(0, Line[2].Length - 1)), Line[2].Substring(Line[2].Length - 1), false, SequenceID);
            }
            else if(Line[1] == "location")
            {
                SequenceID += 1;
                string[] separators = { ":" };
                string[] words = Line[2].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                if(words.Length != 2) Warnings.Add("Possible unwanted behaviour from incorrect syntax at line " + lineNumber);
                sequence.AddCommand(0,Line[2], false, SequenceID);
                
            }
            else Errors.Add("A function for player does not exist at line " + lineNumber);            
        }

        void HandleMap(List<string> Line, int SequenceID, int lineNumber, ActionSequence sequence)
        {
            if (Line[1] == "change")
            {
                SequenceID += 0;
                sequence.AddCommand(0,Line[2],false, SequenceID);
            }
            else Errors.Add("A function for map does not exist at line " + lineNumber);
        }

        void HandleMessages(List<string> Line, int SequenceID, int lineNumber, ActionSequence sequence)
        {
            if(Line[1] == "write")
            {
                SequenceID += 0;
                sequence.AddCommand(0, Line[2], false, SequenceID);
            }
            else if (Line[1] == "debugWhait")
            {
                SequenceID -= 1;
                sequence.AddCommand(0, "", false, SequenceID);
            }
            else Errors.Add("A function for log does not exist at line " + lineNumber);
        }




        //==========================================================================
        //Prints errors
        //==========================================================================
        int defineVariable(string name)
        {
            if (name == "string") return 1;
            else if (name == "int") return 2;
            else if (name == "float") return 3;
            else if (name == "bool") return 4;
            return -1;
        }


        //==========================================================================
        //Prints errors
        //==========================================================================
        void printErrors()
        {
            foreach (string x in Errors)
                Loger.write(x,2);

            Errors.Clear();
        }

        void printWarnings()
        {
            foreach (string x in Warnings)
                Loger.write(x, 1);

            Warnings.Clear();
        }

        //==========================================================================
        //Get variables
        //==========================================================================
        public VariableVarations getVariables()
        {
            return this;
        }


    }
}
