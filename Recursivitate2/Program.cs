using System;

namespace Recursivitate2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 6, 7, 8, 9, 10 };
            Console.WriteLine(Recursivitate.Maxim(vector, vector.Length - 1, int.MinValue));
        }
    }
}
