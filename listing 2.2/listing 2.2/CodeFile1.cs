using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class HudredsDemo
{
    static void Main()
    {
        //Целочисленные переменные
        int number, hundreds;
        //Считывание целого числа
        number = Int32.Parse(
            Interaction.InputBox(
            //Надпись над полем ввода
            "Ввведите целое число:",
            //Заголовок окна
            "Количество сотен")
            );
        //Количество сотен в числе (для целочисленных операндов деление выполняется нацело)
        hundreds = number / 100 % 10;
        //Текстовая переменная
        string txt="В этом числе "+hundreds+" сотен!";
        //Отображение окна с сообщением
        // (аргументы метода - сообщение и заголовок окна):
        MessageBox.Show(txt, "Сотни");
    }
}