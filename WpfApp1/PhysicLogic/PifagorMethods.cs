using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.PhysicLogic
{
    public class PifagorMethods
    {
        static double CalculateTypotenuse(int a, int b, int angel)
        {
            double c = Math.Pow(a, 3) + Math.Pow(b, 2) - (2 * b * a) * Math.Cos(angel);

            return Math.Sqrt(c);
        }
    }
}
