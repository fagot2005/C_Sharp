using System;
using System.Collections.Generic;


namespace Person_And_BankAccaunt
{
    class Program
    {
        List<Person> persons = new List<Person>();
        List<BankAccaunt> bankAccaunts = new List<BankAccaunt>();


        static void Main(string[] args)
        {
            Program program = new Program();
            program.MenyStepOne();

            Console.ReadKey();
        }

        public void AddNewPerson()
        {
            string idPerson, namePerson, gengerPerson;
            byte agePersone;
            Console.WriteLine("Enter ID new Person");
            idPerson = Console.ReadLine();
            Console.WriteLine("Enter Name new Person");
            namePerson = Console.ReadLine();
            Console.WriteLine("Enter gender new Person");
            gengerPerson = Console.ReadLine();
            Console.WriteLine("Enter age new Person");
            agePersone = byte.Parse(Console.ReadLine());
            if (FoundElementPersonById(idPerson))
            {
                persons.Add(new Person(idPerson, namePerson, gengerPerson, agePersone));
                Console.WriteLine("New Person with ID {0}, Name {1}, gender {2} and age {3} add sussesfull", idPerson, namePerson, gengerPerson, agePersone);
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            }
            MenyStepTwoPerson();
        }

        public bool FoundElementPersonById(string id)
        {
            bool resaltOfFoundElement = true;
            foreach (Person element in persons)
            {
                if (String.Equals(element.id, id))
                {
                    resaltOfFoundElement = false;
                    Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.id, element.name, element.gender, element.age);
                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                    MenyStepTwoPerson();

                    break;
                }
            }
            return resaltOfFoundElement;
        }

        public bool FoundElementPersonByName(string name)
        {
            bool resaltOfFoundElement = true;
            foreach (Person element in persons)
            {
                if (String.Equals(element.name, name))
                    resaltOfFoundElement = false;
                Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.id, element.name, element.gender, element.age);
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                MenyStepTwoPerson();
                break;
            }
            return resaltOfFoundElement;
        }

        public void MenyStepOne()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с нужным объектом:");
            Console.WriteLine("1- Работа с клиентами, 2- Работа со счетами клиентов");
            string firstStepMeny = Console.ReadLine();
            switch (firstStepMeny)
            {
                case "1":
                    MenyStepTwoPerson();
                    break;
                case "2":
                    MenyStepTwoBankAccaunt();
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1 или вариант 2");
                    break;
            }
        }

        public void MenyStepTwoPerson()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с клиентами:");
            Console.WriteLine("1- Добавление нового клиента, 2- Поиск клиента по ID, 3- Поиск клиента по имени, 4- Возврат в предыдущее меню");
            string twoStepMenyPerson = Console.ReadLine();
            //if (String.Equals(twoStepMenyPerson, "1"))
            switch (twoStepMenyPerson)
            {
                case "1":
                    AddNewPerson();
                    break;
                case "2":
                    Console.WriteLine("Введите ID клиента");
                    string personID = Console.ReadLine();
                    FoundElementPersonById(personID);
                    break;
                case "3":
                    Console.WriteLine("Введите имя клиента");
                    string personName = Console.ReadLine();
                    FoundElementPersonByName(personName);
                    break;
                case "4":
                    MenyStepOne();
                    break;
                default:
                    Console.WriteLine("Следует выбрать вариат 1, 2, 3 или 4");
                    break;
            }
        }

        public void MenyStepTwoBankAccaunt()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню для работы с банковскими счетами клиентов:");
            Console.WriteLine("1- Добавление нового счета клиента, 2- Поиск счета по имени, 3- Поиск счета по ID, 4- Увеличение остатка по счету, 5- Уменьшение остатка по счетускаРабота со счетами клиентов");
            string firstStepMeny = Console.ReadLine();
            //if (String.Equals(firstStepMeny, "1"))
        }
    }
}