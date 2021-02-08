using System;

namespace Listing_7._5_Vstavka_i_zameshenie_txt
{
    class ReplaceStringDemo
    {
        static void Main(string[] args)
        {
            //Исходный текст
            String txt = "Мы изучаем C#";
            //Проверка исходного текста
            Console.WriteLine(txt);
            //Текстовая переменная
            String str;
            //Вставка слова в текст
            str = txt.Insert(11, "язык ");
            //Проверка текста
            Console.WriteLine(str);
            //Вставка текста слова  с пследующим замещением другого текстового блока
            str = str.Insert(3, "не ").Replace("C#", "Java");
            //Проверка текста
            Console.WriteLine(str);
            //Замена пробелов на подчеркивания
            str = str.Replace(' ', '_');
            //Проверка текста
            Console.WriteLine(str);
            //Извлечение подстроки
            str = str.Substring(2, 12);
            //Проверка текста
            Console.WriteLine(str);
            //Извлечение подстроки
            str = txt.Substring(3);
            //Проверка текста
            Console.WriteLine(str);
            //Проверка исходного текста
            Console.WriteLine(txt);
        }
    }
}
