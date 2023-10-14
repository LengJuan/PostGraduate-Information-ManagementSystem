using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace 研究生信息管理系统
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == "" || txtuserpassword.Text.Trim() == "")
            {
                MessageBox.Show("用户名或密码不得为空！");

            }
            else
            {
                try
                {
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_login values('" + txtusername.Text.Trim() + "','" + txtuserpassword.Text.Trim() + "','" + cmbpurview.Text.Trim() + "')";
                    if (txtuserpassword.Text.ToString().Trim() == txtpasswordok.Text.ToString().Trim())
                    {
                        if (label2.Text.Trim() != textBox1.Text.Trim())
                        {
                            MessageBox.Show("验证码不正确！请重新输入");
                            label2.Text = CreatRandomCode(4);
                            textBox1.Text = "";
                        }
                        else
                        {
                            bool i = DB.UpDataDB(mysql);
                            if (i)
                            {
                                MessageBox.Show("注册成功！");
                                txtuserpassword.Text = "";
                                txtusername.Text = "";
                                txtpasswordok.Text = "";
                                cmbpurview.Text = "";
                                label2.Text = CreatRandomCode(4);
                                textBox1.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("两次输入密码不一致，请重输！");
                        txtuserpassword.Text = "";
                        txtpasswordok.Text = "";
                    }
                }
                catch (Exception exp)
                {
                    txtuserpassword.Text = "";
                    txtusername.Text = "";
                    txtpasswordok.Text = "";
                    cmbpurview.Text = "";
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            FrmAgreement agreement = new FrmAgreement();
            agreement.Close();
            this.Close();
        }
        public static string CreatRandomCode(int length)
        {
            string list = "abcdefghijklmnopqrstuvwxyz1234567890";
            Random random = new Random();
            string code = "";
            for (int i = 0; i < length; i++)
            {
                code += list[random.Next(0, list.Length - 1)];
            }
            return code;
        }
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            label2.Text = CreatRandomCode(4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
