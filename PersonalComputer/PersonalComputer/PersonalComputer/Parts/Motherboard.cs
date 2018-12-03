using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class Motherboard : ComputerComponent
    {
        /// <summary> Гнездо (разъём) для установки центрального процессора на материнской плате. </summary>
        public Socket Socket { get; private set; }
        /// <summary> Чипсет материнской платы — это набор микросхем системной логики, обеспечивающий взаимодействие основных компонентов компьютера: центрального процессора, оперативной памяти, устройств ввода-вывода (графических карт, жестких дисков, внешних портов и т.д.). </summary>
        public Chipset Chipset { get; private set; }
        /// <summary> Тип оперативной памяти, поддерживаемой материнской платой. </summary>
        public MemoryType MemoryType { get; private set; }
        /// <summary> Слоты памяти. </summary>
        public int MemorySlots { get; private set; }
        // и другие свойства мат. платы.
        /// <summary>
        /// Материнская плата.
        /// </summary>
        /// <param name="modelName"> Наименование модели. </param>
        /// <param name="manufacturer"> Производитель. </param>
        /// <param name="socket"> Сокет. </param>
        /// <param name="chipset"> Чипсет. </param>
        /// <param name="memoryType"> Тип памяти. </param>
        /// <param name="memorySlots"> Количество слотов памяти. </param>
        /// <param name="PCIExpressX16"> Количество слотов для подключения видеокарт PCIе x16. </param>
        public Motherboard(string modelName, Manufacturer manufacturer, int serialNumber, Socket socket, Chipset chipset, MemoryType memoryType, int memorySlots)
            : base(modelName, manufacturer, serialNumber)
        {
            this.Socket = socket;
            this.Chipset = chipset;
            this.MemoryType = memoryType;
            this.MemorySlots = memorySlots;
        }
        public override void ShowInfo()
        {
            this.ToString();
            base.ShowInfo();
            Console.WriteLine("Сокет - " + Socket.ToString());
            Console.WriteLine("Чипсет - " + Chipset.ToString());
            Console.WriteLine("Тип памяти - " + MemoryType.ToString());
            Console.WriteLine("Количество слотов памяти - " + MemorySlots);
        }
        public override string ToString()
        {
            return "Материнская плата";
        }
    }
}