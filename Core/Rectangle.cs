using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Rectangle : Shape
    {
        public override double GetArea()
        {
            Console.Write("Введите ширину: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите длину: ");
            double b = double.Parse(Console.ReadLine());

            double result = a * b;
            Console.WriteLine("Площадь прямоугольника: " + result);

            return result;
        }
    }
}
