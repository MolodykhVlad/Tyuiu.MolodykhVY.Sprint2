using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Sprint2.Task2.V9.Lib;

namespace Tyuiu.MolodykhVY.Sprint2.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Молодых В. Ю. | ИИПб-23-3";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры                                *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #9                                                               *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПб-23-3                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры   *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной       *");
            Console.WriteLine("* области.                                                                 *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (res == true)
                Console.WriteLine("Точка входит в область");

            else
                Console.WriteLine("Точка не входит в область");


            Console.ReadKey();
        }
    }
}
