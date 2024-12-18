using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Настоящий специалист с конкуретной заработной платой 15000 в месяц");
        }
    }
}
