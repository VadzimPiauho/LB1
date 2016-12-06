using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_1
{
    class Program
    {
        static void Main(string[] args)
        {  
            do
            {       
                Console.WriteLine("Введите температуру в Фарингейтах");
                Console.WriteLine("Для выхода нажмите Enter");
                try
                {
                    double FValur = Convert.ToInt32(Console.ReadLine());
                    //if (Console.ReadKey().Key == ConsoleKey.Enter)
                    //{
                    //    break;
                    //}     
                    Console.Clear();
                    Console.WriteLine("Температура в Цельсиях = " + (FValur - 32) * 5 / 9); 
                }
                catch (Exception)
                {
                    Console.WriteLine("Завершение программы");
                    Environment.Exit(0);
                }     
            } while (true);       
        }
    }
}     