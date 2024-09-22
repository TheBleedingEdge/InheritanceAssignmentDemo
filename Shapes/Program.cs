namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle("Rectangle", 5, 3);
            rectangle.Fill("Yellow");
            Console.WriteLine($"{rectangle.Name}'s surface area is {rectangle.CalculateSurfaceArea()} units.");

            var triangle = new Triangle("Pythagoras", 5, 3);
            triangle.Fill("Blue");
            Console.WriteLine($"{triangle.Name}'s surface area is {triangle.CalculateSurfaceArea()} units.");

            var circle = new Circle("Circle", 6);
            circle.Fill("Red");
            Console.WriteLine($"{circle.Name}'s surface area is {circle.CalculateSurfaceArea()} units.");
        }
    }
}
