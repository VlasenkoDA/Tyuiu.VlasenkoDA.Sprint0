using System;

namespace Tyuiu.VlasenkoDA.Sprint0.Task1.V0
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World");
            string name = "Игорь";
            int age = 45;
            Console.WriteLine("Здравствуйте меня зовут " + name + " мне " + age + " лет!");
            Console.ReadKey(); // позволяет дождаться нажатия клавиши, чтобы окно консоли не закрылось сразу
        }
    }
}