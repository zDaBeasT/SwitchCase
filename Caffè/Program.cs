using System;

namespace Caffè
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caffè: 1-ristretto, 2-normale, 3-lungo");
            Console.WriteLine("Seleziona il prodotto");

            string str = Console.ReadLine();

            double costo = 0;

            switch(str)
            {
                case "1":
                case "ristretto":
                    costo += 25;
                    break;

                case "2":
                case "normale":
                    costo += 25;
                    goto case "1";

                case "3":
                case "lungo":
                    costo += 50;
                    goto case"1";

                default:
                    Console.WriteLine("Selezione non valida, per favore selezionare prodotto 1, 2, o 3.");
                    break;

            }

            if(costo!=0)
            {
                Console.WriteLine($"Per favore, inserire {costo} centesimi per prendere il prodotto");
            }

            Console.WriteLine("Grazie per averci preferito. Buona giornata");
            Console.ReadLine();
        }
    }
}
