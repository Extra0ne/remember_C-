using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remember_Scharp_
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////
            //    Console.Write("Сколько вчего чисел?");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    int numMax = 0;
            //    int numMin = 0;
            //    int a;
            //    Console.Write("Число:");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    int min = a;
            //    int max = a;
            //    for (int i = 1; i < num; i++)
            //    {
            //        Console.Write("Число:");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        if (a <= min)
            //        {
            //            min = a;
            //            numMin = i;
            //        }
            //        if (a >= max)
            //        {
            //            max = a;
            //            numMax = i;
            //        }
            //    }
            //    Console.WriteLine("НOМЕР минимального числа - {numMin + 1},  НОМЕР максимального числа - {numMax + 1}.");

            //    Console.ReadLine();
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////
            //Console.Write("Число учеников : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int appraisal;
            //int amount = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("оценка : ");
            //    appraisal = Convert.ToInt32(Console.ReadLine());
            //    if (appraisal == 5)
            //        amount++;
            //}
            //Console.WriteLine("Количестко пятерок - {amount}");
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////
            int n, s = 0;
            Console.Write("Введите шестизначное число: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 6; i++)
            {
                s = s + n  % 10;
                n = n / 10;
            }
            Console.WriteLine("Сумма цифр = {0}", s);
            Console.ReadKey();
            ///////////////////////////////////////////////////////////////////////////////////////////


            ///////////////////////////////////////////////////////////////////////////////////////////

            // Z2.1.Даны вещественные числа a1, a2, …, a12.Определить сумму тех из них, которые больше 10,75.
            //int i = 0;
            //Double sum = 0; 
            //while (i < 12)
            //{
            //    Console.Write("Число : ");
            //    Double a = Convert.ToDouble(Console.ReadLine());
            //    if (a <= 10.75)
            //    {

            //    }
            //    else
            //    {
            //        sum += a;
            //    }
            //    i++;
            //}
            //Console.WriteLine("сумма = {sum}");
            //Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
