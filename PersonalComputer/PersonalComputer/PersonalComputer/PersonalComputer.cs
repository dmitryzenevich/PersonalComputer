using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    public enum ComputerState
    {
        On,
        Off,
    }
    class PersonalComputer : IProduct
    {
        public string Name { get; }
        public ComputerCase ComputerCase { get; }
        /// <summary> Материнская плата </summary>
        public Motherboard Motherboard { get; }
        public CPU Cpu { get; }
        /// <summary> Операционая система. </summary>
        public OperationSystem OperationSystem { get; }
        /// <summary>  Состояние компьютера. По умолчанию выключен. </summary>
        public ComputerState computerState = ComputerState.Off;
        /// <summary> Список всех компонентов компьютера. </summary>
        public List<ComputerComponent> computerComponents { get; } = new List<ComputerComponent>();

        public double Price { get; }

        public PersonalComputer(string name, ComputerCase computerCase, Motherboard motherboard, CPU cpu, OperationSystem operationSystem, int price)
        {
            this.ComputerCase = computerCase;
            this.Name = name;
            this.Motherboard = motherboard;
            this.Cpu = cpu;
            this.OperationSystem = operationSystem;
            this.Price = price;

            computerComponents.Add(Motherboard);
            computerComponents.Add(Cpu);
        }
        /// <summary> Включение компьютера. </summary>
		public void TurnOn()
        {
            switch (computerState)
            {
                case ComputerState.On:
                    Console.WriteLine("Компьютер " + this.ToString() + " уже включен.");
                    break;
                case ComputerState.Off:
                    Console.WriteLine("Компьютер " + this.ToString() + " включается...");
                    break;
                default:
                    break;
            }
        }
        /// <summary> Выключение компьютера. </summary>
		public void TurnOff()
        {
            switch (computerState)
            {
                case ComputerState.On:
                    Console.WriteLine("Компьютер " + this.ToString() + " выключается...");
                    break;
                case ComputerState.Off:
                    Console.WriteLine("Компьютер " + this.ToString() + " уже выключен.");
                    break;
                default:
                    break;
            }
        }
        /// <summary> Перезагрузка компьютера. </summary>
        public void Restart()
        {
            switch (computerState)
            {
                case ComputerState.On:
                    Console.WriteLine("Компьютер " + this.ToString() + " перезагружается.");
                    break;
                case ComputerState.Off:
                    Console.WriteLine("Компьютер " + this.ToString() + " невозможно перезагрузить, он выключен.");
                    break;
                default:
                    break;
            }
        }
        /// <summary> Установка программы. </summary>
        /// <param name="program"></param>
        public void Install(Application application)
        {
            // Установить пользовательское приложение в операционной системе.
            OperationSystem.InstallApplication(application);
        }
        /// <summary> Возвращает true, если такой компонент у компьютера присутствует. </summary>
        /// <param name="computerComponent">Компонент.</param>
        /// <returns></returns>
        public bool CheckComponent(ComputerComponent computerComponent)
        {
            foreach (ComputerComponent component in computerComponents)
            {
                if (computerComponent.Equals(component))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return Name;
        }

        public double GetDiscountPrice(User user)
        {
            throw new NotImplementedException();
        }
    }
}
