using System;

namespace Test_String
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                string str = Console.ReadLine();
                Console.WriteLine("С клавиатуры введено {0}", str);
                Console.WriteLine("");
                Console.WriteLine("Продолжить? 1-Да, 0-Нет");
                string answear = Console.ReadLine();
                if ( String.Equals(answear, "0"))
                    cont = false;
            }

        }
    }
}
