using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Triangle2 : IDrawable
    {
        public int Draw()
        {
            Console.WriteLine("Треугольник нарисован");
            return 0;
        }
    }
}
