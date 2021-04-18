using System;

namespace Duzbucaqlinin_saesi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             * Düzbucaqlının sahəsi
            Düzbucaqlının sahəsini hesablayın.

            Giriş verilənləri
            Düzbucaqlının tamqiymətli a və b (1 ≤ a, b ≤ 1000) tərəfləri.

            Çıxış verilənləri
            Düzbucaqlının sahəsini ekrana çıxardın.

            Giriş verilənləri #1
            3 4
            Çıxış verilənləri #1
            12
             */
            #endregion
            #region
            string[] Array = Console.ReadLine().Split();
            float a = float.Parse(Array[0]);
            float b = float.Parse(Array[1]);
            Console.WriteLine(a * b);
            #endregion
        }
    }
}
