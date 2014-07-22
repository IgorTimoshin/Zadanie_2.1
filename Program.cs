using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите координату центра окружности - X");
            // Считываем значение, введённое пользователем
            string s = Console.ReadLine();
            // Преобразовываем его в тип double
            double x = double.Parse(s);

            Console.WriteLine("Введите координату центра окружности - Y");
            s = Console.ReadLine();
            double y = double.Parse(s);

            Console.WriteLine("Введите радиус окружности");
            s = Console.ReadLine();
            double r = double.Parse(s);

            // Создаём экземпляр класса Circle и передаём ему, ранее введённые параметры x, y, r
            Circle circle = new Circle(x, y, r);

            Console.WriteLine("Длина окружности = {0}", circle._length);
            Console.WriteLine("Площадь круга = {0}", circle._s);

            // Проверяем, пересекает ли окружность оси координат
            if (circle.Intersect())
                Console.WriteLine("Окружность пересекает одну или обе оси координат");
            else
                Console.WriteLine("Окружность не пересекает оси координат");

            Console.WriteLine("Введите угловой коэффициент прямой (K)");
            s = Console.ReadLine();
            double k = double.Parse(s);

            Console.WriteLine("Введите коэффициент b для уравнения прямой");
            s = Console.ReadLine();
            double b = double.Parse(s);

            Console.WriteLine("Длина отрезка, отсечённого окружностью = {0}", circle.Segment(k, b));

            // Эту строку пишем для того, чтобы программа не закрывалась пока пользователь не нажмёт любую клавишу
            Console.ReadKey();
        }
    }
}
