namespace Labb_4___Generic_collections
{
    public class Resturant
    {
        List<string> menuItems = new List<string>(); // lista av menyartiklar.
        Queue<string> orders = new Queue<string>(); // Lista av beställda ordrar.

        public void AddtoMenu(MenuItem menuItem) // Lägger till en ny maträtt i menyn och loggar detta till konsolen.
        {
            //menuItems.Add(menuItem);
        }
        public void ShowMenu() // Skriver ut alla maträtter i menyn till konsolen.
        {
            foreach (var item in menuItems)
            {
                Console.WriteLine(item);
            }
        }
        public void CreateOrder(Order order) // Lägger till en ny beställning i kön och loggar detta till konsolen.
        {

        }
        public void HandleOrder() // Hanterar (tar bort) den första beställningen i kön och loggar detta till konsolen.
        {

        }
        public string ShowOrders() // Skriver ut alla beställningar i kön till konsolen.
        {
            return "";
        }
        public void ShowNextOrder() // Skriver ut beställningen som är näst i kön till konsolen.
        {
            Console.WriteLine(orders.Peek);
        }
        public void ShowOrderCount() // Skriver ut antalet beställningar i kön till konsolen.
        {
            Console.WriteLine(orders.Count);
        }
    }
}
