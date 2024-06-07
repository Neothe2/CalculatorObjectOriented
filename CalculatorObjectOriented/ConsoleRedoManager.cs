using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorObjectOriented
{
    internal class ConsoleRedoManager
    {
        public bool askRedo()
        {
            bool redo = false;
            Console.Write("Again? (Y/n): ");
            var redoInput = Console.ReadLine();
            redo = redoInput == "n" ? false : true;
            if (redo)
            {
                Console.WriteLine();
                Console.WriteLine("---");
                Console.WriteLine();
            }

            return redo;
        }
    }
}
