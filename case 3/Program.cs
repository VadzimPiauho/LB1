using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число в диапазоне от 100 до 999");
                int Value = Convert.ToInt16(Console.ReadLine());
                if (Value >= 100 && Value <= 999)
                {
                    for (int i = 0; i < Convert.ToString(Value).Length; i++)
                    {
                        switch (Convert.ToInt32(Convert.ToString(Value)[i].ToString()))
                        {
                            case 0:
                                if (i == 2)
                                {
                                    break;
                                }
                                break;
                            case 1:
                                if (i == 0)
                                    Console.Write("Сто ");
                                if (i == 1)
                                {
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 0)
                                        Console.Write("десять ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 1)
                                        Console.Write("одинадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 2)
                                        Console.Write("двенадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 3)
                                        Console.Write("тринадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 4)
                                        Console.Write("четырнадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 5)
                                        Console.Write("пятнадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 6)
                                        Console.Write("шеснадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 7)
                                        Console.Write("семнадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 8)
                                        Console.Write("восемнадцать ");
                                    if (Convert.ToInt32(Convert.ToString(Value)[i + 1].ToString()) == 9)
                                        Console.Write("девятнадцать ");
                                    i++;
                                    break;
                                }
                                if (i == 2)
                                    Console.WriteLine("один ");
                                break;
                            case 2:
                                if (i == 0)
                                    Console.Write("Двести ");
                                if (i == 1)
                                    Console.Write("двадцать ");
                                if (i == 2)
                                    Console.WriteLine("два ");
                                break;
                            case 3:
                                if (i == 0)
                                    Console.Write("Триста ");
                                if (i == 1)
                                    Console.Write("тридцать ");
                                if (i == 2)
                                    Console.WriteLine("три ");
                                break;
                            case 4:
                                if (i == 0)
                                    Console.Write("Четыреста ");
                                if (i == 1)
                                    Console.Write("сорок ");
                                if (i == 2)
                                    Console.WriteLine("четыре ");
                                break;
                            case 5:
                                if (i == 0)
                                    Console.Write("Пятьсот ");
                                if (i == 1)
                                    Console.Write("пятьдесят ");
                                if (i == 2)
                                    Console.WriteLine("пять ");
                                break;
                            case 6:
                                if (i == 0)
                                    Console.Write("Шестьсот ");
                                if (i == 1)
                                    Console.Write("шестьдесят ");
                                if (i == 2)
                                    Console.WriteLine("шесть ");
                                break;
                            case 7:
                                if (i == 0)
                                    Console.Write("Семьсот ");
                                if (i == 1)
                                    Console.Write("семьдесят ");
                                if (i == 2)
                                    Console.WriteLine("семь ");
                                break;
                            case 8:
                                if (i == 0)
                                    Console.Write("Восемьсот ");
                                if (i == 1)
                                    Console.Write("восемьдесят ");
                                if (i == 2)
                                    Console.WriteLine("восемь ");
                                break;
                            case 9:
                                if (i == 0)
                                    Console.Write("Девятьсот ");
                                if (i == 1)
                                    Console.Write("девяноста ");
                                if (i == 2)
                                    Console.WriteLine("девять ");
                                break;
                        }

                    }
                }
                // int b= Convert.ToString(Value).Length;
                // Console.WriteLine(b);
                //Console.WriteLine(Convert.ToString(Value/100));
                // Console.WriteLine(Convert.ToString((Value / 10)%10));
                // Console.WriteLine(Convert.ToString(Value % 10));              
                else
                {
                    Console.WriteLine("Введенный диапазон не верный");
                }
                if (Value == 0)
                {
                    Console.WriteLine("Число не введено");
                }

                Console.Read();
            }
            catch (Exception)
            {   
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }  
        }
    }
}
