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
    public partial class FrmUpdate : Form
    {
        public FrmUpdate()
        {
            InitializeComponent();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "" && txtpwd.Text != "" && txtnewpwd.Text != "" && txtnewpwdok.Text != "")
            {
                try
                {
                    DataBase DB = new DataBase();
                    DataSet myds = new DataSet();
                    string mysql = "select Username,Userpassword from tbl_login where Username='" + txtuser.Text.Trim() + "' and Userpassword='" + txtpwd.Text.Trim() + "'";
                    myds = DB.GetDataFromDB(mysql);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        if (txtnewpwd.Text.Trim() == txtnewpwdok.Text.Trim())
                        {
                            if (txtnewpwd.Text.Trim() != txtpwd.Text.Trim())
                            {
                                if (DialogResult.Yes == MessageBox.Show("您真的确认要修改吗！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                                {
                                    DataBase db = new DataBase();
                                    string updatesql = "update tbl_login set Userpassword ='" + txtnewpwdok.Text.Trim() + "' where Username='" + txtuser.Text.Trim() + "'";
                                    bool i = db.UpDataDB(updatesql);
                                    if (i)
                                    {
                                        MessageBox.Show("修改成功！");
                                        txtnewpwd.Text = "";
                                        txtnewpwdok.Text = "";
                                        txtuser.Text = "";
                                        txtpwd.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("程序哪里出错了~");
                                    }
                                }
                                else
                                {
                                    txtnewpwd.Text = "";
                                    txtnewpwdok.Text = "";
                                    txtuser.Text = "";
                                    txtpwd.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("新密码不能和旧密码一致！", "提示");
                            }
                        }
                        else
                        {
                            MessageBox.Show("两次输入密码不一致！请重输");
                            txtnewpwd.Text = "";
                            txtnewpwdok.Text = "";
                        }
                    }
                    else if (myds.Tables[0].Rows.Count <= 0)
                    {
                        MessageBox.Show("用户名不存在或输入错误！");
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
            {
                MessageBox.Show("请填入全部信息！");
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
