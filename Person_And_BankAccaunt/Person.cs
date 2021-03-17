using System;
using System.Collections.Generic;
using System.Text;

namespace Person_And_BankAccount
{
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public byte Age { get; set; }
        public Person(string id, string name, string gender, byte age)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }
}
