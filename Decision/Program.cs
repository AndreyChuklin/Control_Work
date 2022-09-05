using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача: написать прогармму, которая из имеющегося массива срок формирует массив из строк, длина которых меньше либо равна 3 символа.
            // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

            string[] array1 = new string[7] { "567", "213", "hello", "world", "not", "mega", "prog" };
            string[] array2 = new string[array1.Length];
            int count = 0;
            void SecondArrayWithIF(string[] array1, string[] array2)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Length <= 3)
                    {
                        array2[count] = array1[i];
                        count++;
                    }
                }
            }
            void PrintArray(string[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
                Console.WriteLine();
            }
            SecondArrayWithIF(array1, array2);
            PrintArray(array2);
        }
    }
}
