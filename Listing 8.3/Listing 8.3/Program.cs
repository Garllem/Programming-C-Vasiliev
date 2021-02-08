using System;

namespace Listing_8._3_Peregruzka_arifmeticheskih_i_pobitovih_operatorov
{
    //Класс с перегрузкой арифметических и побитовых операторов
    class MyData
    {
        private int code;
        private char symb;
        private string text;
        //Конструктор с тремя аргументами
        public MyData(int n, char s, string t)
        {
            code = n;
            symb = s;
            text = t;
        }
        //Перегрузка метода ToString()
        public override string ToString()
        {
            //Локальная текстовая переменная:
            string txt = "Поля объекта:\n";
            txt += "Числовое поле: " + code + "\n";
            txt += "Символьное поле: " + symb + "\n";
            txt += "Текстовое поле: " + text + "\n";
            txt += "----------------------";
            //Результат метода 
            return txt;
        }
        // Операторный метод для вычисления суммы объекта и целого числа
        public static MyData operator +(MyData obj, int n)
        {
            return new MyData(+obj + n, -obj, ~obj);
        }
        //Операторный метод для вычисления разности объекта и целого числа
        public static MyData operator -(MyData obj, int n)
        {
            return new MyData(+obj - n, -obj, ~obj);
        }
        //Операторный метод для вычисления суммы целого числа и объекта
        public static int operator +(int n, MyData obj)
        {
            return n + (+obj);
        }
        //Операторный метод для вычисления разности целого числа и объекта
        public static int operator -(int n, MyData obj)
        {
            return n - (+obj);
        }
        //Операторный метод для вычисления суммы объекта и текстовой строки
        public static MyData operator +(MyData obj, string t)
        {
            return new MyData(+obj, -obj, t);
        }
        //Оператрный метод возвращает результатом текст
        public static string operator ~(MyData obj)
        {
            return obj.text;
        }
        //Операторный метод возвращает результатом число
        public static int operator +(MyData obj)
        {
            return obj.code;
        }
        //Операторный метод возвращает результатом символ
        public static char operator -(MyData obj)
        {
            return obj.symb;
        }
        //Операторный метод возвращает результатом символ из текста
        public static char operator >>(MyData obj, int k)
        {
            return (~obj)[k];
        }
        //Операторный метод возвращает результатом символ из текста
        public static char operator <<(MyData obj, int k)
        {
            return (~obj)[(~obj).Length - k - 1];
        }
        //Операторный метод возвращает результатом объект
        public static MyData operator ^(MyData a, MyData b)
        {
            string txt = ~a + " & " + ~b; //Локальная переменная
            return new MyData(+a, -b, txt); //Результат метода
        }
        //Операторный метод для увеличения значения целочисленного поля объекта
        public static MyData operator ++(MyData obj)
        {
            obj.code += 10; //Увеличение значения поля
            return obj; //Результат метода
        }
        //Операторный метод для уменьшения значения целочисленного поля объекта
        public static MyData operator --(MyData obj)
        {
            obj.code -= 10; // Уменьшение значения поля
            return obj;
        }
    }
    //Класс с главным методом

    class OverloadingOperatorsDemo
    {
        static void Main(string[] args)
        {
            //Создание объектов
            MyData A = new MyData(100, 'A', "Alpha");
            MyData B = new MyData(200, 'B', "Bravo");
            //Новый объект
            MyData C = A ^ B;
            //Проверка результата
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            //Новый объект
            C = B ^ A;
            //Проверка результата
            Console.WriteLine(C);
            //Переменные
            int n = +A; //Значение поля code объекта А
            char s = -A; //Значение поля symb объекта А
            string t = ~A; //Значение поля string объекта А
            //Проверка результатов
            Console.WriteLine("Объект А: поля {0}, \'{1}\' и \"{2}\"\n", n, s, t);
            //Увеличение значения поля code объекта А
            A++;
            //Проверка результата
            Console.WriteLine(A);
            //Увеличение значения поля code объекта А и проверка результата
            Console.WriteLine(++A);
            //Уменьшение значения поля code объекта В и проверка результата
            Console.WriteLine(B--);
            //Уменьшение значения поля code объекта В
            --B;
            //Проверка результата
            Console.WriteLine(B);
            //К объекту прибавляется число
            C = A + 1000;
            //Проверка результата
            Console.WriteLine(C);
            //Из объекта вычитается число
            C = A - 100;
            //Проверка результата
            Console.WriteLine(C);
            //Сумма и разность числа и объекта
            Console.WriteLine("Сумма и разность: {0} и {1}\n", 2000 + A, 1000 - A);
            //Прибавление к объекту текстовой строки
            C = A + "Charlie";
            //Проверка результата
            Console.WriteLine(C);
            //Посимвольное отображение значения текстового поля
            //объекта С
            for (int k = 0; k < (~C).Length; k++)
            {
                Console.Write((C >> k) + " ");
            }
            Console.WriteLine();
            //Символы из текстового поля объекта С отображаютя в обратном порядке
            for (int k = 0; k < (~C).Length; k++)
            {
                Console.Write((C << k) + " ");
            }
            Console.WriteLine();
            //Прибавление объекта к тексстовой строке
            t = "Объект С. " + C;
            //Проверка результата
            Console.WriteLine(t);
        }
    }
}
