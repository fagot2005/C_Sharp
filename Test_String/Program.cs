using System;

namespace Test_String
{
    class Program
    {

        public enum Gender
        {
            Male,
            Fimale
        }

        static void Main(string[] args)
        {
            Gender genderPerson;
            Console.WriteLine("Enter gender, 0-Male, 1-Fimale");


            bool corectInput = true;
            while (corectInput)
            {
                string digitGender = Console.ReadLine();
                genderPerson = (Gender)int.Parse(digitGender);
                Console.WriteLine(genderPerson);

            }

            
            //bool cont = true;
            //while (cont == true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine("С клавиатуры введено {0}", str);
            //    Console.WriteLine("");
            //    Console.WriteLine("Продолжить? 1-Да, 0-Нет");
            //    string answear = Console.ReadLine();
            //    if ( String.Equals(answear, "0"))
            //        cont = false;
            //}

        }
    }
}
