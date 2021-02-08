using System;

namespace Listing_9._8_Using_indexator
{
    //Класс с индексатором
    class MyClass
    {
        //Закрытое целочисленное поле
        private int code;
        //Конструктор с символьным аргументом
        public MyClass(char s)
        {
            //Присваивание значения полю
            code = s;
        }
        //Символьный индексатор с целочисленным индексом
        public char this[int k]
        {
            //Метод вызывается при считывании значения выражения с проиндексированным объектом
            get
            {
                //Значение свойства
                return (char)(code + k);
            }
            //Метод вызывается при присваивании значения выражению с проиндексированным объектом
            set
            {
                //Присваивание значения полю
                code = value - k;
            }
        }
    }
    class MoreIndexDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass('A');
            //Индексирование объекта для считывания значения
            for(int k=0;k<10;k++)
            {
                Console.Write(obj[k]+" ");
            }
            Console.WriteLine();
            //Присваивание значения выражению с индексированным объектом
            obj[5] = 'Q';
            //Индексирование объекта для считывания значения
            for(int k=0;k<10;k++)
            {
                Console.Write(obj[k] + " ");
            }
            Console.WriteLine();
            //Использование отрицательного индекса при индексировании объекта
            for(int k=0;k<10;k++)
            {
                Console.Write(obj[-k] + " ");
            }
            Console.WriteLine();
        }
    }
}
