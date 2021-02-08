using System;

namespace Listing_9._12_Dvumernie_indeksatory
{
    //Класс с двумерным индексатором
    class MyClass
    {
        //Закрытое поле, являющееся ссылкой на двумерный символьный массив
        private char[,] symbs;
        //Конструктор с двумя аргументами
        public MyClass(int a, int b)
        {
            //Слздание двумерного массива
            symbs = new char[a, b];
            //Перебор строк массива
            for(int i=0; i<symbs.GetLength(0);i++)
            {
                //Перебор строк массива
                for(int j=0;j<symbs.GetLength(1);j++)
                {
                    symbs[i, j] = 'O';//Значение элемента массива
                }
            }
        }
        //Метод для отображения содержимого массива
        public void show()
        {
            Console.WriteLine("Двумерный массив:");
            //Перебор строк массива
            for(int i=0;i<symbs.GetLength(0);i++)
            {
                //Перебор столбцов массива
                for(int j=0; j<symbs.GetLength(1); j++)
                {
                    //Отображение значения элемента
                    Console.Write(symbs[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        //Двумерный индексатор
        public char this[int i, int j]
        {
            //Считывание
            get
            {
                //Результат
                return symbs[i, j];
            }
            //Присвоение
            set
            {
                //Значение элемента массива
                symbs[i, j] = value;
            }
        }
    }
    class TwoDimIndexerDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass(2, 3);
            //Проверка содержимого массива
            obj.show();
            //Индексирование объекта
            obj[0, 0] = 'A';
            obj[1, 2] = 'Z';
            //Проверка содержимого массива
            obj.show();
            Console.WriteLine("Проверка:");
            //Индексирование объекта 
            Console.WriteLine("obj[0,0]={0}",obj[0,0]);
            Console.WriteLine("obj[1,1]={0}", obj[1, 1]);
            Console.WriteLine("obj[1,2]={0}", obj[1, 2]);
        }
    }
}
