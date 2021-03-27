using System;

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
            Vehicle boing737 = new Plane(23.5, 4);
            //Console.WriteLine(boing737.);
        }
    }

    class Vehicle
    {
        public string Сoordinates { get; set; }
        

    }

    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int Count { get; set; }

        public Plane(double height, int count)
        {
            this.Height = height;
            this.Count = count;
        }
    }
    
    class Car : Vehicle
    {
        public int Power { get; set; }
        public int CountDoors { get; set; }

        public Car(int power, int countDoors)
        {
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
