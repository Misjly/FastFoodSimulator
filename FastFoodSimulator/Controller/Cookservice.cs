using FastFoodSimulator.Model;
using FastFoodSimulator.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FastFoodSimulator.Controller
{
    public class CookService
    {
        private static OrderQueue _orderQueue = OrderQueue.GetInstance();
        private static TakeAway _takeAway = TakeAway.GetInstance();
        public static Semaphore Semaphore = new Semaphore(0, 100);
        private static Thread _cookThread;

        public static void StartCookService(int num)
        {
            _cookThread = new Thread(new ParameterizedThreadStart(TakeAndPlaceOrder));
            _cookThread.Start(num);
        }

        public static void AbortCookService()
        {
            _cookThread.Abort();
        }
        public static void TakeAndPlaceOrder(object time) {
            int myTime = Convert.ToInt32(time);
            while (true) {
                Semaphore.WaitOne();
                Order order;
                try
                {
                    order = _orderQueue.GetOrder();
                    _orderQueue.OrderList.Remove(order);
                    if (Application.OpenForms["SimulationForm"] != null)
                    {
                        (Application.OpenForms["SimulationForm"] as SimulationForm).Delete();
                        (Application.OpenForms["SimulationForm"] as SimulationForm).QueueUpdate();
                        (Application.OpenForms["SimulationForm"] as SimulationForm).ProgressQueue(order.OrderNumber);
                    }
                    Thread.Sleep(myTime * 1000);
                    _takeAway.PutOrder(order);
                    if (Application.OpenForms["SimulationForm"] != null)
                    {
                        (Application.OpenForms["SimulationForm"] as SimulationForm).ProgressQueue(0);
                    }
                    if (Application.OpenForms["SimulationForm"] != null)
                    {
                        (Application.OpenForms["SimulationForm"] as SimulationForm).UpdateReadyLine(order);
                    }

                }
                catch (Exception) { }
                ClientPickUpOrder.Semaphore.Release();
            }
        }
    }
}
