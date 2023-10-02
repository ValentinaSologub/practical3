class Program
{
    static void Main(string[] args)
    {
        Point A = new Point(6, 8, "A");
        Point B = new Point(2, 7, "B");
        Point C = new Point(4, 1, "C");
        Figure triangle = new Figure(A, B, C);
        triangle.CalculatePerimeter();
    }
}
