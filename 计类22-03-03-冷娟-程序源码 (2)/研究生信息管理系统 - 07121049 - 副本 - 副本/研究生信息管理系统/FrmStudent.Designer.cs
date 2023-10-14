namespace 研究生信息管理系统
{
    partial class FrmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.cmbmajor = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "专业";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "所在学院";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "学号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "性别";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(114, 11);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(121, 28);
            this.txtname.TabIndex = 6;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(677, 79);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 28);
            this.txtno.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "年龄";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(677, 18);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 28);
            this.txtage.TabIndex = 10;
            // 
            // cmbmajor
            // 
            this.cmbmajor.FormattingEnabled = true;
            this.cmbmajor.Location = new System.Drawing.Point(377, 81);
            this.cmbmajor.Name = "cmbmajor";
            this.cmbmajor.Size = new System.Drawing.Size(121, 26);
            this.cmbmajor.TabIndex = 11;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Items.AddRange(new object[] {
            "计算机学院",
            "医学部",
            "人文学院",
            "石油工程学院",
            "地质学院",
            "外国语学院"});
            this.cmbdept.Location = new System.Drawing.Point(114, 76);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(121, 26);
            this.cmbdept.TabIndex = 12;
            this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(253, 125);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(89, 32);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(360, 125);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(89, 32);
            this.btndelete.TabIndex = 15;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(464, 125);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(89, 32);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvstudent
            // 
            this.dgvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(32, 179);
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.RowHeadersWidth = 62;
            this.dgvstudent.RowTemplate.Height = 30;
            this.dgvstudent.Size = new System.Drawing.Size(862, 358);
            this.dgvstudent.TabIndex = 17;
            this.dgvstudent.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvstudent_RowHeaderMouseClick);
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbsex.Location = new System.Drawing.Point(377, 13);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(121, 26);
            this.cmbsex.TabIndex = 18;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(568, 125);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(81, 32);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.cmbsex);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.cmbdept);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtage);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.cmbmajor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 160);
            this.panel1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(655, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "将数据库导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvstudent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "研究生信息管理系统";
            this.Load += new System.EventHandler(this.frmstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ComboBox cmbmajor;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}