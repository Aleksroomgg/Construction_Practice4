using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Скорость авто: 55 км/ч");
        }
    }
}
