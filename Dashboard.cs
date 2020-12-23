using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsHotelManagement
{
    public partial class Dashboard : Form
    {
        Login Login { get; set; }
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(Login l) : this()
        {
            this.Login = l;
        }



      

       

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //
        }

      

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            userControlAddRoom.Visible = true;
            userControlCheckOut.Visible = false;
            userControlCustomerRegistration.Visible = false;
            userControlAddRoom.BringToFront();
           
   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Login.Show();
            this.Visible = false;
        }

        private void btnCustomerReg_Click(object sender, EventArgs e)
        {
            userControlAddRoom.Visible = false;
            userControlCheckOut.Visible = false;
            userControlCustomerRegistration.Visible = true;
            userControlCustomerRegistration.BringToFront();
        }

        private void userControlAddRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            userControlAddRoom.Visible = false;
            userControlCustomerRegistration.Visible = false;
            userControlCheckOut.Visible = true;
            userControlCheckOut.BringToFront();
           
        }

        
    }
}
