using System;

namespace Listing_6._6_Static_polya_i_method
{
    //Класс со статическим полем и методом
    class MyClass
    {
        //Статическое поле
        public static int code = 100;
        //Статический метод
        public static void show()
        {
            Console.WriteLine("Статическое поле: "+code);
        }
    }
    //Класс с главным методом
    class StaticDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Вызов статического метода
            MyClass.show();
            //Обращение к статическому полю
            MyClass.code = 200;
            //Вызов статического метода
            MyClass.show();

        }
    }
}
