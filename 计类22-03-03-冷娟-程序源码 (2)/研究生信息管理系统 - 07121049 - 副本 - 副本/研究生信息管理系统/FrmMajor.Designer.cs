namespace 研究生信息管理系统
{
    partial class FrmMajor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMajor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgv_major = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_major)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "专业";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "所在院系";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(144, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(570, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(146, 28);
            this.textBox2.TabIndex = 3;
            // 
            // dgv_major
            // 
            this.dgv_major.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_major.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_major.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_major.Location = new System.Drawing.Point(24, 160);
            this.dgv_major.Name = "dgv_major";
            this.dgv_major.RowHeadersWidth = 62;
            this.dgv_major.RowTemplate.Height = 30;
            this.dgv_major.Size = new System.Drawing.Size(868, 379);
            this.dgv_major.TabIndex = 4;
            this.dgv_major.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_major_RowHeaderMouseClick);
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(339, 103);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(90, 35);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(452, 103);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(90, 35);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "删除";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.Location = new System.Drawing.Point(570, 103);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(90, 35);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnadd);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 142);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(694, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "将数据导出为excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMajor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_major);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMajor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "专业信息系统";
            this.Load += new System.EventHandler(this.FrmMajor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_major)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgv_major;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}