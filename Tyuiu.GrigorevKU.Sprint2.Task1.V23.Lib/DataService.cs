using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GrigorevKU.Sprint2.Task1.V23.Lib
{
    public class DataService : ISprint2Task1V23
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a < d) | (c == b);
            res[1] = (c >= b) & (a + b > d);
            res[2] = (a >= c) || (d > c);
            res[3] = (a < b) && (c != b);
            res[4] = ! (c == b);
            res[5] = (a < c) ^ (c >= b);
            return res;

        }
    }
}
