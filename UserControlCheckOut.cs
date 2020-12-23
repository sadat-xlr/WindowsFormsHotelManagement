using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHotelManagement.All_User_Control
{
    public partial class UserControlCheckOut : UserControl

    {
        private DataAccess da = new DataAccess();
        private string query;
        private int c_id;
        public UserControlCheckOut()
        {
            InitializeComponent();
        }

        private void UserControlCheckOut_Load(object sender, EventArgs e)
        {
            query = "select Customer.customerId,Customer.customerName,Customer.mobileNo,Customer.nationality,Customer.gender,Customer.dob,Customer.NID,Customer.customerAddress,Customer.checkinDate,Rooms.roomNo,Rooms.roomtype,Rooms.bed,Rooms.price from Customer inner join Rooms on Customer.roomid=Rooms.roomid where Checkedout='NO'";
            dgvCustomer.DataSource = da.ExecuteQueryTable(query);

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select Customer.customerId,Customer.customerName,Customer.mobileNo,Customer.nationality,Customer.gender,Customer.dob,Customer.NID,Customer.customerAddress,Customer.checkinDate,Rooms.roomNo,Rooms.roomtype,Rooms.bed,Rooms.price from Customer inner join Rooms on Customer.roomid=Rooms.roomid where customerName like'" + txtNameSearch.Text + "%' and Checkedout='NO'";
            dgvCustomer.DataSource = da.ExecuteQueryTable(query);
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           

                try
                {
                    if (dgvCustomer.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        c_id = int.Parse(dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());// column remain same thats why Cell[0]
                        txtGetName.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtGetRoomNo.Text = dgvCustomer.Rows[e.RowIndex].Cells[9].Value.ToString();
                    }
                }
                catch
                {

                    MessageBox.Show("ERROR OCCUR", "Exception", MessageBoxButtons.RetryCancel);
                }
            
        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGetName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_uc_Click(object sender, EventArgs e)
        {
            if (txtGetName.Text != "")
            {
                if (MessageBox.Show("Confirm Check Out?", "CONFIRMATION", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    query = "update Customer set Checkedout='YES',checkoutDate='" + dtpCheckOut.Text + "' where customerId=" + c_id + " update Rooms set reservation='NO' where roomNo='"+txtGetRoomNo.Text+"'; ";
                    da.ExecuteUpdateQuery(query);
                    MessageBox.Show("Check Out Successfull","Confirmed",MessageBoxButtons.OK);
                   UserControlCheckOut_Load(this, null);
                    this.ClearAll();


                }
            }
            else
            {
                MessageBox.Show("Please select Customer", "Exception", MessageBoxButtons.RetryCancel);
            }

        }
        public void ClearAll()
        {
            txtGetName.Clear();
            txtNameSearch.Clear();
            txtGetRoomNo.Clear();
            
            dtpCheckOut.ResetText();
        }

        private void UserControlCheckOut_Leave(object sender, EventArgs e)
        {
            this.ClearAll();
        }
    }
}
