using System;

namespace ucreqemli_ededin_reqemlerini_deyismek
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Üçrəqəmli ədədin rəqəmlərini dəyişdirmək
            /*
            Üçrəqəmli ədədin rəqəmlərini dəyişdirmək
           Verilmiş üçrəqəmli ədəddə birinci və sonuncu rəqəmlərin yerini dəyişdirin

           Giriş verilənləri
           Yeganə n(100 ≤ n ≤ 999) natural ədədi.

           Çıxış verilənləri
           Yerdəyişmədən sonra alınan ədədi verməli.

           Giriş verilənləri #1
           198
           Çıxış verilənləri #1
           891
            */
            #endregion
            #region
            short eded = Convert.ToInt16(Console.ReadLine());
            int sonReqem = eded % 10;
            int ilkReqem = eded / 100;
            int ortaReqem = (eded / 10) % 10;
            if (sonReqem == default)
            {
                Console.WriteLine($"{ortaReqem}{ilkReqem}");
            }
            else
            {
                Console.WriteLine($"{sonReqem}{ortaReqem}{ilkReqem}");
            }
            #endregion
        }
    }
}
