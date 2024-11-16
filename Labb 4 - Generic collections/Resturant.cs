namespace Labb_4___Generic_collections
{
    public class Resturant
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private Queue<Order> orderQueue = new Queue<Order>();

        public void AddtoMenu(MenuItem menuItem)
        {
            menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} was added to the menu");
        }
        public void ShowMenu()
        {
            Console.WriteLine("     MENU");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item}");
            }
        }
        public void CreateOrder(Order order)
        {
            orderQueue.Enqueue(order);
            Console.WriteLine($" Order number #{order.OrderNumber()} was successfully added");
        }
        public void HandleOrder()
        {
            var order = orderQueue.Dequeue();
            Console.WriteLine($"{order} was served!");
        }
        public void ShowOrders()
        {
            Console.WriteLine(" Current orders:"); // Ändra denna
            foreach (var item in orderQueue)
            {
                Console.WriteLine( item);
            }
        }
        public void ShowNextOrder()
        {
            Console.WriteLine($" Next item in queue: {orderQueue.Peek()}");
        }
        public void ShowOrderCount()
        {
            Console.WriteLine($"\n Orders in queue: {orderQueue.Count}\n");
        }
        
    }
}
