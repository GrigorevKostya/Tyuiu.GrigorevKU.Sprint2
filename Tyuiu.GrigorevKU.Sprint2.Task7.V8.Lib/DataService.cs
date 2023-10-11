﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrigorevKU.Sprint2.Task7.V8.Lib
{
    public class DataService : ISprint2Task7V8
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y - Math.Pow(x, 2) <= 0) && ((x >= 0) && ((y >= 0) && (y <= 4))))
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
