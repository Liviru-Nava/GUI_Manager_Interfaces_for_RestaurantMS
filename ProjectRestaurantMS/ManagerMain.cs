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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void btn_Employee_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegistration register = new EmployeeRegistration(); //create an object to access or open the  registration form
            register.ShowDialog();  //open the registration form but you cannot click anywhere else
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyStats statistcs = new DailyStats();    //create an object to access the statistics form
            statistcs.ShowDialog(); //open the statistics form
        }

        private void btn_Employee_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetails details = new EmployeeDetails();    //create an object to access the Employee details form
            details.ShowDialog();   //Open the details form
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports report = new Reports();     //create an object to access the report form
            report.ShowDialog();    //open the report form
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
