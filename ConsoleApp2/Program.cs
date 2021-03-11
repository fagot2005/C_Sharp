using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ligthArray = 1000;
            ArrayList list = new ArrayList();
            list.Add(1); list.Add(2); list.Add(3);
            for (int i = 5; i < ligthArray; i = i + 2)
            {
                bool emptyNumger = true;
                for (int j = 3; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        emptyNumger = false;
                        break;
                    }
                }
                if (emptyNumger)
                    list.Add(i);
            }
            foreach (object o in list)
            {
                int kwadrat = (int)o;
                Console.WriteLine(string.Format("{0} - {1}", o, kwadrat*kwadrat));
            }
            Console.ReadKey();
        }
    }
}
