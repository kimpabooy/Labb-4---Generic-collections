using System.Diagnostics;
using System.Numerics;

namespace Labb_4___Generic_collections
{
    public class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public override string ToString()
        {
            string orders = string.Join("\n", _orderItems);
            return $" Order #{_orderId}\n{orders}\n Bordsnummer: {_tableNumber}";
        }
        
        public int OrderNumber()
        {
            return _orderId;
        }
                
        public decimal TotalPrice()
        {
            decimal sum = 0;
            foreach (var item in _orderItems)
            {
                sum += item.Price;
            }
            return sum;
        }
    }
}
