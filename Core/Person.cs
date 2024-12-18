using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    internal class Person : IComparable<Person>
    {
        public int Age { get; set; }

        public Person(int age)
        {
            Age = age;
        }
        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }
}
