using System;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<Action<float, float>, bool> func = GetTrue; //создание делегата 
            Action<float, float> action = Print; //инициализация делегата
            func.Invoke(action); //вызов делегата
            func = GetFalse; // инициализация делегата
            func.Invoke(action); //вызов делегата

        }

        static void Draw(float x, float y) //метод вывода на экран
        {
            Console.WriteLine($"{x} and {y}");

        }
        static bool GetTrue(Action<string, string> draw) //true
        {
            draw.Invoke("сиси", "попы");
            return true;
        }
        static bool GetFalse(Action<string, string> draw) //false
        {
            draw.Invoke("booba", "ass");
            return false;
        }


    }
}
