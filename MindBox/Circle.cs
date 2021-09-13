using System;

namespace MindBox
{
    /// <summary>Класс круга/summary>
    public class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор с параметрами для указания радиуса создаваемого круга
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Неверно указан радиус", nameof(radius));
            }

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}