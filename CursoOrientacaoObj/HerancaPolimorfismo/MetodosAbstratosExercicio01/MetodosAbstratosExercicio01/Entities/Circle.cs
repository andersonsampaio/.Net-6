using MetodosAbstratosExercicio01.Entities.Enums;

namespace MetodosAbstratosExercicio01.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
