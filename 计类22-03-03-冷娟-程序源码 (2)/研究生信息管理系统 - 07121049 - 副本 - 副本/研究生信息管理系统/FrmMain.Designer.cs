namespace 研究生信息管理系统
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnuser = new System.Windows.Forms.Button();
            this.btnpaper = new System.Windows.Forms.Button();
            this.btnprofessor = new System.Windows.Forms.Button();
            this.btnparty = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.btnexercitation = new System.Windows.Forms.Button();
            this.btngrade = new System.Windows.Forms.Button();
            this.btncourse = new System.Windows.Forms.Button();
            this.btnmajor = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(123, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用研究生信息管理系统";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnuser);
            this.groupBox1.Controls.Add(this.btnpaper);
            this.groupBox1.Controls.Add(this.btnprofessor);
            this.groupBox1.Controls.Add(this.btnparty);
            this.groupBox1.Controls.Add(this.btnstudent);
            this.groupBox1.Controls.Add(this.btnexercitation);
            this.groupBox1.Controls.Add(this.btngrade);
            this.groupBox1.Controls.Add(this.btncourse);
            this.groupBox1.Controls.Add(this.btnmajor);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(78, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请选择要进入的子系统";
            // 
            // btnuser
            // 
            this.btnuser.Location = new System.Drawing.Point(18, 44);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(233, 53);
            this.btnuser.TabIndex = 9;
            this.btnuser.Text = "用户信息管理系统";
            this.btnuser.UseVisualStyleBackColor = true;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnpaper
            // 
            this.btnpaper.Location = new System.Drawing.Point(562, 224);
            this.btnpaper.Name = "btnpaper";
            this.btnpaper.Size = new System.Drawing.Size(216, 53);
            this.btnpaper.TabIndex = 8;
            this.btnpaper.Text = "论文发表管理系统";
            this.btnpaper.UseVisualStyleBackColor = true;
            this.btnpaper.Click += new System.EventHandler(this.btnpaper_Click);
            // 
            // btnprofessor
            // 
            this.btnprofessor.Location = new System.Drawing.Point(297, 224);
            this.btnprofessor.Name = "btnprofessor";
            this.btnprofessor.Size = new System.Drawing.Size(225, 53);
            this.btnprofessor.TabIndex = 4;
            this.btnprofessor.Text = "导师信息管理系统";
            this.btnprofessor.UseVisualStyleBackColor = true;
            this.btnprofessor.Click += new System.EventHandler(this.btnprofessor_Click);
            // 
            // btnparty
            // 
            this.btnparty.Location = new System.Drawing.Point(562, 44);
            this.btnparty.Name = "btnparty";
            this.btnparty.Size = new System.Drawing.Size(216, 53);
            this.btnparty.TabIndex = 6;
            this.btnparty.Text = "党员情况管理系统";
            this.btnparty.UseVisualStyleBackColor = true;
            this.btnparty.Click += new System.EventHandler(this.btnparty_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.Location = new System.Drawing.Point(297, 44);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(225, 53);
            this.btnstudent.TabIndex = 2;
            this.btnstudent.Text = "研究生信息管理系统";
            this.btnstudent.UseVisualStyleBackColor = true;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // btnexercitation
            // 
            this.btnexercitation.Location = new System.Drawing.Point(562, 138);
            this.btnexercitation.Name = "btnexercitation";
            this.btnexercitation.Size = new System.Drawing.Size(216, 53);
            this.btnexercitation.TabIndex = 5;
            this.btnexercitation.Text = "实习情况管理系统";
            this.btnexercitation.UseVisualStyleBackColor = true;
            this.btnexercitation.Click += new System.EventHandler(this.btnexercitation_Click);
            // 
            // btngrade
            // 
            this.btngrade.Location = new System.Drawing.Point(297, 138);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(225, 53);
            this.btngrade.TabIndex = 3;
            this.btngrade.Text = "成绩信息管理系统";
            this.btngrade.UseVisualStyleBackColor = true;
            this.btngrade.Click += new System.EventHandler(this.btngrade_Click);
            // 
            // btncourse
            // 
            this.btncourse.AutoSize = true;
            this.btncourse.Location = new System.Drawing.Point(18, 224);
            this.btncourse.Name = "btncourse";
            this.btncourse.Size = new System.Drawing.Size(233, 53);
            this.btncourse.TabIndex = 1;
            this.btncourse.Text = "课程信息系统";
            this.btncourse.UseVisualStyleBackColor = true;
            this.btncourse.Click += new System.EventHandler(this.btncourse_Click);
            // 
            // btnmajor
            // 
            this.btnmajor.AutoSize = true;
            this.btnmajor.Location = new System.Drawing.Point(18, 138);
            this.btnmajor.Name = "btnmajor";
            this.btnmajor.Size = new System.Drawing.Size(233, 53);
            this.btnmajor.TabIndex = 0;
            this.btnmajor.Text = "专业信息系统";
            this.btnmajor.UseVisualStyleBackColor = true;
            this.btnmajor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(589, 449);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(208, 53);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "退出本系统";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button8_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "研究生信息管理系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpaper;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnparty;
        private System.Windows.Forms.Button btnexercitation;
        private System.Windows.Forms.Button btnprofessor;
        private System.Windows.Forms.Button btngrade;
        private System.Windows.Forms.Button btnstudent;
        private System.Windows.Forms.Button btncourse;
        private System.Windows.Forms.Button btnmajor;
        private System.Windows.Forms.Button btnuser;
    }
}

