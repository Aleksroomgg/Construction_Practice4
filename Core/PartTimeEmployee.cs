using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("(не)Настоящий специалист с конкуретной заработной платой 1820руб в месяц");
        }
    }
}
