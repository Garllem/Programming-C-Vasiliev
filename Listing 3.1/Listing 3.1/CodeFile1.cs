using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class UsingIfDemo
{
    static void Main ()
    {
        //Переменная для определения типа пикторгаммы
        MessageBoxIcon icon;
        //Переменные для определения текста сообщения,
        //заголовка окна и имени пользователя
        string msg, title, name;
        //Считывание имени пользователя
        name = Interaction.InputBox(
            //Текст над ролем ввода
            "Как вас зовут?",
            //Название окна
            "Знакомимся");
        //Проверка введенного пользователем текста
        if (name=="")
        {
            // Если текст не введён
            //Пиктограмма ошибки
            icon = MessageBoxIcon.Error;
            //Текст сообщения
            msg = "Очень жаль, что мы не познакомлись!";
            //Заголовок окна
            title = "Знакомство не состоялось";
        }
        else
        {
            //Если текст введён
            //Информационная пиктограмма
            icon = MessageBoxIcon.Information;
            //Текст сообщения
            msg = "Очень приятно, " + name + "!";
            //Заголовок окна
            title = "Знакомство состоялось";
        }
        //Отображение сообщения (аргументы текст мообщения, заголовок, кнопки и пиктограмма
        MessageBox.Show(msg, title, MessageBoxButtons.OK, icon);
    }
}