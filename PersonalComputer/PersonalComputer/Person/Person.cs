using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    abstract class Person
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
