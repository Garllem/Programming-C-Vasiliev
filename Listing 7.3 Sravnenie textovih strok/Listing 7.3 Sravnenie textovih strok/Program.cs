using System;

namespace Listing_7._3_Sravnenie_textovih_strok
{
    class CompStringDemo
    {
        //Статический метод для сравнения текстовых строк
        static bool StrCmp(String X, String Y)
        {
            //Если строки разной длины
            if (X.Length != Y.Length) return false;
            //Если строки одинаковой длины
            for(int k=0;k<X.Length;k++)
            {
                //Если символы в текстовых строках разные
                if (X[k] != Y[k]) return false;
            }
            //Результат метода, если строки одинаковой длины
            //и все символы в текстовых строках совпадают
            return true;    
        }
        //Главный метод
        static void Main(string[] args)
        {
            //Символьный массив
            char[] smb = { 'Я', 'з', 'ы', 'к', ' ', 'C', '#' };
            //Текстовый объект
            String A = "Язык C#";
            //Отображение текстовой строки
            Console.WriteLine("A: \"{0}\"",A);
            //Создание нового текстового объекта
            String B = new String(smb);
            //Отображение текстовой строки
            Console.WriteLine("B: \"{0}\"", B);
            //Ещё один текстовый объект
            String C = "ЯЗЫК С#";
            //Отображение текстовой строки
            Console.WriteLine("C: \"{0}\"", C);
            Console.WriteLine("Сравнение строк");
            //Сравнение текстовых строк
            Console.WriteLine("A==B: {0}", A==B);
            Console.WriteLine("StrCmp(A, B): {0}", StrCmp(A, B));
            Console.WriteLine("A==C: {0}", A==C);
            Console.WriteLine("StrCmp(A, C): {0}", StrCmp(A, C));
            Console.WriteLine("B!=C: {0}",B!=C);
            Console.WriteLine("StrCmp(A, \"C#\"): {0}", StrCmp(A, "C#"));
        }
    }
}
