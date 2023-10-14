namespace 研究生信息管理系统
{
    partial class FrmProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dtbirthtime = new System.Windows.Forms.DateTimePicker();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmajor = new System.Windows.Forms.TextBox();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvprofessor = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofessor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.dtbirthtime);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.txtmajor);
            this.panel1.Controls.Add(this.cmbsex);
            this.panel1.Controls.Add(this.txttitle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 174);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(713, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 16;
            this.button1.Text = "将数据导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(614, 121);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(83, 33);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(509, 121);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(86, 33);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(405, 121);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(83, 33);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dtbirthtime
            // 
            this.dtbirthtime.Location = new System.Drawing.Point(637, 64);
            this.dtbirthtime.Name = "dtbirthtime";
            this.dtbirthtime.Size = new System.Drawing.Size(197, 28);
            this.dtbirthtime.TabIndex = 12;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(405, 65);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 28);
            this.txtphone.TabIndex = 11;
            // 
            // txtmajor
            // 
            this.txtmajor.Location = new System.Drawing.Point(121, 61);
            this.txtmajor.Name = "txtmajor";
            this.txtmajor.Size = new System.Drawing.Size(100, 28);
            this.txtmajor.TabIndex = 10;
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbsex.Location = new System.Drawing.Point(637, 16);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(197, 26);
            this.cmbsex.TabIndex = 9;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(405, 13);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 28);
            this.txttitle.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "出生日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "联系方式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "研究方向";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "职称";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(121, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 28);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(297, 121);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(83, 33);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvprofessor
            // 
            this.dgvprofessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprofessor.Location = new System.Drawing.Point(12, 192);
            this.dgvprofessor.Name = "dgvprofessor";
            this.dgvprofessor.RowHeadersWidth = 62;
            this.dgvprofessor.RowTemplate.Height = 30;
            this.dgvprofessor.Size = new System.Drawing.Size(904, 340);
            this.dgvprofessor.TabIndex = 1;
            this.dgvprofessor.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvprofessor_RowHeaderMouseClick);
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.dgvprofessor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导师信息管理系统";
            this.Load += new System.EventHandler(this.frmprofessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprofessor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvprofessor;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dtbirthtime;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmajor;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}