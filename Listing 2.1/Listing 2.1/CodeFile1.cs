using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

class OddEvenDemo
{
    static void Main()
    {
        // Целочисленные переменные
        int number, reminder;
        // Считывание целого числа
        number = Int32.Parse(Interaction.InputBox("Введите целое число:", "Проверка"));

        //Вычисляется остаток от деления на 2
        reminder = number % 2;
        string txt = "Вы ввели ";
        txt += (reminder == 0 ? "четное":"нечетное") + " число!";
        MessageBox.Show(txt);
    }
}
   