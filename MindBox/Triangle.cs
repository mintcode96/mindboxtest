using System;

namespace MindBox
{
    /// <summary>Класс треугольника/summary>
    public class Triangle : Figure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public bool IsRectangular
        {
            get
            {
                bool IsPythagorasTriangle(double leg1, double leg2, double hypotenuse)
                {
                    return (Math.Pow(leg1, 2) + Math.Pow(leg2, 2)).Equals(Math.Pow(hypotenuse, 2));
                }

                return IsPythagorasTriangle(_firstSide, _secondSide, _thirdSide) ||
                       IsPythagorasTriangle(_firstSide, _thirdSide, _secondSide) ||
                       IsPythagorasTriangle(_secondSide, _thirdSide, _firstSide);
            }
        }

        /// <summary>
        /// Конструктор с параметрами для указания всех сторон создаваемого треугольника
        /// </summary>
        /// <param name="firstSide">Первая сторона(она же сторона 'a')</param>
        /// <param name="secondSide">Вторая сторона(она же сторона 'b')</param>
        /// <param name="thirdSide">Третья сторона(она же сторона 'c')</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            ValidateSide(firstSide);
            ValidateSide(secondSide);
            ValidateSide(thirdSide);

            var maxSide = Math.Max(firstSide, Math.Max(secondSide, thirdSide));
            var perimeter = firstSide + secondSide + thirdSide;

            if (perimeter - maxSide <= maxSide)
            {
                throw new ArgumentException(
                    "Наибольшая сторона треугольника должна быть меньше суммы других сторон");
            }

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            var semiPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _firstSide) * (semiPerimeter - _secondSide) *
                             (semiPerimeter - _thirdSide));
        }

        private void ValidateSide(double side)
        {
            if (side <= 0)
            {
                throw new ArgumentException("Неверно указана сторона", nameof(side));
            }
        }
    }
}