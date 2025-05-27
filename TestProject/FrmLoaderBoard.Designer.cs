namespace TestProject
{
    partial class FrmLoaderBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorrectAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bảng xếp hạng điểm thi theo môn";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.Username,
            this.FullName,
            this.Mark,
            this.CorrectAnswer,
            this.TotalQuestion,
            this.TestDate,
            this.SubjectName});
            this.grvData.Location = new System.Drawing.Point(17, 145);
            this.grvData.Name = "grvData";
            this.grvData.RowHeadersVisible = false;
            this.grvData.RowHeadersWidth = 62;
            this.grvData.RowTemplate.Height = 28;
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.Size = new System.Drawing.Size(1026, 277);
            this.grvData.TabIndex = 8;
            this.grvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvData_RowPrePaint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // Username
            // 
            this.Username.DataPropertyName = "UserName";
            this.Username.HeaderText = "Tài khoản";
            this.Username.MinimumWidth = 8;
            this.Username.Name = "Username";
            this.Username.Width = 120;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 8;
            this.FullName.Name = "FullName";
            this.FullName.Width = 130;
            // 
            // Mark
            // 
            this.Mark.DataPropertyName = "Mark";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Mark.DefaultCellStyle = dataGridViewCellStyle3;
            this.Mark.HeaderText = "Điểm";
            this.Mark.MinimumWidth = 8;
            this.Mark.Name = "Mark";
            this.Mark.Width = 150;
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.DataPropertyName = "CorrectAnswer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CorrectAnswer.DefaultCellStyle = dataGridViewCellStyle4;
            this.CorrectAnswer.HeaderText = "Số câu trả lời đúng";
            this.CorrectAnswer.MinimumWidth = 8;
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.Width = 150;
            // 
            // TotalQuestion
            // 
            this.TotalQuestion.DataPropertyName = "TotalQuestion";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TotalQuestion.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalQuestion.HeaderText = "Tổng số câu";
            this.TotalQuestion.MinimumWidth = 8;
            this.TotalQuestion.Name = "TotalQuestion";
            this.TotalQuestion.Width = 150;
            // 
            // TestDate
            // 
            this.TestDate.DataPropertyName = "TestDate";
            dataGridViewCellStyle6.Format = "dd/MM/yyyy";
            dataGridViewCellStyle6.NullValue = null;
            this.TestDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.TestDate.HeaderText = "Ngày thi";
            this.TestDate.MinimumWidth = 8;
            this.TestDate.Name = "TestDate";
            this.TestDate.Width = 150;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên môn thi";
            this.SubjectName.MinimumWidth = 8;
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Width = 150;
            // 
            // FrmLoaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 502);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(1077, 558);
            this.MinimumSize = new System.Drawing.Size(1077, 558);
            this.Name = "FrmLoaderBoard";
            this.Text = "FrmLoaderBoard";
            this.Load += new System.EventHandler(this.FrmLoaderBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorrectAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
    }
}