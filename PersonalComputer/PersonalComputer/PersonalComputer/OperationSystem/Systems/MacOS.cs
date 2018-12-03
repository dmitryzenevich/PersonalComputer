using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class MacOS : OperationSystem
    {
        public MacOS()
            : base("MacOS", "1.0")
        {

        }
        public MacOS(string version)
            : base("MacOS", version)
        {

        }
        public override void InstallApplication(Application application)
        {
            base.InstallApplication(application);
            //Свои особенности при установке приложения в данной системе.
        }
        public override string ToString()
        {
            return "MacOS";
        }
    }
}
