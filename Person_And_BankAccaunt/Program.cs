using System;

namespace Person_And_BankAccount
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonsService ps = new PersonsService();
            BankAccountService bac = new BankAccountService();
            Menu menu = new Menu();
            menu.MenuStepOne(ps, bac);
            Console.ReadKey();
        }
    }
}