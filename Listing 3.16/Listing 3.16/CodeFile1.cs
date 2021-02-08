using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class TryCatchDemo
{
    static void Main ()
    {
        //Сообщение о начале выплнения программы
        MessageBox.Show("Выполняется программа!", "Начало");
        //Перехват и обработка исключений
        try
        {
            //Контролируемый код
            //Попытка преобразовать текст в число
            Double.Parse(
                Interaction.InputBox(
                    "Введите действительное число",
                    "Число")
                        );
            //Отображение сообщения
            MessageBox.Show("Да, это было число!", "Число");
        }
        //Блок обработки исключений
        catch
        {
            //Отображение сообщения
            MessageBox.Show("Надо было ввести число!",
                "Ошибка",
                //В окне одна кнопка ОК
                MessageBoxButtons.OK,
                //Используется пиктограмма ошибки
                MessageBoxIcon.Error
                );
        } //ЗАвершение блока обработки
        //Сообщение о завершении выполнения программы
        MessageBox.Show("Программа завершена!", "Завершение");
    }
}