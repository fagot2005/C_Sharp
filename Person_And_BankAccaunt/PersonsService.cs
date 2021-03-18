using System;
using System.Collections.Generic;

namespace Person_And_BankAccount
{
    class PersonsService
    {
        //Program pr = new Program();
        //PersonsService ps = new PersonsService();
        List<Person> persons = new List<Person>();
        //Menu menu = new Menu();
        
        public void AddNewPerson()
        {
            string idPerson, namePerson;
            Gender gengerPerson;
            byte agePersone;
            Console.WriteLine("Enter ID new Person");
            idPerson = Console.ReadLine();
            Console.WriteLine("Enter Name new Person");
            namePerson = Console.ReadLine();
            //Console.WriteLine("Enter gender new Person");
            gengerPerson = CorectInputGender();
            //gengerPerson = Console.ReadLine();
            Console.WriteLine("Enter age new Person");
            agePersone = byte.Parse(Console.ReadLine());
            if (FoundElementPersonById(idPerson))
            {
                persons.Add(new Person(idPerson, namePerson, gengerPerson, agePersone));
                Console.WriteLine("New Person with ID {0}, Name {1}, gender {2} and age {3} add sussesfull", idPerson, namePerson, gengerPerson, agePersone);
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
            }
            //MenuStepTwoPerson();
        }

        public bool FoundElementPersonById(string id)
        {
            bool resaltOfFoundElement = true;
            foreach (Person element in persons)
            {
                if (String.Equals(element.Id, id))
                {
                    resaltOfFoundElement = false;
                    Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                    //MenuStepTwoPerson();
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
                if (String.Equals(element.Name, name))
                    resaltOfFoundElement = false;
                Console.WriteLine("Person with ID {0}, Name {1}, gender {2} and age {3} already in the system", element.Id, element.Name, element.Gender, element.Age);
                Console.WriteLine("Для продолжения нажмите любую клавишу");
                Console.ReadKey();
                //MenuStepTwoPerson();
                break;
            }
            return resaltOfFoundElement;
        }

        public Gender CorectInputGender()
        {
            Gender genderPerson = 0;
            bool corectInput = true;
            while (corectInput)
            {
                //Console.Clear();
                Console.WriteLine("Enter gender new Person, 0-Male, 1-Fimale");
                string digitGender = Console.ReadLine();
                if (String.Equals(digitGender, "0") | (String.Equals(digitGender, "1")))
                {
                    genderPerson = (Gender)int.Parse(digitGender);
                    corectInput = false;
                    //Console.WriteLine(genderPerson);
                }
                else
                {
                    Console.WriteLine("You need enter only 0 or 1. Please press any key and try again.");
                    Console.ReadKey();
                }
            }
            return genderPerson;
        }
    }
}
