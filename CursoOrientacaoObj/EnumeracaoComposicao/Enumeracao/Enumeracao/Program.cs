
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;

namespace Enumeracao {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString(); //Convertendo Enumeração para String
            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);
            
        }
    }
}