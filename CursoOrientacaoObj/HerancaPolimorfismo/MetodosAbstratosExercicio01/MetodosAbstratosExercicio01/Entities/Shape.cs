using MetodosAbstratosExercicio01.Entities.Enums;

namespace MetodosAbstratosExercicio01.Entities
{
    internal abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        public abstract double Area();
    }
}
