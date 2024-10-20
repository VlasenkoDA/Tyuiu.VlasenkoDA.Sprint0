﻿using System.Numerics;

namespace Tyuiu.VlasenkoDA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        //Пример циклической структуры, цикл с параметрами For
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;

        }
        //Пример циклической структуры, цикл с предусловием While
        public static object SubstractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }
        //Пример циклической структуры, цикл с постусловием do While
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;

        }
    }

}
