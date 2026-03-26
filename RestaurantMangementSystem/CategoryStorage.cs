using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class CategoryStorage
    {
        private static readonly string StorageFile = "categories.xml";
        private static List<Category> categories = new List<Category>();
        private static int nextId = 1;
        private static bool isLoaded = false;

        static CategoryStorage()
        {
            LoadCategories();
        }

        public static void LoadCategories()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Category>));
                    using (FileStream file = File.OpenRead(StorageFile))
                    {
                        var loadedCategories = (List<Category>)serializer.Deserialize(file);
                        categories = loadedCategories ?? new List<Category>();

                        if (categories.Count > 0)
                        {
                            nextId = categories.Max(c => c.Id) + 1;
                        }
                        isLoaded = true;
                        Console.WriteLine($"Loaded {categories.Count} categories from {StorageFile}");
                    }
                }
                else
                {
                    categories = new List<Category>();
                    isLoaded = true;
                    Console.WriteLine($"No categories file found at {StorageFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading categories: {ex.Message}");
                categories = new List<Category>();
                isLoaded = true;
            }
        }

        public static void SaveCategories()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Category>));
                using (TextWriter writer = new StreamWriter(StorageFile))
                {
                    serializer.Serialize(writer, categories);
                    Console.WriteLine($"Saved {categories.Count} categories to {StorageFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving categories: {ex.Message}");
            }
        }

        public static List<Category> GetAllCategories()
        {
            if (!isLoaded)
                LoadCategories();
            return new List<Category>(categories);
        }

        public static Category GetCategoryById(int id)
        {
            if (!isLoaded) LoadCategories();
            return categories.Find(c => c.Id == id);
        }

        public static void AddCategory(Category category)
        {
            if (!isLoaded) LoadCategories();

            category.Id = nextId++;
            categories.Add(category);
            SaveCategories();

            Console.WriteLine($"Category '{category.Name}' (ID: {category.Id}) added.");
        }

        public static bool UpdateCategory(Category updatedCategory)
        {
            if (!isLoaded) LoadCategories();

            var existing = categories.Find(c => c.Id == updatedCategory.Id);
            if (existing != null)
            {
                existing.Name = updatedCategory.Name;
                existing.Description = updatedCategory.Description;
                existing.IsActive = updatedCategory.IsActive;
                // Do not update CreatedDate usually; keep original
                SaveCategories();
                Console.WriteLine($"Category ID {existing.Id} updated.");
                return true;
            }
            return false;
        }

        public static bool DeleteCategory(int id)
        {
            if (!isLoaded) LoadCategories();

            var category = categories.Find(c => c.Id == id);
            if (category != null)
            {
                categories.Remove(category);
                SaveCategories();
                Console.WriteLine($"Category ID {id} deleted.");
                return true;
            }
            return false;
        }

        // Optional: Get active categories only
        public static List<Category> GetActiveCategories()
        {
            if (!isLoaded) LoadCategories();
            return categories.Where(c => c.IsActive).ToList();
        }

        // Debug method
        public static void PrintAllCategories()
        {
            Console.WriteLine("=== ALL CATEGORIES IN STORAGE ===");
            foreach (var cat in categories)
            {
                Console.WriteLine($"ID: {cat.Id}, Name: {cat.Name}, Active: {cat.IsActive}");
            }
            Console.WriteLine("==================================");
        }
    }
}