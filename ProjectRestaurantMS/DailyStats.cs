using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectRestaurantMS
{
    public partial class DailyStats : Form
    {
        public DailyStats()
        {
            InitializeComponent();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            statsOrders orders = new statsOrders();
            orders.TopLevel = false;
            orders.Dock = DockStyle.Fill;
            center_content_panel.Controls.Add(orders);
            orders.BringToFront();
            orders.Show();
            
        }
        private void btn_revenue_Click(object sender, EventArgs e)
        {
            statsRevenue revenue = new statsRevenue();
            revenue.TopLevel = false;
            revenue.Dock = DockStyle.Fill;
            center_content_panel.Controls.Add(revenue);
            revenue.BringToFront();
            revenue.Show();
        }

        private void btn_dining_Click(object sender, EventArgs e)
        {
            statsDining dining = new statsDining();
            dining.TopLevel = false;
            dining.Dock = DockStyle.Fill;
            center_content_panel.Controls.Add(dining);
            dining.BringToFront();
            dining.Show();
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            this.Close();
            main.Show();
        }

        
    }
}
