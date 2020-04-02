using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1Wielowątkowe
{
    class Funkcja
    {

        public static double  oblicz(double x)
        {
            return  3 *Math.Pow(x,3) + Math.Cos(7 * x) - Math.Log(2 * x);
        }
    }
}
