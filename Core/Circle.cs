using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Circle : Shape
    {
        public override double GetArea()
        {
            Console.WriteLine("Введите значения радиуса: ");
            double a = double.Parse(Console.ReadLine());

            double result = 3.14 * (a * a);
            Console.WriteLine("Площадь круга: " + result);
            return result;
        }
    }
}
