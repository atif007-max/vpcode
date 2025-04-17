using System;

namespace VariableScope
{
    // Global variable
    class Program
    {
        static int globalVariable = 100; 

        static void Main(string[] args)
        {
            // Local variable
            int localVariable = 50; 

            Console.WriteLine("Global Variable: " + globalVariable);
            Console.WriteLine("Local Variable: " + localVariable);

            // Call a method to show the accessibility of the global variable
            DisplayGlobalVariable();

            // Uncommenting the below line will result in an error 
            // because localVariable is not accessible here:
            // Console.WriteLine(localVariable); 
        }

        static void DisplayGlobalVariable()
        {
            Console.WriteLine("Accessing Global Variable in another method: " + globalVariable);
        }
    }
}