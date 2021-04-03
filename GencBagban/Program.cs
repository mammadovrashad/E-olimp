using System;

namespace GencBagban
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            Vasyanın anası ondan bağçadakı gənc ağacları suvarmağı xahiş etdi.Vasya bilir -ağaclar nə qədər ki, kiçikdirlər, onları çox yaxşı suvarmaq lazımdır.Amma nə qədər suvarmaq-məlum deyil.Lakin Vasya çox ağıllı oğlan idi. O, orta məktəb üçün botanika dərsliyini tamam diqqətlə oxudu və aydınlaşdırdı ki, suvarma suyunun miqdarı ağacdakı yarpaqların cəmi miqdarı ilə düz mütənasibdir. Ağacların yaxşı böyüməsi üçün hər ağaca onun hər yarpağına bir litr olmaqla su vermək kifayətdir.

            Vasyanın xoşbəxtliyindən ağacdakı yarpaqlar yaruslarla böyüyür, başqa sözlə, ən yuxarıdakı birinci yarusda iki yarpaq, ikincidə dörd yarpaq, sonrakında altı yarpaq və s., hər sonrakı yarusda əvvəlkindən iki yarpaq çox olmaqla yerləşir. Ən yuxarıda isə əlavə bir yarpaq böyüyür.Bic Vasya kiçik bacısı Maşenkanı ağacdakı yarusların sayını saymağa göndərdi, Sizdən isə hər ağac üçün onu suvarmağa lazım olan suyun miqdarını hesablayan proqramı yazmağı xahiş edir.

            Giriş verilənləri
            Giriş faylında ağacda yarusların miqdarı olan n(0 ≤ n ≤ 1000) ədədi yazılır.

            Çıxış verilənləri
            Çıxışa bu ağacı suvarmaq üçün lazım olan suyun miqdarını litrlə verin.

            Giriş verilənləri #1
            3
            Çıxış verilənləri #1
            13
            */
            #endregion
            #region
            int a = int.Parse(Console.ReadLine());
            int s = 1;
            for (int i = 0; i <= a; i++)
            {
                s = s + i * 2;
            }
            Console.WriteLine(s);
            #endregion
        }
    }
}
