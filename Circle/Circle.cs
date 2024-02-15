using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    static class Circle
    {
        static public double GetLenght(double r)
        {
            return Math.PI * 2 * r;
        }
        static public double GetSquare(double r)
        {
            return Math.PI * r * r;
        }
        static public string IsInArea(double x, double y, double x0, double y0, double r)
        {
            double diffx = Math.Abs(x0 - x);
            double diffy = Math.Abs(y0 - y);
            if (diffx > r || diffy > r)
                return "Не принадлежит";
            double r0 = Math.Sqrt((x - x0) * (x - x0) + (y - y0) * (y - y0));
            if (r0 > r)
                return "Не принадлежит";
            else
                return "Принадлежит";
        }
    }
}
