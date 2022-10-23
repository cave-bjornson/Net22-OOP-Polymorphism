using ShapeLibrary;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main()
        {
            var geometricShapes = new List<Geometry>
            {
                new Parallelogram(),
                new Rectangle(),
                new Square(),
                new Ellipse(),
                new Circle()
            };

            geometricShapes.ForEach(
                shape => Console.WriteLine($"Area {shape.GetType().Name}: {shape.Area():N2}")
            );
        }
    }
}
