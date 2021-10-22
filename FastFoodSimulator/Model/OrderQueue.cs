using System.Collections.Generic;
using System.Linq;

namespace FastFoodSimulator.Model
{
    class OrderQueue
    {
        private static OrderQueue _instance;
        public List<Order> OrderList = new List<Order>();
        private Order _lastOrder;
        public Order GetLastOrder() { return _lastOrder; }
        public void SetLastOrder(Order lastOrder) { this._lastOrder = lastOrder; }
        
        public void AddOrder(Order order)
        {
            OrderList.Add(order);
            _lastOrder = order;
        }
        public Order GetOrder()
        {
            Order order = OrderList.First();
            OrderList.Remove(order);
            return order;
        }              

        public static OrderQueue GetInstance() {
            if (_instance == null)
                _instance = new OrderQueue();
            return _instance;
        }
        private OrderQueue() { }
    }
}
