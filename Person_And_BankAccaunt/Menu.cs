using System;
using System.Collections.Generic;

namespace Person_And_BankAccount
{
    class Menu
    {
        PersonsService personsService = new PersonsService();
        public void MenuStepOne()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с нужным объектом:");
            Console.WriteLine("1- Работа с клиентами, 2- Работа со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            switch (firstStepMenu)
            {
                case "1":
                    MenuStepTwoPerson();
                    break;
                case "2":
                    MenuStepTwoBankAccount();
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1 или вариант 2");
                    break;
            }
        }

        public void MenuStepTwoPerson()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с клиентами:");
            Console.WriteLine("1- Добавление нового клиента, 2- Поиск клиента по ID, 3- Поиск клиента по имени, 4- Возврат в предыдущее меню");
            string twoStepMenuPerson = Console.ReadLine();
            switch (twoStepMenuPerson)
            {
                case "1":
                    personsService.AddNewPerson();
                    break;
                case "2":
                    Console.WriteLine("Введите ID клиента");
                    string personID = Console.ReadLine();
                    personsService.FoundElementPersonById(personID);
                    break;
                case "3":
                    Console.WriteLine("Введите имя клиента");
                    string personName = Console.ReadLine();
                    personsService.FoundElementPersonByName(personName);
                    break;
                case "4":
                    MenuStepOne();
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1, 2, 3 или 4");
                    break;
            }
        }
                public void MenuStepTwoBankAccount()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1- Добавление нового счета клиента, 2- Поиск счета по имени, 3- Поиск счета по ID, 4- Увеличение остатка по счету, 5- Уменьшение остатка по счетускаРабота со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            //if (String.Equals(firstStepMenu, "1"))
        }
    }
}
