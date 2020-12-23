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
    public partial class UserControlCustomerRegistration : UserControl
    {
        private DataAccess da=new DataAccess();
        private string query;
        private int roomid;
        public UserControlCustomerRegistration()
        {
            InitializeComponent();
        }
        public void SetDataFields(string query, ComboBox box)
        {
            SqlDataReader sdr = da.FetchData(query);
            while (sdr.Read()) //read table row wise
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    box.Items.Add(sdr.GetString(i));
                }

            }
            sdr.Close();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from Rooms where bed='" + cmbBed.Text + "' and roomtype='" + cmbRoomType.Text + "' and reservation='NO' ;";

            SetDataFields(query, cmbRoomNo);
        }

        private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRoomType.SelectedIndex = -1;//
            cmbRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from Rooms where roomNo='" + cmbRoomNo.Text + "'";
            DataSet ds= da.ExecuteQuery(query);
           txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            roomid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            query = "insert into Customer(customerName,mobileNo,nationality,gender,dob,NID,customerAddress,checkinDate,roomid)values('"+txtCustomerName.Text+"','"+txtCustomerMobileNo.Text+"','"+txtCustomerNationality.Text+"','"+cmbCustomerGender.Text+"','"+dtpDateOfBirth.Text+"','"+txtCustomerNID.Text+"','"+txtCustomerAddress.Text+"','"+dtpCheckIn.Text+"',"+roomid+ ")update Rooms set reservation = 'YES' where roomNo = '" + cmbRoomNo.Text + "'";
            
           
                if (txtCustomerName.Text != "" && txtCustomerAddress.Text != "" && txtCustomerMobileNo.Text != "" && txtCustomerNationality.Text != "" && txtCustomerNID.Text != "" && txtPrice.Text != "" && cmbBed.Text != "" && cmbRoomNo.Text != "" && cmbCustomerGender.Text != "" && cmbRoomType.Text != "" && dtpDateOfBirth.Text != "" && dtpCheckIn.Text != "")
                {
                    da.ExecuteUpdateQuery(query);

                    MessageBox.Show("Registration Completed", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();

                }
                else
                {
                    MessageBox.Show("Fill All fields", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }   
                
       
            //api work will be here
           // txtCustomerAddress.Text=
            
        
        }
        public void ClearAll()
        {
            txtCustomerName.Clear();
            txtCustomerMobileNo.Clear();
            txtCustomerAddress.Clear();
            txtCustomerNationality.Clear();
            txtCustomerNID.Clear();
            cmbCustomerGender.SelectedIndex=1;
            cmbRoomType.SelectedIndex = -1;
            dtpCheckIn.ResetText();
            cmbBed.SelectedIndex = -1;
            dtpDateOfBirth.ResetText();
            cmbRoomNo.Items.Clear();
            txtPrice.Clear();



        }

        private void UserControlCustomerRegistration_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
