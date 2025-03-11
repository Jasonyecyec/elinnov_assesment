namespace elinnov_exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            InventoryManager inventoryManager = new InventoryManager();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1️.Add Product");
                Console.WriteLine("2️.Remove Product");
                Console.WriteLine("3️.Update Product");
                Console.WriteLine("4️.List Products");
                Console.WriteLine("5️.Get Total Inventory Value");
                Console.WriteLine("6️.Exit");
                Console.Write("Enter choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Enter a number between 1 - 6");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        int productId = validInt("Enter ProductId: ", 1);
                        Console.Write("Enter Product name: ");
                        string name = Console.ReadLine();
                        int quantity = validInt("Enter Quantity: ", 0);
                        double price = validDouble("Enter Price: ", 0);

                        inventoryManager.AddProduct(new Product(productId, name, quantity, price));
                    break;

                    case 2:
                        int removeId = validInt("Enter Product ID to remove: ",1);
                        inventoryManager.RemoveProduct(removeId);
                    break;

                    case 3:
                        int updateId = validInt("Enter Product ID to update: ", 1);
                        int newQuantity = validInt("Enter new Quantity: ", 0);
                        inventoryManager.UpdateProduct(updateId, newQuantity);
                    break;

                    case 4:
                        inventoryManager.ListProducts();
                    break;

                    case 5:
                        Console.WriteLine($"Total Inventory value: {inventoryManager.GetTotalValue():C}");
                    break;

                    case 6:
                        isRunning = false;
                        Console.WriteLine("Exiting inventory...");
                    break;

                    default:
                        Console.WriteLine("Invalid choice, Please try again.");
                    break;
                }
            }
        }

        public static int validInt(string prompt, int minValue)
        {
            int value;

            while (true)
            {
                Console.Write(prompt);
                if(int.TryParse(Console.ReadLine(), out value) && value >= minValue)
                {
                    return value;
                }

                Console.WriteLine($"Invalid input! Please enter number greater than or equal to {minValue}");
            }

        }

        public static double validDouble(string prompt, double minValue)
        {
            double value;

            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out value) && value >= minValue)
                {
                    return value;
                }

                Console.WriteLine($"Invalid input! Please enter number greater than or equal to {minValue}");
            }
        }
    }
}
