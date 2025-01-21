using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Inventory
    {
        public Product[] ProductInventory {  get; set; }
        private int count = 0;


        public void AddProduct(Product product)
        {
            ProductInventory[count++] = product;
        }

        public void DisplayProducts()
        {
            for (int i = 0; i < count; i++)
            {
                if (ProductInventory[i] != null)
                {
                    Console.Write($"{ProductInventory[i].Category} | {ProductInventory[i].Name} | {ProductInventory[i].Price} | {ProductInventory[i].Quantity} | {ProductInventory[i].CategoryID} \n");
                }
            }
        }

        public void UpdateProductQuantity(int count, string id) 
        {
            for (int i = 0; i < ProductInventory.Length; i++)
            {
                if(ProductInventory[i] != null && ProductInventory[i].CategoryID == id)
                {
                    ProductInventory[i].UpdateQuantity(count);
                }
            }
        }

        public void FindProductByID(string id)
        {
            for (int i = 0; i < ProductInventory.Length; i++)
            {
                if (id.Trim() != null && ProductInventory[i].CategoryID == id)
                {
                    Console.Write($"{ProductInventory[i].Category} | {ProductInventory[i].Name} | {ProductInventory[i].Price} | {ProductInventory[i].CategoryID} \\n");
                    break;
                }
            }
        }

        public Inventory(int size)
        {
            ProductInventory = new Product[size];
        }

    }
}
