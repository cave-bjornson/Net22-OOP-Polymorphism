namespace ShapeLibrary
{
    public abstract class Geometry
    {
        public abstract double Area();

        public override string ToString()
        {
            return $"{nameof(Area)}: {Area():N2}";
        }
    }
}
