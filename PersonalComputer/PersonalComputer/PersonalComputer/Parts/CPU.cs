using System;

namespace PersonalComputer
{
    class CPU : ComputerComponent
    {
        /// <summary>Частота процессора.</summary>
        public int ClockFrequency { get; set; }
        /// <summary>Количество ядер.</summary>
        public int NumberOfCores { get; set; }
        /// <summary>Размер кэша.</summary>
        public int CacheSize { get; set; }
        /// <summary>Процессор.</summary>
        /// <param name="manufacturer">Имя модели.</param>
        /// <param name="manufacturer">Производитель.</param>
        /// <param name="clockFrequency">Частота процессора.</param>
        /// <param name="numberOfCores">Количество ядер.</param>
        /// <param name="cacheSize">Размер кэша.</param>
        public CPU(string modelName, Manufacturer manufacturer, int serialNumber, int clockFrequency, int numberOfCores, int cacheSize)
            : base(modelName, manufacturer, serialNumber)
        {
            this.ClockFrequency = clockFrequency;
            this.NumberOfCores = numberOfCores;
            this.CacheSize = cacheSize;
        }
        public override void ShowInfo()
        {
            this.ToString();
            base.ShowInfo();
            Console.WriteLine("Частота процессора - " + ClockFrequency);
            Console.WriteLine("Количество ядер - " + NumberOfCores);
            Console.WriteLine("Размер кэша - " + CacheSize);
        }

        public override string ToString()
        {
            return ModelName;
        }
    }
}
