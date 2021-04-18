using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[5] { 1, 2, 3, 4, 5 };
           
            foreach (var items in newArray)
            {
                Console.WriteLine(items);
            }
        }
    }
}
