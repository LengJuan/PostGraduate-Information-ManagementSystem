namespace 研究生信息管理系统
{
    partial class FrmExercitation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExercitation));
            this.dgvexercitation = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtspan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtbirthtime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtstarttime = new System.Windows.Forms.DateTimePicker();
            this.dtendtime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexercitation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvexercitation
            // 
            this.dgvexercitation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexercitation.Location = new System.Drawing.Point(31, 173);
            this.dgvexercitation.Name = "dgvexercitation";
            this.dgvexercitation.RowHeadersWidth = 62;
            this.dgvexercitation.RowTemplate.Height = 30;
            this.dgvexercitation.Size = new System.Drawing.Size(863, 370);
            this.dgvexercitation.TabIndex = 0;
            this.dgvexercitation.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvexercitation_RowHeaderMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtspan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtbirthtime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtstarttime);
            this.panel1.Controls.Add(this.dtendtime);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtpayment);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcity);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtposition);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 155);
            this.panel1.TabIndex = 1;
            // 
            // txtspan
            // 
            this.txtspan.Location = new System.Drawing.Point(675, 67);
            this.txtspan.Name = "txtspan";
            this.txtspan.Size = new System.Drawing.Size(100, 28);
            this.txtspan.TabIndex = 24;
            this.txtspan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtspan_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "实习时长";
            // 
            // dtbirthtime
            // 
            this.dtbirthtime.Location = new System.Drawing.Point(409, 6);
            this.dtbirthtime.Name = "dtbirthtime";
            this.dtbirthtime.Size = new System.Drawing.Size(176, 28);
            this.dtbirthtime.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "出生日期";
            // 
            // dtstarttime
            // 
            this.dtstarttime.Location = new System.Drawing.Point(423, 68);
            this.dtstarttime.Name = "dtstarttime";
            this.dtstarttime.Size = new System.Drawing.Size(162, 28);
            this.dtstarttime.TabIndex = 20;
            this.dtstarttime.ValueChanged += new System.EventHandler(this.dtstarttime_ValueChanged);
            // 
            // dtendtime
            // 
            this.dtendtime.Location = new System.Drawing.Point(154, 117);
            this.dtendtime.Name = "dtendtime";
            this.dtendtime.Size = new System.Drawing.Size(200, 28);
            this.dtendtime.TabIndex = 19;
            this.dtendtime.ValueChanged += new System.EventHandler(this.dtendtime_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "实习结束时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(312, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "实习开始时间";
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(522, 117);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(81, 28);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(225, 68);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.Size = new System.Drawing.Size(81, 28);
            this.txtpayment.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "薪资";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(675, 3);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(100, 28);
            this.txtcity.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "实习岗位";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(53, 63);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(100, 28);
            this.txtposition.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "城市";
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(609, 117);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 28);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(360, 117);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 28);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(441, 117);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 28);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(225, 3);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(81, 28);
            this.txtno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "学号";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(53, 3);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 28);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(689, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "将数据导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmExercitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvexercitation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmExercitation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "实习情况管理系统";
            this.Load += new System.EventHandler(this.frmexercitation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvexercitation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.DataGridView dgvexercitation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dtbirthtime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtstarttime;
        private System.Windows.Forms.DateTimePicker dtendtime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtspan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}