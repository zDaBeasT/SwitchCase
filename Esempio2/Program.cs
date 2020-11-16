using System;

namespace Esempio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int caseSwitch = rnd.Next(0, 6);

            switch(caseSwitch)
            {
                case 1:
                    Console.WriteLine($"Hai vinto!!! - {caseSwitch}");
                    break;
                case 2:
                case 3:
                    Console.WriteLine($"Riprova, sarai più fortunato - {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"Valore inaspettato - {caseSwitch}");
                    break;


            }

            Console.ReadLine();
        }
    }
}
