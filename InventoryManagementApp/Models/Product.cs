using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
      

     
        public void addAssociatedPart(Part part) {
            AssociatedParts.Add(part);

        }

        public bool removeAssociatedPart(int partID) {
           return AssociatedParts.Remove(Inventory.lookupPart(partID));
        }

        public Part lookupAssoicatedPart(int partID)
        {
            
            for (int i = 0; i < AssociatedParts.Count; i++) {
                if (AssociatedParts[i].PartID == partID) {
                    return AssociatedParts[i];
                }
            }
            
            return null;
        }

    
    }
}
