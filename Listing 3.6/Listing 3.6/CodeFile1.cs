using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class SwitchDemo
{
    static void Main()
    {
        //Переменная для запоминания введённого числа
        int number;
        //Переменная для записи названия числа
        string txt="";
        //Считывание числа
        number = Int32.Parse(
            Interaction.InputBox(
                "Введите число от 1 до 9:",
                "Число"
                ));
        //Проверка значения переменной number:

        switch (number) //Оператор выбора
        {
            case 1:               
            case 9:
                txt = "Вы ввели нечётное, \n но не простое число.";
                break; //Завершение блока
            case 2:
            case 3:
            case 5:
            case 7:
                txt = "Вы ввели простое число";
                break;
            case 4:
            case 8:
                txt = "Вы ввели число - степень двойки.";
            case 6:
                txt = "Вы ввели 6 - совершенное число.";
                break;
            
            
        } //Завершение оператора выбора
        MessageBox.Show(txt, "Число");
    }
}