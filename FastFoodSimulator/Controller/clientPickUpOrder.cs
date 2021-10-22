using FastFoodSimulator.Model;
using FastFoodSimulator.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FastFoodSimulator.Controller
{
    public class ClientPickUpOrder
    {
        private static TakeAway _takeAway = TakeAway.GetInstance();
        private static Thread _customerTakeOrder;
        public static Semaphore Semaphore = new Semaphore(0, 100);

        public static void StartPickUp() {
            _customerTakeOrder = new Thread(TakeOrder);
            _customerTakeOrder.Start();
        }

        public static void AbortPickUp() {
            _customerTakeOrder.Abort();
        }

        public static void TakeOrder() {
            while (true) {
                Semaphore.WaitOne();
                try
                {
                    Order order = _takeAway.GetOrder();
                    Thread.Sleep(2000);
                    _takeAway.ReadyOrders.Remove(order);
                    if (Application.OpenForms["SimulationForm"] != null)
                    {
                        (Application.OpenForms["SimulationForm"] as SimulationForm).DeleteReadyLine();
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
