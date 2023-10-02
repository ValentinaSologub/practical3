using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Figure
    {
            public Point[] points;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double GetSideLength(Point A, Point B)
        {
            double dx = B.X - A.X;
            double dy = B.Y - A.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                int nextIndex = (i + 1) % points.Length; // Індекс наступної точки у масиві (з замкненим багатокутником)
                double sideLength = GetSideLength(points[i], points[nextIndex]);
                perimeter += sideLength;
            }

            Console.WriteLine($"The name of the polygon: {points.Length}-angle");
            Console.WriteLine($"Perimeter of a polygon: {perimeter}");
        }
}
