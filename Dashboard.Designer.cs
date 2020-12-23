namespace WindowsFormsHotelManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panelDashboardTab = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomerReg = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.panelDashboard2 = new System.Windows.Forms.Panel();
            this.panelDashboard1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.userControlAddRoom = new WindowsFormsHotelManagement.All_User_Control.UserControlAddRoom();
            this.userControlCustomerRegistration = new WindowsFormsHotelManagement.All_User_Control.UserControlCustomerRegistration();
            this.userControlCheckOut = new WindowsFormsHotelManagement.All_User_Control.UserControlCheckOut();
            this.panelDashboardTab.SuspendLayout();
            this.panelDashboard2.SuspendLayout();
            this.panelDashboard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboardTab
            // 
            this.panelDashboardTab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDashboardTab.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboardTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDashboardTab.Controls.Add(this.btnEmployee);
            this.panelDashboardTab.Controls.Add(this.btnCustomerReg);
            this.panelDashboardTab.Controls.Add(this.btnAddRoom);
            this.panelDashboardTab.Controls.Add(this.btnCustomerDetails);
            this.panelDashboardTab.Controls.Add(this.btnCheckOut);
            this.panelDashboardTab.Location = new System.Drawing.Point(4, 3);
            this.panelDashboardTab.Name = "panelDashboardTab";
            this.panelDashboardTab.Size = new System.Drawing.Size(1593, 108);
            this.panelDashboardTab.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Location = new System.Drawing.Point(1269, 8);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(215, 90);
            this.btnEmployee.TabIndex = 14;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            // 
            // btnCustomerReg
            // 
            this.btnCustomerReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerReg.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerReg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomerReg.FlatAppearance.BorderSize = 0;
            this.btnCustomerReg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCustomerReg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCustomerReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReg.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerReg.Location = new System.Drawing.Point(332, 8);
            this.btnCustomerReg.Name = "btnCustomerReg";
            this.btnCustomerReg.Size = new System.Drawing.Size(243, 90);
            this.btnCustomerReg.TabIndex = 11;
            this.btnCustomerReg.Text = "Customer Registration";
            this.btnCustomerReg.UseVisualStyleBackColor = false;
            this.btnCustomerReg.Click += new System.EventHandler(this.btnCustomerReg_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnAddRoom.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRoom.FlatAppearance.BorderSize = 0;
            this.btnAddRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnAddRoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoom.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.Location = new System.Drawing.Point(7, 8);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(269, 90);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCustomerDetails.FlatAppearance.BorderSize = 0;
            this.btnCustomerDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCustomerDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerDetails.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.Location = new System.Drawing.Point(638, 8);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(285, 90);
            this.btnCustomerDetails.TabIndex = 13;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.UseVisualStyleBackColor = false;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(972, 8);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(259, 90);
            this.btnCheckOut.TabIndex = 12;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // panelDashboard2
            // 
            this.panelDashboard2.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDashboard2.Controls.Add(this.userControlCheckOut);
            this.panelDashboard2.Controls.Add(this.userControlAddRoom);
            this.panelDashboard2.Controls.Add(this.userControlCustomerRegistration);
            this.panelDashboard2.Controls.Add(this.panelDashboard1);
            this.panelDashboard2.Location = new System.Drawing.Point(4, 117);
            this.panelDashboard2.Name = "panelDashboard2";
            this.panelDashboard2.Size = new System.Drawing.Size(1593, 771);
            this.panelDashboard2.TabIndex = 4;
            // 
            // panelDashboard1
            // 
            this.panelDashboard1.BackColor = System.Drawing.Color.Transparent;
            this.panelDashboard1.Controls.Add(this.btnMinimize);
            this.panelDashboard1.Controls.Add(this.btnBack);
            this.panelDashboard1.Controls.Add(this.btnClose);
            this.panelDashboard1.Location = new System.Drawing.Point(1334, 17);
            this.panelDashboard1.Name = "panelDashboard1";
            this.panelDashboard1.Size = new System.Drawing.Size(131, 30);
            this.panelDashboard1.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Location = new System.Drawing.Point(78, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 24);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "minimize";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Location = new System.Drawing.Point(46, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(26, 24);
            this.btnBack.TabIndex = 9;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Location = new System.Drawing.Point(14, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 24);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userControlAddRoom
            // 
            this.userControlAddRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControlAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.userControlAddRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlAddRoom.Location = new System.Drawing.Point(283, 3);
            this.userControlAddRoom.Name = "userControlAddRoom";
            this.userControlAddRoom.Size = new System.Drawing.Size(880, 613);
            this.userControlAddRoom.TabIndex = 0;
            this.userControlAddRoom.Visible = false;
            // 
            // userControlCustomerRegistration
            // 
            this.userControlCustomerRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControlCustomerRegistration.BackColor = System.Drawing.Color.Transparent;
            this.userControlCustomerRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlCustomerRegistration.Location = new System.Drawing.Point(-1, -1);
            this.userControlCustomerRegistration.Name = "userControlCustomerRegistration";
            this.userControlCustomerRegistration.Size = new System.Drawing.Size(1029, 635);
            this.userControlCustomerRegistration.TabIndex = 1;
            this.userControlCustomerRegistration.Visible = false;
            // 
            // userControlCheckOut
            // 
            this.userControlCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.userControlCheckOut.Location = new System.Drawing.Point(7, -1);
            this.userControlCheckOut.Name = "userControlCheckOut";
            this.userControlCheckOut.Size = new System.Drawing.Size(1249, 590);
            this.userControlCheckOut.TabIndex = 3;
            this.userControlCheckOut.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panelDashboard2);
            this.Controls.Add(this.panelDashboardTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelDashboardTab.ResumeLayout(false);
            this.panelDashboard2.ResumeLayout(false);
            this.panelDashboard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDashboardTab;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCustomerReg;
        private System.Windows.Forms.Panel panelDashboard2;
        private System.Windows.Forms.Panel panelDashboard1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private All_User_Control.UserControlAddRoom userControlAddRoom;
        private All_User_Control.UserControlCustomerRegistration userControlCustomerRegistration;
        private All_User_Control.UserControlCheckOut userControlCheckOut;
        //private All_User_Control.UserControlCheckout userControlCheckOut;
    }
}