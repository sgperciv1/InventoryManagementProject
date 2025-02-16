using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Models
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        public static int PartIdCount = 0;
        public static int ProductIdCount = 0;

        static Inventory()
        {
            AddPartsToInventory();
            AddProductsToInventory();
        }

        private static void AddPartsToInventory()
        {
            var parts = new List<Part>
            {
                new Inhouse { PartID = 0, Name = "Wheel", InStock = 15, Price = 12.11M, Min = 5, Max = 25, MachineID = 1 },
                new Inhouse { PartID = 1, Name = "Pedal", InStock = 11, Price = 8.22M, Min = 5, Max = 25, MachineID = 2 },
                new Outsourced { PartID = 2, Name = "Chain", InStock = 12, Price = 8.33M, Min = 5, Max = 25, CompanyName = "Chain Company" },
                new Outsourced { PartID = 3, Name = "Seat", InStock = 8, Price = 4.55M, Min = 2, Max = 15, CompanyName = "Seat Company" }
            };

            foreach (var part in parts)
            {
               addPart(part);
            }
          
        }

        private static void AddProductsToInventory()
        {
            var products = new List<Product>
            {
                new Product { ProductID = 0, Name = "Red Bicycle", InStock = 15, Price = 11.44M, Min = 1, Max = 25 },
                new Product { ProductID = 1, Name = "Yellow Bicycle", InStock = 19, Price = 9.66M, Min = 1, Max = 20 },
                new Product { ProductID = 2, Name = "Blue Bicycle", InStock = 5, Price = 12.77M, Min = 1, Max = 25 }
            };

            products[0].addAssociatedPart(AllParts[1]); 
            products[0].addAssociatedPart(AllParts[2]);

            products[1].addAssociatedPart(AllParts[1]); 
            products[1].addAssociatedPart(AllParts[2]); 
            products[1].addAssociatedPart(AllParts[3]); 

            products[2].addAssociatedPart(AllParts[1]); 
            products[2].addAssociatedPart(AllParts[3]);

            foreach (var product in products)
            {
               addProduct(product);
            }
           
        }


        public static void addProduct(Product product)
        {
            Products.Add(product);
            ProductIdCount++;

        }
        public static bool removeProduct(int productID)
        {

            for (int index = 0; index < Products.Count; ++index)
            {
                if (Products[index].ProductID == productID)
                {
                    return Products.Remove(Products[index]);

                }
            }

            return false;
        }
        public static Product lookupProduct(int productID)
        {
           for(int i=0; i< Products.Count; ++i)
            {
                if (Products[i].ProductID == productID) { 
                return Products[i];
                }

            }
            return null;
        }
        public static void updateProduct(int productID, Product product)
        {

            for (int index = 0; index < Products.Count; ++index)
            {
                if (Products[index].ProductID == productID)
                {
                    Products[index] = product;
                    break;
                }
            }


        }
        public static void addPart(Part part)
        {
            AllParts.Add(part);
            PartIdCount++;
        }

        public static bool deletePart(Part part)
        {
            return AllParts.Remove(part);

        }
        public static Part lookupPart(int partID)
        {

            for (int i = 0; i < AllParts.Count; i++) {
                if (AllParts[i].PartID == partID) {
                    return AllParts[i];
                }

            }
            
            return null;


        }
        public static void updatePart(int partID, Part part)
        {

            for (int index = 0; index < AllParts.Count; ++index)
            {
                if (AllParts[index].PartID == partID)
                {
                    AllParts[index] = part;
                    break;
                }
            }

        }
    }
}
