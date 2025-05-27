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
using TestProject.Common;

namespace TestProject
{
    public partial class frmManagerSubject : Form
    {
        private string strMessageInputSeacrh = "Nhập từ khóa tìm kiếm";
        private int rowIndex = 0; // lưu lại vị trí của các row
        private bool isNewUser = false;
        public frmManagerSubject()
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
        // lấy các thuộc tính từ lớp Subject01
        private Subject01 GetSubjectInfo()
        {
            int.TryParse(txtSubjectId.Text, out int userId);
            // khởi tạo đố tượng userACCount
            Subject01 subject = new Subject01();
            subject.SubjectID = txtSubjectId.Text.Trim();
            subject.SubjectName = txtSubjectName.Text.Trim();
            subject.Description = txtDescription.Text.Trim();
            subject.CreatedAt = DateTime.Now;
            subject.CreatedBy = Sessionn.LogonUser.UserName;
            subject.ModifiedBy = Sessionn.LogonUser.UserName;
            subject.ModifiedAt = DateTime.Now;
            return subject;
        }
        //2.
        private bool IsValidUser(Subject01 subject)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(subject.SubjectName))
            {
                strMessage = "Tên môn thi không được để trống";
            }
            if(string.IsNullOrEmpty(subject.SubjectID))
            {
                strMessage += "Mã môn thi không được để trống\n";
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
        private void AddNewSubject()
        {
            var newSubject = GetSubjectInfo();
            if(!IsValidUser(newSubject))
                return;// đóng từ vòng gửi xe
            try
            {
                BSubject01.NewSubject(newSubject);
                loadData();
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
            //var userCreate = GetSubjectInfo();
           

            isNewUser = true;
            ShowHideButton(true);
            SetEnableControl(true);
            AddNewSubject();
            txtSubjectId.Clear();
            txtDescription.Clear();
            txtSubjectName.Clear();
            
            //txtSubjectId.Enabled = true; // cho phép nhập mã môn thi
            ////txtSubjectId.ReadOnly = false; // chỉ đọc
        }
        private void loadData()
        {
            try
            {
                grvData.AutoGenerateColumns = false; // kh cho nó tự động sinh cột
                grvData.DataSource = BSubject01.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }
        // tải dữ liệu lên khi form load
        private void frmManagerSubject_Load(object sender, EventArgs e)
        {
            loadData();
            SetEnableControl(false);
        
            
            grvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //load data for cbb

           //cbbRole.DataSource = BUserRole.GetAll();
           //cbbRole.DisplayMember = "RoleName";
           // cbbRole.ValueMember = "RoleId";
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
                else if(ctr is ComboBox)
                {
                    ComboBox cbbInput = ctr as ComboBox;
                    cbbInput.Enabled = isSuccess;
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
                //row.Tag = row.Cells["UserId"].Value.ToString();

                txtSubjectId.Text = row.Cells["SubjectId"].Value?.ToString() ?? "";


                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                //txtEmail.Text = row.Cells["Email"].Value.ToString();

                //txtFullname.Text = row.Cells["FullName"].Value.ToString();
                //txtPassword.Text = row.Cells["Password"].Value.ToString();
                //txtDescription.Text = row.Cells["PhoneNumber"].Value.ToString();
                //cbbRole.SelectedValue = row.Cells["RoleId"].Value.ToString();
                //dtBirthday.Text = row.Cells["Birthday"].FormattedValue.ToString();
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

        private void UpdateSubject()
        {
            var editSubject= GetSubjectInfo();
            //MessageBox.Show(editSubject.UserId.ToString());
            //MessageBox.Show($"UserId: {editSubject.UserId}, UserName: {editSubject.UserName}");

            if (!IsValidUser(editSubject))
                return;// đóng từ vòng gửi xe
            try
            {
                BSubject01.UpdateSubject(editSubject);
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
            txtSubjectId.ReadOnly = true; // chỉ đọc
            //UpdateSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string subjectId = txtSubjectId.Text.Trim();
            if (string.IsNullOrEmpty(subjectId) || rowIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn cau hoi cần xóa", "Thông báo" +
                    "");
                return;
            }
            try
            {
                string subjectName = txtSubjectName.Text.Trim();
            // kiem tra xem nguoi dung có muốn xóa thật không
            if (MessageBox.Show($"Bạn có chắc chắn xóa cau hoi  {subjectName}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BSubject01.DeleteSubject(subjectId);
                MessageBox.Show("Xóa cau hoi thành công!","Thông báo");
                // tai lai du lieu cho nguoi dung nhin thay
                loadData();
                //return;
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                if (keyword.Equals(strMessageInputSeacrh))
                    keyword = string.Empty;
                //if (string.IsNullOrEmpty(keyword))
                //{
                //    MessageBox.Show("Vui long nhap tu khoa can tim kiem", "Thong bao");
                //    return;
                //}
                grvData.DataSource = BSubject01.Search(keyword);
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
            var getNewUser = GetSubjectInfo();
            if (!IsValidUser(getNewUser))
                return;// đóng từ vòng gửi xe
            try
            {
                BSubject01.NewSubject(getNewUser);
                MessageBox.Show("Thêm môn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
                UpdateSubject();
            ShowHideButton(false);
            SetEnableControl(false);
        }
    }
}
