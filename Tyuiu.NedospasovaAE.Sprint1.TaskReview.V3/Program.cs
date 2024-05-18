using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NedospasovaAE.Sprint1.TaskReview.V3.Lib;

namespace Tyuiu.NedospasovaAE.Sprint1.TaskReview.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x, y;
            Console.Title = "Спринт #1 | Выполнила: Недоспасова.А.Э | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #8                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Недоспасова Александра Эдуардовна | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Вычислить значение выражения, используя данные, введенные      *");
            Console.WriteLine("* пользователем и округлить до трех чисел после запятой                   *");
            Console.WriteLine("*          3 + e^(y-1)                                                    *");
            Console.WriteLine("* z = .....................                                               *");
            Console.WriteLine("*      1 + x^2 * |y - tgx|                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите значение x:                                                        ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:                                                        ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.Calculate(x, y);
            string formattedResult = result.ToString("F3");
            Console.WriteLine(formattedResult);
            Console.ReadKey();
        }
    }
}
