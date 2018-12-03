using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalComputer
{
    abstract class OperationSystem
    {
        public string Name { get; protected set; }
        public string Version { get; protected set; }
        public List<Application> InstalledApps { get; protected set; } = new List<Application>();
        public OperationSystem(string name, string version)
        {
            this.Name = name;
            this.Version = version;
        }
        public virtual void InstallApplication(Application application)
        {
            Console.WriteLine("Установка пользовательского приложения" + application.ToString() + "в системе " + Name + ".");
            InstalledApps.Add(application);
        }
        public virtual void InstallApplications(Application[] applications)
        {
            for (int i = 0; i < applications.Length; i++)
                Console.WriteLine("Установка пользовательского приложения" + applications[i].ToString() + "в системе " + Name + ".");
            InstalledApps.AddRange(applications);
        }
        public virtual void UnInstallApplication(Application application)
        {
            Console.WriteLine("Удаление пользовательского приложения" + application.ToString() + "в системе " + Name + ".");
            InstalledApps.Remove(application);
        }
        public virtual void UnInstallApplications(Application[] applications)
        {
            for (int i = 0; i < applications.Length; i++)
            {
                Console.WriteLine("Удаление пользовательского приложения" + applications[i].ToString() + "в системе " + Name + ".");
                InstalledApps.Remove(applications[i]);
            }
        }
    }
}
