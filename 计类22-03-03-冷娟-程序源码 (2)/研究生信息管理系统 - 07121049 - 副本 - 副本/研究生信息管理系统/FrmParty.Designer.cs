namespace 研究生信息管理系统
{
    partial class FrmParty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParty));
            this.btnexit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dgvparty = new System.Windows.Forms.DataGridView();
            this.dtparty = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbmajor = new System.Windows.Forms.ComboBox();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnation = new System.Windows.Forms.TextBox();
            this.dtbirth = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvparty)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(564, 179);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(97, 28);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "学号";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(106, 22);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(121, 28);
            this.txtno.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "入党时间";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(337, 15);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(164, 28);
            this.txtname.TabIndex = 7;
            // 
            // dgvparty
            // 
            this.dgvparty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvparty.Location = new System.Drawing.Point(43, 235);
            this.dgvparty.Name = "dgvparty";
            this.dgvparty.RowHeadersWidth = 62;
            this.dgvparty.RowTemplate.Height = 30;
            this.dgvparty.Size = new System.Drawing.Size(858, 311);
            this.dgvparty.TabIndex = 9;
            this.dgvparty.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvparty_RowHeaderMouseClick);
            // 
            // dtparty
            // 
            this.dtparty.Location = new System.Drawing.Point(589, 69);
            this.dtparty.Name = "dtparty";
            this.dtparty.Size = new System.Drawing.Size(200, 28);
            this.dtparty.TabIndex = 10;
            this.dtparty.Value = new System.DateTime(2019, 7, 17, 0, 0, 0, 0);
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(461, 179);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(97, 28);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(231, 179);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(97, 28);
            this.btnupdate.TabIndex = 13;
            this.btnupdate.Text = "修改";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(349, 179);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(97, 28);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "专业";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "学院";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "性别";
            // 
            // cmbmajor
            // 
            this.cmbmajor.FormattingEnabled = true;
            this.cmbmajor.Location = new System.Drawing.Point(106, 132);
            this.cmbmajor.Name = "cmbmajor";
            this.cmbmajor.Size = new System.Drawing.Size(121, 26);
            this.cmbmajor.TabIndex = 20;
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbsex.Location = new System.Drawing.Point(337, 132);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(164, 26);
            this.cmbsex.TabIndex = 21;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Items.AddRange(new object[] {
            "计算机学院",
            "石油工程学院",
            "地质学院",
            "人文学院",
            "医学部"});
            this.cmbdept.Location = new System.Drawing.Point(589, 15);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(200, 26);
            this.cmbdept.TabIndex = 22;
            this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "民族";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "联系电话";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(106, 79);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(121, 28);
            this.txtphone.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(514, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "出生日期";
            // 
            // txtnation
            // 
            this.txtnation.Location = new System.Drawing.Point(337, 73);
            this.txtnation.Name = "txtnation";
            this.txtnation.Size = new System.Drawing.Size(164, 28);
            this.txtnation.TabIndex = 29;
            // 
            // dtbirth
            // 
            this.dtbirth.Location = new System.Drawing.Point(589, 132);
            this.dtbirth.Name = "dtbirth";
            this.dtbirth.Size = new System.Drawing.Size(200, 28);
            this.dtbirth.TabIndex = 30;
            this.dtbirth.Value = new System.DateTime(1998, 12, 3, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbdept);
            this.panel1.Controls.Add(this.dtparty);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbmajor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtphone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbsex);
            this.panel1.Controls.Add(this.txtnation);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtbirth);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.txtno);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Location = new System.Drawing.Point(43, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 216);
            this.panel1.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(667, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 28);
            this.button1.TabIndex = 31;
            this.button1.Text = "将数据导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvparty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmParty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "党员情况管理系统";
            this.Load += new System.EventHandler(this.frmparty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvparty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dgvparty;
        private System.Windows.Forms.DateTimePicker dtparty;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbmajor;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnation;
        private System.Windows.Forms.DateTimePicker dtbirth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}