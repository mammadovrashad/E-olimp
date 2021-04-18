using System;

namespace Almalari_bolusdurme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            n məktəbli k almanı bərabər bölüşdürdülər, bölünməyən qalanlar sabətdə qalır. Səbətdə neçə alma qalacaq?

            Giriş verilənləri
            İki tam n və k ədədləri verilir. Bütün giriş verilənləri 1500-ü aşmır – məktəbdə az hallarda çox şagird olur və belə bir səbəti hardan tapmalı?

            Çıxış verilənləri
            Proqram yeganə ədədi – səbətdə qalan almaların sayını verməlidir.

            Giriş verilənləri #1
            3
            14
            Çıxış verilənləri #1
            2
            */
            #endregion
            #region
            int sagird = Convert.ToInt16(Console.ReadLine());
            int alma = Convert.ToInt16(Console.ReadLine());
            int result = alma%sagird;
            Console.WriteLine(result);
            #endregion
        }
    }
}
