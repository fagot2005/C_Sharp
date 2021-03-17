using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    public class BankAccount
    {
        public string Id { get; set; }
        public Person Person { get; set; }
        public string Carency { get; set; }
        public double Balans { get; set; }

        public BankAccount(string id, Person persons, string carency, double balans)
        {
            this.Id = id;
            this.Person = persons;
            this.Carency = carency;
            this.Balans = balans;
        }
    }
}
