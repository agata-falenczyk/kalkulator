using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_firstApp
{
    public static class InputValidation
    {
        //moze zmienic nazwe na checkIfNotNull
        public static bool checkNulls(string userInput)
        {
            if (string.IsNullOrEmpty(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //moze zmienic nazwe na checkIfNotZero?
        public static bool checkIfZero(string userInput)
        {
            return userInput == "0"; // zwróć wynik porównania czy userInput wynosi 0             
        }

        public static bool isNumber(string userInput)
        {
            double temp;
            return double.TryParse(userInput, out temp);
        }

        public static bool PerformAllChecks(string userInput)
        {
            bool isNotNull = !checkNulls(userInput);
            bool isNotZero = !checkIfZero(userInput);
            bool IsNumber = isNumber(userInput);

            return isNotNull && isNotZero && IsNumber; // zwróć wynik koniunkcji
                                                       //return isNotNull(userInput) && isNotZero(userInput) && isNumber(userInput);

        }


    }
}
