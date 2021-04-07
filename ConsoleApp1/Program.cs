using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cəmin kvadratı
            /*
            İkirəqəmli natural ədədin rəqəmlərinin cəminin kvadratını hesablayın.

            Giriş verilənləri
            İkirəqəmli natural ədəd.

            Çıxış verilənləri
            Verilmiş ədədin rəqəmlərinin cəminin kvadratı.

            Giriş verilənləri #1
            23
            Çıxış verilənləri #1
            25 
            */
            #endregion
            #region
            byte eded = byte.Parse(Console.ReadLine());
            int qaliq = eded % 10;
            int tamHisse = eded / 10;
            double result= Math.Pow((qaliq + tamHisse), 2);
            Console.WriteLine(result);
            #endregion
        }
    }
}
