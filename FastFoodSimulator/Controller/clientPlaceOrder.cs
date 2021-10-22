using FastFoodSimulator.Model;
using FastFoodSimulator.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FastFoodSimulator.Controller
{
    public class ClientPlaceOrder
    {
        public static Semaphore Semaphore = new Semaphore(0, 100);
        private static Thread _customerPlaceOrder;

        public static void StartPlaceOrder(int num) {
            _customerPlaceOrder = new Thread(new ParameterizedThreadStart(PlaceOrder));
            _customerPlaceOrder.Start(num);
        }

        public static void AbortPlaceOrder() {
            _customerPlaceOrder.Abort();
        }
        public static void PlaceOrder(object time) {
            int myTime = Convert.ToInt32(time);
            while (true) {
                Customer customer = new Customer();
                Waiter waiter = new Waiter();
                customer.OrderNumber = waiter.PlaceOrder();
                if (Application.OpenForms["SimulationForm"] != null)
                {
                    (Application.OpenForms["SimulationForm"] as SimulationForm).Update(customer);
                    (Application.OpenForms["SimulationForm"] as SimulationForm).QueueUpdate();
                }
                Thread.Sleep(myTime * 1000);
                CookService.Semaphore.Release();
            }
        }
    }
}
