using BussinessAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject.Common;

namespace TestProject
{
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            try
            {
                cbbSubject.DataSource = BSubject01.GetAll();
                cbbSubject.DisplayMember = "SubjectName";
                cbbSubject.ValueMember = "SubjectId";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void frmOption_Load(object sender, EventArgs e)
        {
            loadData();

            txtTime.ReadOnly = true;
        }

        private void cbbNumberOfSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTime.Text = cbbNumberOfSubject.Text;
        }


        private void btnReadlly_Click_1(object sender, EventArgs e)
        {
            try
            {
                Sessionn.Subject = cbbSubject.Text.Trim();
                Sessionn.SubjectId = cbbSubject.SelectedValue.ToString();
                Sessionn.testTime = Convert.ToInt32(txtTime.Text.Trim());
                Sessionn.numberOfQuestion = Convert.ToInt32(cbbNumberOfSubject.Text.Trim());
                frmStart frm = new frmStart();
                frm.Hide();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
