using System;

namespace Listing_9._10_Idexator_bez_get
{
    //Класс с индексатором
    class MyString
    {
        //Закрытое текстовое поле
        private string text;
        //Конструктор с текстовым аргументом
        public MyString (string t)
        {
            text = t;
        }
        //Операторный метод для неявного преобразования
        //текстового значения в объект класса MyString
        public static implicit operator MyString(string t)
        {
            return new MyString(t);
        }
        //Переопределение метода ToString
        public override string ToString()
        {
            return text;
        }
        //Символьный индексар с целочисленным индексом
        public char this[int k]
        {
            //Присваивание
            set
            {
                //Проверка значения индекса
                if (k < 0 || k >= text.Length) return;
                //Текстовая переменная
                string t = "";
                //Добавление символов к тексту
                for(int i=0;i<k;i++)
                {
                    t += text[i];
                }
                //Добавление в текст присваиваемого символа
                t += value;
                //Добавление символов к тексту
                for(int i=k+1;i<text.Length;i++)
                {
                    t += text[i];
                }
                //Новое значение текстового поля
                text = t;
            }
        }
    }
    class WithoutGetIndexerDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyString txt = "Муха";
            //Проверка текста
            Console.WriteLine(txt);
            //Попытка изменить символ в тексте
            txt[-1] = 'Ы';
            //Проверка текста
            Console.WriteLine(txt);
            //Попытка изменить символ в тексте
            txt[4] = 'Ъ';
            //Проверка текста
            Console.WriteLine(txt);
            //Изменение символа в тексте
            txt[0] = 'C';
            //Проверка текста
            Console.WriteLine(txt);
            //Изменение символа в тексте
            txt[1] = 'л';
            //Проверка текста
            Console.WriteLine(txt);
            txt[2] = 'о';
            //Проверка текста
            Console.WriteLine(txt);
            txt[3] = 'н';
            //Проверка текста
            Console.WriteLine(txt);
        }
    }
}
