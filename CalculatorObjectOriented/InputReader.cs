using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class InputReader
    {
        private string inputPrompt { get; set; }

        public void setInputPrompt(string inputPrompt)
        {
            this.inputPrompt = inputPrompt;
        }

        public InputReader()
        {
            this.inputPrompt = "Input: ";
        }

        public string? getInputWithTwoLines()
        {
            Console.WriteLine(inputPrompt);
            return Console.ReadLine();
        }

        public string? getInputWithOneLine()
        {
            Console.Write(inputPrompt);
            return Console.ReadLine();
        }
    }
}
