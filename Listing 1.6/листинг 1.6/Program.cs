using System;

namespace листинг_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string name2;
            // Заголовок консольного окна
            Console.Title = "Давайте познакомимся";
            // сообщение в консоле
            Console.Write("Как Вас зовут? ");
            // считывание текста
            name = Console.ReadLine();

            Console.Write("Куда вас послать? ");
            name2 = Console.ReadLine();
            // ещё одна текстовая переменная
            string txt = "Очень приятно, " + name + "! "+"идите "+name2;
            // заголовок консольного окна
            Console.Title = "Знакомство состоялось";
            // сообщение в консоле

            Console.WriteLine(txt);
            Console.ReadKey();
        }
    }
}
