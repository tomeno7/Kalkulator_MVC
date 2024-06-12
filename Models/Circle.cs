namespace Kalkulator_MVC.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
        public override double CalculatePerimeter() => 2 * Math.PI * Radius;
    }
}