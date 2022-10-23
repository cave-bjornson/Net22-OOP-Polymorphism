namespace ShapeLibrary
{
    internal static class Shared
    {
        public static void ValidatePositiveSetterValue(double value)
        {
            if (!(value > 0.0))
            {
                throw new ArgumentOutOfRangeException(nameof(value), "must be a positive number");
            }
        }
    }
}
