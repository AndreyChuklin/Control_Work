using System;

namespace Decision
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача: написать прогармму, которая из имеющегося массива срок формирует массив из строк, длина которых меньше либо равна 3 символа.
            // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

            string[] array1 = new string[7] { "hello", "213", "567", "world", "not", "mega", "prog" };
            string[] array2 = new string[array1.Length];

            void SecondArray(string[] array1, string[] array2)
            {
                int count = 0;
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
            SecondArray(array1, array2);
            PrintArray(array2);
        }
    }
}
