using System;

class CharArrayDemo
{
    static void Main ()
    {
        //объект для генерирования случайных чисел
        Random rnd = new Random();
        //размер массива и индексная переменная
        int size = 10, k;
        //создание символьного массива
        char[] sumbs = new char[size];
        //отображение сообщения
        Console.WriteLine("Массив случайных символов");
        //Заполнение массива случайными символами
        for (k=0; k < sumbs.Length; k++)
        {
            //значение элемента массива
            sumbs[k] = (char)('A' + rnd.Next(26));
            //отображение значения элемента массива
            Console.Write("| " + sumbs[k] + " ");
        }
        Console.WriteLine("|");
        //отображение сообщения
        Console.WriteLine("Массив в обратном порядке");
        for (k = sumbs.Length - 1; k >= 0; k--)
        {
            //отображение значения для элемента массива
            Console.Write("| " + sumbs[k] + " ");
        }
        Console.WriteLine("|");
        Console.ReadKey();
    }
}