using System.Diagnostics;

namespace AreaTriangle
{
    internal class TriArea
    {
        public static double Triangle(double triangleBase, double height)       // ****** 'Base' RESERVED key word ******
        {
            double area = (triangleBase * height / 2);      // eg - 12 x 10 = 120 / 2 = 60
            return area;
        }

        static void Main()
        {
            Console.WriteLine(Triangle(10, 10));        // Output -  50
            Console.WriteLine();

            Console.WriteLine(Triangle(12, 10));        // Output -  60
            Console.WriteLine();

            Console.WriteLine(Triangle(6, 3));        // Output -  9
            Console.WriteLine();

        }
    }
}

// Task - Method that takes the triangles base and height and returns the area.