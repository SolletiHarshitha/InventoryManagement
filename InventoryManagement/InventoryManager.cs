using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    class InventoryManager
    {
        //Add to Inventory
        public List<InventoryUtility.Rice> AddToInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of Rice");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Rice");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight of Rice in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Rice");
            utility.Type = Console.ReadLine();
            rice.Add(utility);
            Console.WriteLine("\n" + utility.Name + " Rice Added Successfully");
            return rice;
        }
        public List<InventoryUtility.Wheat>AddToInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of Wheat");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Wheat");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight of Wheat in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Wheat");
            utility.Type = Console.ReadLine();
            wheat.Add(utility);
            Console.WriteLine("\n" + utility.Name + " Wheat Added Successfully");
            return wheat;
        }
        public List<InventoryUtility.Pulse> AddToInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of Pulse");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Pulse");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight ofPulse in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Pulse");
            utility.Type = Console.ReadLine();
            pulse.Add(utility);
            Console.WriteLine("\n" + utility.Name + " Pulse Added Successfully");
            return pulse;
        }

        //Update to Inventory
        public List<InventoryUtility.Rice> UpdateToInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.Write("Enter Name of Rice to be updated : ");
            string itemName = Console.ReadLine();
            rice.Remove(rice.Find(ut => ut.Name.Equals(itemName)));

            Console.WriteLine("Enter Name of Rice");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Rice");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight of Rice in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Rice");
            utility.Type = Console.ReadLine();
            rice.Add(utility);
            return rice;
        }
        public List<InventoryUtility.Wheat> UpdateToInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.Write("Enter Name of Wheat to be updated : ");
            string itemName = Console.ReadLine();
            wheat.Remove(wheat.Find(ut => ut.Name.Equals(itemName)));

            Console.WriteLine("Enter Name of Wheat");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Wheat");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight of Wheat in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Wheat");
            utility.Type = Console.ReadLine();
            wheat.Add(utility);
            return wheat;
        }
        public List<InventoryUtility.Pulse> UpdateToInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.Write("Enter Name of Pulse to be updated : ");
            string itemName = Console.ReadLine();
            pulse.Remove(pulse.Find(ut => ut.Name.Equals(itemName)));

            Console.WriteLine("Enter Name of Pulse");
            utility.Name = Console.ReadLine();
            Console.WriteLine("Enter Price of Pulse");
            utility.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight of Pulse in kgs");
            utility.Kg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Type of Pulse");
            utility.Type = Console.ReadLine();
            pulse.Add(utility);
            return pulse;
        }

        //Remove from Inventory
        public List<InventoryUtility.Rice> RemoveFromInventory(List<InventoryUtility.Rice> rice)
        {
            InventoryUtility.Rice utility = new InventoryUtility.Rice();
            Console.WriteLine("Enter Name of Rice");
            string itemName = Console.ReadLine();
            rice.Remove(rice.Find(ut => ut.Name.Equals(itemName)));
            Console.WriteLine("\n" + itemName + " Rice Deleted Successfully");
            return rice;
        }
        public List<InventoryUtility.Wheat> RemoveFromInventory(List<InventoryUtility.Wheat> wheat)
        {
            InventoryUtility.Wheat utility = new InventoryUtility.Wheat();
            Console.WriteLine("Enter Name of Wheat");
            string itemName = Console.ReadLine();
            wheat.Remove(wheat.Find(ut => ut.Name.Equals(itemName)));
            Console.WriteLine("\n" + itemName + " Wheat Deleted Successfully");
            return wheat;
        }
        public List<InventoryUtility.Pulse> RemoveFromInventory(List<InventoryUtility.Pulse> pulse)
        {
            InventoryUtility.Pulse utility = new InventoryUtility.Pulse();
            Console.WriteLine("Enter Name of Pulse");
            string itemName = Console.ReadLine();
            pulse.Remove(pulse.Find(ut => ut.Name.Equals(itemName)));
            Console.WriteLine("\n" + itemName + " Pulse Deleted Successfully");
            return pulse;
        }

        //Display Inventory
        public void DisplayInventory(List<InventoryUtility.Rice> rice)
        {
            Console.WriteLine("********************Rice Inventory*********************************");
            int totalInventoryRice = 0;
            foreach(InventoryUtility.Rice i in rice)
            {
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
                Console.WriteLine("\nName : " + i.Name + "\nWeight : " + i.Kg + "\nPrice : " + i.Price + "\nType : " + i.Type);
            }
            Console.WriteLine("Total Inventory cost for rice is : " + totalInventoryRice);
        }
        public void DisplayInventory(List<InventoryUtility.Wheat> wheat)
        {
            Console.WriteLine("******************Wheat Inventory**********************************");
            int totalInventoryRice = 0;
            foreach (InventoryUtility.Wheat i in wheat)
            {
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
                Console.WriteLine("\nName : " + i.Name + "\nWeight : " + i.Kg + "\nPrice : " + i.Price + "\nType : " + i.Type);
            }
            Console.WriteLine("Total Inventory cost for wheat is : " + totalInventoryRice);
        }
        public void DisplayInventory(List<InventoryUtility.Pulse> pulse)
        {
            Console.WriteLine("*****************Pulse Inventory***********************************");
            int totalInventoryRice = 0;
            foreach (InventoryUtility.Pulse i in pulse)
            {
                totalInventoryRice += ManageInventory(i.Kg, i.Price);
                Console.WriteLine("\nName : " + i.Name + "\nWeight : " + i.Kg + "\nPrice : " + i.Price + "\nType : " + i.Type);
            }
            Console.WriteLine("Total Inventory cost for pulse is : " + totalInventoryRice);
        }

        public int ManageInventory(int kg,int price)
        {
            return kg * price;
        }
    }
} 
