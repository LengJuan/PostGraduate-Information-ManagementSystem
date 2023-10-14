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
    public partial class FrmGrade : Form
    {
        public FrmGrade()
        {
            InitializeComponent();
        }
        string selectcondition;
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SetHeaderText()
        {
            dgvgrade.Columns[0].HeaderText = "学号";
            dgvgrade.Columns[1].HeaderText = "姓名";
            dgvgrade.Columns[2].HeaderText = "课程编号";
            dgvgrade.Columns[3].HeaderText = "课程名称";
            dgvgrade.Columns[4].HeaderText = "成绩";
        }
        private void FrmGrade_Load(object sender, EventArgs e)
        {//selectindex=-1表示什么也没选中
            if (ClassShared.userinfo[1] == "学生登录")
            {
                btninsert.Enabled = false;
            }
            else if (ClassShared.userinfo[1] == "教师登录")
            {
                btninsert.Enabled = true;
            }
            DataBase DBStudent = new DataBase();
            DataSet student = new DataSet();
            string mysql = "select Sno,Sname from tbl_student";
            student = DBStudent.GetDataFromDB(mysql);
            if (student.Tables[0].Rows.Count > 0)
            {
                //cmbstudent.Items.Clear();//可以换一种方法
                for (int i = 0; i < student.Tables[0].Rows.Count; i++)
                {
                    cmbstudent.Items.Add(student.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "--" + student.Tables[0].Rows[i].ItemArray[1].ToString().Trim());
                }
            }
            else
            {
                MessageBox.Show("错误！未查询到任何信息");
            }
            DataBase DBCourse = new DataBase();
            DataSet course = new DataSet();
            string MySql = "select Cno,Cname from tbl_Course";
            course = DBStudent.GetDataFromDB(MySql);
            if (course.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < course.Tables[0].Rows.Count; i++)
                {
                    cmbcourse.Items.Add(course.Tables[0].Rows[i].ItemArray[0].ToString().Trim() + "--" + course.Tables[0].Rows[i].ItemArray[1].ToString().Trim());
                }
            }
            else
            {
                MessageBox.Show("错误！未查询到任何信息");
            }
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            if (cmbstudent.Text == "" || cmbcourse.Text == "" || txtgrade.Text == "")
            {
                MessageBox.Show("输入的信息不完整，请继续输入！");

            }
            else
            {
                string mysql = "insert into tbl_grade values('" + cmbstudent.Text.ToString().Substring(0, 4) + "','" + cmbcourse.Text.ToString().Substring(0, 4) + "','" + txtgrade.Text + "')";
                bool i = DB.UpDataDB(mysql);
                if (i)
                {
                    MessageBox.Show("该条成绩录入成功！！");
                }
                else
                {
                    MessageBox.Show("成绩不合理或该条记录已经存在！", "提示");
                }
                cmbstudent.Text = "";
                cmbcourse.Text = "";
                txtgrade.Text = "";
            }
        }
        private void btnselect_Click(object sender, EventArgs e)
        {//最重要的是sql语句是啥样的
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
                    string mysql = "select tbl_grade.Sno,tbl_student.Sname,tbl_grade.Cno,tbl_Course.Cname,tbl_grade.grade from tbl_student,tbl_Course,tbl_grade where tbl_Course.Cno=tbl_grade.Cno and tbl_student.Sno=tbl_grade.Sno and " + selectcondition + "='" + cmbcontent.Text.Trim() + "'";
                    //临时数据集
                    myds = DB.GetDataFromDB(mysql);
                    if (myds.Tables[0].Rows.Count > 0)
                    {
                        dgvgrade.DataSource = myds.Tables[0];
                        SetHeaderText();
                    }
                    else
                    {
                        MessageBox.Show("没有符合条件的记录！");
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
                string mysql = "select tbl_grade.Sno,tbl_student.Sname,tbl_grade.Cno,tbl_Course.Cname,tbl_grade.grade from tbl_student,tbl_Course,tbl_grade where tbl_Course.Cno=tbl_grade.Cno and tbl_student.Sno=tbl_grade.Sno";
                //临时数据集
                myds = DB.GetDataFromDB(mysql);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    dgvgrade.DataSource = myds.Tables[0];
                    SetHeaderText();
                }
                else
                {
                    MessageBox.Show("没有符合条件的记录！");
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
            string mysql = "select Sno,Cno from tbl_grade";
            myds = DB.GetDataFromDB(mysql);
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
                            flag = false;//一旦相等，马上给flag赋值为false，终止循环
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
                flag = true;
                cmbcontent.Items.Clear();
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
            switch (cmbkind.SelectedIndex)
            {

                case 0:
                    selectcondition = "tbl_grade.Sno";
                    break;
                case 1:
                    selectcondition = "tbl_grade.Cno";
                    break;
            }
        }
    }
}

