using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrigorevKU.Sprint2.Task2.V30.Lib
{
    public class DataService : ISprint2Task2V30
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (y <= 2 || y >= 13 || x <= 1 || x >= 14 || (x == 2 && y == 3) || (x >= 6 && x <= 8 && y >= 3 && y <= 4) || (x == 13 && ((y <= 5 && y >= 3) || (y >= 8))) || (x == 2) && (y >= 7) || (y == 12) && (x <= 6 || x >= 11) || y >= 8 && y <= 10 && (x <= 5 || x >= 7))
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }
    }
}
