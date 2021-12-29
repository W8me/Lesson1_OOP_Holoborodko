using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.Write("Введите значение первой стороны: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение второй стороны: ");
            y = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(x, y);

            double s = rectangle1.AreaCalculator();
            double p = rectangle1.PerimeterCalculator();

            //Console.WriteLine($"\nПрямоугольник со сторонами {x} и {y}");
            Console.WriteLine($"\nПлощадь:{s} Периметер:{p}");
        }
    }
}
