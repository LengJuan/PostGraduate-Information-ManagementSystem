using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace 研究生信息管理系统
{
    public partial class FrmPaper : Form
    {
        public FrmPaper()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SetHeaderText()
        {
            dgvpaper.Columns[0].HeaderText = "指导教师";
            dgvpaper.Columns[1].HeaderText = "发表时间";
            dgvpaper.Columns[2].HeaderText = "学号";
            dgvpaper.Columns[3].HeaderText = "姓名";
            dgvpaper.Columns[4].HeaderText = "论文题目";
        }
        void DataClear()
        {
            txttitle.Text = "";
            txtno.Text = "";
            txtname.Text = "";
            txtinstructor.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase DB = new DataBase();
                if (txtname.Text == "" || txtinstructor.Text == "" || txtno.Text == "" || txttitle.Text == "" || dtpublish.Text == "")
                {
                    MessageBox.Show("输入的数据不得为空，请重新添加！");
                    return;
                }
                else
                {
                    string mysql = "insert into tbl_paper values('" + txtinstructor.Text.Trim() + "','" + dtpublish.Value + "','" + txtno.Text.Trim() + "','" + txtname.Text.Trim() + "','" + txttitle.Text.Trim() + "')";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        MessageBox.Show("同学，你的论文发表情况已成功导入！！");
                    }
                    else
                    {
                        DataClear();
                        return;
                    }
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show(exp.Message);
            }
        }
        private void btnselect_Click(object sender, EventArgs e)
        {//此表无需主键
            if (cmbcontent.SelectedIndex == -1 || cmbkind.SelectedIndex == -1)
            {
                MessageBox.Show("选择不能为空！");
            }
            else
            {
                try
                {
                    DataBase DB = new DataBase();
                    DataSet myds = new DataSet();
                    string mysql = "select instructor ,paper_time,sno,sname,title from tbl_paper where instructor='" + cmbcontent.Text.Trim() + "' or sname='" + cmbcontent.Text.Trim() + "'";
                    myds = DB.GetDataFromDB(mysql);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        dgvpaper.DataSource = myds.Tables[0];
                        SetHeaderText();
                    }
                    else
                    {
                        MessageBox.Show("很抱歉没能查询到你所需的信息！");
                        return;
                    }
                }
                catch (Exception exp)
                {

                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void btnselectall_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase DB = new DataBase();
                DataSet myds = new DataSet();
                string mysql = "select instructor ,paper_time,sno,sname,title from tbl_paper ";
                myds = DB.GetDataFromDB(mysql);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    dgvpaper.DataSource = myds.Tables[0];
                    SetHeaderText();
                }
                else
                {
                    MessageBox.Show("很抱歉没能查询到你所需的信息！");
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void cmbkind_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool flag = false;
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select sname,instructor from tbl_paper";
            try
            {
                myds = DB.GetDataFromDB(mysql);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    if (cmbkind.SelectedIndex == 0)
                    {
                        cmbcontent.Items.Clear();
                        cmbcontent.Items.Add(myds.Tables[0].Rows[0].ItemArray[0]);//
                        for (int i = 0; i < myds.Tables[0].Rows.Count; i++)
                        {
                            for (int n = 0; n < i; n++)
                            {
                                if (myds.Tables[0].Rows[i].ItemArray[0].ToString().Trim() != myds.Tables[0].Rows[n].ItemArray[0].ToString().Trim())
                                {
                                    flag = true;
                                    //cmbcontent.Items.Remove(myds.Tables[0].Rows[i].ItemArray[0]);
                                }
                                else
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag == true)
                            {
                                cmbcontent.Items.Add(myds.Tables[0].Rows[i].ItemArray[0]);
                            }
                        }
                    }
                    else if (cmbkind.SelectedIndex == 1)
                    {
                        cmbcontent.Items.Clear();
                        cmbcontent.Items.Add(myds.Tables[0].Rows[0].ItemArray[1]);//
                        for (int i = 0; i < myds.Tables[0].Rows.Count; i++)
                        {
                            for (int n = 0; n < i; n++)
                            {
                                if (myds.Tables[0].Rows[i].ItemArray[1].ToString().Trim() != myds.Tables[0].Rows[n].ItemArray[1].ToString().Trim())
                                {
                                    flag = true;
                                }
                                else
                                {
                                    flag = false;
                                    break;
                                }
                            }
                            if (flag == true)
                            {
                                cmbcontent.Items.Add(myds.Tables[0].Rows[i].ItemArray[1]);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("程序出错了！");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
