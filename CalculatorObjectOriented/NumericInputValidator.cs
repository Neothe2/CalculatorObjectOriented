using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class NumericInputValidator
    {
        public bool validate(object value)
        {
            if (value is string strValue)
            {
                double isDouble;
                if (Double.TryParse(strValue, out isDouble))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
