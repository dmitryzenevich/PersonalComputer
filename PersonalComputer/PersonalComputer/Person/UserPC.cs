using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    abstract class UserPC: Person
    {
        public bool CanRepairComputer { get; protected set; }
        public UserPC(string name, int age, bool canRepairComputer)
            :base(name, age)
        {
            this.CanRepairComputer = canRepairComputer;
        }
        public void ComputerOn(PersonalComputer pc)
        {
            pc.TurnOn();
        }
        public void ComputerOff(PersonalComputer pc)
        {
            pc.TurnOff();
        }
        public void ComputerRestart(PersonalComputer pc)
        {
            pc.Restart();
        }
        public void InstallApp(PersonalComputer pc, Application app)
        {
            Console.WriteLine("Устанавливаю " + app.ToString() + "для" + pc.OperationSystem.ToString());
            pc.Install(app);
        }
    }
}
