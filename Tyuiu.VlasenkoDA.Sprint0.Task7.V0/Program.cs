using System;
using Tyuiu.VlasenkoDA.Sprint0.Task7.V0.Lib;

namespace Tyuiu.VlasenkoDA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 Выполнил: Власенко Д.А РППБ-24-1";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Спринт #0                                                                       *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                                     *");
            Console.WriteLine("* Задание # 7                                                                     *");
            Console.WriteLine("* Вариант # 0                                                                     *");
            Console.WriteLine("* Выполнил: Власенко Д.А РППБ-24-1                                                *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Условие:                                                                        *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух            *");
            Console.WriteLine("* одинаковых массивов по длине.                                                   *");
            Console.WriteLine("*                                                                                 *");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Исходные данные:                                                                *");
            Console.WriteLine("***********************************************************************************");

            // Решение задачи
            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива #1:");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i]);
                if (i < arrayNums1.Length - 1) // Условие, чтобы не было запятой после последнего элемента
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива #2:");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i]);
                if (i < arrayNums2.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("* Результат:                                                                      *");
            Console.WriteLine("***********************************************************************************");

            // Убираем лишнюю точку с запятой в условии
            if (arrayNums1.Length == arrayNums2.Length)
            {
                // Проверяем, что метод AdditionArrays работает корректно
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массивов равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i]);
                    if (i < resultArray.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }

            Console.ReadKey();
        }
    }
}
