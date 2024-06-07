namespace CalculatorObjectOriented
{
    internal interface IOperandCalculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }

        public double calculate();
    }

    internal abstract class OperandCalculator
    {
        public double number1 { get; set; }
        public double number2 { get; set; }

        public OperandCalculator(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }

        public abstract double calculate();
    }
}