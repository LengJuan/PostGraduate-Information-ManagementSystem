using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmMajor : Form
    {
        public FrmMajor()
        {
            InitializeComponent();
        }
        void DataOpen()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }
        void DataClose()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }
        void DataClear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void FrmMajor_Load(object sender, EventArgs e)
        {
            if (ClassShared.userinfo[1] == "学生登录")
            {
                btndelete.Enabled = false;
                btnadd.Enabled = false;
            }
            else if (ClassShared.userinfo[1] == "教师登录")
            {
                btndelete.Enabled = true;
                btnadd.Enabled = true;
            }
            refreshdata();
            DataClose();
        }
        void SetTextHeader()
        {
            dgv_major.Columns[0].HeaderText = "专业";
            dgv_major.Columns[1].HeaderText = "所在院系";
        }
        void refreshdata()
        {
            try
            {
                DataBase DB = new DataBase();
                DataSet myds = new DataSet();
                string mysql = "select * from tbl_major";
                myds = DB.GetDataFromDB(mysql);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    dgv_major.DataSource = myds.Tables[0];
                    SetTextHeader();
                }
                else
                {
                    MessageBox.Show("未能查询到相关信息！");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void dgv_major_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgv_major.CurrentCell.RowIndex;
            textBox1.Text = dgv_major[0, i].Value.ToString();
            textBox2.Text = dgv_major[1, i].Value.ToString();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                DataClear();
                btndelete.Enabled = false;
                btnexit.Enabled = false;
                dgv_major.Enabled = false;
                btnadd.Text = "确定";
                DataOpen();//在点击添加后先让用户输入数据
            }
            else//点击确认后
            {
                if (textBox1.Text != "" && textBox2.Text != "")//确保非空
                {
                    btnadd.Text = "添加";
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    dgv_major.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_major (Subject,Sdept) values ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";
                    bool n = DB.UpDataDB(mysql);
                    if (n)
                    {
                        if (MessageBox.Show("添加成功！要继续添加吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            btnadd.Text = "添加";
                            btnadd.PerformClick();
                            refreshdata();
                        }
                        else
                        {
                            refreshdata();
                            return;
                            //  this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("您输入的信息不正确，请重新输入！", "错误");
                        refreshdata();
                    }
                }
                else
                {
                    MessageBox.Show("您输入的信息不完整，请继续输入！");
                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("未选中！");
                return;
            }
            else
            {
                if (btndelete.Text == "删除")
                {

                    btndelete.Text = "确定";
                    DataBase DB = new DataBase();
                    string mysql = "delete from tbl_major where Subject='" + textBox1.Text + "'";
                    if (MessageBox.Show("真的要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool n = DB.UpDataDB(mysql);
                        if (n)
                        {
                            refreshdata();
                            btndelete.Text = "删除";
                            MessageBox.Show("您已成功删除该条记录");
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            for (int i = 0; i < dgv_major.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgv_major.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgv_major.Rows.Count; r++)//这里表示数据的行标,dgv_major.Rows.Count表示行数
            {
                for (int i = 0; i < dgv_major.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgv_major.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgv_major.Rows[r].Cells[i].Value获取列的r行i值
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


