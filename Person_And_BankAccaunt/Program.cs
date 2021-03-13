using System;

namespace Person_And_BankAccaunt
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            BankAccaunt bankAccaunt1 = new BankAccaunt();
            BankAccaunt bankAccaunt2 = new BankAccaunt();
            person1.id = "123";
            person1.Name = "Vasil";
            person1.age = 46;
            person1.gender = "man";
            bankAccaunt1.id = "2600";
            bankAccaunt1.persons = person1;
            bankAccaunt1.carency = "usd";
            bankAccaunt1.balans = 1000;
            bankAccaunt2.id = "2620";
            bankAccaunt2.persons = person1;
            bankAccaunt2.carency = "eur";
            bankAccaunt2.balans = 3500;

            Console.WriteLine("Hello World!");
        }
    }
}
