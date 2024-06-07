using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class NumberInputReader
    {
        //Should add factory and facade and input reader interface because there may be different modes of input
        InputReader inputReader = new InputReader();
        NumericInputValidator numericInputValidator = new NumericInputValidator();

        public double readNumber(string inputPrompt)
        {
            inputReader.setInputPrompt(inputPrompt);
            string? input = inputReader.getInputWithOneLine();
            bool inputValid = input != null ? numericInputValidator.validate(input) : false;
            while (!inputValid)
            {
                Console.WriteLine("Input invalid!");
                input = inputReader.getInputWithOneLine();
                inputValid = input != null ? numericInputValidator.validate(input) : false;
            }


            return Double.Parse(input!);
        }
    }
}
