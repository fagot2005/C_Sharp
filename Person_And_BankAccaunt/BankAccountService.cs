using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    class BankAccountService
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();

        public void AddNewBankAccount(Person person)
        {
            string id;
            Carency carency;
            double balans = 0;
            Console.WriteLine("Enner ID Bank Account");
            id = Console.ReadLine();
            //Console.WriteLine("Enter Carency Bank Account");
            carency = CorectInputCarency();
            if (person != null)
            {
                bankAccounts.Add(new BankAccount(id, person, carency, balans));
                Console.WriteLine("Bank Account {0} client {1} carency {2} with balans {3} add sussesful", id, person.Name, carency, balans);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Bank Account {0} is not add. Client isn't found.", id);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
        }

        public void TopUpAmount(string bankAccountId, double topUpAmount)
        {
            BankAccount bankAccount = FindBankAccountById(bankAccountId);
            if (bankAccount != null)
            {
                Console.WriteLine("Balans bank account {0} changed  sussesful. Current balans is {1} {2}", bankAccount.Id, bankAccount.Balans += topUpAmount, bankAccount.Carency);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Balans not changed. This  bank account {0} not found", bankAccountId);
                Console.WriteLine("Please, press any key to continue.");
                Console.ReadKey();
            }
        }

        public BankAccount FindBankAccountById(string bankAccountId)
        {
            BankAccount bankAccount = null;
            foreach (BankAccount element in bankAccounts)
            {
                if (String.Equals(bankAccountId, element.Id))
                {
                    bankAccount = element;
                    Console.WriteLine("Bank account with Id {0} find already in the system.");
                    Console.WriteLine("Please, press any key to continue.");
                    Console.ReadKey();
                }
            }
            return bankAccount;
        }

        public void OutputAllPersonsAndAllBankAccounts()
        {
            foreach (BankAccount element in bankAccounts)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", element.Person.Id, element.Person.Name, element.Person.Gender, element.Person.Age, element.Id, element.Carency, element.Balans);
            }
            Console.WriteLine("Please, press any key to continue.");
            Console.ReadKey();
        }

        public void AddAllBankAccountc(Person person)
        {
            bankAccounts.Add(new BankAccount("260034", person, Carency.UAH, 2500));
            bankAccounts.Add(new BankAccount("260099", person, Carency.EUR, 3500));
        }

        public Carency CorectInputCarency()
        {
            Carency corectCarency = 0;
            bool corectInput = true;
            while (corectInput)
            {
                Console.WriteLine("Enter сarency new Bank Account, USD - 840, EUR = 978, UAH = 980");
                string digitСarency = Console.ReadLine();
                if (String.Equals(digitСarency, "840") | String.Equals(digitСarency, "978") | String.Equals(digitСarency, "980"))
                {
                    corectCarency = (Carency)int.Parse(digitСarency);
                    corectInput = false;
                }
                else
                {
                    Console.WriteLine("You need enter only 840, 978 or 980. Please press any key and try again.");
                    Console.ReadKey();
                }
            }
            return corectCarency;
        }
    }
}