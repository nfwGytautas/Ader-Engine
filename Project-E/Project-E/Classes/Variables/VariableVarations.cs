using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class VariableVarations
    {
        public List<StringVariable> Strings = new List<StringVariable>();
        public List<IntegerVariable> Ints = new List<IntegerVariable>();
        public List<FloatVariable> Floats = new List<FloatVariable>();
        public List<BooleanVariable> Booleans = new List<BooleanVariable>(); 

        protected void Reset()
        {
            Strings.Clear();
            Ints.Clear();
            Floats.Clear();
            Booleans.Clear();
        }

        public int getAmount()
        {
            return Strings.Count + Ints.Count + Floats.Count + Booleans.Count;
        }
    }
}
