using System;

class Program
{
    static void Main()
    {
        /*
         * Användaren matar in tre tal separerade med mellanslag:
         * x, y och n. x och y används för att kontrollera om
         * ett tal är jämnt delbart. n bestämmer hur långt loopen går.
         * Split delar upp inmatningen till tre strängar som sedan tolkas som int.
         */
        string[] input = Console.ReadLine().Split();
        int x = int.Parse(input[0]);
        int y = int.Parse(input[1]);
        int n = int.Parse(input[2]);

        // Loopen går från 1 till n. n bestämmer hur många rader som skrivs ut.
        for (int i = 1; i <= n; i++)
        {

            string output = "";

            // Om i är jämnt delbart med x, lägg till "Fizz" i output 
            if (i % x == 0)
            {
                output += "Fizz";
            }

            // Om i är jämnt delbart med y, lägg till "Buzz" i output
            // Om i är delbart med både x och y får vi "FizzBuzz" 
            if (i % y == 0)
            {
                output += "Buzz";
            }
            // Om inget av ovan är sant – skriv ut talet i stället
            if (output == "")
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(output);
            }
        }
    }
}
