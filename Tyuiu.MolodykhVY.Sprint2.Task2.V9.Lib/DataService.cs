﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.MolodykhVY.Sprint2.Task2.V9.Lib
{
    public class DataService : ISprint2Task2V9
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((((x >= 3) && (x <= 5)) && ((y >= 3) && (y <= 4))) || ((x == 4) && ((y >= 3) && (y <= 10))) || (((x >= 3) && (x <= 5)) && (y == 11)) || (((x >= 6) && (x <= 12)) && ((y >= 9) && (y <= 11))) || (((x >= 7) && (x <= 10)) && (y == 12)) || (((x >= 8) && (x <= 12)) && ((y >= 5) && (y <= 8))) || (((x >= 9) && (x <= 12)) && ((y >= 3) && (y <= 4))) || (((x == 7) && (y == 6))) || ((x == 13) && ((y >= 6) && (y <= 8))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
