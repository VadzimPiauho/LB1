using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Deposit = 1000;
            Console.WriteLine("Начальный вклад в банке равен " + Convert.ToString(Deposit));
            Console.WriteLine("Введите процент вклада");
            try
            {
                int Percent = Convert.ToInt32(Console.ReadLine());
                if (Percent < 0)
                {
                    Console.WriteLine("Введен отрицательный процент");
                    Environment.Exit(0);
                }
                int K = 0;
                while (Deposit < 1100)
                {
                    Deposit += (Deposit / 100) * Percent;
                    K++;
                }
                Console.WriteLine("Размер вклада превысит 1100 руб через " + Convert.ToString(K)
                    + " месяцев и будет равен " + Convert.ToString(Deposit));
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
                
            }

        }
    }
}
