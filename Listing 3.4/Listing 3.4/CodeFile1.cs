using System;

class AnotherNestedDemo
{
    static void Main ()
    {
        //Переменная для запоминания введённого числа
        int number;
        //Отображение сообщения
        Console.WriteLine("Введите целое число");
        //Считывание числа
        number = Int32.Parse(Console.ReadLine());
        //Если введени еденица
        if (number == 1) Console.WriteLine("Еденица");
        //Если введени двойка
        else if (number == 2) Console.WriteLine("Двойка");
        //Если введени тройка
        else if (number == 3) Console.WriteLine("Тройка");
        //Если введени четвёрка
        else if (number == 4) Console.WriteLine("Четвёрка");

        //Все прочие случаи
        else Console.WriteLine("Неизвестное число");

        Console.ReadKey();

    }
}