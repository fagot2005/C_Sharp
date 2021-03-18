﻿using System;
using System.Collections.Generic;

namespace Person_And_BankAccount
{
    class Program
    {
        //List<Person> persons = new List<Person>();
        List<BankAccount> bankAccounts = new List<BankAccount>();
        

        static void Main(string[] args)
        {
            //Menu menu = new Menu();
            //Program pr = new Program();
            PersonsService ps = new PersonsService();
            MenuStepOne(ps);
            Console.ReadKey();
        }

        //public void AddNewPerson()
        //{
        //    string idPerson, namePerson;
        //    Gender gengerPerson;
        //    byte agePersone;
        //    Console.WriteLine("Enter ID new Person");
        //    idPerson = Console.ReadLine();
        //    Console.WriteLine("Enter Name new Person");
        //    namePerson = Console.ReadLine();
        //    //Console.WriteLine("Enter gender new Person");
        //    gengerPerson = CorectInputGender();
        //    //gengerPerson = Console.ReadLine();
        //    Console.WriteLine("Enter age new Person");
        //    agePersone = byte.Parse(Console.ReadLine());
        //    if (FoundElementPersonById(idPerson))
        //    {
        //        persons.Add(new Person(idPerson, namePerson, gengerPerson, agePersone));
        //        Console.WriteLine("New Person with ID {0}, Name {1}, gender {2} and age {3} add sussesfull", idPerson, namePerson, gengerPerson, agePersone);
        //        Console.WriteLine("Для продолжения нажмите любую клавишу");
        //        Console.ReadKey();
        //    }
        //    MenuStepTwoPerson();
        //}

        //public bool FoundElementPersonById(string id)
        //{
        //    bool resaltOfFoundElement = true;
        //    foreach (Person element in persons)
        //    {
        //        if (String.Equals(element.Id, id))
        //        {
        //            resaltOfFoundElement = false;
        //            Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
        //            Console.WriteLine("Для продолжения нажмите любую клавишу");
        //            Console.ReadKey();
        //            MenuStepTwoPerson();
        //            break;
        //        }
        //    }
        //    return resaltOfFoundElement;
        //}

        //public bool FoundElementPersonByName(string name)
        //{
        //    bool resaltOfFoundElement = true;
        //    foreach (Person element in persons)
        //    {
        //        if (String.Equals(element.Name, name))
        //            resaltOfFoundElement = false;
        //        Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
        //        Console.WriteLine("Для продолжения нажмите любую клавишу");
        //        Console.ReadKey();
        //        MenuStepTwoPerson();
        //        break;
        //    }
        //    return resaltOfFoundElement;
        //}

        static void MenuStepOne(PersonsService ps)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с нужным объектом:");
            Console.WriteLine("1- Работа с клиентами, 2- Работа со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            switch (firstStepMenu)
            {
                case "1":
                    MenuStepTwoPerson(ps);
                    break;
                case "2":
                    MenuStepTwoBankAccount(ps);
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1 или вариант 2");
                    break;
            }
        }

        static void MenuStepTwoPerson(PersonsService ps)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с клиентами:");
            Console.WriteLine("1- Добавление нового клиента, 2- Поиск клиента по ID, 3- Поиск клиента по имени, 4- Возврат в предыдущее меню");
            string twoStepMenuPerson = Console.ReadLine();
            switch (twoStepMenuPerson)
            {
                case "1":
                    ps.AddNewPerson();
                    MenuStepTwoPerson(ps);
                    break;
                case "2":
                    Console.WriteLine("Введите ID клиента");
                    string personID = Console.ReadLine();
                    ps.FoundElementPersonById(personID);
                    MenuStepTwoPerson(ps);
                    break;
                case "3":
                    Console.WriteLine("Введите имя клиента");
                    string personName = Console.ReadLine();
                    ps.FoundElementPersonByName(personName);
                    MenuStepTwoPerson(ps);
                    break;
                case "4":
                    MenuStepOne(ps);
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1, 2, 3 или 4");
                    break;
            }
        }

        public static void MenuStepTwoBankAccount(PersonsService ps)
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1- Добавление нового счета клиента, 2- Поиск счета по имени, 3- Поиск счета по ID, 4- Увеличение остатка по счету, 5- Уменьшение остатка по счетускаРабота со счетами клиентов");
            string firstStepMenu = Console.ReadLine();
            //if (String.Equals(firstStepMenu, "1"))
        }

        //public Gender CorectInputGender()
        //{
        //    Gender genderPerson = 0;
        //    bool corectInput = true;
        //    while (corectInput)
        //    {
        //        //Console.Clear();
        //        Console.WriteLine("Enter gender new Person, 0-Male, 1-Fimale");
        //        string digitGender = Console.ReadLine();
        //        if (String.Equals(digitGender, "0") | (String.Equals(digitGender, "1")))
        //        {
        //            genderPerson = (Gender)int.Parse(digitGender);
        //            corectInput = false;
        //            //Console.WriteLine(genderPerson);
        //        }
        //        else
        //        {
        //            Console.WriteLine("You need enter only 0 or 1. Please press any key and try again.");
        //            Console.ReadKey();
        //        }
        //    }
        //    return genderPerson;
        //}
    }
}