using System.Collections.Generic;
using System.Linq;

namespace RestaurantMangementSystem
{
    public static class KitchenOrderManager
    {
        private static List<Order> kitchenOrders = new List<Order>();

        public static void AddOrderToKitchen(Order order)
        {
            kitchenOrders.Add(order);
        }

        public static List<Order> GetKitchenOrders()
        {
            return kitchenOrders.Where(o => o.Status != OrderStatus.Completed &&
                                           o.Status != OrderStatus.Cancelled).ToList();
        }

        public static void UpdateOrderStatus(int orderId, OrderStatus status)
        {
            var order = kitchenOrders.FirstOrDefault(o => o.OrderId == orderId);
            if (order != null)
            {
                order.Status = status;
            }
        }
    }
}