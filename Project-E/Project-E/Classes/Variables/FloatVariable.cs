using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_E.Classes
{
    public class FloatVariable : Variable
    {
        float value;

        public FloatVariable()
        {
        }

        public FloatVariable(string name)
        {
            setName(name);
        }

        public FloatVariable(string name, float value)
        {
            setName(name);
            setValue(value);
        }


        void setName(string sent_name)
        {
            name = sent_name;
        }

        void setValue(float sent_value)
        {
            value = sent_value;
        }

        public float getValue()
        {
            return value;
        }
    }
}
