using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmProfessor : Form
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }
        void DataClose()
        {
            txtname.Enabled = false;
            txtphone.Enabled = false;
            txtmajor.Enabled = false;
            txttitle.Enabled = false;
            cmbsex.Enabled = false;
            dtbirthtime.Enabled = false;
        }
        void DataOpen()
        {
            txtname.Enabled = true;
            txtphone.Enabled = true;
            txtmajor.Enabled = true;
            txttitle.Enabled = true;
            cmbsex.Enabled = true;
            dtbirthtime.Enabled = true;
        }
        void DataClear()
        {
            txtname.Text = "";
            txtphone.Text = "";
            txtmajor.Text = "";
            txttitle.Text = "";
            dtbirthtime.Text = "";
            cmbsex.Text = "";
        }
        void refreshdata()
        {
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select * from tbl_professor";
            myds = DB.GetDataFromDB(mysql);
            if (myds.Tables[0].Rows.Count != 0)
            {
                dgvprofessor.DataSource = myds.Tables[0];
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("未能查询到相关数据！", "提示");
            }
        }
        void SetHeaderText()
        {
            dgvprofessor.Columns[0].HeaderText = "联系方式";
            dgvprofessor.Columns[1].HeaderText = "姓名";
            dgvprofessor.Columns[2].HeaderText = "职称";
            dgvprofessor.Columns[3].HeaderText = "性别";
            dgvprofessor.Columns[4].HeaderText = "研究方向";
            dgvprofessor.Columns[5].HeaderText = "出生日期";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                DataClear();
                btnadd.Text = "确定";
                DataOpen();
                dgvprofessor.Enabled = false;
                btndelete.Enabled = false;
                btnexit.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                if (txtname.Text == "" || txtmajor.Text == "" || txtphone.Text == "" || txttitle.Text == "" || cmbsex.Text == "" || dtbirthtime.Text == "")
                {
                    MessageBox.Show("输入的数据不得为空，请继续输入！");
                }
                else
                {
                    btnadd.Text = "添加";
                    dgvprofessor.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    btnupdate.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    try
                    {
                        string mysql = "insert into tbl_professor values('" + txtphone.Text.Trim() + "','" + txtname.Text.Trim() + "','" + txttitle.Text.Trim() + "','" + cmbsex.Text.Trim() + "','" + txtmajor.Text.Trim() + "','" + dtbirthtime.Value + "')";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            if (DialogResult.Yes == MessageBox.Show("添加成功，是否还要继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                btnadd.Text = "添加";
                                btnadd.PerformClick();
                                refreshdata();
                            }
                            else
                            {
                                btnadd.Text = "添加";
                                refreshdata();
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("添加错误，请重新添加！", "提示");
                            DataClear();
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }
        }
        private void frmprofessor_Load(object sender, EventArgs e)
        {
            if (ClassShared.userinfo[1] == "学生登录")
            {
                btnadd.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                btnadd.Enabled = true;
                btndelete.Enabled = true;
                btnupdate.Enabled = true;
            }
            refreshdata();
            DataClose();
            DataClear();
            dgvprofessor.Enabled = true;
        }
        private void dgvprofessor_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvprofessor.CurrentCell.RowIndex;
            txtphone.Text = dgvprofessor[0, i].Value.ToString();
            txtname.Text = dgvprofessor[1, i].Value.ToString();
            txttitle.Text = dgvprofessor[2, i].Value.ToString();
            cmbsex.Text = dgvprofessor[3, i].Value.ToString();
            txtmajor.Text = dgvprofessor[4, i].Value.ToString();
            dtbirthtime.Text = dgvprofessor[5, i].Value.ToString();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtmajor.Text == "" || txtname.Text == "" || txtphone.Text == "" || txttitle.Text == "" || cmbsex.Text == "" || dtbirthtime.Text == "")
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
                    string mysql = "delete from tbl_professor where T_name='" + txtname.Text.Trim() + "'";
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
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtmajor.Text == "" || txtname.Text == "" || txtphone.Text == "" || txttitle.Text == "" || cmbsex.Text == "" || dtbirthtime.Text == "")
            {
                MessageBox.Show("未选中或填入数据不完整！");
                return;
            }
            else
            {
                if (btnupdate.Text == "修改")
                {
                    btnupdate.Text = "确定";
                    DataOpen();
                    txtname.Enabled = false;
                    txtname.Enabled = false;
                    btnadd.Enabled = false;
                    btndelete.Enabled = false;
                    btnexit.Enabled = false;
                    dgvprofessor.Enabled = false;
                }
                else
                {
                    if (txtmajor.Text == "" || txtname.Text == "" || txtphone.Text == "" || txttitle.Text == "" || cmbsex.Text == "" || dtbirthtime.Text == "")
                    {
                        MessageBox.Show("未选中或填入数据不完整！");
                    }
                    else
                    {
                        btnupdate.Text = "修改";
                        DataClose();
                        btnadd.Enabled = true;
                        btndelete.Enabled = true;
                        btnexit.Enabled = true;
                        dgvprofessor.Enabled = true;
                        DataBase DB = new DataBase();
                        DataSet myds = new DataSet();
                        string mysql = "update tbl_professor set T_telephone='" + txtphone.Text.Trim() + "',T_birthtime='" + dtbirthtime.Value + "',T_title='" + txttitle.Text.Trim() + "',T_sex='" + cmbsex.Text.Trim() + "',T_major='" + txtmajor.Text.Trim() + "'where T_name='" + txtname.Text.Trim() + "'";
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
            for (int i = 0; i < dgvprofessor.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvprofessor.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvprofessor.Rows.Count; r++)//这里表示数据的行标,dgvprofessor.Rows.Count表示行数
            {
                for (int i = 0; i < dgvprofessor.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvprofessor.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvprofessor.Rows[r].Cells[i].Value获取列的r行i值
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
