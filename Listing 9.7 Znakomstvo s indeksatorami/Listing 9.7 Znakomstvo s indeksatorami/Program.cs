﻿using System;

namespace Listing_9._7_Znakomstvo_s_indeksatorami
{
    //Класс с индексатором
    class MyClass
    {
        //Закрытое поле, являющееся ссылкой на массив
        private int[] nums;
        //Конструктор с целочисленным аргументом
        public MyClass(int n)
        {
            //Создание массива
            nums = new int[n];
            //Заполнение массива
            for(int k=0; k<nums.Length; k++)
            {
                nums[k] = 0;
            }
        }
        //Переопределение метода ToString
        public override string ToString()
        {
            //Формирование текстовой строки
            string txt = "{" + nums[0];
            for(int k=1; k<nums.Length;k++)
            {
                txt += "," + nums[k];
            }
            txt += "}";
            //Результат метода
            return txt;
        }
        //Целочисленное свойство
        public int length
        {
            //Метод вызывается при считывании значения свойства
            get
            {
                //Значение свойства
                return nums.Length;
            }
        }
        //Целочисленный индексатор с целочисленным индексом
        public int this[int k]
        {
            //Метод вызывается при считывании значения объекта с индексом
            get
            {
                //Значение выражения
                return nums[k];
            }
            //Метод вызывается при присваивании значения объекту с индексом
            set
            {
                //Присваивание значения элементу массива
                nums[k] = value;
            }
        }
    }
    class UsingIndexerDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(5);
            //Отображение содержимого массива из объекта
            Console.WriteLine(obj);
            //Присваивание значений элементам массива из объекта с использованием индексирования объекта
            for(int k=0; k<obj.length;k++)
            {
                obj[k] = 2 * k + 1;
            }
            //Отображение содержимого массива из объекта
            Console.WriteLine(obj);
            //Поэлиментное отображение массива из объекта с использованием индексирования объекта
            for (int k = 0; k < obj.length; k++)
            {
                //Используется индексирование объекта
                Console.Write(" "+obj[k]);
            }
            Console.WriteLine();
        }
    }
}
