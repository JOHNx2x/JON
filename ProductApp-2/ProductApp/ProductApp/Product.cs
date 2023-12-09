using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }


    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(int id, string name, double price)
        {
            if (products.Any(p => p.ProductId == id))
            {
                // Handle the case where the ID already exists
                MessageBox.Show("Product ID already exists.");
                return;
            }

            // Check if the product name already exists
            if (products.Any(p => p.ProductName == name))
            {
                // Handle the case where the name already exists
                MessageBox.Show("Product name already exists.");
                return;
            }

            // If the ID and name are unique, add the new product
            Product newProduct = new Product()
            {
                ProductId = id,
                ProductName = name,
                ProductPrice = price,
            };

            products.Add(newProduct);
        }



        public void DisplayProducts(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = products;
            dataGridView.Refresh();

        }

        public Product FindProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    Console.WriteLine($"\nID: {product.ProductId}, Name: {product.ProductName}, Price: {product.ProductPrice}");
                    return product;
                }
            }

            return null; // return null if no product found with the given id
        }

    }
}
