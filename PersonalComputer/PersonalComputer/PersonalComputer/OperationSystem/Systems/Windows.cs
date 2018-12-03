using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class Windows : OperationSystem
    {
        public Windows()
            : base("Windows", "1.0")
        {

        }
        public Windows(string version)
            : base("Windows", version)
        {

        }
        public override void InstallApplication(Application application)
        {
            base.InstallApplication(application);
            //Свои особенности при установке приложения в данной системе.
        }

        public override string ToString()
        {
            return "Windows";
        }
    }
}
