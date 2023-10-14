namespace 研究生信息管理系统
{
    partial class FrmPaper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPaper));
            this.dgvpaper = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinstructor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpublish = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbcontent = new System.Windows.Forms.ComboBox();
            this.cmbkind = new System.Windows.Forms.ComboBox();
            this.btnselect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnselectall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaper)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvpaper
            // 
            this.dgvpaper.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpaper.Location = new System.Drawing.Point(52, 273);
            this.dgvpaper.Name = "dgvpaper";
            this.dgvpaper.RowHeadersWidth = 62;
            this.dgvpaper.RowTemplate.Height = 30;
            this.dgvpaper.Size = new System.Drawing.Size(838, 259);
            this.dgvpaper.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(729, 90);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 28);
            this.btnexit.TabIndex = 2;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "作者";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(348, 28);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 28);
            this.txtno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "学号";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(111, 21);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 28);
            this.txtname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "指导教师";
            // 
            // txtinstructor
            // 
            this.txtinstructor.Location = new System.Drawing.Point(649, 31);
            this.txtinstructor.Name = "txtinstructor";
            this.txtinstructor.Size = new System.Drawing.Size(100, 28);
            this.txtinstructor.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "论文名称";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(111, 74);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 28);
            this.txttitle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "发表时间";
            // 
            // dtpublish
            // 
            this.dtpublish.Location = new System.Drawing.Point(348, 70);
            this.dtpublish.Name = "dtpublish";
            this.dtpublish.Size = new System.Drawing.Size(200, 28);
            this.dtpublish.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtinstructor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpublish);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 131);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "论文上传";
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(705, 97);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(81, 28);
            this.btnadd.TabIndex = 13;
            this.btnadd.Text = "上传";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbcontent);
            this.groupBox2.Controls.Add(this.cmbkind);
            this.groupBox2.Controls.Add(this.btnselect);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnexit);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnselectall);
            this.groupBox2.Location = new System.Drawing.Point(52, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 124);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            // 
            // cmbcontent
            // 
            this.cmbcontent.FormattingEnabled = true;
            this.cmbcontent.Location = new System.Drawing.Point(463, 40);
            this.cmbcontent.Name = "cmbcontent";
            this.cmbcontent.Size = new System.Drawing.Size(121, 26);
            this.cmbcontent.TabIndex = 6;
            // 
            // cmbkind
            // 
            this.cmbkind.FormattingEnabled = true;
            this.cmbkind.Items.AddRange(new object[] {
            "作者",
            "指导教师"});
            this.cmbkind.Location = new System.Drawing.Point(189, 40);
            this.cmbkind.Name = "cmbkind";
            this.cmbkind.Size = new System.Drawing.Size(121, 26);
            this.cmbkind.TabIndex = 5;
            this.cmbkind.SelectedIndexChanged += new System.EventHandler(this.cmbkind_SelectedIndexChanged);
            // 
            // btnselect
            // 
            this.btnselect.AutoSize = true;
            this.btnselect.Location = new System.Drawing.Point(601, 90);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 28);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "查询";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "查询值";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "查询内容";
            // 
            // btnselectall
            // 
            this.btnselectall.AutoSize = true;
            this.btnselectall.Location = new System.Drawing.Point(463, 90);
            this.btnselectall.Name = "btnselectall";
            this.btnselectall.Size = new System.Drawing.Size(90, 28);
            this.btnselectall.TabIndex = 0;
            this.btnselectall.Text = "查询全部";
            this.btnselectall.UseVisualStyleBackColor = true;
            this.btnselectall.Click += new System.EventHandler(this.btnselectall_Click);
            // 
            // FrmPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPaper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "论文发表管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaper)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpaper;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinstructor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpublish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbcontent;
        private System.Windows.Forms.ComboBox cmbkind;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnselectall;
    }
}