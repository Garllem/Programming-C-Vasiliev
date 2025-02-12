﻿using System;

namespace Listing_4._10
{
    class MultiDimArrayDemo
    {
        static void Main(string[] args)
        {
            //трёхмерный символьный массив
            char[,,] symbs = new char[4, 3, 5];
            //одномерный символьный массив
            char[] s = { 'б', 'Б', 'b', 'B' };
            //Заполнение трёхмерного массива и отображение значений его элемента
            //Цикл по первому индексу
            for(int i=0;i<symbs.GetLength(0);i++)
            {
                //Отображение сообщения
                Console.WriteLine(" Слой № {0}:", i + 1);
                //Цикл по второму индексу
                for(int j=0;j<symbs.GetLength(1);j++)
                {
                    //Цикл по третьему индексу
                    for(int k=0;k<symbs.GetLength(2);k++)
                    {
                        //Присвоение значения элнменту массива
                        symbs[i, j, k] = s[i];
                        //Изменение элемениа в одномерном массиве
                        s[i]++;
                        //Отображение значения элемента массива
                        Console.Write(symbs[i, j, k] + " ");
                    }
                    //Переход к новой строке
                    Console.WriteLine();
                }
                //Отображение линии
                Console.WriteLine("--------------");
            }

           
        }
    }
}
