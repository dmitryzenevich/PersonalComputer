using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class ScrapMetalCollectionSystem
    {
        public List<ComputerComponent> ComputerComponents { get; } = new List<ComputerComponent>();
        public ScrapMetalCollectionSystem()
        {
        }
        public ScrapMetalCollectionSystem(List<ComputerComponent> computerComponents)
        {
            this.ComputerComponents.AddRange(computerComponents);
        }
        // Сдать металлолом.
        public void PassScrap()
        {
            if (ComputerComponents.Count != 0)
                return;
            foreach (var component in ComputerComponents)
            {
                PassScrap(component);
            }
            Console.WriteLine("Компьютерные компоненты сданы на металлолом.");
        }

        private void PassScrap(ComputerComponent component)
        {
            component = null;
        }

        public void AddScrap(ComputerComponent computerComponent)
        {
            ComputerComponents.Add(computerComponent);
        }
    }
}
