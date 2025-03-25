using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        /*
         * I min lista komme föremål att sparas 
         */
        List<string> packLista = new List<string>();

        /*
         * Föremålen användaren matar in räknas varje element med hjälp av property Count
         * och skrivs ut av den generiska metoden Add. 
         */
        Console.WriteLine("Skriv in 5 saker du vill packa:");
        while (packLista.Count < 5)
        {
            Console.Write($"{packLista.Count + 1}: ");
            packLista.Add(Console.ReadLine());
        }

        while (true)
        {
            // Rensar fönstret efter att man har valt att ändra ett objekt.
            Console.Clear();

            // Här visas listan på de objekt som användaren har matat in.
            Console.WriteLine("--- Packlista ---");
            for (int i = 0; i < packLista.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {packLista[i]}");
            }

            Console.WriteLine("\n1. Byt ut ett objekt\n2. Avsluta");
            Console.Write("Välj: ");
            string val = Console.ReadLine();

            if (val == "2")
            {
                Console.WriteLine("Avslutar programmet...");
                break;
            }

            /* Användaren får välja vilket föremål i listan (plats 1–5) som ska bytas ut. 
             * Vi konverterar användarens val till rätt index 
             * (index - 1 eftersom listan börjar på 0),tar bort den gamla föremålet 
             * och lägger till det nya föremålet på samma plats.
             */

            else if (val == "1")
            {
                Console.Write("Vilket nummer vill du byta ut (1–5): ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= 5)
                {
                    Console.Write("Nytt föremål att lägga till: ");


                    string läggaTillNySak = Console.ReadLine();

                    packLista.RemoveAt(index - 1);
                    packLista.Insert(index - 1, läggaTillNySak);

                }
            }
            else
            {
                Console.WriteLine("Fel val. Tryck på en tangent.");
                Console.ReadKey();
            }
        }
    }
}
