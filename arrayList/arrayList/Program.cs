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
                // Вывод одномерного массива
                if (item.GetType() == typeof(System.Int32[]))
                {
                    IntArrayOutput(item as int[]);
                }
            }

            // Удаляем элемент bool array
            list.RemoveAt(4);

            // Выводим элемент по индексу
            Console.WriteLine(list[0]);
            Console.WriteLine();

            // Array List 
            ArrayList какой_то_массив = new ArrayList();
            Console.Write("Введите кол-во элементов в массиве: ");
            int N = int.Parse(Console.ReadLine());

            ReadlineConsoleDinamyc(какой_то_массив, N);
        }

        static void IntArrayOutput(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        static void ReadlineConsoleDinamyc(ArrayList array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                array.Add(int.Parse(Console.ReadLine()));
            }
            OutputNewArrayList(array);
            Console.WriteLine();
            BubbleSort(array);
        }

        static void OutputNewArrayList(ArrayList newArray)
        {
            foreach (int element in newArray)
            {
                Console.Write("[" + element + "]");
            }
        }

        static void BubbleSort(ArrayList array)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = i; j < array.Count; j++)
                {
                    if (Convert.ToInt32(array[i]) > Convert.ToInt32(array[j]))
                    {
                        int temp = Convert.ToInt32(array[i]);
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            OutputNewArrayList(array);
        }
    }
}
