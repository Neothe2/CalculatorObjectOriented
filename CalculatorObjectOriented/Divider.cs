using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class Divider : OperandCalculator
    {
        public Divider(double number1, double number2) : base(number1, number2)
        {
        }

        public override double calculate()
        {
            return this.number1 / this.number2;
        }
    }
}
//public double number1 { get; set; }

//public double number2 { get; set; }

//public Divider(double number1, double number2)
//{
//    this.number1 = number1;
//    this.number2 = number2;
//}