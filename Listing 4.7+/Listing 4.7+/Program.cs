using System;

    class Program
    {
    //Использование цикла по коллекции
        static void Main(string[] args)
        {
        //Целочисленный массив
        int[] nums = { 1, 3, 4, 8, 9 };
        //Символьный массив 
        char[] symbs = { 'a', 'b', 'A', 'B', 'Ы' };
        //Текстовый массив
        string[] txts = { "красный", "желтый", "синий" };
        Console.WriteLine("Целочисленный массив");
        
        //Циклы по целочисленному массиву
        foreach(int s in nums)
            {
            Console.WriteLine("Число {0} - {1}", s, s%2==0?"четное":"нечетное");
            }
        Console.WriteLine("Символьный массив");
        //Цикл по символьнуму массиву
        foreach(char s in symbs)
        {
            Console.WriteLine("Код символа {0} - {1}", s, (int)s);
        }
        Console.WriteLine("Текстовый массив");
        //Цикл по текстовому массиву
        foreach (string s in txts)
        {
            Console.WriteLine("В слове \"{0}\"{1} букв", s, s.Length);
        }

    }
    }
