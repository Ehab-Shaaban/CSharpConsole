using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter=new InputConverter();
                CalculatorEngine calculatorEngine=new CalculatorEngine();

                Console.WriteLine("Enter first number");
                double firstNumber = inputConverter.ConvertToNumber(Console.ReadLine());

                Console.WriteLine("Enter second number");
                double secondNumber = inputConverter.ConvertToNumber(Console.ReadLine());

                Console.WriteLine("Enter the operation (+ or - or * or /");
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("Result: "+result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
