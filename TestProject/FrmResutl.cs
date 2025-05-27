using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Entityes;

using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Common;
using BussinessAccessLayer;

namespace TestProject
{
    public partial class FrmResutl : Form
    {
        public FrmResutl(int correctAnswer, float mark)
        {
            InitializeComponent();
            // lấy thông tin từ class Sessionn
            txtFullname.Text = Sessionn.LogonUser.UserName;
            txtBirthday.Text = Sessionn.LogonUser.Birthday.ToString("dd/MM/yyyy");// đinhj dạng ngày tháng
            txtSubject.Text = Sessionn.Subject;
            txtNumberOfQuestion.Text = Sessionn.numberOfQuestion.ToString();
            txtCorrectAnswer.Text = correctAnswer.ToString();
            txtMark.Text = mark.ToString("0.00"); // định dạng điểm với 2 chữ số thập phân
            if (mark >= 9)
            {
                txtRate.Text = "Xuất sắc";
            }
            else if (mark > 7)
            {
                txtRate.Text = "Giỏi";
            }
            else if (mark > 5)
            {
                txtRate.Text = "Khá";
            }
            else if (mark > 3)
            {
                txtRate.Text = "Trung bình";
            }
            else
            {
                txtRate.Text = "Yếu";
            }
            // khởi tạo và lưu dữ liệu vào đối tượng TestHistory trong database
            /*
            * 	(@UserId int,
          @SubjectId  varchar(50)
          ,@TestDate datetime
          ,@CorrectAnswer int
          ,@TotalQuestion int
          ,@Mark int
          ,@CreatedBy varchar(50))
       as
            */
            TestHistory testHistory = new TestHistory()
            {
                UserId = Sessionn.LogonUser.UserId,
                SubjectId = Sessionn.SubjectId,
                TestDate = DateTime.Now,
                CorrectAnswer = correctAnswer,
                TotalQuestion = Sessionn.numberOfQuestion,
                Mark = (int)mark,
                CreatedBy = Sessionn.LogonUser.UserName,
            };
            try
            {
                BTestHistory.SaveResult(testHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmResutl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLoaderBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLoaderBoard frm = new FrmLoaderBoard();
            frm.ShowDialog(); // hiển thị form LoaderBoard
        }
    }
}
