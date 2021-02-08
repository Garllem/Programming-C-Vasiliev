using System;

namespace Listing_9._5_Ispolzovanie_razlichnih_svoistv
{
    //Класс со свойствами
    class MyClass
    {
        //Закрытое поле массив
        private int[] nums;
        //Текстовое свойство без set-аксесора
        public string content
        {
            //Метод вызывается при считывании значения свойства
            get
            {
                //Если ссылка на массив пустая
                if (nums == null) return "{}";
                //Форматирование текстовой строки
                string txt = "{" + nums[0];
                for(int k=1; k<nums.Length;k++)
                {
                    txt += "," + nums[k];
                }
                txt += "}";
                //Значение свойства
                return txt;
            }
        }
        //Целочисленное свойство без get-аксесора
        public int element
        {
            //Метод вызывается при присваивании значения свойству
            set
            {
                //Если ссылка на массив пустая
                if(nums==null)
                {
                    //Создание массива из одного элемента
                    nums = new int[1];
                    //Значение единственного эдемента массива
                    nums[0] = value;
                }
                else
                {
                    //Если ссылка не пустая Создание массива
                    int[] n = new int[nums.Length + 1];
                    //Заполнение массива
                    for(int k=0; k<nums.Length; k++)
                    {
                        n[k] = nums[k];
                    }
                    //Значение последнего элемента в массиве
                    n[nums.Length] = value;
                    //Ссылка на созданный массив записывается в поле объекта
                    nums = n;
                }
            }
        }
        //Свойство является ссылкой на массив
        public int[] data
        {
            //Метод вызывается при считывании значения свойства
            get
            {
                //Создание массива
                int[] res = new int[nums.Length];
                //Заполнение массива
                for(int k=0; k<nums.Length; k++)
                {
                    res[k] = nums[k];
                }
                //Значение свойства
                return res;
            }
            //Метод вызывается при присваивании значения свойству
            set
            {
                //Создание массива
                nums = new int[value.Length];
                //Заполнение массива
                for(int k=0; k<value.Length; k++)
                {
                    nums[k] = value[k];
                }
            }
        }
    }
    class MoreUsingPropsDemo
    {
        static void Main(string[] args)
        {
            //Создание объекта
            MyClass obj = new MyClass();
            //Проверка содержимого массива
            Console.WriteLine(obj.content);
            //Присваивание значения свойству element
            obj.element = 10;
            //Проверка содержимого массива из объекта
            Console.WriteLine(obj.content);
            //Присваивание значения свойству element
            obj.element = 5;
            obj.element = 7;
            //Проверка содержимого массива из объекта
            Console.WriteLine(obj.content);
            //Считывание значения свойства data
            int[] A = obj.data;
            //Присваивание значения свойству element
            obj.element = 12;
            //ОТОБРАЖЕНИЕ СОДЕРЖИМОГО МАССИВА A
            for(int k=0;k<A.Length;k++)
            {
                Console.Write(A[k]+" ");
            }
            Console.WriteLine();
            //Проверка содержимого массива из объекта
            Console.WriteLine(obj.content);
            //Создание массива
            int[] B = { 11, 3, 6 };
            //Присваивание значение свойству data
            obj.data = B;
            //Изменение значения элемента массива В
            B[0] = 0;
            //Отображение содержимого массива В
            for (int k = 0; k < B.Length; k++)
            {
                Console.Write(B[k] + " ");
            }
            Console.WriteLine();
            //Проверка содержимого массива из объекта
            Console.WriteLine(obj.content);

        }
    }
}
