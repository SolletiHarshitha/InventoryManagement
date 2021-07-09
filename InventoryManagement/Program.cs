using System;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inventory Management");
            Inventory inventory = new Inventory();
            inventory.JsonDeserialize();
        }
    }
}
