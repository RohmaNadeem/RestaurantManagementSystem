using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class ProductStorage
    {
        private static readonly string StorageFile = "products.xml";
        private static List<Product> products = new List<Product>();
        private static int nextId = 1;

        static ProductStorage()
        {
            LoadProducts();
        }

        public static void LoadProducts()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                    using (FileStream file = File.OpenRead(StorageFile))
                    {
                        products = (List<Product>)serializer.Deserialize(file);
                        if (products.Count > 0)
                        {
                            nextId = products.Max(p => p.Id) + 1;
                        }
                    }
                }
                else
                {
                    CreateSampleProducts();
                    SaveProducts();
                }
            }
            catch (Exception)
            {
                products = new List<Product>();
                CreateSampleProducts();
                SaveProducts();
            }
        }

        public static void SaveProducts()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
                using (TextWriter writer = new StreamWriter(StorageFile))
                {
                    serializer.Serialize(writer, products);
                }
            }
            catch (Exception)
            {
                // Silently fail
            }
        }

        private static void CreateSampleProducts()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Burger", Category = "Main Course",
                    Description = "Classic beef burger with cheese", Price = 12.99m,
                    Cost = 4.50m, StockQuantity = 50, Unit = "Piece", IsAvailable = true,
                    CreatedDate = DateTime.Now.AddDays(-30) },
                new Product { Id = 2, Name = "French Fries", Category = "Appetizers",
                    Description = "Crispy golden fries", Price = 5.99m, Cost = 1.20m,
                    StockQuantity = 200, Unit = "Portion", IsAvailable = true,
                    CreatedDate = DateTime.Now.AddDays(-25) },
                new Product { Id = 3, Name = "Caesar Salad", Category = "Salads",
                    Description = "Fresh salad with Caesar dressing", Price = 8.99m,
                    Cost = 2.80m, StockQuantity = 30, Unit = "Bowl", IsAvailable = true,
                    CreatedDate = DateTime.Now.AddDays(-20) },
                new Product { Id = 4, Name = "Coca Cola", Category = "Beverages",
                    Description = "330ml can", Price = 2.50m, Cost = 0.80m,
                    StockQuantity = 150, Unit = "Can", IsAvailable = true,
                    CreatedDate = DateTime.Now.AddDays(-15) },
                new Product { Id = 5, Name = "Chocolate Cake", Category = "Desserts",
                    Description = "Rich chocolate cake slice", Price = 6.99m, Cost = 2.00m,
                    StockQuantity = 20, Unit = "Slice", IsAvailable = true,
                    CreatedDate = DateTime.Now.AddDays(-10) }
            };
            nextId = 6;
        }

        public static List<Product> GetAllProducts()
        {
            return new List<Product>(products);
        }

        public static Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }

        public static List<string> GetAllCategories()
        {
            var categories = new HashSet<string>();
            foreach (var product in products)
            {
                if (!string.IsNullOrEmpty(product.Category))
                    categories.Add(product.Category);
            }
            return categories.ToList();
        }

        public static void AddProduct(Product product)
        {
            product.Id = nextId++;
            product.CreatedDate = DateTime.Now;
            product.LastUpdated = DateTime.Now;
            products.Add(product);
            SaveProducts();
        }

        public static bool UpdateProduct(Product updatedProduct)
        {
            var existingProduct = products.Find(p => p.Id == updatedProduct.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Category = updatedProduct.Category;
                existingProduct.Description = updatedProduct.Description;
                existingProduct.Price = updatedProduct.Price;
                existingProduct.Cost = updatedProduct.Cost;
                existingProduct.StockQuantity = updatedProduct.StockQuantity;
                existingProduct.Unit = updatedProduct.Unit;
                existingProduct.IsAvailable = updatedProduct.IsAvailable;
                existingProduct.LastUpdated = DateTime.Now;
                SaveProducts();
                return true;
            }
            return false;
        }

        public static bool DeleteProduct(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
                SaveProducts();
                return true;
            }
            return false;
        }

        public static List<Product> SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllProducts();

            searchTerm = searchTerm.ToLower();
            return products.FindAll(p =>
                (p.Name != null && p.Name.ToLower().Contains(searchTerm)) ||
                (p.Category != null && p.Category.ToLower().Contains(searchTerm)) ||
                (p.Description != null && p.Description.ToLower().Contains(searchTerm)));
        }

        public static int GetTotalProducts()
        {
            return products.Count;
        }

        public static int GetLowStockProducts(int threshold = 10)
        {
            return products.FindAll(p => p.StockQuantity <= threshold).Count;
        }

        public static decimal GetTotalInventoryValue()
        {
            decimal total = 0;
            foreach (var product in products)
            {
                total += product.Cost * product.StockQuantity;
            }
            return total;
        }
    }
}