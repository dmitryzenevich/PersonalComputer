using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    class Linux : OperationSystem
    {
        public Linux()
            : base("Linux", "1.0")
        {

        }
        public Linux(string version)
            : base("Linux", version)
        {

        }
        public override void InstallApplication(Application application)
        {
            base.InstallApplication(application);
            //Свои особенности при установке приложения в данной системе.
        }
        public override string ToString()
        {
            return "Linux";
        }
    }
}
