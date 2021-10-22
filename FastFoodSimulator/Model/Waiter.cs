using System.Threading;

namespace FastFoodSimulator.Model
{
    class Waiter
    {
        private static readonly OrderQueue _list = OrderQueue.GetInstance();
        private int _id = 0;
        public int PlaceOrder()
        {
            Thread.Sleep(1000);
            if (_list.GetLastOrder() == null)
                _id = 1;
            else
                _id = _list.GetLastOrder().OrderNumber + 1;
            Order order = new Order(_id);
            _list.AddOrder(order);
            return _id;
        }
    }
}
