using Heranca_x_Interface01.Model.Enums;

namespace Heranca_x_Interface01.Model.Entities
{
    abstract class AbstractShape : IShape // é um subtipo da Interface
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
