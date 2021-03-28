using System;
using System.Collections.Generic;

namespace Vehicle
{

//    Задание 3 
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:  
//Создать класс Vehicle.
//В теле класса создайте поля:  координаты и параметры средств передвижения (цена, скорость, год выпуска).  
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.  
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.


    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            //Console.WriteLine("Hi");
            Vehicle boing737 = new Plane("34434", 23.3, 4);
            Vehicle porshe = new Car("842342", 200, 2);
            list.Add(boing737);
            list.Add(porshe);
            //boing737.Сoordinates = ;
            //Console.WriteLine(boing737.Сoordinates);
            foreach(Vehicle element in list)
            {
                //if(element.GetType = Vehicle.P)
                Plane plane = (Plane)element;
                Console.WriteLine(plane.Сoordinates, plane.Height, plane.Count);
            }
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public string Сoordinates { get; set; }
        //public Vehicle Vehicle { get; set; }
        
     }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int Count { get; set; }

        public Plane( string coordinate, double height, int count)
        {
            this.Сoordinates = coordinate;
            this.Height = height;
            this.Count = count;
        }
    }
    
    class Car : Vehicle
    {
        public int Power { get; set; }
        public int CountDoors { get; set; }

        public Car(string coordinate, int power, int countDoors)
        {
            this.Сoordinates = coordinate;
            this.Power = power;
            this.CountDoors = countDoors;
        }

    }

    class Ship : Vehicle
    {
        public int CountPassanger { get; set; }
        public string Port { get; set; }
    }
}
