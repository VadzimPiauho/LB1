using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите A");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите C");
                int C = Convert.ToInt32(Console.ReadLine());
                if (A < 0 || B < 0 || C < 0)
                {
                    Console.WriteLine("Введено отрицательное число");
                    Environment.Exit(0);
                }
                int SAB = A * B;
                int SC = C * C;
                Console.WriteLine("Площадь прямоугольника состоронами A и B = " + Convert.ToString(SAB));
                Console.WriteLine("Площадь квадрата состороной С = " + Convert.ToString(SC));
                if (((A / C) < 1) && ((B / C) < 1))
                {
                    Console.WriteLine("В прямоугольнике нельзя разместить ни одного квадрата со стороной С");
                    Environment.Exit(0);
                }
                Console.WriteLine("В прямоугольнике со сторонами А и В квадрат со стороной С помещается  "
                    + Convert.ToString((A / C) * (B / C))
                    + " раз");
                Console.WriteLine("Оставшаяся площадь незанятой части прямоугольника = "
                    + Convert.ToString(SAB - ((A / C) * (B / C) * SC)));
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);    
            }      
        }
    }
}
