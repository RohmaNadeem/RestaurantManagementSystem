using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    public static class OrderStorage
    {
        private static readonly string StorageFile = "orders.xml";
        private static List<Order> orders = new List<Order>();
        private static int nextId = 1;
        private static bool isLoaded = false;

        static OrderStorage()
        {
            LoadOrders();
        }

        public static void LoadOrders()
        {
            try
            {
                if (File.Exists(StorageFile))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                    using (FileStream file = File.OpenRead(StorageFile))
                    {
                        var loadedOrders = (List<Order>)serializer.Deserialize(file);
                        orders = loadedOrders ?? new List<Order>();

                        if (orders.Count > 0)
                        {
                            nextId = orders.Max(o => o.OrderId) + 1;
                        }
                        isLoaded = true;
                        Console.WriteLine($"Loaded {orders.Count} orders from {StorageFile}");
                    }
                }
                else
                {
                    orders = new List<Order>();
                    isLoaded = true;
                    Console.WriteLine($"No orders file found at {StorageFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading orders: {ex.Message}");
                orders = new List<Order>();
                isLoaded = true;
            }
        }

        public static void SaveOrders()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Order>));
                using (TextWriter writer = new StreamWriter(StorageFile))
                {
                    serializer.Serialize(writer, orders);
                    Console.WriteLine($"Saved {orders.Count} orders to {StorageFile}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving orders: {ex.Message}");
            }
        }

        public static List<Order> GetAllOrders()
        {
            // Make sure orders are loaded
            if (!isLoaded)
            {
                LoadOrders();
            }
            return new List<Order>(orders);
        }

        public static Order GetOrderById(int id)
        {
            if (!isLoaded) LoadOrders();
            return orders.Find(o => o.OrderId == id);
        }

        public static void AddOrder(Order order)
        {
            if (!isLoaded) LoadOrders();

            order.OrderId = nextId++;
            orders.Add(order);
            SaveOrders();

            // Log for debugging
            Console.WriteLine($"Order #{order.OrderId} ({order.OrderNumber}) added with status: {order.Status}");
            Console.WriteLine($"Items count: {order.Items?.Count ?? 0}");

            // Notify kitchen
            KitchenOrderManager.AddOrderToKitchen(order);
        }

        public static bool UpdateOrder(Order updatedOrder)
        {
            if (!isLoaded) LoadOrders();

            var existingOrder = orders.Find(o => o.OrderId == updatedOrder.OrderId);
            if (existingOrder != null)
            {
                // Update all properties
                existingOrder.Status = updatedOrder.Status;
                existingOrder.IsPaid = updatedOrder.IsPaid;
                existingOrder.PaidDate = updatedOrder.PaidDate;
                existingOrder.PaymentMethod = updatedOrder.PaymentMethod;
                existingOrder.CustomerName = updatedOrder.CustomerName;
                existingOrder.CustomerPhone = updatedOrder.CustomerPhone;
                existingOrder.TableNumber = updatedOrder.TableNumber;
                existingOrder.DeliveryAddress = updatedOrder.DeliveryAddress;
                existingOrder.Type = updatedOrder.Type;
                existingOrder.Notes = updatedOrder.Notes;
                existingOrder.Discount = updatedOrder.Discount;

                // Update items if provided
                if (updatedOrder.Items != null && updatedOrder.Items.Count > 0)
                {
                    existingOrder.Items = updatedOrder.Items;
                    existingOrder.CalculateTotals();
                }

                SaveOrders();
                Console.WriteLine($"Order #{existingOrder.OrderId} updated. Status: {existingOrder.Status}");
                return true;
            }
            return false;
        }

        public static List<Order> GetTodayOrders()
        {
            if (!isLoaded) LoadOrders();
            return orders.Where(o => o.OrderDate.Date == DateTime.Today).ToList();
        }

        public static List<Order> GetPendingKitchenOrders()
        {
            if (!isLoaded) LoadOrders();
            return orders.Where(o => o.Status == OrderStatus.Pending ||
                                    o.Status == OrderStatus.Preparing ||
                                    o.Status == OrderStatus.Ready).ToList();
        }

        // Debug method
        public static void PrintAllOrders()
        {
            Console.WriteLine("=== ALL ORDERS IN STORAGE ===");
            foreach (var order in orders)
            {
                Console.WriteLine($"ID: {order.OrderId}, #: {order.OrderNumber}, Status: {order.Status}, Items: {order.Items?.Count ?? 0}");
            }
            Console.WriteLine("==============================");
        }
    }
}