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
            CountToN(1, 10);
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

        //Counts the numbers between the first argument and the second one
        private static void CountToN(int n1, int n2)
        {
            for ( int i = n1+1; i < n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
