namespace CalculatorObjectOriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var redoManager = new ConsoleRedoManager();
            bool redo = true;
            while (redo)
            {
                var numberInputReader = new NumberInputReader();
                var operandInputReader = new OperandInputReader();

                var number1 = numberInputReader.readNumber("Enter first number: ");
                var number2 = numberInputReader.readNumber("Enter second number: ");
                var operand = operandInputReader.readOperand("Enter operand (+, -, /, *): ");

                var calculator = new Calculator(number1, number2, operand);
                Console.WriteLine(calculator.calculate());

                redo = redoManager.askRedo();
            }

        }
    }
}
