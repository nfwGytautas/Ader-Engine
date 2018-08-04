using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class IntegerVariable : Variable
    {
        int value;

        public IntegerVariable()
        {
        }

        public IntegerVariable(string name)
        {
            setName(name);
        }

        public IntegerVariable(string name, int value)
        {
            setName(name);
            setValue(value);
        }


        void setName(string sent_name)
        {
            name = sent_name;
        }

        void setValue(int sent_value)
        {
            value = sent_value;
        }

        public int getValue()
        {
            return value;
        }
    }
}
