namespace Labb_4___Generic_collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            Resturant resturant = new Resturant();

            resturant.AddtoMenu(new MenuItem(1, "Pankakor", 49));
            resturant.AddtoMenu(new MenuItem(2, "Hamburgare", 99));
            resturant.AddtoMenu(new MenuItem(3, "Fläskfilé", 149));
            resturant.AddtoMenu(new MenuItem(4, "Crème brûlée", 65));
            LineBreak();

            resturant.ShowMenu();
            LineBreak();

            // Adding orders
            Order order1 = new Order(new List<MenuItem> {
                new MenuItem(1, "Pankakor", 49),
                new MenuItem(2, "Hamburgare", 99) 
            }, 5);
            resturant.CreateOrder(order1);
            
            Order order2 = new Order(new List<MenuItem> {
                new MenuItem(3, "Fläskfilé", 149),
                new MenuItem(4, "crème brûlée", 65) 
            }, 10);
            resturant.CreateOrder(order2);
            
            Order order3 = new Order(new List<MenuItem> {
                new MenuItem(1, "Pankakor", 49),
                new MenuItem(3, "Fläskfilé", 149) 
            }, 15);
            resturant.CreateOrder(order3);
            LineBreak();

            resturant.ShowOrders();
            LineBreak();

            resturant.ShowOrderCount();
            LineBreak();

            resturant.ShowNextOrder();
            LineBreak();

            // Serving 1 order.
            resturant.HandleOrder();
            LineBreak();

            resturant.ShowOrderCount();
            LineBreak();

            // Adding a new order to the list.
            var order4 = new Order(new List<MenuItem> {
                new MenuItem(4, "crème brûlée", 65),
                new MenuItem(2, "Hamburgare", 99) 
            }, 20);
            resturant.CreateOrder(order4);
            LineBreak();

            resturant.ShowOrderCount();
            LineBreak();

            // Serving 2 orders.
            resturant.HandleOrder();
            resturant.HandleOrder();
            LineBreak();

            resturant.ShowOrderCount();
            LineBreak();

            resturant.ShowNextOrder();
            LineBreak();

            // Serveing 1 order.
            resturant.HandleOrder();
            LineBreak();

            resturant.ShowOrderCount();


            Console.ReadKey();
        }

        static void LineBreak()
        {
            Console.WriteLine("--------------------------------------------");
        }
    }
}
