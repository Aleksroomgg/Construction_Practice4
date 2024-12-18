using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Square : IDrawable
    {
        public int Draw()
        {
            Console.WriteLine("Площадь нарисована");
            return 0;
        }
    }
}
