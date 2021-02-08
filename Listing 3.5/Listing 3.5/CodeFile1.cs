using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class SwitchDemo
{
    static void Main ()
    {
        //Переменная для запоминания введённого числа
        int number;
        //Переменная для записи названия числа
        string name;
        //Считывание числа
        number = Int32.Parse(
            Interaction.InputBox(
                "Введите число", 
                "Число"
                ));
        //Использование оператора выбора для определения
        //названия введённого числа

        switch (number)
        {
            case 1:
                name = "Еденица";
                break;
            case 2:
                name = "Двойка";
                break;
            case 3:
                name = "Тройка";
                break;
            case 4:
                name = "Четвёрка";
                break;
            default:
                name = "Неизвестное число";
                break;

        } //Завершение оператора выбора
        MessageBox.Show(name, "Число");
    }
}