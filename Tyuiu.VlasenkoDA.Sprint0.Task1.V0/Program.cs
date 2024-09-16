using System;

namespace Tyuiu.VlasenkoDA.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World");
            string name = "Дмитрий";
            int age = 32;
            Console.WriteLine("Здравствуйте меня зовут " + name + " мне " + age + " лет!");
            Console.ReadKey(); // позволяет дождаться нажатия клавиши, чтобы окно консоли не закрылось сразу
        }
    }
}