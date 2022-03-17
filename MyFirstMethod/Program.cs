using System;

namespace MyFirstMethod
{
    
    /// <summary>
    /// This program is an exercise to practice the usage of Methods
    /// </summary>
    class Program
    {
        //Main method calls the other methods to count
        static void Main(string[] args)
        {
            CountToN(5);
            CountToN(3);
            CountTo10();
        }

        //This method calls the other one to count until 10
        private static void CountTo10()
        {
            CountToN(10);
        }

        //Count to the number in the argument when the method is called in Main
        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
