using System;

namespace GenericDemo
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.3, 3.6, 4.8, 5.10, 6.369 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Program.ToPrint<int>(intArray);
            Program.ToPrint<double>(doubleArray);
            Program.ToPrint<char>(charArray);
        }

        /// <summary>
        /// Converts to print.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray">The input array.</param>
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("**************");
        }
    }
}
            //public static void toprint(int[] inputArray)
            // {
            // foreach(int element in inputArray)
            // {
            //       Console.WriteLine(element);
            //   }
            //   Console.WriteLine("*************");
            // }

            // public static void toprint(double[] inputArray)
            //{
            //  foreach (int element in inputArray)
            //{
            //  Console.WriteLine(element);
            //}
            //Console.WriteLine("*************");
            //}

