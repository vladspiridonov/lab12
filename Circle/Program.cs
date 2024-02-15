using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x0:");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y0:");
            double y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("r:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Circle.IsInArea(x,y,x0,y0,r));
            double l = Circle.GetLenght(r);
            double s = Circle.GetSquare(r);
            Console.WriteLine("Длина окружности: {0}\nПлощадь: {1}",l,s);
            Console.ReadKey();
        }
    }
}
