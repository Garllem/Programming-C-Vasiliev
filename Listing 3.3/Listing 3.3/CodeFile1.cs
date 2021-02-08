using System;

class NestedDemo
{
    static void Main ()
    {
        //Текстовая переменная
        string txt;
        //Отображение сообщения
        Console.Write("Введите текст");
        //Считываем текст
        txt = Console.ReadLine();
        //Если введена не пустая строка
        if (txt!="")
        {
            //Отображение сообщения
            Console.WriteLine("Спасибо, что ввели текст");
            //Если в строке больше 10 символов
            if (txt.Length > 10)
            {
                //Сообщение
                Console.WriteLine("Ого, как много букв");
            }
            //Если в строке не больше 10 символов
            else
            {
                //Отображение сообщения
                Console.WriteLine("Ого, как мало букв");
            }
        }
        else
        {
            Console.WriteLine("Жаль, что не ввели текст");
        }
        Console.ReadKey();
    }
}