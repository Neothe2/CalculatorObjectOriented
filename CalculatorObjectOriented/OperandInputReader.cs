using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class OperandInputReader
    {
        //Should add factory and facade and input reader interface because there may be different modes of input
        InputReader inputReader = new InputReader();
        OperandValidator operandInputValidator = new OperandValidator();

        public string readOperand(string inputPrompt)
        {
            inputReader.setInputPrompt(inputPrompt);
            string? input = inputReader.getInputWithOneLine();
            bool inputValid = input != null ? operandInputValidator.validate(input!.Trim()) : false;
            while (!inputValid)
            {
                //Should make an error logger class but no time (also better error message).
                Console.WriteLine("Input invalid! The options are +, -, /, *");
                input = inputReader.getInputWithOneLine();
                inputValid = input != null ? operandInputValidator.validate(input!.Trim()) : false;
            }
            return input!.Trim();
        }
    }
}
