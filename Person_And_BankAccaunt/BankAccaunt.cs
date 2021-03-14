using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccaunt
{
    class BankAccaunt
    {
        public string Id;
        public Person Persons;
        public string Carency;
        public double Balans;

        public BankAccaunt(string Id, Person Persons, string Carency, double Balans)
        {
            this.Id = Id;
            this.Persons = Persons;
            this.Carency = Carency;
            this.Balans = Balans;
        }
    }
}
