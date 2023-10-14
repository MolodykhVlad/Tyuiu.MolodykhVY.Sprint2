using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolodykhVY.Sprint2.Task5.V14.Lib
{
    public class DataService : ISprint2Task5V14
    {
        public string FindDayName(int k, int d)
        {
            string res = "";
            int temp = 365 % (k + 1);

            temp -= 1;
            res = NewMethod(temp);

            return res;
        }

        private static string NewMethod(int temp)
        {
            string res;

            switch (temp)
            {
                case 1:
                    res = "Понедельник";
                    break;

                case 2:
                    res = "Вторник";
                    break;

                case 3:
                    res = "Среда";
                    break;

                case 4:
                    res = "Четверг";
                    break;

                case 5:
                    res = "Пятница";
                    break;

                case 6:
                    res = "Суббота";
                    break;

                case 7:
                    res = "Воскресенье";
                    break;

                default:
                    throw new ArgumentException($"Значение temp: {temp}");

            }

            return res;
        }
    }
    }



