namespace WindowsFormsHotelManagement.All_User_Control
{
    partial class UserControlCustomerRegistration
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbCustomerGender = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerMobileNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNationality = new System.Windows.Forms.Label();
            this.lblCustomerReg = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtCustomerMobileNo = new System.Windows.Forms.TextBox();
            this.txtCustomerNationality = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblNID = new System.Windows.Forms.Label();
            this.lblCustomerCheckIn = new System.Windows.Forms.Label();
            this.txtCustomerNID = new System.Windows.Forms.TextBox();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbBed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.cmbRoomNo = new System.Windows.Forms.ComboBox();
            this.hotelDataSet1 = new WindowsFormsHotelManagement.hotelDataSet1();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new WindowsFormsHotelManagement.hotelDataSet1TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(62)))), ((int)(((byte)(6)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(673, 406);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(135, 28);
            this.btnRegister.TabIndex = 84;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbCustomerGender
            // 
            this.cmbCustomerGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbCustomerGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.cmbCustomerGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCustomerGender.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerGender.FormattingEnabled = true;
            this.cmbCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbCustomerGender.Location = new System.Drawing.Point(21, 326);
            this.cmbCustomerGender.Name = "cmbCustomerGender";
            this.cmbCustomerGender.Size = new System.Drawing.Size(253, 24);
            this.cmbCustomerGender.TabIndex = 81;
            this.cmbCustomerGender.Text = "Gender";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(21, 137);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 25);
            this.txtCustomerName.TabIndex = 80;
            this.txtCustomerName.Text = "Customer Name";
            // 
            // lblCustomerMobileNumber
            // 
            this.lblCustomerMobileNumber.AutoSize = true;
            this.lblCustomerMobileNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerMobileNumber.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerMobileNumber.Location = new System.Drawing.Point(15, 165);
            this.lblCustomerMobileNumber.Name = "lblCustomerMobileNumber";
            this.lblCustomerMobileNumber.Size = new System.Drawing.Size(78, 16);
            this.lblCustomerMobileNumber.TabIndex = 77;
            this.lblCustomerMobileNumber.Text = "Mobile NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Address";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(18, 111);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(108, 16);
            this.lblCustomerName.TabIndex = 76;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerNationality
            // 
            this.lblCustomerNationality.AutoSize = true;
            this.lblCustomerNationality.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerNationality.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNationality.Location = new System.Drawing.Point(15, 213);
            this.lblCustomerNationality.Name = "lblCustomerNationality";
            this.lblCustomerNationality.Size = new System.Drawing.Size(79, 16);
            this.lblCustomerNationality.TabIndex = 78;
            this.lblCustomerNationality.Text = "Nationality";
            // 
            // lblCustomerReg
            // 
            this.lblCustomerReg.AutoSize = true;
            this.lblCustomerReg.Font = new System.Drawing.Font("Kristen ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerReg.Location = new System.Drawing.Point(210, 47);
            this.lblCustomerReg.Name = "lblCustomerReg";
            this.lblCustomerReg.Size = new System.Drawing.Size(361, 40);
            this.lblCustomerReg.TabIndex = 75;
            this.lblCustomerReg.Text = "Customer Registration";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(18, 307);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(54, 16);
            this.lblGender.TabIndex = 86;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(18, 353);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(94, 16);
            this.lblDOB.TabIndex = 87;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtCustomerMobileNo
            // 
            this.txtCustomerMobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerMobileNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtCustomerMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerMobileNo.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerMobileNo.Location = new System.Drawing.Point(21, 184);
            this.txtCustomerMobileNo.Name = "txtCustomerMobileNo";
            this.txtCustomerMobileNo.Size = new System.Drawing.Size(253, 25);
            this.txtCustomerMobileNo.TabIndex = 88;
            this.txtCustomerMobileNo.Text = "MobileNO";
            // 
            // txtCustomerNationality
            // 
            this.txtCustomerNationality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerNationality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtCustomerNationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerNationality.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNationality.Location = new System.Drawing.Point(21, 232);
            this.txtCustomerNationality.Name = "txtCustomerNationality";
            this.txtCustomerNationality.Size = new System.Drawing.Size(253, 25);
            this.txtCustomerNationality.TabIndex = 89;
            this.txtCustomerNationality.Text = "Nationality";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtCustomerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(21, 279);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(253, 25);
            this.txtCustomerAddress.TabIndex = 90;
            this.txtCustomerAddress.Text = "Address";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CalendarFont = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpDateOfBirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpDateOfBirth.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpDateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(21, 373);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(253, 25);
            this.dtpDateOfBirth.TabIndex = 91;
            // 
            // lblNID
            // 
            this.lblNID.AutoSize = true;
            this.lblNID.BackColor = System.Drawing.Color.Transparent;
            this.lblNID.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNID.Location = new System.Drawing.Point(313, 111);
            this.lblNID.Name = "lblNID";
            this.lblNID.Size = new System.Drawing.Size(61, 16);
            this.lblNID.TabIndex = 92;
            this.lblNID.Text = "NID NO";
            // 
            // lblCustomerCheckIn
            // 
            this.lblCustomerCheckIn.AutoSize = true;
            this.lblCustomerCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerCheckIn.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerCheckIn.Location = new System.Drawing.Point(313, 165);
            this.lblCustomerCheckIn.Name = "lblCustomerCheckIn";
            this.lblCustomerCheckIn.Size = new System.Drawing.Size(100, 16);
            this.lblCustomerCheckIn.TabIndex = 93;
            this.lblCustomerCheckIn.Text = "Check In Date";
            // 
            // txtCustomerNID
            // 
            this.txtCustomerNID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerNID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtCustomerNID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerNID.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNID.Location = new System.Drawing.Point(316, 130);
            this.txtCustomerNID.Name = "txtCustomerNID";
            this.txtCustomerNID.Size = new System.Drawing.Size(253, 25);
            this.txtCustomerNID.TabIndex = 94;
            this.txtCustomerNID.Text = "Customer Id";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CalendarFont = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckIn.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckIn.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.dtpCheckIn.CustomFormat = "dd-MM-yyyy";
            this.dtpCheckIn.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(316, 184);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(253, 25);
            this.dtpCheckIn.TabIndex = 95;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.cmbRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoomType.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "AC",
            "NON AC"});
            this.cmbRoomType.Location = new System.Drawing.Point(652, 208);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(253, 24);
            this.cmbRoomType.TabIndex = 97;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomType.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomType.Location = new System.Drawing.Point(650, 189);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(77, 16);
            this.lblRoomType.TabIndex = 96;
            this.lblRoomType.Text = "Room Type";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(652, 326);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(254, 25);
            this.txtPrice.TabIndex = 101;
            this.txtPrice.Text = "0000";
            // 
            // cmbBed
            // 
            this.cmbBed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.cmbBed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBed.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBed.FormattingEnabled = true;
            this.cmbBed.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbBed.Location = new System.Drawing.Point(653, 147);
            this.cmbBed.Name = "cmbBed";
            this.cmbBed.Size = new System.Drawing.Size(254, 24);
            this.cmbBed.TabIndex = 100;
            this.cmbBed.SelectedIndexChanged += new System.EventHandler(this.cmbBed_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(650, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(649, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Bed";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomNo.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNo.Location = new System.Drawing.Point(649, 241);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(70, 16);
            this.lblRoomNo.TabIndex = 102;
            this.lblRoomNo.Text = "Room No.";
            // 
            // cmbRoomNo
            // 
            this.cmbRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRoomNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(117)))));
            this.cmbRoomNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRoomNo.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomNo.FormattingEnabled = true;
            this.cmbRoomNo.Location = new System.Drawing.Point(652, 262);
            this.cmbRoomNo.Name = "cmbRoomNo";
            this.cmbRoomNo.Size = new System.Drawing.Size(253, 24);
            this.cmbRoomNo.TabIndex = 103;
            this.cmbRoomNo.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNo_SelectedIndexChanged);
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
            // UserControlCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmbRoomNo);
            this.Controls.Add(this.lblRoomNo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cmbBed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.txtCustomerNID);
            this.Controls.Add(this.lblCustomerCheckIn);
            this.Controls.Add(this.lblNID);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerNationality);
            this.Controls.Add(this.txtCustomerMobileNo);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbCustomerGender);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerMobileNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerNationality);
            this.Controls.Add(this.lblCustomerReg);
            this.Name = "UserControlCustomerRegistration";
            this.Size = new System.Drawing.Size(1027, 643);
            this.Leave += new System.EventHandler(this.UserControlCustomerRegistration_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbCustomerGender;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerMobileNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNationality;
        private System.Windows.Forms.Label lblCustomerReg;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtCustomerMobileNo;
        private System.Windows.Forms.TextBox txtCustomerNationality;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lblNID;
        private System.Windows.Forms.Label lblCustomerCheckIn;
        private System.Windows.Forms.TextBox txtCustomerNID;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.ComboBox cmbRoomNo;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private hotelDataSet1 hotelDataSet1;
        private hotelDataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
    }
}
