namespace 研究生信息管理系统
{
    partial class FrmCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourse));
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbsemester = new System.Windows.Forms.ComboBox();
            this.txtperiod = new System.Windows.Forms.TextBox();
            this.txtteacher = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtcno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcourse
            // 
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Location = new System.Drawing.Point(39, 177);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.RowHeadersWidth = 62;
            this.dgvcourse.RowTemplate.Height = 30;
            this.dgvcourse.Size = new System.Drawing.Size(864, 355);
            this.dgvcourse.TabIndex = 0;
            this.dgvcourse.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcourse_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbsemester);
            this.panel1.Controls.Add(this.txtperiod);
            this.panel1.Controls.Add(this.txtteacher);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtcredit);
            this.panel1.Controls.Add(this.txtcname);
            this.panel1.Controls.Add(this.txtcno);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(39, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 144);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(634, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "将数据导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbsemester
            // 
            this.cmbsemester.FormattingEnabled = true;
            this.cmbsemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbsemester.Location = new System.Drawing.Point(389, 63);
            this.cmbsemester.Name = "cmbsemester";
            this.cmbsemester.Size = new System.Drawing.Size(100, 26);
            this.cmbsemester.TabIndex = 16;
            // 
            // txtperiod
            // 
            this.txtperiod.Location = new System.Drawing.Point(119, 63);
            this.txtperiod.Name = "txtperiod";
            this.txtperiod.Size = new System.Drawing.Size(100, 28);
            this.txtperiod.TabIndex = 15;
            // 
            // txtteacher
            // 
            this.txtteacher.Location = new System.Drawing.Point(676, 57);
            this.txtteacher.Name = "txtteacher";
            this.txtteacher.Size = new System.Drawing.Size(100, 28);
            this.txtteacher.TabIndex = 14;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(541, 103);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(87, 32);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(448, 103);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 32);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(355, 103);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(87, 32);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(676, 19);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(100, 28);
            this.txtcredit.TabIndex = 9;
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(389, 19);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(100, 28);
            this.txtcname.TabIndex = 8;
            // 
            // txtcno
            // 
            this.txtcno.Location = new System.Drawing.Point(119, 16);
            this.txtcno.Name = "txtcno";
            this.txtcno.Size = new System.Drawing.Size(100, 28);
            this.txtcno.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "任课教师";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "学时";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "学期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "学分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "课程名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "课程编号";
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(262, 103);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 32);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // FrmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvcourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程信息管理系统";
            this.Load += new System.EventHandler(this.FrmCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbsemester;
        private System.Windows.Forms.TextBox txtperiod;
        private System.Windows.Forms.TextBox txtteacher;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.TextBox txtcname;
        private System.Windows.Forms.TextBox txtcno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
    }
}