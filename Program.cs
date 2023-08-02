namespace DistanceCalculation
{
    class Program
    {
        static double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки (x y z):");
            string[] point1Coords = Console.ReadLine().Split();
            double x1 = double.Parse(point1Coords[0]);
            double y1 = double.Parse(point1Coords[1]);
            double z1 = double.Parse(point1Coords[2]);

            Console.WriteLine("Введите координаты второй точки (x y z):");
            string[] point2Coords = Console.ReadLine().Split();
            double x2 = double.Parse(point2Coords[0]);
            double y2 = double.Parse(point2Coords[1]);
            double z2 = double.Parse(point2Coords[2]);

            double distance = Distance3D(x1, y1, z1, x2, y2, z2);

            Console.WriteLine($"Расстояние между точками: {distance:F2}");
        }
    }
}
