using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class TechnicalSpecialist : UserPC
    {
        // Здесь в конструкторе явно определяется что технический специалист может чинить компьютеры.
        public TechnicalSpecialist(string name, int age, bool canRepairComputer)
            :base(name, age, true)
        {

        }
        /// <summary>
        /// Заменяет старый компонент компьютера на новый компонент.
        /// </summary>
        /// <param name="pc">Компьютер</param>
        /// <param name="oldComputerComponent">Старый компонент</param>
        /// <param name="newComputerComponent">Новый компонент</param>
        public void ReplaceComputerComponents(PersonalComputer pc, ComputerComponent oldComputerComponent, ComputerComponent newComputerComponent)
        {
            if (!pc.CheckComponent(oldComputerComponent))
            {
                Console.WriteLine("Такого компонента в компьютере нету.");
                return;
            }
            
            Type oldComponentType = oldComputerComponent.GetType();
            Type newComponentType = newComputerComponent.GetType();
            if (newComponentType.Equals(oldComponentType))
            {
                Console.WriteLine("Вы заменили" + oldComputerComponent.ToString() + " на " + newComputerComponent.ToString());
            }
            else
            {
                Console.WriteLine("Невозможно заменить " + oldComputerComponent.ToString() + " на " + newComputerComponent.ToString());
            }
        }
    }
}
