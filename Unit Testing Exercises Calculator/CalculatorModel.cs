namespace Unit_Testing_Exercises_Calculator
{
    public class CalculatorModel
    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                return 0;
            }
            return (double)number1 / number2;
        }
    }
}