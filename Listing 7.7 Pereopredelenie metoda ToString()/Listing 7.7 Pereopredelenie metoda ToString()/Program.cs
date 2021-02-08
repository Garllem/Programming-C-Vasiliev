using System;

namespace Listing_7._7_Pereopredelenie_metoda_ToString__
{
    //Класс с переопределением метода ToString()
    class MyClass
    {
        //Целочисленное поле
        public int num;
        //Символьное поле
        public char symb;
        //Конструктор
        public MyClass(int n, char s)
        {
            //присваивание значений полям
            num = n;
            symb = s;
            //Отображение сообщения о создании объекта
            //Неявно вызываем метод ToString()
            Console.WriteLine("Создан новый объект\n"+this);
        }
        //Переопределение метода ToString()
        public override String ToString()
        {
            //Локальная текстовая переменная
            String txt = "Числовое поле: " + num;
            txt += "\nСимвольное поле: " + symb;
            //Результат метода
            return txt;
        }
    }
    //Класс с главным методом программы
    class ToStringDemo
    {
        //Главный метод
        static void Main(string[] args)
        {
            //Создание нового объекта
            MyClass obj = new MyClass(100, 'А');
            //Новые значения полей объекта
            obj.num = 200;
            obj.symb = 'В';
            Console.WriteLine("Новые значения полей объекта");
            //Отображение значений полей объекта
            //Неявно вызывается метод ToString()
            Console.WriteLine(obj);
            //Разбивка текста с описанием объекта на подстроки
            //Метод ToString() вызывается в явном виде
            String[] str = obj.ToString().Split('\n');
            Console.WriteLine("Явный вызов метода ToString() ");
            //Отображеие подстрок, содержащих значения полей объекта
            for(int k=0;k<str.Length;k++)
            {
                Console.WriteLine("[* "+str[k]+" *]");
            }
        }
    }
}
