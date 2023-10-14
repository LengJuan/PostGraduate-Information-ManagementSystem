using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        void DataClose()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }
        void DataOpen()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
        }
        void DataClear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        void refreshdate()
        {
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select * from tbl_user";
            myds = DB.GetDataFromDB(mysql);
            if (myds.Tables[0].Rows.Count != 0)
            {
                dgvuser.DataSource = myds.Tables[0];
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("未能查询到记录！");
            }
        }
        void SetHeaderText()
        { //想明白是谁给谁赋值
            dgvuser.Columns[0].HeaderText = "姓名";
            dgvuser.Columns[1].HeaderText = "性别";
            dgvuser.Columns[2].HeaderText = "所在学院";
            dgvuser.Columns[3].HeaderText = "年龄";
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            refreshdate();
            DataClose();
        }
        private void dgvuser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvuser.CurrentCell.RowIndex;
            textBox1.Text = dgvuser[0, i].Value.ToString();
            textBox2.Text = dgvuser[3, i].Value.ToString();
            comboBox1.Text = dgvuser[1, i].Value.ToString();
            comboBox2.Text = dgvuser[2, i].Value.ToString();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                btnadd.Text = "确定";
                DataClear();
                DataOpen();
                dgvuser.Enabled = false;
                btndelete.Enabled = false;
                btnexit.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
                {
                    MessageBox.Show("输入的信息不完整，请继续输入！");
                }
                else
                {
                    btnadd.Text = "添加";
                    DataClose();
                    dgvuser.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    btnupdate.Enabled = true;
                    try
                    {
                        DataBase DB = new DataBase();
                        string mysql = "insert into tbl_user values('" + textBox1.Text.ToString().Trim() + "','" + comboBox1.Text.ToString().Trim() + "','" + comboBox2.Text.ToString().Trim() + "','" + textBox2.Text.ToString().Trim() + "')";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            if (DialogResult.Yes == MessageBox.Show("您是否还要继续添加记录？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                DataClear();
                                refreshdate();
                                btnadd.Text = "添加";
                                btnadd.PerformClick();
                            }
                            else
                            {
                                DataClear();
                                refreshdate();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("程序出错了~");
                            DataClear();
                            return;
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }

                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
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
                    string mysql = "delete from tbl_user where Sname='" + textBox1.Text.ToString().Trim() + "'";
                    if (DialogResult.Yes == MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        bool i = DB.UpDataDB(mysql); ;
                        if (i)
                        {
                            refreshdate();
                            MessageBox.Show("该条记录已成功删除！");
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
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("数据不得为空，请选中或继续输入！");
                return;
            }
            else
            {
                if (btnupdate.Text == "修改")
                {
                    btnupdate.Text = "确定";
                    DataOpen();
                    textBox1.Enabled = false;
                    dgvuser.Enabled = false;
                    btnadd.Enabled = false;
                    btndelete.Enabled = false;
                    btnexit.Enabled = false;
                }
                else if (btnupdate.Text == "确定")
                {
                    btnupdate.Text = "修改";
                    DataClose();
                    dgvuser.Enabled = true;
                    btnadd.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    DataBase DB = new DataBase();
                    string mysql = "update tbl_user set Sage='" + textBox2.Text.ToString().Trim() + "',Sdept='" + comboBox2.Text.ToString().Trim() + "',Ssex='" + comboBox1.Text.ToString().Trim() + "' where Sname='" + textBox1.Text.ToString().Trim() + "'";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        MessageBox.Show("恭喜！修改成功！");
                        refreshdate();
                    }
                    else
                    {
                        DataClear();
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
            for (int i = 0; i < dgvuser.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvuser.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvuser.Rows.Count; r++)//这里表示数据的行标,dgvuser.Rows.Count表示行数
            {
                for (int i = 0; i < dgvuser.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvuser.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvuser.Rows[r].Cells[i].Value获取列的r行i值
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
