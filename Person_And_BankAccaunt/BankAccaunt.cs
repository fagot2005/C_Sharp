using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccaunt
{
    public class BankAccaunt
    {
        public string id;
        public Person person;
        public string carency;
        public double Balans;

        public BankAccaunt(string Id, Person Persons, string Carency, double Balans)
        {
            this.id = Id;
            this.person = Persons;
            this.carency = Carency;
            this.Balans = Balans;
        }
    }
}
