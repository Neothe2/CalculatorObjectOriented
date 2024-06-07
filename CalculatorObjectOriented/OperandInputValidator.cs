using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class OperandValidator
    {
        public bool validate(string value)
        {
            if (value == "+" || value == "-" || value == "/" || value == "*")
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
