using System;

namespace Listing_9._9_Indexator_bez_set
{
    //Класс с индексатором
    class MyClass
    {
        //Закрытое целочисленно поле
        private int number;
        //Конструктор с одним аргументом
         public MyClass(int n)
        {
            //Присваивание значения полю
            number = n;
        }
        //Целочисленный индексатор с целочисленным индексом
        public int this[int k]
        {
            //Считывание
            get
            {
                //Целочисленная переменная
                int n = number;
                //отбрасывание цифр из млпдших рядов
                for(int i=0;i<k;i++)
                {
                    n /= 10;
                }
                //Значение свойства
                return n % 10;
            }

        }
    }
    class WithoutSetIndexerDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(12345);
            //Цифры в десятичном представлении числа
            for(int k=0;k<9;k++)
            {
                Console.Write(" | "+obj[k]);
            }
            Console.WriteLine(" |");
        }
    }
}
