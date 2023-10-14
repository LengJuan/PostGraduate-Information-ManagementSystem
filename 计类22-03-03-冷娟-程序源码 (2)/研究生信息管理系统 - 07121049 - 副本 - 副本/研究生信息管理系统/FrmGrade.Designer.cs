namespace 研究生信息管理系统
{
    partial class FrmGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrade));
            this.dgvgrade = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbcourse = new System.Windows.Forms.ComboBox();
            this.cmbstudent = new System.Windows.Forms.ComboBox();
            this.txtgrade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btninsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnselectall = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.cmbcontent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbkind = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvgrade
            // 
            this.dgvgrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgrade.Location = new System.Drawing.Point(46, 228);
            this.dgvgrade.Name = "dgvgrade";
            this.dgvgrade.RowHeadersWidth = 62;
            this.dgvgrade.RowTemplate.Height = 30;
            this.dgvgrade.Size = new System.Drawing.Size(831, 304);
            this.dgvgrade.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcourse);
            this.groupBox1.Controls.Add(this.cmbstudent);
            this.groupBox1.Controls.Add(this.txtgrade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btninsert);
            this.groupBox1.Location = new System.Drawing.Point(46, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "学生成绩录入";
            // 
            // cmbcourse
            // 
            this.cmbcourse.FormattingEnabled = true;
            this.cmbcourse.Location = new System.Drawing.Point(141, 67);
            this.cmbcourse.Name = "cmbcourse";
            this.cmbcourse.Size = new System.Drawing.Size(121, 26);
            this.cmbcourse.TabIndex = 7;
            // 
            // cmbstudent
            // 
            this.cmbstudent.FormattingEnabled = true;
            this.cmbstudent.Location = new System.Drawing.Point(141, 27);
            this.cmbstudent.Name = "cmbstudent";
            this.cmbstudent.Size = new System.Drawing.Size(121, 26);
            this.cmbstudent.TabIndex = 6;
            // 
            // txtgrade
            // 
            this.txtgrade.Location = new System.Drawing.Point(523, 24);
            this.txtgrade.Name = "txtgrade";
            this.txtgrade.Size = new System.Drawing.Size(100, 28);
            this.txtgrade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "请输入课程";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "成绩";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入学生";
            // 
            // btninsert
            // 
            this.btninsert.AutoSize = true;
            this.btninsert.Location = new System.Drawing.Point(544, 71);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(90, 28);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "录入成绩";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnexit);
            this.groupBox2.Controls.Add(this.btnselectall);
            this.groupBox2.Controls.Add(this.btnselect);
            this.groupBox2.Controls.Add(this.cmbcontent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbkind);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(46, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 103);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "学生成绩查询";
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(696, 53);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 28);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnselectall
            // 
            this.btnselectall.AutoSize = true;
            this.btnselectall.Location = new System.Drawing.Point(614, 54);
            this.btnselectall.Name = "btnselectall";
            this.btnselectall.Size = new System.Drawing.Size(75, 28);
            this.btnselectall.TabIndex = 5;
            this.btnselectall.Text = "全部";
            this.btnselectall.UseVisualStyleBackColor = true;
            this.btnselectall.Click += new System.EventHandler(this.btnselectall_Click);
            // 
            // btnselect
            // 
            this.btnselect.AutoSize = true;
            this.btnselect.Location = new System.Drawing.Point(523, 54);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(81, 28);
            this.btnselect.TabIndex = 4;
            this.btnselect.Text = "查询";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // cmbcontent
            // 
            this.cmbcontent.FormattingEnabled = true;
            this.cmbcontent.Location = new System.Drawing.Point(372, 46);
            this.cmbcontent.Name = "cmbcontent";
            this.cmbcontent.Size = new System.Drawing.Size(121, 26);
            this.cmbcontent.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "查询值";
            // 
            // cmbkind
            // 
            this.cmbkind.FormattingEnabled = true;
            this.cmbkind.Items.AddRange(new object[] {
            "学生学号",
            "课程编号"});
            this.cmbkind.Location = new System.Drawing.Point(125, 46);
            this.cmbkind.Name = "cmbkind";
            this.cmbkind.Size = new System.Drawing.Size(121, 26);
            this.cmbkind.TabIndex = 1;
            this.cmbkind.SelectedIndexChanged += new System.EventHandler(this.cmbkind_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "查询内容";
            // 
            // FrmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvgrade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "成绩信息管理系统";
            this.Load += new System.EventHandler(this.FrmGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgrade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgrade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbcourse;
        private System.Windows.Forms.ComboBox cmbstudent;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnselectall;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ComboBox cmbcontent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbkind;
        private System.Windows.Forms.Label label4;
    }
}