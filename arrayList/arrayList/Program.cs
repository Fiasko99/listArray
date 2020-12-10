using System;
// Подключение библиотеки
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            // Добавление элементов в массив 
            list.Add(22); // int 
            list.Add(2.2); // double
            list.Add("какая то строка"); // string
            list.Add(new int[]{ 22, 44 }); // array int
            list.Add(new bool[] { true, false, true}); // array bool 
            list.Add(new string[,] { { "hello" }, { "world" } }); // array td string
            
            // Вывод array list
            foreach (object item in list)
            {
                Console.WriteLine(item);
                
                if (item.GetType() == typeof(System.Int32[]))
                {
                    IntArrayOutput(item as int[]);
                }
            }

            // Удаляем элемент bool array
            list.RemoveAt(4);

            // Выводим элемент по индексу
            Console.WriteLine(list[0]);



        }

        static void IntArrayOutput(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
