using BussinessAccessLayer;
using Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class frmManageUser : Form
    {
        private string strMessageInputSeacrh = "Nhập từ khóa tìm kiếm";
        private int rowIndex = 0; // lưu lại vị trí của các row
        private bool isNewUser = false;
        public frmManageUser()
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
        // lấy các thuộc tính từ lớp UserAccount
        private UserAccount GetInfor()
        {
            int.TryParse(txtUserId.Text, out int userId);
            // khởi tạo đố tượng userACCount
            UserAccount userAccount = new UserAccount();
            // gán giá trị cho từng thuộc tính ở đây
            userAccount.UserId = userId;
            userAccount.RoleId = txtRole.Text.Trim();
            userAccount.UserName = txtUsername.Text.Trim();
            userAccount.Password = txtPassword.Text.Trim(); // cần phải mã hóa

            userAccount.Email = txtEmail.Text.Trim();
            userAccount.PhoneNumber = txtPhone.Text.Trim();
            userAccount.Address = txtAddress.Text.Trim();
            userAccount.FullName = txtFullname.Text.Trim();
            userAccount.Birthday = dtBirthday.Value;
            userAccount.CreatedAt = DateTime.Now;
            userAccount.CreatedBy = "Han";
            userAccount.ModifiedAt = DateTime.Now;
            userAccount.ModifiedBy = "Han";
            return userAccount;
        }
        //2.
        private bool IsValidUser(UserAccount user)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(user.UserName))
            {
                strMessage = "Tài khoản không được để trống";
            }
            if(string.IsNullOrEmpty(user.Password))
            {
                strMessage += "Mật khẩu không được để trống\n";
            }
            if(string.IsNullOrEmpty(user.FullName))
            {
                strMessage += "Họ tên không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.Email))
            {
                strMessage += "Email không được để trống\n";
            }
            if (string.IsNullOrEmpty(user.PhoneNumber))
            {
                strMessage += "Số điện thoại không được để trống\n";
            }
            // kiểm tra thông tin có hợp lệ hay không
            if (!string.IsNullOrEmpty(strMessage))
            {
                MessageBox.Show(strMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void ShowHideButton(bool IsSaveCannel = false)
        {
            btnCannel.Visible = btnSave.Visible = IsSaveCannel;
            btnAdd.Visible = btnEdit.Visible = btnDelete.Visible = !IsSaveCannel;
        }
        private void AddNewUser()
        {
            var getUser = GetInfor();
            if(!IsValidUser(getUser))
                return;// đóng từ vòng gửi xe
            try
            {
                BUserAccount.NewUserAccount(getUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
             * CÁC BƯỚC THỰC HIỆN 
             * 1. LẤY thông tin từ giao diện
             * 2. kiểm tra thông tin có hợp lệ hay không
             * 3. thao tác với cơ sở dữ liệu
             * 
             */
            //var userCreate = GetInfor();
          

            isNewUser = true;
            ShowHideButton(true);
            AddNewUser();
            SetEnableControl(true);
        }
        private void loadData()
        {
            try
            {
                grvData.AutoGenerateColumns = false; // kh cho nó tự động sinh cột
                grvData.DataSource = BUserAccount.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }
        // tải dữ liệu lên khi form load
        private void frmManageUser_Load(object sender, EventArgs e)
        {
            loadData();
            SetEnableControl(false);
        }
        private void SetEnableControl(bool isSuccess = true)
        {
            // thực hiện duyệt qua các control trong grv
            foreach(Control ctr in grData.Controls)
            {
                // kiểm tra control là textbox thì đặt nó về trạng thái enable
                if (ctr is TextBox)
                {
                    TextBox txtInput = (TextBox)ctr;
                    txtInput.Enabled = isSuccess;
                }
                // tương tự như thế, datetimepicker
                //else if (ctr is ComboBox)
                //{
                //    ComboBox cbxInput = ctr as ComboBox;
                //    cbxInput.Enabled = isSuccess;
                //}
                else if(ctr is DateTimePicker)
                {
                    DateTimePicker dpkDate = ctr as DateTimePicker;
                    dpkDate.Enabled = isSuccess;
                }
            }
        }
        private void grvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grvData["STT", e.RowIndex].Value = e.RowIndex + 1;
        }

        private void ShowDetailData(int rowIndex)
        {
            try
            {
                // lấy ra dòng khi người dùng click  
                DataGridViewRow row = grvData.Rows[rowIndex];
                row.Tag = row.Cells["UserId"].Value.ToString();

                txtUserId.Text = row.Cells["UserId"].Value?.ToString() ?? "";


                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                txtFullname.Text = row.Cells["FullName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value.ToString();
                txtRole.Text = row.Cells["RoleId"].Value.ToString();
                dtBirthday.Text = row.Cells["Birthday"].FormattedValue.ToString();
                // Fix for CS1955: Use the Value property instead of FormattedValueType  
                //if (row.Cells["Birthday"].Value != null)
                //{
                //    dtBirthday.Text = Convert.ToDateTime(row.Cells["Birthday"].Value).ToString();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }
        private void grvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            ShowDetailData(rowIndex);

        }

        private void UpdateUser()
        {
            var editUser = GetInfor();
            //MessageBox.Show(editUser.UserId.ToString());
            //MessageBox.Show($"UserId: {editUser.UserId}, UserName: {editUser.UserName}");

            if (!IsValidUser(editUser))
                return;// đóng từ vòng gửi xe
            try
            {
                BUserAccount.UpdateUser(editUser);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo!");
                // tải lại dữ liệu cho người dùng nhìn thấy
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // kiểm tra vá lấy thông tin từ giao diện
            isNewUser = false;
            ShowHideButton(true);
            SetEnableControl(true);
            //UpdateUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(txtUserId.Text, out int userId);
            if (userId == 0)
            {
                MessageBox.Show("Vui long chon nguoi dung can xoa", "Thong bao");
                return;
            }
            try
            {
                string fullName = txtFullname.Text.Trim();
                // kiem tra xem nguoi dung có muốn xóa thật không
                if (MessageBox.Show($"Bạn có chắc chắn xóa người dùng {fullName}","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BUserAccount.DeleteUser(userId);
                    MessageBox.Show("Xoa nguoi dung thanh cong");
                    // tai lai du lieu cho nguoi dung nhin thay
                    loadData();
                    //return;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui long nhap tu khoa can tim kiem", "Thong bao");
                    return;
                }
                grvData.DataSource = BUserAccount.Search(keyword);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                txtSearch.Text = strMessageInputSeacrh;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void newUser()
        {
            var getNewUser = GetInfor();
            if (!IsValidUser(getNewUser))
                return;// đóng từ vòng gửi xe
            try
            {
                BUserAccount.NewUserAccount(getNewUser);
                MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCannel_Click(object sender, EventArgs e)
        {
            ShowHideButton(false);
            ShowDetailData(rowIndex);
            SetEnableControl(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNewUser)
                newUser();
            else
                UpdateUser();
            ShowHideButton(false);
        }
    }
}
