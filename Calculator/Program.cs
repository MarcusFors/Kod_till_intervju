using System;

namespace Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kör = true;

            while (kör)
            {
                Console.Clear();
                Console.WriteLine("=== MINIRÄKNARE ===");

                /*
                 * Användaren skriver in det första talet. TryParse kontrollerar
                 * att inmatningen är ett giltigt tal. Om det inte är det, visas ett
                 * felmeddelande och användaren får försöka igen.
                 */
                Console.Write("Skriv första talet: ");
                if (!double.TryParse(Console.ReadLine(), out double tal1))
                {
                    Console.WriteLine("Felaktigt tal. Försök igen.");
                    FortsättRäkna();
                    continue;
                }

                /*
                 * Användaren väljer en operator för beräkningen. Den lagras
                 * i variabeln 'matteTecken' och hanteras senare i en switch-sats.
                 */
                Console.Write("Skriv operator (+, -, *, /): ");
                string matteTecken = Console.ReadLine();

                /*
                 * Samma kontroll görs för andra talet. Om det inte är ett giltigt tal
                 * får användaren försöka igen.
                 */
                Console.Write("Skriv andra talet: ");
                if (!double.TryParse(Console.ReadLine(), out double tal2))
                {
                    Console.WriteLine("Felaktigt tal. Försök igen.");
                    FortsättRäkna();
                    continue;
                }

                double resultat = 0;
                bool ogiltigOperator = false;

                /*
                 * Här används en switch-sats istället för många if-else.
                 * Den kollar vilket räknesätt användaren valde och räknar ut resultatet.
                 * Om användaren försöker dela med 0, visas ett särskilt felmeddelande.
                 */

                switch (matteTecken)
                {
                    case "+":
                        resultat = tal1 + tal2;
                        break;
                    case "-":
                        resultat = tal1 - tal2;
                        break;
                    case "*":
                        resultat = tal1 * tal2;
                        break;
                    case "/":
                        if (tal2 == 0)
                        {
                            Console.WriteLine("Du kan inte dela med 0!");
                            FortsättRäkna();
                            continue;
                        }
                        resultat = tal1 / tal2;
                        break;
                    default:
                        ogiltigOperator = true;
                        Console.WriteLine("Ogiltig operator.");
                        break;
                }


                // Om operatorn var giltig, skriv ut resultatet
                if (ogiltigOperator != false)
                {
                    Console.WriteLine($"Resultat: {tal1} {matteTecken} {tal2} = {resultat}");
                }

                // Fråga om användaren vill fortsätta
                Console.Write("\nVill du räkna igen? (j/n): ");
                string svar = Console.ReadLine().ToLower();
                if (svar != "j")
                {
                    kör = false;
                }
            }

            //Avslutningsmeddelande.
            Console.WriteLine("Tack för att du använde miniräknaren!");
        }

        // Enkel metod för att pausa programmet innan det fortsätter
        static void FortsättRäkna()
        {
            Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
            Console.ReadKey();
        }
    }
}
