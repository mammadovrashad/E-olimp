using System;

namespace SadeMesele
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Proqram ikirəqəmli ədədi oxuyur və ədədin hər bir rəqəmini arada boşluq olmaqla ekrana verir.

            Giriş verilənləri
            10 - 99 arası hər hansı bir natural ədəd

            Çıxış verilənləri

            Giriş verilənləri #1
            23
            Çıxış verilənləri #1
            2 3
            */
            #endregion
            #region
            byte b = byte.Parse(Console.ReadLine());
            int c = b / 10;
            int d = b % 10;
            Console.WriteLine("{0} {1}", c, d);
            Console.Read();
            #endregion
        }
    }
}
