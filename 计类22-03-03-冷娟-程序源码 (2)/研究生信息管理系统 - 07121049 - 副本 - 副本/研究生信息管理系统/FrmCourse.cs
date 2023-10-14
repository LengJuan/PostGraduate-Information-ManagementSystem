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
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmCourse : Form
    {
        public FrmCourse()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DataClose()
        {
            txtcname.Enabled = false;
            txtcno.Enabled = false;
            txtcredit.Enabled = false;
            txtperiod.Enabled = false;
            txtteacher.Enabled = false;
            cmbsemester.Enabled = false;
        }
        void DataOpen()
        {
            txtcname.Enabled = true;
            txtcno.Enabled = true;
            txtcredit.Enabled = true;
            txtperiod.Enabled = true;
            txtteacher.Enabled = true;
            cmbsemester.Enabled = true;
        }
        void DataClear()
        {
            txtteacher.Text = "";
            txtperiod.Text = "";
            txtcredit.Text = "";
            txtcno.Text = "";
            txtcname.Text = "";
            cmbsemester.Text = "";
        }
        void refreshdata()
        {
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select * from tbl_Course";
            myds = DB.GetDataFromDB(mysql);
            if (myds.Tables[0].Rows.Count != 0)
            {
                dgvcourse.DataSource = myds.Tables[0];
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("未能查询到相关数据！", "提示");
            }
        }
        void SetHeaderText()
        {
            dgvcourse.Columns[0].HeaderText = "课程编号";
            dgvcourse.Columns[1].HeaderText = "学分";
            dgvcourse.Columns[2].HeaderText = "授课教师";
            dgvcourse.Columns[3].HeaderText = "课程名称";
            dgvcourse.Columns[4].HeaderText = "开设学期";
            dgvcourse.Columns[5].HeaderText = "学时";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                DataClear();
                btnadd.Text = "确定";
                DataOpen();
                dgvcourse.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
                btnexit.Enabled = false;
            }
            else
            {

                if (txtcname.Text == "" || txtcno.Text == "" || txtcredit.Text == "" || txtperiod.Text == "" || txtteacher.Text == "" || cmbsemester.Text == "")
                {
                    MessageBox.Show("输入的数据不得为空，请重新添加！");
                }
                else
                {
                    btnadd.Text = "添加";
                    dgvcourse.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    btnupdate.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_course values('" + txtcno.Text.Trim() + "','" + txtcredit.Text.Trim() + "','" + txtteacher.Text.Trim() + "','" + txtcname.Text.Trim() + "','" + cmbsemester.Text.Trim() + "','" + txtperiod.Text.Trim() + "')";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        if (DialogResult.Yes == MessageBox.Show("添加成功，是否还要继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            btnadd.PerformClick();
                            refreshdata();
                        }
                        else
                        {
                            refreshdata();
                            return;
                        }
                    }
                    else
                    {
                        refreshdata();
                        MessageBox.Show("添加错误，请重新添加！", "提示");
                        return;
                    }
                }
            }
        }
        private void dgvcourse_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvcourse.CurrentCell.RowIndex;
            txtcno.Text = dgvcourse[0, i].Value.ToString();
            txtcredit.Text = dgvcourse[1, i].Value.ToString();
            txtteacher.Text = dgvcourse[2, i].Value.ToString();
            txtcname.Text = dgvcourse[3, i].Value.ToString();
            cmbsemester.Text = dgvcourse[4, i].Value.ToString();
            txtperiod.Text = dgvcourse[5, i].Value.ToString();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtcno.Text == "" || txtcname.Text == "" || txtcredit.Text == "" || txtperiod.Text == "" || txtteacher.Text == "" || cmbsemester.Text == "")
            {
                MessageBox.Show("未选中！");
                return;
            }
            else
            {
                if (btnupdate.Text == "修改")
                {
                    btnupdate.Text = "确定";
                    DataOpen();
                    txtcno.Enabled = false;
                    btnadd.Enabled = false;
                    btndelete.Enabled = false;
                    btnexit.Enabled = false;
                    dgvcourse.Enabled = false;
                }
                else if (btnupdate.Text == "确定")
                {

                    if (txtcno.Text.Trim() == "" || txtcname.Text == "" || txtcredit.Text.Trim() == "" || txtperiod.Text.Trim() == "" || txtteacher.Text.Trim() == "" || cmbsemester.Text.Trim() == "")
                    {
                        MessageBox.Show("所填数据不完整！请继续添加数据");
                    }
                    else
                    {
                        btnupdate.Text = "修改";
                        DataClose();
                        btnadd.Enabled = true;
                        btndelete.Enabled = true;
                        btnexit.Enabled = true;
                        dgvcourse.Enabled = true;
                        DataBase DB = new DataBase();
                        string mysql = "update tbl_course set Ccredit='" + txtcredit.Text.Trim() + "',Cprofessor='" + txtteacher.Text.Trim() + "',Cname='" + txtcname.Text.Trim() + "',Csemester='" + cmbsemester.Text.Trim() + "',Cperiod='" + txtperiod.Text.Trim() + "'where Cno='" + txtcno.Text.Trim() + "'";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            MessageBox.Show("您已修改成功！", "提示");
                            refreshdata();
                            return;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        private void FrmCourse_Load(object sender, EventArgs e)
        {
            DataClose();
            refreshdata();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtcno.Text.Trim() == "" || txtcname.Text == "" || txtcredit.Text.Trim() == "" || txtperiod.Text.Trim() == "" || txtteacher.Text.Trim() == "" || cmbsemester.Text.Trim() == "") {
                MessageBox.Show("未选中！");
                return;
            }
            else {
                if (btndelete.Text == "删除")
                {
                    btndelete.Text = "确定";
                    DataBase DB = new DataBase();
                    string mysql = "delete from tbl_Course where Cno='" + txtcno.Text.Trim() + "'";
                    if (DialogResult.Yes == MessageBox.Show("您真的要删除当前记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            refreshdata();
                            MessageBox.Show("您已成功删除该条记录！");
                            btndelete.Text = "删除";
                            return;
                        }
                        else
                        {
                            btndelete.Text = "删除";
                            return;
                        }
                    }
                    else
                    {
                        btndelete.Text = "删除";
                        return;
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "IC00";//可以在这里设置默认文件名
            string saveFileName = "";//文件保存名
            SaveFileDialog saveDialog = new SaveFileDialog();//实例化文件对象
            saveDialog.DefaultExt = "xlsx";//文件默认扩展名
            saveDialog.Filter = "Excel文件|*.xlsx";//获取或设置当前文件名筛选器字符串，该字符串决定对话框的“另存为文件类型”或“文件类型”框中出现的选择内容。
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();//打开保存窗口给你选择路径和设置文件名
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;//Workbooks代表一个 Microsoft Excel 工作簿
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);//新建一个工作表。 新工作表将成为活动工作表。
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                                                                  //写入标题             
            for (int i = 0; i < dgvcourse.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvcourse.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvcourse.Rows.Count; r++)//这里表示数据的行标,dgvcourse.Rows.Count表示行数
            {
                for (int i = 0; i < dgvcourse.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvcourse.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvcourse.Rows[r].Cells[i].Value获取列的r行i值
                }
                System.Windows.Forms.Application.DoEvents();//实时更新表格
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);//提示保存成功
            if (saveFileName != "")//saveFileName保存文件名不为空
            {
                try
                {
                    workbook.Saved = true;//获取或设置一个值，该值指示工作簿自上次保存以来是否进行了更改
                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;将工作簿副本保存到文件中，但不修改内存中打开的工作簿                 
                }
                catch (Exception ex)
                {//fileSaved = false;                      
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁           
        }
    }
}
