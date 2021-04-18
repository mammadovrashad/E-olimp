using System;

namespace Duzbucaqlinin_perimetri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Düzbucaqlının perimetri
            Düzbucaqlının perimetrini hesablayın.

            Giriş verilənləri
            Dördbucaqlının tamqiymətli a və b (1 ≤ a, b ≤ 1000) tərəfləri.

            Çıxış verilənləri
            Dördbucaqlının perimetrini verməli.

           
            Giriş verilənləri #1
            3 4
            Çıxış verilənləri #1
            14
            */
            #endregion
            #region
            string[] Array = Console.ReadLine().Split();
            int a = int.Parse(Array[0]);
            int b = int.Parse(Array[1]);
            Console.WriteLine((a*2)+(b*2));
            #endregion
        }
    }
}
