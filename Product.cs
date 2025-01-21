using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson17
{
    internal class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }

        private string categoryID;

        public string CategoryID
        {
            get { return categoryID; }
            set
            {
                if(value == null)
                {
                    value = new Guid().ToString();
                    categoryID = value;
                }
                else
                {
                    categoryID = value;
                }
               
            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }

            }
        }

        public int Quantity { get; set; }

        public Product(string name, string category, int price, int quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            CategoryID = Guid.NewGuid().ToString();
        }

        public void UpdateQuantity(int count)
        {
            Quantity += count;
        }

        public void DisplayInfo()
        {
            Console.Write($"{Category} | {Name} | {Price} | {Quantity} | {CategoryID} \n");
        }

    }
}
