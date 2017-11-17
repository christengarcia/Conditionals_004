using System;

namespace Conditionals_004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            string ageAsString = Console.ReadLine();
            int age = int.Parse(ageAsString);

            if (age > 65)
            {
                Console.WriteLine("You are a senior citizen.");
            }
            else if ( age >= 21 )
            {
                Console.WriteLine("You are an adult.");
            }
            else 
            {
                Console.WriteLine("You are not yet a " +
                                  "legal adult.");
            }
        }
    }
}
