using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MolodykhVY.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {   //a = 325, b = 325, c = 242, d = 324
            //True, False, True, False, True, False
            bool[] res = new bool[6];
            res[0] = (a < (d + 10)) & (c > (b - 100));
            res[1] = (a == b + 1) | (c != d - 82);
            res[2] = !(!res[0]);
            res[3] = (a <= b) ^ (c >= d - 100);
            res[4] = (a == b) || (d > c);
            res[5] = (Math.Pow(a, 2) < b) && (c - 737 == d);
            return res;
        }
    }
}

