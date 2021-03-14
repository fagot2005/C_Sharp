using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccaunt
{
    public class Person
    {
        public Person(string id, string name, string gender, byte age)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Age = age;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; } 
    }
}
