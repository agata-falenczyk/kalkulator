using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kalkulator_firstApp
{

    class Program
    {
        private static DataContainer getUserInput()
        {
            DataContainer dataContainer = new DataContainer();
            Console.WriteLine("Podaj pierwszą liczbę");
            dataContainer.FirstInput = Console.ReadLine();
            Console.WriteLine("Podaj drugą liczbę");
            dataContainer.SecondInput = Console.ReadLine();
            Console.WriteLine("Podaj symbol");
            dataContainer.Command = Console.ReadLine();
            return dataContainer;
        }
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Witaj w Kalkulator!");

                DataContainer dataContainer = getUserInput();
                bool check = InputValidation.PerformAllChecks(dataContainer.FirstInput);
                bool check2 = InputValidation.PerformAllChecks(dataContainer.SecondInput);
                if ((check == false) || (check2 == false))
                {
                    isRunning = false;
                    break;
                }

                dataContainer.FirstNumber = double.Parse(dataContainer.FirstInput);
                dataContainer.SecondNumber = double.Parse(dataContainer.SecondInput);

                MathsOperations math = new MathsOperations();
                decimal result = math.DoMath(dataContainer);

                Console.WriteLine($"Wynik: {dataContainer.FirstNumber} {dataContainer.Command} {dataContainer.SecondNumber} to: {result}");
                Console.WriteLine("Zakończ? Y/N");
                string quit = Console.ReadLine();

                if (quit == "Y")
                {
                    isRunning = false;
                }
                Console.ReadLine();

                //double wynik = jakisObiekt.wykonajOperacje(first, second, symol);
                //string nazwaOperacji = zwrocNazweOperacji(symbol);
                //Console.WriteLine($"Wynik {nazwaOperacji}: {wynik}");
            }
        }
    }
}

