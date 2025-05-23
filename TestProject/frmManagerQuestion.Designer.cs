namespace TestProject
{
    partial class frmManagerQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtQuestionId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grData = new System.Windows.Forms.GroupBox();
            this.cbbSubject = new System.Windows.Forms.ComboBox();
            this.txtQContent = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCannel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.grData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã câu hỏi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Môn thi ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(157, 120);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(170, 26);
            this.txtAnswer.TabIndex = 13;
            // 
            // txtQuestionId
            // 
            this.txtQuestionId.Location = new System.Drawing.Point(157, 31);
            this.txtQuestionId.Name = "txtQuestionId";
            this.txtQuestionId.Size = new System.Drawing.Size(170, 26);
            this.txtQuestionId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kết quả";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(355, 265);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(510, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(468, 71);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(170, 26);
            this.txtOptionA.TabIndex = 9;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(468, 117);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(170, 26);
            this.txtOptionC.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Lựa chọn C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lựa chọn A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nội dung";
            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(798, 61);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(180, 26);
            this.txtOptionB.TabIndex = 5;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(798, 115);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(180, 26);
            this.txtOptionD.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Lựa chọn D";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(684, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lựa chọn B";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(249, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 39);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(369, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 39);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(939, 227);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quản lý câu hỏi";
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
            this.QuestionId,
            this.SubjectId,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
            this.grvData.Location = new System.Drawing.Point(27, 272);
            this.grvData.Name = "grvData";
            this.grvData.ReadOnly = true;
            this.grvData.RowHeadersVisible = false;
            this.grvData.RowHeadersWidth = 62;
            this.grvData.RowTemplate.Height = 28;
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.Size = new System.Drawing.Size(1012, 214);
            this.grvData.TabIndex = 7;
            this.grvData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_RowEnter);
            this.grvData.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grvData_RowPrePaint);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle2;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 8;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 60;
            // 
            // QuestionId
            // 
            this.QuestionId.DataPropertyName = "QuestionId";
            this.QuestionId.HeaderText = "Mã câu hỏi";
            this.QuestionId.MinimumWidth = 8;
            this.QuestionId.Name = "QuestionId";
            this.QuestionId.ReadOnly = true;
            this.QuestionId.Width = 150;
            // 
            // SubjectId
            // 
            this.SubjectId.DataPropertyName = "SubjectId";
            this.SubjectId.HeaderText = "Môn thi";
            this.SubjectId.MinimumWidth = 8;
            this.SubjectId.Name = "SubjectId";
            this.SubjectId.ReadOnly = true;
            this.SubjectId.Width = 150;
            // 
            // QContent
            // 
            this.QContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QContent.DataPropertyName = "QContent";
            this.QContent.HeaderText = "Nội dung";
            this.QContent.MinimumWidth = 8;
            this.QContent.Name = "QContent";
            this.QContent.ReadOnly = true;
            this.QContent.Width = 130;
            // 
            // OptionA
            // 
            this.OptionA.DataPropertyName = "OptionA";
            this.OptionA.HeaderText = "Lựa chọn A";
            this.OptionA.MinimumWidth = 8;
            this.OptionA.Name = "OptionA";
            this.OptionA.ReadOnly = true;
            this.OptionA.Width = 120;
            // 
            // OptionB
            // 
            this.OptionB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionB.DataPropertyName = "OptionB";
            this.OptionB.HeaderText = "Lựa chọn B";
            this.OptionB.MinimumWidth = 8;
            this.OptionB.Name = "OptionB";
            this.OptionB.ReadOnly = true;
            this.OptionB.Width = 140;
            // 
            // OptionC
            // 
            this.OptionC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionC.DataPropertyName = "OptionC";
            this.OptionC.HeaderText = "Lựa chọn C";
            this.OptionC.MinimumWidth = 8;
            this.OptionC.Name = "OptionC";
            this.OptionC.ReadOnly = true;
            this.OptionC.Width = 130;
            // 
            // OptionD
            // 
            this.OptionD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OptionD.DataPropertyName = "OptionD";
            this.OptionD.HeaderText = "Lựa chọn D";
            this.OptionD.MinimumWidth = 8;
            this.OptionD.Name = "OptionD";
            this.OptionD.ReadOnly = true;
            this.OptionD.Width = 130;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Câu trả lời";
            this.Answer.MinimumWidth = 8;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            this.Answer.Width = 130;
            // 
            // grData
            // 
            this.grData.BackColor = System.Drawing.SystemColors.Control;
            this.grData.Controls.Add(this.cbbSubject);
            this.grData.Controls.Add(this.label7);
            this.grData.Controls.Add(this.label1);
            this.grData.Controls.Add(this.label2);
            this.grData.Controls.Add(this.label3);
            this.grData.Controls.Add(this.txtAnswer);
            this.grData.Controls.Add(this.txtOptionB);
            this.grData.Controls.Add(this.txtQuestionId);
            this.grData.Controls.Add(this.label6);
            this.grData.Controls.Add(this.txtOptionD);
            this.grData.Controls.Add(this.label5);
            this.grData.Controls.Add(this.label4);
            this.grData.Controls.Add(this.txtOptionC);
            this.grData.Controls.Add(this.label9);
            this.grData.Controls.Add(this.txtQContent);
            this.grData.Controls.Add(this.txtOptionA);
            this.grData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grData.Location = new System.Drawing.Point(27, 41);
            this.grData.Name = "grData";
            this.grData.Size = new System.Drawing.Size(1012, 164);
            this.grData.TabIndex = 1;
            this.grData.TabStop = false;
            this.grData.Text = "Thông tin người dùng";
            // 
            // cbbSubject
            // 
            this.cbbSubject.FormattingEnabled = true;
            this.cbbSubject.Location = new System.Drawing.Point(157, 71);
            this.cbbSubject.Name = "cbbSubject";
            this.cbbSubject.Size = new System.Drawing.Size(170, 28);
            this.cbbSubject.TabIndex = 19;
            // 
            // txtQContent
            // 
            this.txtQContent.Location = new System.Drawing.Point(468, 28);
            this.txtQContent.Name = "txtQContent";
            this.txtQContent.Size = new System.Drawing.Size(510, 26);
            this.txtQContent.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(691, 233);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 26);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "nhập tài khoản\\mật khẩu\\.";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCannel
            // 
            this.btnCannel.Location = new System.Drawing.Point(586, 227);
            this.btnCannel.Name = "btnCannel";
            this.btnCannel.Size = new System.Drawing.Size(89, 39);
            this.btnCannel.TabIndex = 4;
            this.btnCannel.Text = "Hủy";
            this.btnCannel.UseVisualStyleBackColor = true;
            this.btnCannel.Visible = false;
            this.btnCannel.Click += new System.EventHandler(this.btnCannel_Click);
            // 
            // frmManagerQuestion
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 490);
            this.Controls.Add(this.grData);
            this.Controls.Add(this.grvData);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCannel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1114, 546);
            this.MinimumSize = new System.Drawing.Size(1114, 546);
            this.Name = "frmManagerQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.frmManagerQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.grData.ResumeLayout(false);
            this.grData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtQuestionId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.GroupBox grData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCannel;
        private System.Windows.Forms.TextBox txtQContent;
        private System.Windows.Forms.ComboBox cbbSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}