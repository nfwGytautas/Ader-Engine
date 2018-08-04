using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class StringVariable : Variable
    {
        string value;

        public StringVariable()
        {
        }

        public StringVariable(string name)
        {
            setName(name);
        }

        public StringVariable(string name, string value)
        {
            setName(name);
            setValue(value);
        }


        void setName(string sent_name)
        {
            name = sent_name;
        }

        void setValue(string sent_value)
        {
            value = sent_value;
        }

        public string getValue()
        {
            return value;
        }
   
    }
}
