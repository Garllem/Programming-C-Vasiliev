using System;

namespace Listing_4._8
{
    class TwoDimArrayDemo
    {
        static void Main(string[] args)
        {
            //Кооичество строк и столбцов в массива
            int rows = 3, cols = 5;
            //Создание двумерного массива
            int[,] nums = new int[rows, cols];
            //Значене первого элемента в массиве
            int value = 1;
            //Заполнение и отображение массива.
            //Перебор строк в массиве
            for(int i=0;i<nums.GetLength(0);i++)
            {
                //Перебор столбцов в строке
                for(int j=0;j<nums.GetLength(1);j++)
                {
                    //Присвоение значение элементу массива:
                    nums[i, j] = value;
                    //Это будет значение следующего элемента
                    value++;
                    //Отображение элемента в строке
                    Console.Write(nums[i, j] + "\t");
                }
                //Переход к новой строке
                Console.WriteLine();
            }


            Console.ReadKey();
        }
        
    }
}
