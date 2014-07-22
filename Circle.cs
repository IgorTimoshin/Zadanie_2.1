using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Circle
    {
        // Создадим открытые поля
        public double _xO, _yO;                 // Координаты центра окружности
        public double _radius;                  // Радиус окружности
        public double _length;                  // Длина окружности
        public double _s;                       // Площадь круга

        // В метод конструктор, при создании экземпляра класса, будем передавать координаты центра окружности и радиус
        public Circle(double xO, double yO, double rad)
        {
            // Приравниваем значения полей с параметрами, переданными конструктору при создании
            _xO = xO;
            _yO = yO;
            _radius = rad;
            // Вычисляем длину окружности и площадь круга
            _length = 2 * Math.PI * _radius;
            _s = Math.PI * _radius * _radius;
        }

        // Непараметризированный метод определяющий, пересекаются ли границы окружности с осями координат
        public bool Intersect()
        {
            if (((Math.Abs(_xO) - _radius) <= 0) || ((Math.Abs(_yO) - _radius) <= 0) ||
                (((Math.Abs(_xO) - _radius) <= 0) && ((Math.Abs(_yO) - _radius) <= 0)))
                return true;
            else
                return false;
        }

        // Параметризированный метод, вычисляющий длину отрезка, отсекаемого окружностью.
        // Если прямая не пересекает окружность, то возвращается значение 0
        public double Segment(double k, double b)
        {
            double d = Math.Pow((2 * k * b - 2 * _xO - 2 * _yO * k), 2) - (4 + 4 * k * k) * (b * b - _radius * _radius + _xO * _xO + _yO * _yO - 2 * _yO * b);
            if (d < 0)
                return 0;
            else if (d > 0)
            {
                double x1 = (-(2 * k * b - 2 * _xO - 2 * _yO * k) - Math.Sqrt(d)) / (2 + 2 * k * k);
                double x2 = (-(2 * k * b - 2 * _xO - 2 * _yO * k) + Math.Sqrt(d)) / (2 + 2 * k * k);

                if (x1 == x2)
                    return 0;
                else
                {
                    double y1 = k * x1 + b;
                    double y2 = k * x2 + b;

                    double l = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                    return l;
                }
            }
            else
                return 0;
        }
    }
}
