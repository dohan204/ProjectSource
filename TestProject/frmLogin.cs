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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChange = new frmChangePassword();
            frmChange.ShowDialog();
        }

        private void mnManageUser_Click(object sender, EventArgs e)
        {
            frmManageUser frmManage = new frmManageUser();
            frmManage.ShowDialog();
        }

        private void mnManagerSubject_Click(object sender, EventArgs e)
        {
            frmManagerSubject frmManagerSubject = new frmManagerSubject();
            frmManagerSubject.ShowDialog();
        }

        private void quảnLýCâuHỏiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagerQuestion frmManagerQuestion = new frmManagerQuestion();
            frmManagerQuestion.ShowDialog();
        }

        private void làmBàiThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOption frm = new frmOption();
            frm.ShowDialog();
        }
    }
}
