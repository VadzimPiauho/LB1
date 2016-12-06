using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите температуру в Фарингейтах");
           double  FValur= Convert.ToInt16(Console.ReadLine());
           Console.WriteLine("Температура в Цельсиях = " + (FValur-32)*5/9);
           
        }
    }
}
