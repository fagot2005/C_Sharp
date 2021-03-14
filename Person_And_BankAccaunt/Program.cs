using System;
using System.Collections.Generic;


namespace Person_And_BankAccaunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //MenyStepOne();
            List<Person> persons = new List<Person>();
            List<BankAccaunt> bankAccaunts = new List<BankAccaunt>();
            persons.Add(new Person("123", "Vasil", "man", 46));
            bankAccaunts.Add(new BankAccaunt("2600", persons.Find(x=>String.Equals(x.Id, "123")), "USD", 1500));


            //Person person1 = new Person);
            //BankAccaunt acc1 = new BankAccaunt("2600", person1, "usd", 1000);
            //BankAccaunt acc2 = new BankAccaunt("2620", person1, "eur", 3500);

            //Console.WriteLine($"{person1.Name}  {person1.Age}");
            Console.ReadKey();
        }

        static void MenyStepOne()
        {
            Console.WriteLine("Выберите пункт меню для работы с нужным объектом:");
            Console.WriteLine("1- Работа с клиентами, 2- Работа со счетами клиентов");
            string firstStepMeny = Console.ReadLine();
            if (String.Equals(firstStepMeny, "1"))
                MenyStepTwoPerson();
            else MenyStepTwoBankAccaunt();
        }

        private static void MenyStepTwoBankAccaunt()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с клиентами:");
            Console.WriteLine("1- Добалвние нового клиента, 2- Поиск клиента по ID, 3- Поиск клиента по имени, 4- Возврат в предыдущее меню");
            string twoStepMenyPerson = Console.ReadLine();
            //if (String.Equals(twoStepMenyPerson, "1"))
        }

        private static void MenyStepTwoPerson()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1- Добавление нового счета клиента, 2- Поиск счета по имени, 3- Поиск счета по ID, 4- Увеличение остатка по счету, 5- Уменьшение остскаРабота со счетами клиентов");
            string firstStepMeny = Console.ReadLine();
            //if (String.Equals(firstStepMeny, "1"))
        }
    }
}