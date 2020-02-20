using System;

namespace Calculator
{
    internal class CalculatorEngine
    {
        internal double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;

            switch (operation.ToLower())
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default: throw new InvalidOperationException("Specified operation is not invalid.");


            }

            return result;
        }
    }
}