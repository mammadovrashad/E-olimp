using System;

namespace sonuncu_reqem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Sonuncu rəqəm
            Ədədin sonuncu rəqəmini tapmaq tələb olunur.

            Giriş verilənləri
            Yeganə n (1 ≤ n ≤ 109) natural ədədi.

            Çıxış verilənləri
            n ədədinin sonuncu rəqəmini verməli.

            Giriş verilənləri #1
            123
            Çıxış verilənləri #1
            3
            Giriş verilənləri #2
            6578
            Çıxış verilənləri #2
            8
            */
            #endregion
            #region
            int eded = Convert.ToInt32(Console.ReadLine());
            int sonuncu = eded % 10;
            Console.WriteLine(sonuncu);
            #endregion
        }
    }
}
