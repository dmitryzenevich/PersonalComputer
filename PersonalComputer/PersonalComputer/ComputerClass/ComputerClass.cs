using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class ComputerClass
    {
        public List<PersonalComputer> Computers { get; private set; }
        private int computersCount;
        public int ComputersCount
        {
            get
            {
                computersCount = Computers.Count;
                return computersCount;
            }
            private set { computersCount = value; }
        }
        public ComputerClass() { }
        public ComputerClass(List<PersonalComputer> computers)
        {
            this.ComputersCount = computers.Count;
            this.Computers = computers;
        }
    }
}
