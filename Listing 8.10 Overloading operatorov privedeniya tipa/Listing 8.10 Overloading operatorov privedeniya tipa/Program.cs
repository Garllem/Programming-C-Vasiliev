using System;

namespace Listing_8._10_Overloading_operatorov_privedeniya_tipa
{
    //класс с перегрузкой операторов приведения типа
    class MyClass
    {
        public int code;    //Целочисленное поле
        public char symb;   //Символьное поле
        public String text; //Текстовое поле
        //Конструктор с тремя аргументами
        public MyClass (int n, char s, String t)
        {
            code = n;
            symb = s;
            text = t;
        }
        //Переопределение метода ToString
        public override string ToString()
        {
            //Локальная переменная
            String txt = "Поля объекта:\n";
            txt += "Числовое поле: " + code + "\n";
            txt+= "Символьное поле: \'" + symb + "\'\n";
            txt += "Текстовое поле: \"" + text + "\"\n";
            txt += "--------------------------------";
            //Результат метода
            return txt;
        }
        //Метод для явного приведения к текстовому типу
        public static explicit operator String(MyClass obj)
        {
            return obj.text;
        }
        //Метод для неявного приведения к типу int
        public static implicit operator int(MyClass obj)
        {
            return obj.code;
        }
        //Метод неявного приведения к типу char
        public static implicit operator char(MyClass obj)
        {
            return obj.symb;
        }
        //Метод неявного преобразования из типа int
        public static implicit operator MyClass(int n)
        {
            MyClass t = new MyClass(n, 'B', "Bravo");
            return t;
        }
        //Метод для явного преобразования из типа char
        public static explicit operator MyClass(char s)
        {
            return new MyClass(300, s, "Charlie");
        }
        //Метод для неявного преобразования из текстового типа
        public static implicit operator MyClass(String t)
        {
            return new MyClass(t.Length, t[0], t);
        }
    }
    class OverloadingImplExplDemo
    {
        static void Main(string[] args)
        {
            //Создание объектов и проверка результата
            //Явное создание объекта
            MyClass A = new MyClass(100, 'A', "Alpha");
            //Неявно вызываемый метод ToString()
            Console.WriteLine("Объект А. "+A);
            //Создание объекта преобразованием из типа int
            MyClass B = 200;
            //Неявно вызываемый метод ToString()
            Console.WriteLine("Объект B. " + B);
            //Создание объекта преобразованием из типа char
            MyClass C = (MyClass)'C';
            //Неявно вызываемый метод ToString()
            Console.WriteLine("Объект С. " + C);
            //Создание объекта преобразованием из текста
            MyClass D = "Delta";
            //Неявно вызываемый метод ToString()
            Console.WriteLine("Объект D. " + D);
            Console.WriteLine("Ещё раз поля объекта А:");
            //Явное  преобразование в тип int
            Console.WriteLine("Число: "+(int)A);
            //Явное преобразование в тип char
            Console.WriteLine("Символ: "+(char)A);
            //Явное преобразование в текст
            Console.WriteLine("Текст: "+(String)A+"\n");
            Console.WriteLine("Разные операции:");
            //Целочисленная переменная
            int n;
            //Неявное преобразование к типу int
            n = A + B;
            Console.WriteLine("Значение A+B="+n);
            //Неявное преобразование к типу char
            char s = B;
            Console.WriteLine("Символ: "+s);
            //Последовательное преобразование из текстового типа к типу MyClass а затем к типу int
            Console.WriteLine("Число: " + (int)(MyClass)"Echo");
            
        }
    }
}
