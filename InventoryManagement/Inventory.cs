using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace InventoryManagement
{
    public class Inventory
    {
        public void JsonDeserialize()
        {
            InventoryManager manager = new InventoryManager();
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json"));
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("\n1.Dispaly Inventory\n2.Add Inventory\n3.Remove from Inventory\n4.Update to Inventory\n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\n1.Rice\n2.Wheat\n3.Pulse");
                        Console.WriteLine("Enter an option : ");
                        int dispalyOption = Convert.ToInt32(Console.ReadLine());
                        switch (dispalyOption)
                        {
                            case 1:
                                manager.DisplayInventory(utility.RiceList);
                                break;
                            case 2:
                                manager.DisplayInventory(utility.WheatList);
                                break;
                            case 3:
                                manager.DisplayInventory(utility.PulseList);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n1. Add Record to Rice\n2. Add Record to pulse\n3. Add Record to wheat\nEnter your Option:");
                        int optionOne = Convert.ToInt32(Console.ReadLine());
                        switch (optionOne)
                        {
                            case 1:
                                // Adding Item to Inventory......
                                utility.RiceList = manager.AddToInventory(utility.RiceList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 2:
                                // Adding Item to Inventory.......
                                utility.PulseList = manager.AddToInventory(utility.PulseList);
                                //Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 3:
                                // Adding Item to Inventory........
                                utility.WheatList = manager.AddToInventory(utility.WheatList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 3:
                        // options
                        Console.WriteLine("\n1. remove Record from Rice\n2. remove Record from pulse\n3. remove Record from wheat\nEnter your Option:");
                        int optionTwo = Convert.ToInt32(Console.ReadLine());
                        switch (optionTwo)
                        {
                            case 1:
                                //  List of Rice is Displayed from Inventory...
                                manager.DisplayInventory(utility.RiceList);
                                // Removing Item from Inventory.......
                                utility.RiceList = manager.RemoveFromInventory(utility.RiceList);
                                // uUpdating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 2:
                                // List of pulses is Displayed from Inventory...
                                manager.DisplayInventory(utility.PulseList);
                                // Removing Item from Inventory.......
                                utility.PulseList = manager.RemoveFromInventory(utility.PulseList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 3:
                                // List of wheat is Displayed from Inventory... 
                                manager.DisplayInventory(utility.WheatList);
                                // Removing Item from Inventory.......
                                utility.WheatList = manager.RemoveFromInventory(utility.WheatList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n1. Update Record to Rice\n2. Update Record to pulse\n3. Update Record to wheat\nEnter your Option:");
                        int optionThree = Convert.ToInt32(Console.ReadLine());
                        switch (optionThree)
                        {
                            case 1:
                                // List of Rice is Displayed from Inventory...
                                manager.DisplayInventory(utility.RiceList);
                                // Updating Item from a List.....
                                utility.RiceList = manager.UpdateToInventory(utility.RiceList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 2:
                                // List of pulses is Displayed from Inventory...
                                manager.DisplayInventory(utility.PulseList);
                                // Updating Item from a List.....
                                utility.PulseList = manager.UpdateToInventory(utility.PulseList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            case 3:
                                // List of wheat is Displayed from Inventory... 
                                manager.DisplayInventory(utility.WheatList);
                                // Updating Item from a List.....
                                utility.WheatList = manager.UpdateToInventory(utility.WheatList);
                                // Updating Item to JSON file by serializing.......
                                File.WriteAllText(@"D:\tvstraining\InventoryManagement\InventoryManagement\InventoryDetails.json", JsonConvert.SerializeObject(utility));
                                break;
                            default:
                                Console.WriteLine(" Invalid Input ");
                                break;
                        }
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine(" Invalid Input ");
                        break;

                }
            }
            
            
        }
    }
}
