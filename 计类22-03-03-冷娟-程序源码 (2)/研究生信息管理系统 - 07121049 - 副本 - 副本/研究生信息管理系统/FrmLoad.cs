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
    public partial class FrmLoad : Form
    {
        public FrmLoad()
        {
            InitializeComponent();
        }
        private void FrmLoad_Load(object sender, EventArgs e)
        {
            textBox1.Focus();//页面载入时光标停在textbox1，等待用户输入
        }
        private void btnload_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }
            else
            {
                try
                {
                    DataSet myds = new DataSet();
                    DataBase DB = new DataBase();
                    string mysql = "select Userpassword,Userpurview from tbl_login where Username ='" + textBox1.Text.Trim() + "' ";
                    myds = DB.GetDataFromDB(mysql);
                    if (myds.Tables[0].Rows[0].ItemArray[0].ToString().Trim() == textBox2.Text.Trim())
                    {
                        FrmMain main = new FrmMain();
                        ClassShared.userinfo[0] = textBox1.Text.Trim();
                        ClassShared.userinfo[1] = myds.Tables[0].Rows[0].ItemArray[1].ToString();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("用户名或者密码错误，请重新输入！", "提示");
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
           this.Close();//应用程序退出
        }
        private void btncancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnload.PerformClick();
        }
    }
}
