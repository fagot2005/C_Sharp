using System;

namespace Person_And_BankAccount
{
    class Menu
    {

        public void MenuStepOne(PersonsService ps, BankAccountService bac)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с нужным объектом:");
            Console.WriteLine("1- Работа с клиентами, 2- Работа со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            switch (firstStepMenu)
            {
                case "1":
                    MenuStepTwoPerson(ps, bac);
                    break;
                case "2":
                    MenuStepTwoBankAccount(ps, bac);
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1 или вариант 2");
                    break;
            }
        }

        public void MenuStepTwoPerson(PersonsService ps, BankAccountService bac)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с клиентами:");
            Console.WriteLine("1- Добавление нового клиента, 2- Поиск клиента по ID, 3- Поиск клиента по имени, 4- Возврат в предыдущее меню");
            string twoStepMenuPerson = Console.ReadLine();
            switch (twoStepMenuPerson)
            {
                case "1":
                    ps.AddNewPerson();
                    MenuStepTwoPerson(ps, bac);
                    break;
                case "2":
                    Console.WriteLine("Введите ID клиента");
                    string personID = Console.ReadLine();
                    ps.FoundElementPersonById(personID);
                    MenuStepTwoPerson(ps, bac);
                    break;
                case "3":
                    Console.WriteLine("Введите имя клиента");
                    string personName = Console.ReadLine();
                    ps.FoundElementPersonByName(personName);
                    MenuStepTwoPerson(ps, bac);
                    break;
                case "4":
                    MenuStepOne(ps, bac);
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1, 2, 3 или 4");
                    break;
            }
        }
        public void MenuStepTwoBankAccount(PersonsService ps, BankAccountService bac)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1- Добавление нового счета клиента, 2- Поиск счета по имени, 3- Поиск счета по ID, 4- Увеличение остатка по счету, 5- Уменьшение остатка по счетускаРабота со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            //if (String.Equals(firstStepMenu, "1"))
        }
    }
}
