using FastFoodSimulator.Controller;
using FastFoodSimulator.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastFoodSimulator.View
{
    public partial class SimulationForm : Form
    {
        private delegate void DeleteCallDelegate();
        private delegate void SafeCallDelegate(Customer customer);
        private delegate void DeleteReadyLineCallDelegate();
        private delegate void SafeReadyLineCallDelegate(Order order);
        private delegate void UpdateDelegate();
        private delegate void ProgressDelegate1(int count);

        private readonly string REG_COMPARE = @"[0-9]+";
        private static bool _isStarted = false;

        public SimulationForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (_isStarted)
                return;
            if (Regex.IsMatch(customerTextBox.ToString(), REG_COMPARE) && Regex.IsMatch(orderTextBox.ToString(), REG_COMPARE))
            {
                ClientPlaceOrder.StartPlaceOrder(Convert.ToInt32(customerTextBox.Text));
                CookService.StartCookService(Convert.ToInt32(orderTextBox.Text));
                ClientPickUpOrder.StartPickUp();
            }
            else
            {
                MessageBox.Show("Invalid input data", "Error");
            }
            _isStarted = true;


        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (!_isStarted)
            {
                return;
            }
            ClientPlaceOrder.AbortPlaceOrder();
            CookService.AbortCookService();
            ClientPickUpOrder.AbortPickUp();
            _isStarted = false;
        }

        public void Update(Customer customer)
        {
            UpdateSafely(customer);
        }

        public void UpdateSafely(Customer customer)
        {
            if (listView1.InvokeRequired)
            {
                var d = new SafeCallDelegate(UpdateSafely);
                listView1.Invoke(d, new object[] { customer });
            }
            else
            {
                try
                {
                    listView1.Items.Add(new ListViewItem(customer.OrderNumber.ToString()));
                }
                catch (NullReferenceException) { }
            }
        }

        public void Delete()
        {
            DeleteSafely();
        }

        public void DeleteSafely()
        {
            if (listView1.InvokeRequired)
            {
                var d = new DeleteCallDelegate(DeleteSafely);
                listView1.Invoke(d);
            }
            else
            {
                try
                {
                    listView1.Items.RemoveAt(0);
                }
                catch (Exception) { }
            }
        }

        public void UpdateReadyLine(Order order)
        {
            UpdateReadyLineSafely(order);
        }

        public void UpdateReadyLineSafely(Order order)
        {
            if (listView2.InvokeRequired)
            {
                SafeReadyLineCallDelegate safeReadyLineCallDelegate = new SafeReadyLineCallDelegate(UpdateReadyLineSafely);
                listView2.Invoke(safeReadyLineCallDelegate, new object[] { order });
            }
            else
            {
                try
                {
                    listView2.Items.Add(new ListViewItem(order.OrderNumber.ToString()));
                }
                catch (NullReferenceException) { }
            }
        }

        public void DeleteReadyLine()
        {
            DeleteReadyLineSafely();
        }

        public void DeleteReadyLineSafely()
        {
            if (listView2.InvokeRequired)
            {
                var d = new DeleteReadyLineCallDelegate(DeleteReadyLineSafely);
                listView2.Invoke(d);
            }
            else
            {
                try
                {
                    listView2.Items.RemoveAt(0);
                }
                catch (Exception) { }
            }
        }

        public void QueueUpdate()
        {
            SafeQueueUpdate();
        }
        public void SafeQueueUpdate()
        {
            if (customerNumTextBox.InvokeRequired)
            {
                UpdateDelegate updateDelegate = new UpdateDelegate(SafeQueueUpdate);
                customerNumTextBox.Invoke(updateDelegate);
            }
            else
            {
                try
                {
                    customerNumTextBox.Text = listView1.Items.Count.ToString();
                }
                catch (NullReferenceException) { }
            }
        }

        public void ProgressQueue(int count)
        {
            SafeProgrressQueue(count);
        }
        public void SafeProgrressQueue(int count)
        {
            if (inProgressTextBox.InvokeRequired)
            {
                var d = new ProgressDelegate1(SafeProgrressQueue);
                inProgressTextBox.Invoke(d, new object[] { count });
            }
            else
            {
                try
                {
                    inProgressTextBox.Text = count.ToString();
                }
                catch (NullReferenceException) { }
            }
        }

        private void SimulationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
