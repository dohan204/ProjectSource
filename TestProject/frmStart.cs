using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Common;
using System.Windows.Forms;
using BussinessAccessLayer;
using Entityes;

namespace TestProject
{
    public partial class frmStart : Form
    {
        private int selectedIndex = 0;
        private int remainTime = 0;
        private DataTable dtQuestion = null;
        private bool isLoaded = false;
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            // Nền form
            this.BackColor = Color.WhiteSmoke;

            // Tiêu đề label
            //lblTitle.ForeColor = ColorTranslator.FromHtml("#2C3E50");

            // Các nút
            btnNext.BackColor = ColorTranslator.FromHtml("#3498DB");
            btnNext.ForeColor = Color.White;

            btnPrev.BackColor = ColorTranslator.FromHtml("#3498DB");
            btnPrev.ForeColor = Color.White;

            btnSubmit.BackColor = ColorTranslator.FromHtml("#E74C3C");
            btnSubmit.ForeColor = Color.White;

            // Đồng hồ thời gian
            label5.ForeColor = ColorTranslator.FromHtml("#D35400");
            // show infor user
            // lấy thông tin từ Sessionn.LogonUser và hiển thị lên các textbox tương ứng
            txtFullName.Text = Sessionn.LogonUser.UserName ;
            txtBirthday.Text = Sessionn.LogonUser.Birthday.ToString("dd/MM/yyyy");
            txtSubjectName.Text = Sessionn.Subject;
            txtNumberOfQuestion.Text = Sessionn.numberOfQuestion.ToString();
            loadData();
            remainTime = Sessionn.testTime * 60; // chuyển đổi phút sang giâ
            timerTest.Enabled = true; // bật timer để đếm thời gian
            isLoaded = true; // đánh dấu là đã tải dữ liệu xong
        }
        private void loadData()
        {
            // tải lên dữ liệu của lvQuestion thông qua Bquestion => bằng hai giá trị subjectId và numberOfQuestion
            try
            {
                dtQuestion = BQuestion.getQuestionForTest(Sessionn.SubjectId, Sessionn.numberOfQuestion);
                // thêm một cái cột mới vào datatable để lưu các phương án đã chọn
                dtQuestion.Columns.Add("QuestionSelected");
                lvQuestion.DataSource = dtQuestion;
                lvQuestion.DisplayMember = "QuestionIndex";
                lvQuestion.ValueMember = "QuestionId";
                selectedIndex = 0; // khởi tạo lại selectedIndex về 0
                lvQuestion.SelectedIndex = selectedIndex; // chọn câu hỏi đầu tiên trong danh sách
                ShowDetailQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {

        }
        
        private string getQuestionSelected()
        {
            string result = string.Empty;
            if (checkA.Checked)
            {
                result = checkA.Text;
            }
            else if(checkB.Checked)
            {
                result = checkB.Text;
            }
            else if (checkC.Checked)
            {
                result = checkC.Text;
            }
            else if (checkD.Checked)
            {
                result = checkD.Text;
            }
            return result;
        }
        private void loadPrevSelectedOption()
        {
            string selectedOption = dtQuestion.Rows[selectedIndex]["QuestionSelected"].ToString();
            if (checkA.Text.Equals(selectedOption))
            {
                checkA.Checked = true;
            }
            else if (checkB.Text.Equals(selectedOption))
            {
                checkB.Checked = true;
            }
            else if (checkC.Text.Equals(selectedOption))
            {
                checkC.Checked = true;
            }
            else if (checkD.Text.Equals(selectedOption))
            {
                checkD.Checked = true;
            }
        }
        private void SaveCurrentSelected()
        {
            // lưu lại các giá trị mà người dùng đã chọn 
            if (selectedIndex >= 0 && selectedIndex < dtQuestion.Rows.Count)
            {
                dtQuestion.Rows[selectedIndex]["QuestionSelected"] = getQuestionSelected(); // lưu giá trị đã chọn vào cột QuestionSelected
            }
        }
        private void ShowDetailQuestion()
        {
            // show detail question
            // hiển thị chi tiết câu hỏi
            try
            {
                int.TryParse(lvQuestion.SelectedValue.ToString(), out int questionId);
                if (questionId < 1)
                    return;
               SaveCurrentSelected(); // lưu lại câu trả lời đã chọn trước đó
                lb01.Text = lvQuestion.Text;
                selectedIndex = lvQuestion.SelectedIndex;
                // lays giá trị qua thuộc tính questionId, thông qua đó lấy ra câu hỏi theo id tương ứng
                Question selectedQuestion = BQuestion.getOneQuestion(questionId);
                // disabel 
                btnNext.Enabled = (selectedIndex < Sessionn.numberOfQuestion - 1);
                btnPrev.Enabled = (selectedIndex > 0);
                rtxContent.Text = selectedQuestion.QContent;
                checkA.Text = selectedQuestion.OptionA;
                checkB.Text = selectedQuestion.OptionB;
                checkC.Text = selectedQuestion.OptionC;
                checkD.Text = selectedQuestion.OptionD;
                checkA.Checked = checkB.Checked = checkC.Checked = checkD.Checked = false; // bỏ chọn tất cả các ô checkbox
                loadPrevSelectedOption();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void lvQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isLoaded)
                ShowDetailQuestion(); // gọi hàm để hiển thị chi tiết câu hỏi khi người dùng chọn một câu hỏi trong danh sách
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // gán giá trị của chỉ số index bằng 0, tại vì biến đếm bắt đầu bằng 0
            lvQuestion.SelectedIndex = 0;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            // gán biến đến chỉ số cuối của danh sách câu hỏi
            lvQuestion.SelectedIndex = Sessionn.numberOfQuestion - 1;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu selectedIndex lớn hơn 0 thì mới cho phép lùi
            if (selectedIndex > 0)
                lvQuestion.SelectedIndex = selectedIndex - 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // kiểm tra nếu selectedIndex nhỏ hơn tổng số câu hỏi thì mới cho tiến:
            // ví dụ tổng là 30, thì giá trị của selectedIndex phải nhỏ hơn số 30 đó là 29 
            if (selectedIndex < Sessionn.numberOfQuestion - 1)
                lvQuestion.SelectedIndex = selectedIndex + 1;
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {
            // giảm dần thời gian từng giây một
            remainTime--;
            string strRemainTime = $"{remainTime / 60} : {remainTime % 60}"; // định dạng hiển thị phút và giây
            txtRemainTime.Text = strRemainTime; // hiển thị thời gian chạy trên textbox
            if(remainTime < 0)
            {
                finishAnswer();
            }
        }

        private void checkA_CheckedChanged(object sender, EventArgs e)
        {
            if(checkA.Checked)
            {
                checkB.Checked = checkC.Checked = checkD.Checked = false; // bỏ chọn các ô khác
            }
        }

        private void checkB_CheckedChanged(object sender, EventArgs e)
        {
            if(checkB.Checked)
            {
                checkA.Checked = checkC.Checked = checkD.Checked = false; // bỏ chọn các ô khác
            }
        }

        private void checkC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkC.Checked)
            {
                checkA.Checked = checkB.Checked = checkD.Checked = false; // bỏ chọn các ô khác
            }
        }

        private void checkD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkD.Checked)
            {
                checkA.Checked = checkB.Checked = checkC.Checked = false; // bỏ chọn các ô khác
            }
        }
        private void finishAnswer()
        {
            isLoaded = false;
            SaveCurrentSelected(); // lưu lại câu trả lời đã chọn trước khi tính điểm   
            int correctAnswer = 0;
            float mark = 0;
            foreach (DataRow row in dtQuestion.Rows)
            {
                string answer = row["Answer"].ToString(); // lay ra dap an vi du: ngon ngu C#
                string selectedOption = row["QuestionSelected"].ToString();// A. // gán giá trị của phương án đã chọn
                //selectedOption = selectedOption.Length > 0 ? selectedOption.Substring(3) : selectedOption;
                if (answer.Equals(selectedOption))
                {
                    correctAnswer++;
                }
            }
            mark = (float)correctAnswer * 10 / Sessionn.numberOfQuestion;
            // hidden current form
            this.Hide();
            FrmResutl frmResutl = new FrmResutl(correctAnswer, mark);
            
            frmResutl.ShowDialog();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn nộp bài không", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return; // nếu người dùng chọn No thì không làm gì cả
            }
            finishAnswer(); // gọi hàm để tính điểm và hiển thị kết quả
            //MessageBox.Show("so diem ban dat duoc la: " + mark.ToString("0.00"));
        }
    }
}
