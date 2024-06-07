using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class Calculator
    {
        private double number1 { get; set; }
        private double number2 { get; set; }

        private string operand { get; set; }

        private OperandCalculator operandCalculator;

        private OperandValidator operandValidator = new OperandValidator();

        public Calculator(double number1, double number2, string operand)
        {
            setNumber1(number1);
            setNumber2(number2);
            setOperand(operand);
        }

        public void setNumber1(double newValue)
        {
            this.number1 = newValue;
        }

        public void setNumber2(double newValue)
        {
            this.number2 = newValue;
        }

        public void setOperand(string operand)
        {
            if (operandValidator.validate(operand))
            {

                this.operand = operand;
                switch (operand)
                {
                    case "+":
                        this.operandCalculator = new Adder(number1, number2);
                        break;
                    case "-":
                        this.operandCalculator = new Subtractor(number1, number2);
                        break;
                    case "*":
                        this.operandCalculator = new Multiplier(number1, number2);
                        break;
                    case "/":
                        this.operandCalculator = new Divider(number1, number2);
                        break;
                }
            }
            else
            {
                throw new Exception("The operand is invalid");
            }
        }

        public double calculate()
        {
            this.operandCalculator.number1 = this.number1;
            this.operandCalculator.number2 = this.number2;

            return this.operandCalculator.calculate();
        }

    }
}
