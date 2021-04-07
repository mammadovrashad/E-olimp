using System;

namespace orta_reqem_olmadan
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Ortadakı rəqəm olmadan
            /*
            Üçrəqəmli ədədi orta rəqəmi olmadan yazmalı.

            Giriş verilənləri
            Yeganə üçrəqəmli ədəd.

            Çıxış verilənləri
            Üçrəqəmli ədədi orta rəqəmi olmadan verməli.

            Giriş verilənləri #1
            198
            Çıxış verilənləri #1
            18
            */
            #endregion
            #region
            short eded = Convert.ToInt16(Console.ReadLine());
            int sonReqem = eded % 10;
            int ilkReqem = eded / 100;
            Console.WriteLine($"{ilkReqem}{sonReqem}");
            #endregion
        }
    }
}
