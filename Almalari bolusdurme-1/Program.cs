using System;

namespace Almalari_bolusdurme_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Almaları bölüşdürmə - 1
            prb4716n məktəbli k almanı bərabər bölüşdürür, bölünməyən isə zənbildə qalır. Hər bir məktəbliyə neçə alma çatacaq?

            Giriş verilənləri
            İki tam n və k ədədləri verilir. Bütün giriş verilənləri 1500-ü aşmır – məktəbdə az hallarda çox şagird olur, çox alma yemək də zərərlidir...

            Çıxış verilənləri
            Yeganə ədədi - hər bir şagirdə çatacaq almaların sayını verin.

            Giriş verilənləri #1
            3
            14
            Çıxış verilənləri #1
            4
            Giriş verilənləri #2
            10
            100
            Çıxış verilənləri #2
            10
            */
            #endregion
            #region
            int sagird = Convert.ToInt16(Console.ReadLine());
            int alma = Convert.ToInt16(Console.ReadLine());
            int result = alma/sagird;
            Console.WriteLine(result);
            #endregion
        }
    }
}
