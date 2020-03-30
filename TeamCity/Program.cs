using System;

namespace TeamCity
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("res: " + count(i, i+1).ToString());
            }

            Console.ReadKey();
        }

        public static int count(int a, int b)
        {
            return a + b;
        }
    }
}   
