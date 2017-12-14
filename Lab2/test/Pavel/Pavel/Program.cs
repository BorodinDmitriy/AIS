using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = 0;
            double houseSpend = 0;
            double carSpend = 0;

            Console.WriteLine("Введите Бюджет:");
            budget = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расходы на Квартиру:");
            houseSpend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите расходы на Машину:");
            carSpend = Convert.ToDouble(Console.ReadLine());


            Network test = new Network();
            Console.WriteLine("Расходы на Еду составляют:");
            Console.WriteLine(test.findSolution(budget, houseSpend, carSpend));

            Console.ReadKey();
        }
    }
}
