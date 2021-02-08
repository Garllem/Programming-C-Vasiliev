using System;

class Listing44
{
    static void Main(string[] args)
    {
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
        for(int k=0; k<A.Length;k++)
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

