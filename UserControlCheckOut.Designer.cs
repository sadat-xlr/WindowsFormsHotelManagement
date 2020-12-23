namespace WindowsFormsHotelManagement.All_User_Control
{
    partial class UserControlCheckOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddRoom = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblroomno = new System.Windows.Forms.Label();
            this.txtGetRoomNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGetName = new System.Windows.Forms.TextBox();
            this.btnCheckOut_uc = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.hotelDataSet1 = new WindowsFormsHotelManagement.hotelDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsHotelManagement.hotelDataSet1TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddRoom
            // 
            this.lblAddRoom.AutoSize = true;
            this.lblAddRoom.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRoom.Location = new System.Drawing.Point(432, 17);
            this.lblAddRoom.Name = "lblAddRoom";
            this.lblAddRoom.Size = new System.Drawing.Size(345, 40);
            this.lblAddRoom.TabIndex = 65;
            this.lblAddRoom.Text = "Customer Check Out";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNameSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtNameSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameSearch.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(124, 90);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(407, 25);
            this.txtNameSearch.TabIndex = 70;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Transparent;
            this.lblname.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(27, 94);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(91, 16);
            this.lblname.TabIndex = 71;
            this.lblname.Text = "Search Name";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(30, 138);
            this.dgvCustomer.MultiSelect = false;
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.Size = new System.Drawing.Size(837, 442);
            this.dgvCustomer.TabIndex = 72;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(909, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Check Out";
            // 
            // lblroomno
            // 
            this.lblroomno.AutoSize = true;
            this.lblroomno.BackColor = System.Drawing.Color.Transparent;
            this.lblroomno.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomno.Location = new System.Drawing.Point(913, 175);
            this.lblroomno.Name = "lblroomno";
            this.lblroomno.Size = new System.Drawing.Size(66, 16);
            this.lblroomno.TabIndex = 76;
            this.lblroomno.Text = "Room No";
            // 
            // txtGetRoomNo
            // 
            this.txtGetRoomNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGetRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtGetRoomNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetRoomNo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetRoomNo.Location = new System.Drawing.Point(992, 171);
            this.txtGetRoomNo.Name = "txtGetRoomNo";
            this.txtGetRoomNo.Size = new System.Drawing.Size(201, 25);
            this.txtGetRoomNo.TabIndex = 75;
            this.txtGetRoomNo.TextChanged += new System.EventHandler(this.txtRoomNo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(918, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 78;
            this.label3.Text = "Name";
            // 
            // txtGetName
            // 
            this.txtGetName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGetName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtGetName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGetName.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGetName.Location = new System.Drawing.Point(992, 138);
            this.txtGetName.Name = "txtGetName";
            this.txtGetName.Size = new System.Drawing.Size(201, 25);
            this.txtGetName.TabIndex = 77;
            this.txtGetName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckOut_uc
            // 
            this.btnCheckOut_uc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOut_uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnCheckOut_uc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckOut_uc.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut_uc.Location = new System.Drawing.Point(943, 302);
            this.btnCheckOut_uc.Name = "btnCheckOut_uc";
            this.btnCheckOut_uc.Size = new System.Drawing.Size(178, 69);
            this.btnCheckOut_uc.TabIndex = 80;
            this.btnCheckOut_uc.Text = "Check Out";
            this.btnCheckOut_uc.UseVisualStyleBackColor = false;
            this.btnCheckOut_uc.Click += new System.EventHandler(this.btnCheckOut_uc_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CalendarFont = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckOut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckOut.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckOut.CustomFormat = "dd-MM-yyyy";
            this.dtpCheckOut.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(992, 205);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(201, 25);
            this.dtpCheckOut.TabIndex = 92;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "hotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.hotelDataSet1;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.btnCheckOut_uc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGetName);
            this.Controls.Add(this.lblroomno);
            this.Controls.Add(this.txtGetRoomNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.lblAddRoom);
            this.Name = "UserControlCheckOut";
            this.Size = new System.Drawing.Size(1235, 599);
            this.Load += new System.EventHandler(this.UserControlCheckOut_Load);
            this.Leave += new System.EventHandler(this.UserControlCheckOut_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddRoom;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblroomno;
        private System.Windows.Forms.TextBox txtGetRoomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGetName;
        private System.Windows.Forms.Button btnCheckOut_uc;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private hotelDataSet1 hotelDataSet1;
        private hotelDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}
