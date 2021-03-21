﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    public class BankAccount
    {
        public string Id { get; set; }
        public Person Person { get; set; }
        public Carency Carency { get; set; }
        public double Balans { get; set; }

        public BankAccount(string id, Person persons, Carency carency, double balans)
        {
            this.Id = id;
            this.Person = persons;
            this.Carency = carency;
            this.Balans = balans;
        }
    }
    
    public enum Carency
        {
            USD = 840,
            EUR = 978,
            UAH = 980
        }
}
