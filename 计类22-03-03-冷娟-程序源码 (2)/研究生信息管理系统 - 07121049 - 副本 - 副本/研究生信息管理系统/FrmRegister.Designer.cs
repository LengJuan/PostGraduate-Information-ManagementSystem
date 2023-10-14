namespace 研究生信息管理系统
{
    partial class FrmRegister
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.cmbpurview = new System.Windows.Forms.ComboBox();
            this.txtpasswordok = new System.Windows.Forms.TextBox();
            this.txtuserpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbpurview
            // 
            this.cmbpurview.FormattingEnabled = true;
            this.cmbpurview.Items.AddRange(new object[] {
            "教师登录",
            "学生登录"});
            this.cmbpurview.Location = new System.Drawing.Point(538, 108);
            this.cmbpurview.Name = "cmbpurview";
            this.cmbpurview.Size = new System.Drawing.Size(121, 26);
            this.cmbpurview.TabIndex = 9;
            // 
            // txtpasswordok
            // 
            this.txtpasswordok.Location = new System.Drawing.Point(211, 98);
            this.txtpasswordok.Name = "txtpasswordok";
            this.txtpasswordok.PasswordChar = '*';
            this.txtpasswordok.Size = new System.Drawing.Size(121, 28);
            this.txtpasswordok.TabIndex = 8;
            // 
            // txtuserpassword
            // 
            this.txtuserpassword.Location = new System.Drawing.Point(538, 42);
            this.txtuserpassword.Name = "txtuserpassword";
            this.txtuserpassword.PasswordChar = '*';
            this.txtuserpassword.Size = new System.Drawing.Size(121, 28);
            this.txtuserpassword.TabIndex = 7;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(211, 49);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(121, 28);
            this.txtusername.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "管理权限";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "请确认用户密码";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 3;
            this.label8.Text = "用户密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "用户名";
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(626, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 28);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "取消";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(508, 185);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(88, 28);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "注册";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.cmbpurview);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtpasswordok);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtuserpassword);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(81, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 229);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Image = global::研究生信息管理系统.Properties.Resources._20151130192154;
            this.label2.Location = new System.Drawing.Point(347, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "  图形验证码  \r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 28);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "请输入验证码：";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbpurview;
        private System.Windows.Forms.TextBox txtpasswordok;
        private System.Windows.Forms.TextBox txtuserpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}