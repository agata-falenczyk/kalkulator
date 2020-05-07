using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_firstApp
{ 
    public class MathsOperations
    {
        public decimal Add(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public decimal Subtract(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public decimal Multiply(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public decimal Divide(decimal firstNumber, decimal secondNumber)
        {
            return firstNumber / secondNumber;

        }

        public decimal DoMath(DataContainer dataContainer)
        {
            decimal result = 0;
            switch (dataContainer.Command)
            {
                case "+":
                    {
                        result = Add(Convert.ToDecimal(dataContainer.FirstNumber), Convert.ToDecimal(dataContainer.SecondNumber));
                        break;
                    }
                case "-":
                    {
                        result = Subtract(Convert.ToDecimal(dataContainer.FirstNumber), Convert.ToDecimal(dataContainer.SecondNumber));
                        break;
                    }
                case "/":
                case ":":
                    {
                        result = Divide(Convert.ToDecimal(dataContainer.FirstNumber), Convert.ToDecimal(dataContainer.SecondNumber));
                        break;
                    }
                case "*":
                    {
                        result = Multiply(Convert.ToDecimal(dataContainer.FirstNumber), Convert.ToDecimal(dataContainer.SecondNumber));
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operacja nie jest obsługiwana");
                        break;
                    }
            }
            return result;
        }
    }
}
