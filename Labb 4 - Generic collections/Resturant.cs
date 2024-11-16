namespace Labb_4___Generic_collections
{
    public class Resturant
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private Queue<Order> orderQueue = new Queue<Order>();

        public void AddtoMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($" {menuItem.Name} har lagts till i menyn");
        }
        public void ShowMenu()
        {
            Console.WriteLine("     Meny");
            foreach (var item in menu)
            {
                Console.WriteLine($" {item.Id}.{item}");
            }
        }
        public void CreateOrder(Order order)
        {
            orderQueue.Enqueue(order);
            Console.WriteLine($" Beställning nr {order.OrderNumber()} har lagts till");
        }
        public void HandleOrder()
        {
            var order = orderQueue.Dequeue();
            Console.WriteLine($" Order nummer {order.OrderNumber()} är klar!");
        }
        public void ShowOrders()
        {
            Console.WriteLine(" Pågående beställningar: \n");
            foreach (var item in orderQueue)
            {
                Console.WriteLine(item);
                Console.WriteLine($" Summa: {item.TotalPrice():C} \n");
            }
        }
        public void ShowNextOrder()
        {
            Console.WriteLine($" Nästa beställning: {orderQueue.Peek()}");
        }
        public void ShowOrderCount()
        {
            Console.WriteLine($"\n Antal ordrar i kön: {orderQueue.Count}\n");
        }
        
    }
}
