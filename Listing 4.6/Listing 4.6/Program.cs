using System;

namespace Listing_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Символьная переменная
            char s;
            //Исходный символьный массив
            char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };
            //Отображение содержимого массива
            Console.WriteLine("Массив до сортировки:");
            for(int k=0; k<symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
            }
            Console.WriteLine();
            //Сортировка элементов в массиве
            for (int i=1;i<symbs.Length;i++)
            {
                //Перебор элементов
                for (int j = 0; j < symbs.Length - i; j++)
                {
                    //Если знаачение элемента слева больше, значение элемента справа
                    if (symbs[j]>symbs[j+1])
                    {
                        s = symbs[j + 1];
                        symbs[j + 1] = symbs[j];
                        symbs[j] = s;
                    }
                }
                
            }
            //Отображение содержимого массива
            Console.WriteLine("Массив после сортировки");
            for(int k=0;k<symbs.Length;k++)
            {
                Console.Write(symbs[k] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

            /*
            
            //Переменные для записи значения элемента и индекса
            int value, index;
            //Размер массива

            int size = 50;
            //Объект для генерирования случайных чисел
            Random rnd = new Random();
            //Создание массива
            int[] nums = new int[size];
            //Заполнение и отображение массива
            for (int k = 0; k < nums.Length; k++)
            {
                //Значение элемента массива
                nums[k] = rnd.Next(1, 101);
                //Отображение значений элементов массивов
                Console.Write("{0}\t", nums[k]);

            }
            Console.WriteLine();
            //Поиск наибольшего эллемента
            index = 0;           //Начальное значение индекса
            value = nums[index]; //Значание элемента с индексом
                                 //Перебор элементов
            for (int k = 1; k < nums.Length; k++)
            {
                //Если значение проверяемого элемента больше текущего наибольшего значения
                if (nums[k] > value)
                {
                    value = nums[k]; //Новое наибольшее значение
                    index = k;       //Новое значение для индекса

                }

            }
            //Отображение результата
            Console.WriteLine("Наибольшее значение:" + value);
            Console.WriteLine("Индекс элемента:" + index);
            Console.ReadKey();


            /*
            //Целочисленный массив
            int[] A = { 1, 3, 5, 7, 9 };
            //Переменные массива
            int[] B, C;
            //Присваивание массивов
            B = A;
            //Создание нового массива
            C = new int[A.Length];
            //Поэлементное копирование массива
            for (int k = 0; k < A.Length; k++)
            {
                C[k] = A[k];
            }
            //Изменение значения первого элемента массива
            A[0] = 0;
            //Изменение значения последнего элемента в массиве В
            B[B.Length - 1] = 0;
            //Сообщение в консольном окне
            Console.WriteLine("A:\tB:\tC:");
            //Отображение содержимого массивов
            for (int k = 0; k < A.Length; k++)
            {
                //Отображение значений элементов массивов
                Console.WriteLine("{0}\t{1}\t{2}", A[k], B[k], C[k]);
            }

            Console.ReadKey();

            /* 

            //Создание и инициализация массивов
            int[] nums = { 1, 3, 5, 7, 6, 5, 4 };
            char[] symbs = new char[] { 'A', 'Z', 'B', 'Y' };
            string[] txts = new string[3] { "один", "два", "три" };
            //отображение содержимого массивов
            Console.WriteLine("Массив nums:");
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write(nums[k] + " ");
            }

            Console.WriteLine("\nМассив symbs:");
            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k] + " ");
            }
            Console.WriteLine("\nМассив txts:");
            for (int k = 0; k < txts.Length; k++)
            {
                Console.Write(txts[k] + " ");
            }
            Console.ReadKey();

            */
        }
    }
}
