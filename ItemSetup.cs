using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke4Marija
{
    internal class ItemSetup
    {
        public Item ItemList { get; set; }

        

        public void ProductSetup(Store MyStore)
        {
            int productIndex = 0;
            string productName = "";
            string productType = "";
            int productPrice = 0;
            int productCount = 0;
            
            // Number of items
            Console.WriteLine("How many different items are you selling at your store?");
            int NumberOfProducts = int.Parse(Console.ReadLine());


            //Add amount of items at the store:

            while (productIndex < NumberOfProducts)
            {

                //Name
                Console.WriteLine("What is the name of your product?");
                productName = Console.ReadLine();

                //Price
                Console.WriteLine($"Enter {productName}'s price:");
                productPrice = int.Parse(Console.ReadLine());

                //Type
                Console.WriteLine($"What's the product's type?");
                productType = Console.ReadLine();

                //Count
                Console.WriteLine($"How many of {productName} in stock?");
                productCount = int.Parse(Console.ReadLine());

                // 
                MyStore.Items.Add(new Item(productName, productType, productPrice, productCount));
                productIndex++;

                Console.Clear();
                
            }

            Console.WriteLine("List of all products: ");
            foreach (var product in MyStore.Items)
            {
                Console.WriteLine("Name: " + product.ProductName + " | Type: " + product.ProductType + " | Price: " + product.ProductPrice + " | In stock: " + productCount);
                Console.WriteLine();
                 
            }

            // Store setup is now finished
            // Switch to shopping customer

        }


    }


}
