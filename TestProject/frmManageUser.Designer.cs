namespace TestProject
{
    partial class frmManageUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grData = new System.Windows.Forms.GroupBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.grData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vai trò";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(157, 120);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(170, 26);
            this.txtFullname.TabIndex = 13;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(157, 31);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(170, 26);
            this.txtUserId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ và tên";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(157, 74);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(170, 26);
            this.txtRole.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(468, 28);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(170, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(468, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(170, 26);
            this.txtPassword.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(468, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mật khẩu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tài khoản";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(798, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(798, 115);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(180, 26);
            this.txtAddress.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(684, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Ngày sinh ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Số điện thoại";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(249, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(939, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quản lý người dùng";
            // 
            // grvData
            // 
            this.grvData.AllowUserToAddRows = false;
            this.grvData.AllowUserToResizeRows = false;
            this.grvData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.RoleId,
            this.Password,
            this.FullName,
            this.Username,
            this.UserId,
            this.PhoneNumber,
            this.Email,
            this.Address,
            this.Birthday});
            this.grvData.Location = new System.Drawing.Point(27, 272);
            this.grvData.Name = "grvData";
            this.grvData.RowHeadersVisible = false;
            this.grvData.RowHeadersWidth = 62;
            this.grvData.RowTemplate.Height = 28;
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.Size = new System.Drawing.Size(978, 214);
            this.grvData.TabIndex = 7;
            this.grvData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_RowEnter);
            this.grvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvData_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "RoleId";
            this.RoleId.HeaderText = "Chức vụ";
            this.RoleId.MinimumWidth = 8;
            this.RoleId.Name = "RoleId";
            this.RoleId.Width = 150;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Visible = false;
            this.Password.Width = 150;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "họ và tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 130;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài khoản";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 120;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "Mã định danh";
            this.UserId.MinimumWidth = 8;
            this.UserId.Name = "UserId";
            this.UserId.Width = 140;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Điện thoại";
            this.PhoneNumber.MinimumWidth = 8;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 130;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 130;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.Width = 130;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            dataGridViewCellStyle3.NullValue = "dd/MM/yyyy";
            this.Birthday.DefaultCellStyle = dataGridViewCellStyle3;
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.MinimumWidth = 8;
            this.Birthday.Name = "Birthday";
            this.Birthday.Width = 130;
            // 
            // grData
            // 
            this.grData.BackColor = System.Drawing.SystemColors.Control;
            this.grData.Controls.Add(this.dtBirthday);
            this.grData.Controls.Add(this.label7);
            this.grData.Controls.Add(this.label1);
            this.grData.Controls.Add(this.label2);
            this.grData.Controls.Add(this.label3);
            this.grData.Controls.Add(this.txtFullname);
            this.grData.Controls.Add(this.txtRole);
            this.grData.Controls.Add(this.txtPhone);
            this.grData.Controls.Add(this.txtUserId);
            this.grData.Controls.Add(this.label6);
            this.grData.Controls.Add(this.txtAddress);
            this.grData.Controls.Add(this.label5);
            this.grData.Controls.Add(this.label4);
            this.grData.Controls.Add(this.label8);
            this.grData.Controls.Add(this.txtEmail);
            this.grData.Controls.Add(this.label9);
            this.grData.Controls.Add(this.txtPassword);
            this.grData.Controls.Add(this.txtUsername);
            this.grData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grData.Location = new System.Drawing.Point(27, 41);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(1012, 164);
            this.grData.TabIndex = 1;
            this.grData.TabStop = false;
            this.grData.Text = "Thông tin người dùng";
            // 
            // dtBirthday
            // 
            this.dtBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBirthday.Location = new System.Drawing.Point(798, 69);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(180, 26);
            this.dtBirthday.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(691, 233);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "nhập tài khoản\\mật khẩu\\.";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(586, 227);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(89, 39);
            this.btnCannel.TabIndex = 4;
            this.btnCannel.Text = "Hủy";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Visible = false;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // frmManageUser
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 490);
            this.Controls.Add(this.grData);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1114, 546);
            this.MinimumSize = new System.Drawing.Size(1114, 546);
            this.Name = "frmManageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmManageUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.grData.ResumeLayout(false);
            this.grData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.GroupBox grData;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCannel;
    }
}