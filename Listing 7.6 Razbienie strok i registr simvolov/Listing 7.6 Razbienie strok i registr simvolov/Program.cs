using System;

namespace Listing_7._6_Razbienie_strok_i_registr_simvolov
{
    class SplittingStringDemo
    {
        static void Main(string[] args)
        {
            //Исходная текстовая строка
            String txt = "Дорогу осилит идущий";
            //Отображение исходного текста
            Console.WriteLine(txt);
            //Текстовая строка
            String str;
            //Текст с символами в верхнем регистре
            str = txt.ToUpper();
            //Проверка текстового значения
            Console.WriteLine(str);
            //Текст с символами в верхнем регистре
            str = txt.ToLower();
            //Проверка текстового значения
            Console.WriteLine(str);
            //Переменная для текстового массива
            String[] words;
            //Разбивка текста на подстроки
            words = txt.Split();
            //Отображение подстрок
            for(int k=0;k<words.Length;k++)
            {
                Console.WriteLine((k+1)+": "+words[k]);
            }
            Console.WriteLine();
            //Разбивка текста на подстроки
            words = txt.Split('у', 'и');
            //Отображение подстрок
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k + 1) + ": " + words[k]);
            }
            Console.WriteLine();
            //Разбивка текста на подстроки
            words = txt.Split(new char[] { 'у', 'и' }, 3);
            //Отображение подстрок
            for (int k = 0; k < words.Length; k++)
            {
                Console.WriteLine((k + 1) + ": " + words[k]);
            }
            Console.WriteLine();
            //Переменная для символьного массива
            char[] symbs;
            //Массив из символов формирующих текст
            symbs = txt.ToCharArray();
            //Отображение символов из массива
            for (int k = 0; k < symbs.Length; k++)
            {
                Console.Write(symbs[k]+" ");
            }
            Console.WriteLine();
        }
    }
}
