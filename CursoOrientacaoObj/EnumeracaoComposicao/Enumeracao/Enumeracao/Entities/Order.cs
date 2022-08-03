using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities {
    internal class Order {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        override public string ToString() {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
