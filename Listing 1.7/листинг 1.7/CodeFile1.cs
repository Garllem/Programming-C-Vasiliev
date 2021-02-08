using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace листинг_1._7
{
    class EnteringInteger
    {
        static void Main(string[] args)
        {
            // текстовые переменные
            string res, txt;
            // целочисленные переменные
            int year = 2019, age, born;
            // отображение окна с полем ввода
            res = Interaction.InputBox("В каком году Вы родились", "Год рождения");
            // преобразование текста в число
            born = Int32.Parse(res);
            // вычисление возраста
            age = year - born;
            txt = "Тогда Вам " + age + " года/лет";

            MessageBox.Show(txt, "Возраст");

        }
    }
}
