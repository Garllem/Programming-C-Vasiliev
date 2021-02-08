using System;

class IntArrayDemo
{
    static void Main()
    {
        //создание массива из 12 чисел
        int[] nums = new int[12];
        //перебол элементов массива
        for(int k=0;k<nums.Length; k++)
        {
            //присваивание значения элементу массива
            nums[k] = 3 * k + 1;
            //отображение значения элемента массива
            Console.Write("| " + nums[k] + " ");
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}