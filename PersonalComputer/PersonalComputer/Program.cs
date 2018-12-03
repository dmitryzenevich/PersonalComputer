using System;
using System.Collections.Generic;

namespace PersonalComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создать список компьютеров.
            List<PersonalComputer> personalComputers = new List<PersonalComputer>();
            // Количество компьютеров.
            int computersCount = 10;
            // Добавить в список 10 одинаковых компьютеров.
            for (int i = 0; i < computersCount; i++)
            {
                personalComputers.Add(
                    new PersonalComputer(
                        i.ToString(),
                        new ComputerCase("DL-177", Manufacturer.Samsung, 693),
                        new Motherboard("GA-77", Manufacturer.GIGABYTE, 123, Socket.LGA1155, Chipset.H110, MemoryType.DDR3, 4),
                        new CPU("Quad", Manufacturer.Intel, 231, 4000, 4, 2048),
                        new Windows(),
                        1000));
            }
            // Создать компьютерный класс.
            ComputerClass computerClass = new ComputerClass(personalComputers);
            // Создать технического специалиста, который может включать/выключать/перезагружать компьютеры, и менять в них компоненты, а также устанавливать пользовательские приложения.
            TechnicalSpecialist technicalSpecialist = new TechnicalSpecialist("Vasya", 30, true);
            // Создать юзера, который может включать/выключать/перезагружать компьютеры и устанавливать пользовательские приложения.
            User user = new User("Pavel", 20);

            // Юзер включает все компьютеры в классе.
            foreach (var computer in computerClass.Computers)
                user.ComputerOn(computer);

            // Технический специалист перезагружает все компьютеры в классе.
            foreach (var computer in computerClass.Computers)
                technicalSpecialist.ComputerRestart(computer);

            // Создать пользовательское приложение.
            Application application = new Application("Visual Studio 2017 Community");
            //Юзер устанавливает пользовательское приложение на все компьютеры в классе.
            foreach (var computer in computerClass.Computers)
                user.InstallApp(computer, application.ShallowCopy());

            // Замена материнской платы.
            // Искусственно сломать материнскую плату в 5 компьютере.
            computerClass.Computers[4].Motherboard.BreakComponent();

            // Найти компьютер со сломанной материнской платой
            PersonalComputer brokenPC = null;
            ComputerComponent brokenComponent = null;
            foreach (var pc in computerClass.Computers)
            {
                foreach (var component in pc.computerComponents)
                {
                    if (component.IsBroken)
                    {
                        brokenComponent = component;
                        brokenPC = pc;
                        break;
                    }
                }
            }

            // Создать новую материнскую плату.
            ComputerComponent newMotherboard = new Motherboard("MN-99", Manufacturer.ASUS, 485, Socket.FM1, Chipset.Q150, MemoryType.DDR4, 4);

            // Заменить материнскую плату.
            technicalSpecialist.ReplaceComputerComponents(brokenPC, brokenComponent, newMotherboard);
            // Создать систему сборки металлолома.
            ScrapMetalCollectionSystem scrapMetalCollectionSystem = new ScrapMetalCollectionSystem();
            // Добавить сломанный компонент в металлолом.
            scrapMetalCollectionSystem.AddScrap(brokenComponent);
            // Сдать металлолом.
            scrapMetalCollectionSystem.PassScrap();

            // Создать список продуктов для магазина
            List<IProduct> products = new List<IProduct>();
            // Добавить в список все компьютеры из компьютерного класса.
            products.AddRange(computerClass.Computers);
            // Создать магазин.
            ComputerShop computerShop = new ComputerShop(products);
            // Создать покупателя.
            Customer customer = new Customer("Ivan", 25, "ул. Пушкина 24-1", 12000, 0);
            Customer customer2 = new Customer("Boris", 35, "ул. Есенина 33-22", 1000, 0);

            //Продать первому покупателю 5 компьютеров.
            for (int i = 0; i < products.Count; i++)
            {
                // Если продажа прошла успешно, то удалить продукт в магазине и добавить в список покупок у покупателя.
                if (computerShop.SaleProduct(products[i], customer))
                    products.RemoveAt(i);
            }

            //Продать второму покупателю 2 компьютера.
            for (int i = 0; i < 2; i++)
            {
                // Если продажа прошла успешно, то удалить продукт в магазине и добавить в список покупок у покупателя.
                if (computerShop.SaleProduct(products[i], customer))
                    products.RemoveAt(i);
            }

            Console.ReadKey();
        }
    }
}