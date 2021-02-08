using System;

namespace Listing_6._8_Kluchevoe_slovo_this
{
    //Класс
    class MyClass
    {
        //Закрытое целочисленное поле
        private int code;
        //Открытый метод
        public int get()
        {
            //Использовано ключевое слово this
            return this.code;
        }
        //Открытый метод
        public void set(int code)
        {
            //Использовано ключевое слово this
            this.code = code;
        }
        //Конструктор
        public MyClass(int code)
        {
            //Использовано ключевое слово this
            this.code = code;
            //Использовано ключевое слово this
            Console.WriteLine("Создан объект: "+this.get());
        }
    }
    //Класс с главным методом
    class UsingThisDemo
    {
        static void Main(string[] args)
        {
            //Создание объетта
            MyClass obj = new MyClass(100);
            //Присваивание значения полю
            obj.set(200);
            //Проверка значений поля
            Console.WriteLine("Новое значение: "+obj.get());
        }
    }
}
