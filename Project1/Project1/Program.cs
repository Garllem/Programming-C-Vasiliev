using System.Windows.Forms;
using Microsoft.VisualBasic;

class inputDialogDemo
{
    static void Main ()
    {
        // Текстовая переменная
        string name;
        // отображение окна с полем ввода
        name = Interaction.InputBox(
            "Как Вас зовут?",           //Текст над полем ввода
            "Давайте познакомимся..."   // Название окна
            );
        // Ещё одна текстовая переменная
        string txt = "Очень приятно, " + name + "!";
        MessageBox.Show(txt,
            "знакомство состоялось",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }
}