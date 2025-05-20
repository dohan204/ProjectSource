using BussinessAccessLayer;
using Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }
        private bool isLoginSuccess = false;
        private bool IsValidInfor(UserAccount usser)
        {
            if(string.IsNullOrEmpty(usser.UserName))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(usser.Password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            if (string.IsNullOrEmpty(usser.NewPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(string.IsNullOrEmpty(usser.ConfirmPass))
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // kiểm tra tài khoản hoặc mk có đúng hay không
            if(!BUserAccount.IsExitesAccount(usser))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // kiểm tra mật khẩu mới và xác nhận mật khẩu mới có giống nhau hay không
            if (!usser.NewPassword.Equals(usser.ConfirmPass))
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu mới phải giống nhau!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // lấy thông tin từ giao diện
            UserAccount user = new UserAccount()
            {
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                NewPassword = txtNewpassword.Text.Trim(),
                ConfirmPass = txtConfimNewpass.Text.Trim(),
            };
            // kiểm trra thông tin đăng nhập
            if (!IsValidInfor(user))
            {
                return;
            }
            // cập nhật mật khẩu mới cho người dùng
            try
            {
                BUserAccount.UpdatePassword(user);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
