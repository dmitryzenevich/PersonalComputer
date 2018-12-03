using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class Application
    {
        public string Name{ get; set; }
        public Application(string name)
        {
            this.Name = name;
        }
        // Мелкое копирование.
        public Application ShallowCopy()
        {
            return (Application)this.MemberwiseClone();
        }
        // Глубокое копирование.
        public Application DeepCopy()
        {
            Application other = (Application)this.MemberwiseClone();
            //Здесь устанавливаем другие свойства объекта
            return other;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
