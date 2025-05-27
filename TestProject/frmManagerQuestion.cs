using BussinessAccessLayer;
using Entityes;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TestProject.Common;

namespace TestProject
{
    public partial class frmManagerQuestion : Form
    {
        private string strMessageInputSeacrh = "Nhập từ khóa tìm kiếm";
        private int rowIndex = 0; // lưu lại vị trí của các row
        private bool isNewUser = false;
        public frmManagerQuestion()
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
        // lấy các thuộc tính từ lớp Question
        private Question GetInfor()
        {
            // khởi tạo đố tượng userACCount
            //Question question = new Question();
            //// gán giá trị cho từng thuộc tính ở đây
            //int.TryParse(txtQuestionId.Text, out int questionId);
            //question.QuestionId = questionId;
            //question.QContent= txtQContent.Text.Trim();
            //question.Answer = txtAnswer.Text.Trim();
            //question.OptionA = txtOptionA.Text.Trim();
            //question.OptionB = txtOptionB.Text.Trim();
            //question.OptionC = txtOptionC.Text.Trim();
            //question.OptionD = txtOptionD.Text.Trim();
            //question.SubjectID = cbbSubject.SelectedValue.ToString();

            //question.CreatedAt = DateTime.Now;
            //question.CreatedBy = "Han";

            //return question;
            // Gán giá trị cho đối tượng question
            Question question = new Question();

            int.TryParse(txtQuestionId.Text, out int questionId);
            question.QuestionId = questionId;
            question.QContent = txtQContent.Text.Trim();
            question.Answer = txtAnswer.Text.Trim();
            question.OptionA = txtOptionA.Text.Trim();
            question.OptionB = txtOptionB.Text.Trim();
            question.OptionC = txtOptionC.Text.Trim();
            question.OptionD = txtOptionD.Text.Trim();
            question.SubjectId = cbbSubject.SelectedValue.ToString();
            //if (cbbSubject.SelectedValue != null)
            //{
            //    question.SubjectID = cbbSubject.SelectedValue.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn môn học!");
            //    //return; // hoặc xử lý logic khác nếu cần
            //}

            question.CreatedAt = DateTime.Now;
            question.CreatedBy = Sessionn.LogonUser.UserName;
            return question;

        }
        //2.
        private bool IsValidQuestion(Question question)
        {
            string strMessage = string.Empty;
            if (string.IsNullOrEmpty(question.QContent))
            {
                strMessage = "Noi dung không được để trống";
            }
            if(string.IsNullOrEmpty(question.OptionA))
            {
                strMessage += "Lua chon A không được để trống\n";
            }
            if(string.IsNullOrEmpty(question.OptionB))
            {
                strMessage += "lua chon B không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionC))
            {
                strMessage += "lua chon C không được để trống\n";
            }
            if (string.IsNullOrEmpty(question.OptionD))
            {
                strMessage += " Lua chon D không được để trống\n";
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
            var getQuestion = GetInfor();
            if(!IsValidQuestion(getQuestion))
                return;// đóng từ vòng gửi xe
            try
            {
                BQuestion.NewQuestion(getQuestion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isNewUser = true;
            ShowHideButton(true);
            SetEnableControl(true);
            AddNewUser();
           
            txtQuestionId.Text = "0";
            txtQuestionId.ReadOnly = true; // chỉ đọc
        }
        private void loadData()
        {
            try
            {

                grvData.AutoGenerateColumns = false; // kh cho nó tự động sinh cột
                grvData.DataSource = BQuestion.GetAll();

                cbbSubject.DataSource = BSubject01.GetAll();
                cbbSubject.DisplayMember = "SubjectName";
                cbbSubject.ValueMember = "SubjectID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi");
            }
        }
        // tải dữ liệu lên khi form load
        private void frmManagerQuestion_Load(object sender, EventArgs e)
        {
            loadData();
            SetEnableControl(false);
            // load data for cbb
            
            //cbbSubject.DataSource = BUserRole.GetAll();
            //cbbSubject.DisplayMember = "RoleName";
            //cbbSubject.ValueMember = "RoleId";
            //grvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                txtQuestionId.Text = row.Cells["QuestionId"].Value?.ToString() ?? "";
                txtAnswer.Text = row.Cells["Answer"].Value.ToString();
                txtQContent.Text = row.Cells["QContent"].Value.ToString();
                txtOptionD.Text = row.Cells["OptionD"].Value.ToString();
                txtOptionC.Text = row.Cells["OptionC"].Value.ToString();
                txtOptionA.Text = row.Cells["OptionA"].Value.ToString();
                txtOptionB.Text = row.Cells["OptionB"].Value.ToString();
                cbbSubject.SelectedValue = row.Cells["SubjectId"].Value.ToString();
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

        private void UpdateQuestion()
        {
            var editQuestion = GetInfor();
            //MessageBox.Show(editUser.UserId.ToString());
            //MessageBox.Show($"UserId: {editUser.UserId}, UserName: {editUser.UserName}");

            if (!IsValidQuestion(editQuestion))
                return;// đóng từ vòng gửi xe
            try
            {
                BQuestion.UpdateUser(editQuestion);
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
            txtQuestionId.ReadOnly = true; // chỉ đọc
            //UpdateSubject();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(txtQuestionId.Text, out int userId);
            if (userId == 0)
            {
                MessageBox.Show("Vui long chon nguoi dung can xoa", "Thong bao");
                return;
            }
            try
            {
                string fullName = txtAnswer.Text.Trim();
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
                if (keyword.Equals(strMessageInputSeacrh))
                    keyword = string.Empty;
                //if (string.IsNullOrEmpty(keyword))
                //{
                //    MessageBox.Show("Vui long nhap tu khoa can tim kiem", "Thong bao");
                //    return;
                //}

                grvData.DataSource = BQuestion.Search(keyword);
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
            var newQuestion = GetInfor();
            if (!IsValidQuestion(newQuestion))
                return;// đóng từ vòng gửi xe
            try
            {
                BQuestion.NewQuestion(newQuestion);
                loadData();
                //MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCannel_Click(object sender, EventArgs e)
        {
            // nếu là thêm mới thì xóa trắng các textbox
            if (!isNewUser)
            {
                txtQuestionId.Text = "0";
                txtQContent.Clear();
                txtAnswer.Clear();
                txtOptionA.Clear();
                txtOptionB.Clear();
                txtOptionC.Clear();
                txtOptionD.Clear();
            }
            else
            {
                // nếu là sửa thì chỉ cần load lại dữ liệu
                loadData();
            }
            ShowHideButton(false);
            ShowDetailData(rowIndex);
            SetEnableControl(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isNewUser)
                newUser();
            else
                UpdateQuestion();
            ShowHideButton(false);
            SetEnableControl(false);
        }

       
    }
}
