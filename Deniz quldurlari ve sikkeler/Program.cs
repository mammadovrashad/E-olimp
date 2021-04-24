using System;

namespace Deniz_quldurlari_ve_sikkeler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             * Dəniz quldurları və sikkələr
            n dəniz qulduruna m qızıl sikkədən ibarət xəzinəni öz aralarında ədalətli şəkildə bölmək müyəssər oldu – hər kəs öz quldur ranqına (dərəcəsinə) və stajına uyğun ona çatacaq payı aldı. Ən kiçik quldur a sikkə, hər sonrakı quldur özündən əvvəlki yoldaşından bir sikkə artıq götürdü. Axırda kapitan idi, ona planlaşdırıldığından iki dəfə artıq sikkə çatdı və aydındır ki, ondan sonra sikkə qalmadı.

            Əgər a və m məlumdursa, kapitanla birlikdə neçə quldur var idi. Komandasız kapitan adi quldurdur, onda n > 1.

            Giriş verilənləri
            İki natural a və m (1 ≤ a ≤ 100, m < 15150) ədədləri. Bütün giriş verilənləri düzgündür.

            Çıxış verilənləri
            Quldurların n sayı.

            Giriş verilənləri #1 content_copy
            5 25
            Çıxış verilənləri #1 content_copy
            3
             */
            #endregion
            #region
            string valu = Console.ReadLine();
            var Array = valu.Split();
            int a = Convert.ToInt32(Array[0]);
            int m = Convert.ToInt32(Array[1]);
            int i = 1;
            x:
            if ((m - a) / 2 >= a)
            {
                i++;
                m = m - a;
                a++;
                goto x;
            }
            Console.WriteLine(i);
            #endregion
        }
    }
}
