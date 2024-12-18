using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Скорость велосипеда: 15 км/ч");
        }
    }
}
