using System;

namespace Listing_10._3_Konstruktor_proizvodnogo_klassa
{
    //Базовый класс
    class Alpha
    {
        //Целочисленное поле
        public int code;
        //Конструктор с одним аргументом
        public Alpha(int n)
        {
            code = n;
            Console.WriteLine("Alpha (один аргумент): {0}", code);
        }
        //Конструктор без аргументов
        public Alpha()
        {
            code = 123;
            Console.WriteLine("Alpha (без аргументов): {0}", code);
        }
    }
    //Производный класс
    class Bravo: Alpha
    {
        //Символьное поле
        public char symb;
        //Конструктор с двумя аргументами
        public Bravo(int n, char s): base(n)
        {
            symb = s;
            Console.WriteLine("Bravo (два аргумента): {0} и \'{1}\'", code,symb);
        }
        //Конструктор с целочисленным аргументом
        public Bravo(int n): base(n)
        {
            symb = 'A';
            Console.WriteLine("Bravo (int-аргумент): {0} и \'{1}\'", code, symb);
        }
        //Конструктор с символьным аргументом
        public Bravo(char s): base(321)
        {
            symb = s;
            Console.WriteLine("Bravo (char-аргумент): {0} и \'{1}\'", code, symb);
        }
        //Конструктор без аргументов
        public Bravo(): base()
        {
            symb = 'O';
            Console.WriteLine("Bravo (без аргументов): {0} и \'{1}\'", code, symb);
        }
    }
    class InheritAndConstrDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта базового класса
            //(конструктор без аргументов)
            Alpha A1 = new Alpha();
            Console.WriteLine();
            //Создание объекта базового класса
            //(конструктор c одним аргументом)
            Alpha A2 = new Alpha(100);
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор c двумя аргументами)
            Bravo B1 = new Bravo(200, 'B');
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор c целочисленным аргументом)
            Bravo B2 = new Bravo(300);
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор c символьным аргументом)
            Bravo B3 = new Bravo('C');
            Console.WriteLine();
            //Создание объекта производного класса
            //(конструктор без аргументов)
            Bravo B4 = new Bravo();

        }
    }
}
