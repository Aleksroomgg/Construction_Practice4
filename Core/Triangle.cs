using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Triangle : Shape
    {
        public override double GetArea()
        {
            Console.Write("Введите высоту: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону к которой проведена высота: ");
            double b = double.Parse(Console.ReadLine());

            double result = (a * b) / 2;

            Console.WriteLine("Площадь треугольника: " + result);
            return result;
        }
    }
}
