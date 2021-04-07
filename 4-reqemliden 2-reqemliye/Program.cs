using System;

namespace _4_reqemliden_2_reqemliye
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Dördrəqəmlidən ikirəqəmliyə
            /*           
            Dördrəqəmli natural ədəddən onun orta rəqəmlərindən ibarət olan ikirəqəmli ədəd düzəldin.

            Giriş verilənləri
            Tək sətirdə verilmiş müsbət dördrəqəmli ədəd.

            Çıxış verilənləri
            Düzəldilmiş ikirəqəmli ədədi çıxışa verin
            Giriş verilənləri #1
            4765
            Çıxış verilənləri #1
            76
            Giriş verilənləri #2
            1010
            Çıxış verilənləri #2
            1
            */
            #endregion
            #region
            short eded = Convert.ToInt16(Console.ReadLine());
            int ucuncuReqem = (eded/10) % 10;
            int  ikinciReqem = (eded / 100)%10;
            if (ikinciReqem == default)
            {
                Console.WriteLine(ucuncuReqem);
            }
            else
            {
                Console.WriteLine($"{ikinciReqem}{ucuncuReqem}");
            }
            #endregion
        }
    }
}
