using BussinessAccessLayer;
using Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using System.Windows.Media;

namespace TestProject
{
    public partial class frmMain : Form
    {
        public bool isLoginSuccess = false;
        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
            {
                return;
            }
            if (rc.Width == 0 || rc.Height == 0)
            {
                return;
            }
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 223, 255), 90))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private bool IsValidUserName(UserAccount user)
        {
            // laays thoong tin tu giao dien 
            
            //Kiem tra thong tin hop le hay chua 
            if (string.IsNullOrEmpty(user.UserName))
            {
                MessageBox.Show("Vui long nhap tai khoan!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Vui long nhap mat khau!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
           

            UserAccount user = new UserAccount()
            {
                UserName = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim()
            };

            // kiem tra tai khoan hop le hay chua
            if(!IsValidUserName(user))
            {
                return;
            }

            // kiem tra tai khoan dang nhap: cai nay phai ket noi toi csdl
            if (BUserAccount.IsExitesAccount(user))
            {
                isLoginSuccess = true;
                this.Close();
                //MessageBox.Show("Dang nhap thanh cong!","thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("tai khoan/mat khau khong dung, vui long kiem tra lai!");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
