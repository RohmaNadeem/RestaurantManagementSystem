using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace RestaurantMangementSystem
{
    [Serializable]
    [XmlRoot("Order")]
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderType Type { get; set; }
        public string TableNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string DeliveryAddress { get; set; }

        [XmlArray("Items")]
        [XmlArrayItem("OrderItem")]
        public List<OrderItem> Items { get; set; }

        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public string PaymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public OrderStatus Status { get; set; }
        public string Notes { get; set; }

        public Order()
        {
            OrderNumber = GenerateOrderNumber();
            OrderDate = DateTime.Now;
            Items = new List<OrderItem>();
            Status = OrderStatus.Pending;
            IsPaid = false;
        }


        private string GenerateOrderNumber()
        {
            return $"ORD-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
        }

        public void CalculateTotals()
        {
            SubTotal = Items.Sum(item => item.TotalPrice);
            Tax = SubTotal * 0.10m; // 10% tax
            Total = SubTotal + Tax - Discount;
        }

        public void AddItem(Product product, int quantity = 1)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
                existingItem.TotalPrice = existingItem.Quantity * existingItem.UnitPrice;
            }
            else
            {
                Items.Add(new OrderItem
                {
                    ProductId = product.Id,
                    ProductName = product.Name,
                    UnitPrice = product.Price,
                    Quantity = quantity,
                    TotalPrice = product.Price * quantity,
                    Notes = ""
                });
            }
            CalculateTotals();
        }

        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                Items.Remove(item);
                CalculateTotals();
            }
        }

        public void UpdateQuantity(int productId, int quantity)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                item.Quantity = quantity;
                item.TotalPrice = item.Quantity * item.UnitPrice;
                CalculateTotals();
            }
        }
    }

    [Serializable]
    public class OrderItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string Notes { get; set; }
    }

    public enum OrderType
    {
        DineIn,
        TakeAway,
        Delivery
    }

    public enum OrderStatus
    {
        Pending,
        Preparing,
        Ready,
        Served,
        Completed,
        Cancelled
    }
}