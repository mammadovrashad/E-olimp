using System;

namespace Intervaldaki_tam_ededlerin_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            string interval = Console.ReadLine();
            var Array = interval.Split();
            int s = 0;
            int i = Convert.ToInt16((Array[0]));
            while(i<= Convert.ToInt32(Array[1]))
            {
                s += i;
                i++;
            }
            Console.WriteLine(s);
            Console.ReadLine();
            #endregion
        }
    }
}
