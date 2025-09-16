using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAssigment
{
    internal class Program
    {
        static bool valid = false;

        static void Main()
        {
            string name = CheckName();

            int age = CheckAge();

            Console.WriteLine($"Your name is {name} and your age is {age}.");

            if (age >= 18)
                Console.WriteLine("You are an adult.");
            else
                Console.WriteLine("You are not an adult.");

            CompareName(name);
        }

        // Antaa käyttäjän syöttämän nimen stringinä
        static string CheckName()
        {
            var name = "";

            while (!valid)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                    valid = true;
                else
                    Console.WriteLine("Name cannot be empty.");
            }
            return name;
        }

        // Antaa käyttäjän syöttämän iän integerinä
        static int CheckAge()
        {
            var age = 0;
            valid = false;
            while (!valid)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out age) && age > 0)
                    valid = true;
                else
                    Console.WriteLine("Please enter a positive integer.");
            }
            return age;
        }

        // Testaa onko saamamme nimi sama kuin esimerkkinimi
        static void CompareName(string _name)
        {
            string compareName = "Matti";

            if (_name.Equals(compareName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Your name matches 'Matti' (case-insensitive).");

            if (_name.Equals(compareName))
                Console.WriteLine("Your name is exactly 'Matti' (case-sensitive).");
        }

    }
}