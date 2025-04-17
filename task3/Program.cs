using System;

namespace UserInputExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for input
            Console.WriteLine("Please enter your name:");

            // Read the input from the user
            string userName = Console.ReadLine();

            // Display the input back to the user
            Console.WriteLine("Hello, " + userName + "! Welcome to the program.");

            // Prompt for another input
            Console.WriteLine("Please enter your age:");

            // Read and convert the input to an integer
            int age;
            if (int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("You are " + age + " years old!");
            }
            else
            {
                Console.WriteLine("Invalid age input! Please enter a valid number.");
            }
        }
    }
}