namespace 研究生信息管理系统
{
    partial class FrmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdate));
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtnewpwdok = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(599, 248);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(88, 28);
            this.btn4.TabIndex = 11;
            this.btn4.Text = "取消";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(440, 248);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(88, 28);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "修改";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 18);
            this.label16.TabIndex = 9;
            this.label16.Text = "请确认新密码";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(92, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "新密码";
            // 
            // txtnewpwdok
            // 
            this.txtnewpwdok.Location = new System.Drawing.Point(550, 150);
            this.txtnewpwdok.Name = "txtnewpwdok";
            this.txtnewpwdok.PasswordChar = '*';
            this.txtnewpwdok.Size = new System.Drawing.Size(100, 28);
            this.txtnewpwdok.TabIndex = 7;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(195, 150);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.PasswordChar = '*';
            this.txtnewpwd.Size = new System.Drawing.Size(100, 28);
            this.txtnewpwd.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "旧密码";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(550, 79);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(100, 28);
            this.txtpwd.TabIndex = 3;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(195, 79);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 28);
            this.txtuser.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "用户名";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "请输入你的信息：";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtnewpwdok);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtnewpwd);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtpwd);
            this.panel1.Location = new System.Drawing.Point(88, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 317);
            this.panel1.TabIndex = 4;
            // 
            // FrmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户修改密码";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtnewpwdok;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}