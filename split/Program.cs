using System;

namespace split
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Kvadratların cəmi
            /*
            İki ədədin kvadratları cəmini hesablayın.

            Giriş verilənləri
            İki a və b ədədləri verilir. Ədədlər mütləq qiymətcə 109 - u aşmır.

            Çıxış verilənləri
            Yeganə tam a2 + b2 ədədini verin.

            Giriş verilənləri #1
            2 3
            Çıxış verilənləri #1
            13
            */
            #endregion
            #region
            string setir = Console.ReadLine();
            var Array= setir.Split(' ');
            double eded1 = double.Parse(Array[0]);
            double eded2 = double.Parse(Array[1]);
            var result = Math.Pow(eded1, 2) + Math.Pow(eded2, 2);
            Console.WriteLine(result);
            #endregion
        }
    }
}
