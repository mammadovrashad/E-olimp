using System;

namespace Stepanin_dostlari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Stepanın dostları
            Stepan məktəblilərin beynəlxalq proqramlaşdırma olimpiadasından (IOI) qayitdı və 
            suvenir kimi n müxtəlif rəngli daş gətirdi. 
            Stepan xəsis oğlan deyil, buna görə də daşları dostları ilə bölüşmək qərarına gəldi. 
            Hər bir dostuna bir ədəd daş verdi. Beləliklə, Stepanın özündə də bir ədəd daş qaldı. 
            Onun dostlarının sayını təyin edin.

            Giriş verilənləri
            Yeganə tam n (1 ≤ n ≤ 100) ədədi.

            Çıxış verilənləri
            Yeganə ədədi - Stepanın dostlarınn sayını verin.

            Nömunənin şərhi

            Stepan 2 daş gətirdi, biri özündə qaldı. Deməli ikinci daşı yekanə dostuna verdi.
            Giriş verilənləri #1
            2
            Çıxış verilənləri #1
            1
            */
            #endregion
            #region
            int das = int.Parse(Console.ReadLine());
            Console.WriteLine(das - 1);
            #endregion
        }
    }
}
