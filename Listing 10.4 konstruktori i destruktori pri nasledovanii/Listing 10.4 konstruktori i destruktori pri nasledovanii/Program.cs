using System;

namespace Listing_10._4_konstruktori_i_destruktori_pri_nasledovanii
{
    //Базовый класс
    class Alpha
    {
        //Конструктор
        public Alpha()
        {
            Console.WriteLine("Конструктор класса Alpha");
        }
        //Деструктор
        ~Alpha()
        {
            Console.WriteLine("Деструктор класса Alpha");
        }
    }
    //Производный класс от Alpha
    class Bravo: Alpha
    {
        //Конструктор
        public Bravo(): base()
        {
            Console.WriteLine("Конструктор класса Bravo");
        }
        //Деструктор
        ~Bravo()
        {
            Console.WriteLine("Деструктор класса Bravo");
        }
    }
    //Производный класс от Bravo
    class Charlie: Bravo
    {
        //Конструктор
        public Charlie(): base()
        {
            Console.WriteLine("Конструктор класса Charlie");
        }
        //Деструктор
        ~Charlie()
        {
            Console.WriteLine("Деструктор класса Charlie");
        }
    }
    class InheritConstrDestrDemo
    {
        static void Main(string[] args)
        {
            //Создание анонимного объекта:
            new Charlie();
        }
    }
}
