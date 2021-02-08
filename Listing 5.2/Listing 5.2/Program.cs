﻿using System;

namespace Listing_5._2
{
    class OwerloadMethDemo
    {
        //Версия статического метода для отображения текста
        //(с тестовым аргументом):
        static void show (string txt)
        {
            Console.WriteLine("Текст: " + txt);
        }

        //Версия статического метода для отображения
        //целого числа (аргумент метода):
        static void show(int num)
        {
            Console.WriteLine("Целое число: " + num);
        }
        //Версия статического метода для отображения
        //действительного числа (аргумент метода):
        static void show(double num)
        {
            Console.WriteLine("Действительное число: " + num);
        }
        //Версия статического метода для отображения
        //символа (аргумент метода):
        static void show(char s)
        {
            Console.WriteLine("Символ: " + s);
        }
        //Версия статического метода для отображения
        //числа (первый аргумент) и символа (второй аргумент):
        static void show(int num, char s)
        {
            Console.WriteLine("Аргументы {0} и {1}",num, s);
        }
        //Главный метод программы
        static void Main(string[] args)
        {
            //Целочисленная переменная:
            int num = 5;
            //Действительная числовая переменная
            double z = 12.5;
            //Симвоьная переменная
            char symb = 'W';
            //Вызываем метод с символьным аргументом
            show(symb);
            //Вызываем метод с текстовым аргументом
            show("Знакомимся с перегрузкой методов");
            //Вызываем метод с целочисленным аргументом:
            show(num);
            //Вызываем метод с действительным аргументом
            show(z);
            //Вызываем метод с двумя аргументами
            show(num, 'Q');
        }
    }
}
