using System;

namespace Tam_eded
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Növbəti siniflər diaqramına əsasən Integersinfini tərtib edin:

            prb7491.gif

            Verilmiş üç a, b, c ədədlərinə görə (a * 7 + b - 2) * (a - c + 5) ifadəsinin qiymətini hesablayın.

            Giriş verilənləri
            Tək sətirdə Modulca 109-dan böyük olmayan üç ədəd: a, b, c.

            Çıxış verilənləri
            İfadənin qiymətini verməli.
            Giriş verilənləri #1
            1 2 3
            Çıxış verilənləri #1
            21
            */
            #endregion
            #region
            string[] Array= Console.ReadLine().Split();
            int a = Convert.ToInt32(Array[0]);
            int b = Convert.ToInt32(Array[1]);
            int c = Convert.ToInt32(Array[2]);
            double total = (double)(a * 7 + b - 2) * (a - c + 5);
            Console.WriteLine(total);
            #endregion
        }
    }
}
