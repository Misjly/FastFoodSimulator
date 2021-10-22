using System.Collections.Generic;
using System.Linq;

namespace FastFoodSimulator.Model
{
    class TakeAway
    {
        private static TakeAway _instance;
        public List<Order> ReadyOrders = new List<Order>();

        public Order GetOrder()
        {
            Order order = ReadyOrders.First();
            ReadyOrders.Remove(order);
            return order;
        }
        public void PutOrder(Order order)
        {
            ReadyOrders.Add(order);
        }
        public Order FindByOrderNum(int number)
        {
            foreach (Order order in ReadyOrders)
            {
                if (order.OrderNumber == number)
                    return order;
            }
            return null;
        }

        private TakeAway() { }
        public static TakeAway GetInstance()
        {
            if (_instance == null)
                _instance = new TakeAway();
            return _instance;
        }
    }
}
