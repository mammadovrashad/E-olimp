using System;

namespace ReqemleriHasili
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Üçrəqəmli ədəd verilir. Onun rəqəmlərinin hasilini hesablamalı.

            Giriş verilənləri
            Tək sətirdə üçrəqəmli ədəd verilir.

            Çıxış verilənləri
            Tək sətirdə verilmiş ədədin rəqəmlərinin hasilini verilməli.

            Giriş verilənləri #1
            235
            Çıxış verilənləri #1
            30
            */
            #endregion
            #region
            short a = Convert.ToInt16(Console.ReadLine());
            int b = a % 10;
            int c = (a / 10) % 10;
            int d = a / 100;
            Console.WriteLine(b * c * d);
            #endregion
        }
    }
}
