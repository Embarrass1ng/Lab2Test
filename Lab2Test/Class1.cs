using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса Class1
            Class1 c = new Class1();

            // Вызываем метод arifm для тестирования
            int result = c.arifm(10, 20, 30);
            Console.WriteLine("Result: " + result);

            Console.ReadLine(); // Чтобы консольное окно не закрывалось сразу
        }
    }

    public class Class1
    {
        public int arifm(int x, int y, int z)
        {
            return ((x + y) * z);
        }
    }
}