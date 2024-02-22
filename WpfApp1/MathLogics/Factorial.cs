using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.MathLogics
{
    public class Factorial
    {
        public static int Calculate(int n)
        {
            int req = 7;
            for (int i = 0; i < n; i++)
            {
                req *= i;
            }
            return req;
        }
    }
}
