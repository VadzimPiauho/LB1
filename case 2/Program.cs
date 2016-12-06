using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите коордианты вершин");
                Console.WriteLine("X1 ");
                int ValueX1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Y1 ");
                int ValueY1 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("X2 ");
                int ValueX2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Y2 ");
                int ValueY2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("X3 ");
                int ValueX3 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Y3 ");
                int ValueY3 = Convert.ToInt16(Console.ReadLine());

                int a = Convert.ToInt16(Math.Sqrt(Math.Pow((ValueX2 - ValueX1), 2) + Math.Pow((ValueY2 - ValueY1), 2)));
                int b = Convert.ToInt16(Math.Sqrt(Math.Pow((ValueX3 - ValueX2), 2) + Math.Pow((ValueY3 - ValueY2), 2)));
                int c = Convert.ToInt16(Math.Sqrt(Math.Pow((ValueX3 - ValueX1), 2) + Math.Pow((ValueY3 - ValueY1), 2)));

                Console.WriteLine("Периметр треугольника = " + Convert.ToString(a + b + c));
                int p = Convert.ToInt16((a + b + c) / 2);
                Console.WriteLine("Площадь треугольника = " + Convert.ToString(Convert.ToInt16(Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5))));
            }
            catch (Exception)
            {   
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            
            
        }
    }
}
