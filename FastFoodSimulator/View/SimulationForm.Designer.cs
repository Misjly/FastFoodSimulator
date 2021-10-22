namespace FastFoodSimulator.View
{
    partial class SimulationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.customerTextBox = new System.Windows.Forms.TextBox();
            this.orderTextBox = new System.Windows.Forms.TextBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.customerNumLabel = new System.Windows.Forms.Label();
            this.customerNumTextBox = new System.Windows.Forms.TextBox();
            this.readyPanel = new System.Windows.Forms.Panel();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Id2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.readyQueueLabel = new System.Windows.Forms.Label();
            this.inLinePanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inLineQueueLabel = new System.Windows.Forms.Label();
            this.inProgressLabel = new System.Windows.Forms.Label();
            this.inProgressTextBox = new System.Windows.Forms.TextBox();
            this.readyPanel.SuspendLayout();
            this.inLinePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 157);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(13, 193);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 28);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // customerTextBox
            // 
            this.customerTextBox.Location = new System.Drawing.Point(13, 44);
            this.customerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerTextBox.Name = "customerTextBox";
            this.customerTextBox.Size = new System.Drawing.Size(99, 22);
            this.customerTextBox.TabIndex = 2;
            // 
            // orderTextBox
            // 
            this.orderTextBox.Location = new System.Drawing.Point(9, 102);
            this.orderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.orderTextBox.Name = "orderTextBox";
            this.orderTextBox.Size = new System.Drawing.Size(99, 22);
            this.orderTextBox.TabIndex = 3;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(14, 20);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(224, 20);
            this.customerLabel.TabIndex = 4;
            this.customerLabel.Text = "customer arival time(integer)";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderLabel.Location = new System.Drawing.Point(9, 79);
            this.orderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(225, 20);
            this.orderLabel.TabIndex = 5;
            this.orderLabel.Text = "order fulfillment time(integer)";
            // 
            // customerNumLabel
            // 
            this.customerNumLabel.AutoSize = true;
            this.customerNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerNumLabel.Location = new System.Drawing.Point(13, 326);
            this.customerNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerNumLabel.Name = "customerNumLabel";
            this.customerNumLabel.Size = new System.Drawing.Size(220, 25);
            this.customerNumLabel.TabIndex = 6;
            this.customerNumLabel.Text = "Id of customer in queue:";
            // 
            // customerNumTextBox
            // 
            this.customerNumTextBox.Location = new System.Drawing.Point(17, 347);
            this.customerNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerNumTextBox.Name = "customerNumTextBox";
            this.customerNumTextBox.ReadOnly = true;
            this.customerNumTextBox.Size = new System.Drawing.Size(104, 22);
            this.customerNumTextBox.TabIndex = 7;
            // 
            // readyPanel
            // 
            this.readyPanel.Controls.Add(this.listView2);
            this.readyPanel.Controls.Add(this.readyQueueLabel);
            this.readyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.readyPanel.Location = new System.Drawing.Point(659, 0);
            this.readyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.readyPanel.Name = "readyPanel";
            this.readyPanel.Size = new System.Drawing.Size(394, 542);
            this.readyPanel.TabIndex = 8;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id2});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(26, 44);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(341, 482);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Id2
            // 
            this.Id2.Text = "Id";
            this.Id2.Width = 259;
            // 
            // readyQueueLabel
            // 
            this.readyQueueLabel.AutoSize = true;
            this.readyQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readyQueueLabel.Location = new System.Drawing.Point(100, 16);
            this.readyQueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyQueueLabel.Name = "readyQueueLabel";
            this.readyQueueLabel.Size = new System.Drawing.Size(163, 25);
            this.readyQueueLabel.TabIndex = 0;
            this.readyQueueLabel.Text = "Takeaway queue";
            // 
            // inLinePanel
            // 
            this.inLinePanel.Controls.Add(this.listView1);
            this.inLinePanel.Controls.Add(this.inLineQueueLabel);
            this.inLinePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.inLinePanel.Location = new System.Drawing.Point(235, 0);
            this.inLinePanel.Margin = new System.Windows.Forms.Padding(4);
            this.inLinePanel.Name = "inLinePanel";
            this.inLinePanel.Size = new System.Drawing.Size(424, 542);
            this.inLinePanel.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(366, 482);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 286;
            // 
            // inLineQueueLabel
            // 
            this.inLineQueueLabel.AutoSize = true;
            this.inLineQueueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inLineQueueLabel.Location = new System.Drawing.Point(107, 16);
            this.inLineQueueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inLineQueueLabel.Name = "inLineQueueLabel";
            this.inLineQueueLabel.Size = new System.Drawing.Size(148, 25);
            this.inLineQueueLabel.TabIndex = 0;
            this.inLineQueueLabel.Text = "Ordering queue";
            // 
            // inProgressLabel
            // 
            this.inProgressLabel.AutoSize = true;
            this.inProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inProgressLabel.Location = new System.Drawing.Point(13, 382);
            this.inProgressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inProgressLabel.Name = "inProgressLabel";
            this.inProgressLabel.Size = new System.Drawing.Size(211, 25);
            this.inProgressLabel.TabIndex = 10;
            this.inProgressLabel.Text = "Id of order  in progress:";
            // 
            // inProgressTextBox
            // 
            this.inProgressTextBox.Location = new System.Drawing.Point(17, 408);
            this.inProgressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inProgressTextBox.Name = "inProgressTextBox";
            this.inProgressTextBox.ReadOnly = true;
            this.inProgressTextBox.Size = new System.Drawing.Size(100, 22);
            this.inProgressTextBox.TabIndex = 11;
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 542);
            this.Controls.Add(this.inProgressTextBox);
            this.Controls.Add(this.inProgressLabel);
            this.Controls.Add(this.inLinePanel);
            this.Controls.Add(this.readyPanel);
            this.Controls.Add(this.customerNumTextBox);
            this.Controls.Add(this.customerNumLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.orderTextBox);
            this.Controls.Add(this.customerTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SimulationForm";
            this.Text = "SimulationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationForm_FormClosing);
            this.readyPanel.ResumeLayout(false);
            this.readyPanel.PerformLayout();
            this.inLinePanel.ResumeLayout(false);
            this.inLinePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox customerTextBox;
        private System.Windows.Forms.TextBox orderTextBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label customerNumLabel;
        private System.Windows.Forms.TextBox customerNumTextBox;
        private System.Windows.Forms.Panel readyPanel;
        private System.Windows.Forms.Label readyQueueLabel;
        private System.Windows.Forms.Panel inLinePanel;
        private System.Windows.Forms.Label inLineQueueLabel;
        private System.Windows.Forms.Label inProgressLabel;
        private System.Windows.Forms.TextBox inProgressTextBox;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Id2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
    }
}

