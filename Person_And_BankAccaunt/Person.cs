using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccaunt
{
    public class Person
    {
        public Person(string id, string name, string gender, byte age)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public string id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public byte age { get; set; } 
    }
}
