using System;
using Tyuiu.VlasenkoDA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.VlasenkoDA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            //Пример циклической труктуры находится в библиотеке классов в методе AdditionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            //Пример циклической труктуры находится в библиотеке классов в методе SubstractionArray
            Console.WriteLine("Разность элементов массива = " + DataService.SubstractionArray(numsArray));

            //Пример циклической труктуры находится в библиотеке классов в методе MultiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
