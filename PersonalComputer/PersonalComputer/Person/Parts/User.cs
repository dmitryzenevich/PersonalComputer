using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class User : UserPC
    {
        // Здесь в конструкторе явно определяется что юзер не может чинить компьютеры.
        public User(string name, int age)
            :base(name, age, false)
        {

        }
    }
}
