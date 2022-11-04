using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada4a4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, c, d, result;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());

            result = 8 * Math.Cos(x) + Math.Pow(x, 5) * (1 + y + c / d / x + c / d) * Math.Tan(x) + 7;

            Console.WriteLine("Резултат= " + result);
            Console.WriteLine("Натиснете произволен клавиш. . .");
        }
    }
}
