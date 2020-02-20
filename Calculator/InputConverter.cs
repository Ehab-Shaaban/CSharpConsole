using System;

namespace Calculator
{
    public class InputConverter
    {
        public double ConvertToNumber(string argTextInput)
        {
            double convrtedNumber;

            if (!double.TryParse(argTextInput, out convrtedNumber))
            {
                throw  new  ArgumentException("Expected a numeric value");
            }

            return convrtedNumber;

        }
    }
}