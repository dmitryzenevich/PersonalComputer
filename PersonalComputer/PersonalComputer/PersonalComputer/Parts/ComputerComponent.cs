using System;

namespace PersonalComputer
{
    abstract class ComputerComponent
    {
        /// <summary> Модель. </summary>
        public string ModelName { get; protected set; }
        /// <summary> Производитель. </summary>
        public Manufacturer Manufacturer { get; protected set; }
        /// <summary> Серийный номер. </summary>
        public int SN{ get; protected set; }
        /// <summary> Флаг исправности. </summary>
        public bool IsBroken { get; protected set; }

        public ComputerComponent(string modelName, Manufacturer manufacturer, int serialNumber)
        {
            this.ModelName = modelName;
            this.Manufacturer = manufacturer;
            this.SN = serialNumber;
            this.IsBroken = false;
        }
        public void BreakComponent()
        {
            this.IsBroken = true;
        }
        public virtual void ShowInfo()
        {
            this.ToString();
            Console.WriteLine("Модель - " + ModelName);
            Console.WriteLine("Производитель - " + Manufacturer.ToString());
            Console.WriteLine("Серийный номер - " + SN);
            Console.WriteLine("Сломан - " + IsBroken);
        }
    }
}
