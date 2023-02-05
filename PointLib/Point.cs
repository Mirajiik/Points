using System;

namespace PointLib
{
    [Serializable]
    public class Point : IComparable
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public virtual double Metric()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(object obj)
        {
            if (obj is Point)
            {
                Point p = (Point)obj;
                return Math.Sign(Metric() - p.Metric());
            }
            throw new Exception("Неверный типы данных для сравнения");
        }
    }
}