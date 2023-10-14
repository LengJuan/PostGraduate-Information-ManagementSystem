using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmExercitation : Form
    {
        public FrmExercitation()
        {
            InitializeComponent();
        }
        void DataClose()
        {
            txtcity.Enabled = false;
            txtname.Enabled = false;
            txtno.Enabled = false;
            txtpayment.Enabled = false;
            txtposition.Enabled = false;
            dtbirthtime.Enabled = false;
            dtendtime.Enabled = false;
            dtstarttime.Enabled = false;
            txtspan.Enabled = false;
        }
        void DataOpen()
        {
            txtcity.Enabled = true;
            txtname.Enabled = true;
            txtno.Enabled = true;
            txtpayment.Enabled = true;
            txtposition.Enabled = true;
            dtbirthtime.Enabled = true;
            dtendtime.Enabled = true;
            dtstarttime.Enabled = true;
            txtspan.Enabled = true;
        }
        void DataClear()
        {
            txtcity.Text = "";
            txtname.Text = "";
            txtno.Text = "";
            txtpayment.Text = "";
            txtposition.Text = "";
            dtbirthtime.Text = "";
            dtstarttime.Text = "";
            dtendtime.Text = "";
            txtspan.Text = "";
        }
        void refreshdata()
        {
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select * from tbl_exercitation";
            myds = DB.GetDataFromDB(mysql);
            if (myds.Tables[0].Rows.Count != 0)
            {
                dgvexercitation.DataSource = myds.Tables[0];
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("未能查询到相关数据！", "提示");
            }
        }
        void SetHeaderText()
        {
            dgvexercitation.Columns[0].HeaderText = "学号";
            dgvexercitation.Columns[1].HeaderText = "城市";
            dgvexercitation.Columns[2].HeaderText = "岗位";
            dgvexercitation.Columns[3].HeaderText = "薪资";
            dgvexercitation.Columns[4].HeaderText = "姓名";
            dgvexercitation.Columns[5].HeaderText = "实习起始日期";
            dgvexercitation.Columns[6].HeaderText = "实习终止日期";
            dgvexercitation.Columns[7].HeaderText = "出生日期";
            dgvexercitation.Columns[8].HeaderText = "实习时长";
        }
        private void frmexercitation_Load(object sender, EventArgs e)
        {
            refreshdata();
            DataClose();
        }
        private void dgvexercitation_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvexercitation.CurrentCell.RowIndex;
            txtno.Text = dgvexercitation[0, i].Value.ToString();
            txtcity.Text = dgvexercitation[1, i].Value.ToString();
            txtposition.Text = dgvexercitation[2, i].Value.ToString();
            txtpayment.Text = dgvexercitation[3, i].Value.ToString();
            txtname.Text = dgvexercitation[4, i].Value.ToString();
            dtbirthtime.Text = dgvexercitation[5, i].Value.ToString();
            dtstarttime.Text = dgvexercitation[6, i].Value.ToString();
            dtendtime.Text = dgvexercitation[7, i].Value.ToString();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                DataClear();
                btnadd.Text = "确定";
                DataOpen();
                dgvexercitation.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
                btnexit.Enabled = false;
            }
            else
            {
                if (txtcity.Text.Trim() == "" || txtname.Text.Trim() == "" || txtno.Text.Trim() == "" || txtpayment.Text.Trim() == "" || txtposition.Text.Trim() == "" || dtbirthtime.Text.Trim() == "" || dtendtime.Text.Trim() == "" || dtstarttime.Text.Trim() == "" || txtspan.Text.Trim()=="")
                {
                    MessageBox.Show("输入的数据不得为空，请重新添加！");
                }
                else
                {
                    btnadd.Text = "添加";
                    dgvexercitation.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    btnupdate.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_exercitation values('" + txtno.Text.Trim() + "','" + txtcity.Text.Trim() + "','" + txtposition.Text.Trim() + "','" + txtpayment.Text.Trim() + "','" + txtname.Text.Trim() + "','" + dtbirthtime.Value + "','" + dtstarttime.Value + "','" + dtendtime.Value + "','" + txtspan.Text.Trim() + "')";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        if (DialogResult.Yes == MessageBox.Show("添加成功，是否还要继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            DataClear();
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
                        btnadd.Text = "添加";
                        MessageBox.Show("添加错误，请重新添加！", "提示");
                        DataClear();
                    }
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtcity.Text.Trim() == "" || txtname.Text.Trim() == "" || txtno.Text.Trim() == "" || txtpayment.Text.Trim() == "" || txtposition.Text.Trim() == "" || dtbirthtime.Text.Trim() == "" || dtendtime.Text.Trim() == "" || dtstarttime.Text.Trim() == "" || txtspan.Text.Trim()=="")
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
                    string mysql = "delete from tbl_exercitation where sno='" + txtno.Text.Trim() + "'";
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
            if (txtcity.Text.Trim() == "" || txtname.Text.Trim() == "" || txtno.Text.Trim() == "" || txtpayment.Text.Trim() == "" || txtposition.Text.Trim() == "" || dtbirthtime.Text.Trim() == "" || dtstarttime.Text.Trim() == "" || dtendtime.Text.Trim() == "" || txtspan.Text.Trim()=="")
            {
                MessageBox.Show("未选中或输入不完整！");
                return;
            }
            else
            {
                if (btnupdate.Text == "修改")
                {
                    btnupdate.Text = "确定";
                    DataOpen();
                    txtno.Enabled = false;
                    btnadd.Enabled = false;
                    btndelete.Enabled = false;
                    btnexit.Enabled = false;
                    dgvexercitation.Enabled = false;
                }
                else
                {
                    if (txtcity.Text.Trim() == "" || txtname.Text.Trim() == "" || txtno.Text.Trim() == "" || txtpayment.Text.Trim() == "" || txtposition.Text.Trim() == "" || dtbirthtime.Text.Trim() == "" || dtstarttime.Text.Trim() == "" || dtendtime.Text.Trim() == "" || txtspan.Text.Trim()=="")
                    {
                        MessageBox.Show("未选中或输入不完整！请继续输入");
                    }
                    else
                    {
                        btnupdate.Text = "修改";
                        DataClose();
                        btnadd.Enabled = true;
                        btndelete.Enabled = true;
                        btnexit.Enabled = true;
                        dgvexercitation.Enabled = true;
                        DataBase DB = new DataBase();
                        string mysql = "update tbl_exercitation set exercitation_starttime='" + dtstarttime.Value + "',city='" + txtcity.Text.Trim() + "',sname='" + txtname.Text.Trim() + "',payment='" + txtpayment.Text.Trim() + "',position='" + txtposition.Text.Trim() + "', exercitation_endtime='" + dtendtime.Value + "',birthtime='" + dtbirthtime.Value + "',timespan='"+txtspan.Text.Trim()+"' where sno='"+ txtno.Text.Trim() + "'";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            MessageBox.Show("您已修改成功！", "提示");
                            refreshdata();
                            return;
                        }
                    }
                }
            }
        }
        private void txtspan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DateTime dt1 = dtstarttime.Value;
            DateTime dt2 = dtendtime.Value;
            TimeSpan timeSpan = dt2 - dt1;
            txtspan.Text = timeSpan.Days.ToString();
        }
        private void dtstarttime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dtstarttime.Value;
            DateTime dt2 = dtendtime.Value;
            TimeSpan timeSpan = dt2 - dt1;
            txtspan.Text = timeSpan.Days.ToString();
        }
        private void dtendtime_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = dtstarttime.Value;
            DateTime dt2 = dtendtime.Value;
            TimeSpan timeSpan = dt2 - dt1;
            txtspan.Text = timeSpan.Days.ToString();
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
            for (int i = 0; i < dgvexercitation.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvexercitation.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvexercitation.Rows.Count; r++)//这里表示数据的行标,dgvexercitation.Rows.Count表示行数
            {
                for (int i = 0; i < dgvexercitation.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvexercitation.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvexercitation.Rows[r].Cells[i].Value获取列的r行i值
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

