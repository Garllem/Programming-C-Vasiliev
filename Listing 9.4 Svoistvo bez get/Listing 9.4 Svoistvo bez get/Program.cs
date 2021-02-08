using System;

namespace Listing_9._4_Svoistvo_bez_get
{
    //Класс со свойством
    class MyClass
    {
        //Закрытое текстовое поле
        private string code;
        //Конструктор с одним аргументом
        public MyClass(uint n)
        {
            //Присваивание значения свойству
            number = n;
        }
        //Переопределение метода ToString
        public override string ToString()
        {
            return code; //Результат метода
        }
        //Свойство без get аксессора
        public uint number
        {
            //Метод вызывается при присваивании значения свойству
            set
            {
                //Локальная переменная
                uint num = value;
                //Начальное значение текстового поля
                code = "";
                //Вычисление битов числа
                do
                {
                    //Значение последнего младшего бита дописывается слева к тексту
                    code = (num % 2) + code;
                    //Сдвиг кода числа на одну позицию вправо
                    num >>= 1;
                } while (num != 0);
            }
        }
    }
    class WiyhoutGetDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(5);
            //Бинарный код целого числа
            Console.WriteLine("Бинарный код числа 5:\t"+obj);
            //Присваивание значения свойству
            obj.number = 45;
            //Бинарный код целого числа
            Console.WriteLine("Бинарный код числа 45:\t" + obj);
        }
    }
}
