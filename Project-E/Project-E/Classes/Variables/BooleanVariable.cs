using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class BooleanVariable : Variable
    {
        bool value;

        public BooleanVariable()
        {
        }

        public BooleanVariable(string name)
        {
            setName(name);
        }

        public BooleanVariable(string name, bool value)
        {
            setName(name);
            setValue(value);
        }


        void setName(string sent_name)
        {
            name = sent_name;
        }

        void setValue(bool sent_value)
        {
            value = sent_value;
        }

        public bool getValue()
        {
            return value;
        }
    }
}
