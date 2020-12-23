using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WindowsFormsHotelManagement.All_User_Control
{
    public partial class UserControlAddRoom : UserControl
    {
        private DataAccess da=new DataAccess();
        private string a = "select * from Rooms";
        

        public UserControlAddRoom()
        {
            InitializeComponent();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string query = "insert into Rooms (roomNo,roomtype,bed,price)values('" + txtRoomNo.Text + "','" + cmbRoomType.Text + "','" + cmbBed.Text + "'," + txtPrice.Text + ")";
            try
            {
                if (txtRoomNo.Text != "" && txtPrice.Text != "" && cmbBed.Text != "" && cmbRoomType.Text != "")
                {
                    da.ExecuteUpdateQuery(query);
                    dgvRoom.DataSource = da.ExecuteQueryTable(a);
                    MessageBox.Show("Room Added", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Fill All fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("ROOM NO ALREADY EXIST", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);

            }

        }

        private void UserControlAddRoom_Load(object sender, EventArgs e)
        {
           
            
            dgvRoom.DataSource= da.ExecuteQueryTable(a);

        }
    }
}
