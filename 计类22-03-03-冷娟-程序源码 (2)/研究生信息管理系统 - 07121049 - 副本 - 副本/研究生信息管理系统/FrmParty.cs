using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmParty : Form
    {
        public FrmParty()
        {
            InitializeComponent();
        }
        private void frmparty_Load(object sender, EventArgs e)
        {//起始显示出sql语句确定下的内存中的数据库
            refreshdata();
        }
        void refreshdata()
        {
            try
            {
                DataBase DB = new DataBase();
                DataSet myds = new DataSet();
                string mysql = "select * from tbl_party";
                myds = DB.GetDataFromDB(mysql);
                if (myds.Tables[0].Rows.Count > 0)
                {
                    dgvparty.DataSource = myds.Tables[0];
                    SetHeaderText();
                    DataClose();
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
        void dataclear()
        {
            txtphone.Text = "";
            txtno.Text = "";
            txtname.Text = "";
            txtnation.Text = "";
            cmbsex.Text = "";
            cmbmajor.Text = "";
            cmbdept.Text = "";
            dtbirth.Text = "";
            dtparty.Text = "";
        }
        void DataClose()
        {
            dtparty.Enabled = false;
            txtno.Enabled = false;
            txtname.Enabled = false;
            cmbmajor.Enabled = false;
            cmbdept.Enabled = false;
            txtnation.Enabled = false;
            dtbirth.Enabled = false;
            txtphone.Enabled = false;
            cmbsex.Enabled = false;
        }
        void DataOpen()
        {
            dtparty.Enabled = true;
            txtno.Enabled = true;
            txtname.Enabled = true;
            cmbmajor.Enabled = true;
            cmbdept.Enabled = true;
            txtnation.Enabled = true;
            dtbirth.Enabled = true;
            txtphone.Enabled = true;
            cmbsex.Enabled = true;
        }
        private void dgvparty_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {//起始将数据集中被选中的一行数据投射在文本框中
            int i = dgvparty.CurrentCell.RowIndex;
            dtparty.Text = dgvparty[0, i].Value.ToString();
            txtno.Text = dgvparty[1, i].Value.ToString();
            txtname.Text = dgvparty[2, i].Value.ToString();
            cmbmajor.Text = dgvparty[3, i].Value.ToString();
            cmbdept.Text = dgvparty[4, i].Value.ToString();
            txtnation.Text = dgvparty[5, i].Value.ToString();
            dtbirth.Text = dgvparty[6, i].Value.ToString();
            txtphone.Text = dgvparty[7, i].Value.ToString();
            cmbsex.Text = dgvparty[8, i].Value.ToString();
        }
        void SetHeaderText()
        {
            dgvparty.Columns[0].HeaderText = "入党时间";
            dgvparty.Columns[1].HeaderText = "学号";
            dgvparty.Columns[2].HeaderText = "姓名";
            dgvparty.Columns[3].HeaderText = "专业";
            dgvparty.Columns[4].HeaderText = "所属院系";
            dgvparty.Columns[5].HeaderText = "民族";
            dgvparty.Columns[6].HeaderText = "出生日期";
            dgvparty.Columns[7].HeaderText = "联系方式";
            dgvparty.Columns[8].HeaderText = "性别";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim() == "" || txtnation.Text.Trim() == "" || txtno.Text.Trim() == "" || txtphone.Text.Trim() == "" || cmbdept.Text.Trim() == "" || cmbmajor.Text.Trim() == "" || cmbsex.Text.Trim() == "" || dtbirth.Text.Trim() == "" || dtparty.Text.Trim() == "")
            {
                MessageBox.Show("您输入的信息不完整，请选中或继续输入！");
                return;
            }
            else
            {
                if (btnupdate.Text == "修改")
                {
                    //txtnation.Text = "";
                    btnupdate.Text = "确认";
                    DataOpen();
                    txtno.Enabled = false;
                    btnadd.Enabled = false;
                    btndelete.Enabled = false;
                    btnexit.Enabled = false;
                    dgvparty.Enabled = false;
                }
                else
                {
                    btnupdate.Text = "修改";
                    DataClose();
                    btnadd.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    dgvparty.Enabled = true;
                    DataBase DB = new DataBase();
                    DataSet myds = new DataSet();
                    string mysql = "update tbl_party set sname='" + txtname.Text.Trim() + "',sex='" + cmbsex.Text.Trim() + "',nation='" + txtnation.Text.Trim() + "',subject='" + cmbmajor.Text.Trim() + "',sdept='" + cmbdept.Text.Trim() + "',telephone='" + txtphone.Text.Trim() + "',birthtime='" + dtparty.Value.ToShortDateString().Trim() + "',party_time='" + dtparty.Value.ToShortDateString().Trim() + "' where sno='" + txtno.Text.Trim() + "'";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        MessageBox.Show("修改成功！");
                        refreshdata();
                    }
                    else
                    {
                        MessageBox.Show("输入错误，请重新输入！", "提示");
                        //dataclear();提示用户重新输入
                    }
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnadd_Click(object sender, EventArgs e)
        {//添加
            if (btnadd.Text == "添加")
            {
                dataclear();
                btnadd.Text = "确定";
                dgvparty.Enabled = false;
                DataOpen();
                btndelete.Enabled = false;
                btnexit.Enabled = false;
                btnupdate.Enabled = false;
            }
            else
            {
                if (txtname.Text == "" || txtnation.Text == "" || txtno.Text == "" || txtphone.Text == "" || cmbdept.Text == "" || cmbmajor.Text == "" || cmbsex.Text == "" || dtbirth.Text == "" || dtparty.Text == "")
                {
                    MessageBox.Show("输入的数据不得为空，请继续输入！");
                }
                else
                {
                    btnadd.Text = "添加";
                    dgvparty.Enabled = true;
                    btndelete.Enabled = true;
                    btnexit.Enabled = true;
                    btnupdate.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_party values('" + dtparty.Value + "','" + txtno.Text.Trim() + "','" + txtname.Text.Trim() + "','" + cmbmajor.Text.Trim() + "','" + cmbdept.Text.Trim() + "','" + txtnation.Text.Trim() + "','" + dtbirth.Value + "','" + txtphone.Text.Trim() + "','" + cmbsex.Text.Trim() + "')";
                    bool i = DB.UpDataDB(mysql);
                    if (i)
                    {
                        if (DialogResult.Yes == MessageBox.Show("添加成功，是否还要继续添加？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            dataclear();
                            btnadd.Text = "添加";
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
                        MessageBox.Show("添加错误，请重新添加！", "提示");
                        dataclear();
                    }
                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {//删除
            if (txtname.Text == "" || txtnation.Text == "" || txtno.Text == "" || txtphone.Text == "" || cmbdept.Text == "" || cmbmajor.Text == "" || cmbsex.Text == "" || dtbirth.Text == "" || dtparty.Text == "")
            {
                MessageBox.Show("未选中！");
                return;
            }
            else
            {
                if (btndelete.Text == "删除")
                {
                    btndelete.Text = "确认";
                    if (DialogResult.Yes == MessageBox.Show("确认删除当前记录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        DataBase DB = new DataBase();
                        DataSet myds = new DataSet();
                        string mysql = "delete from tbl_party where sno='" + txtno.Text.Trim() + "'";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            MessageBox.Show("删除成功！");
                            refreshdata();
                            btndelete.Text = "删除";
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
        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbdept.SelectedIndex)
            {
                case 0:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("软件工程");
                    cmbmajor.Items.Add("计算机科学与技术");
                    cmbmajor.Items.Add("大数据");
                    cmbmajor.Items.Add("人工智能");
                    break;
                case 1:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("石油工程");
                    cmbmajor.Items.Add("勘探");
                    cmbmajor.Items.Add("海上石油开采");
                    break;
                case 2:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("地质勘探");
                    cmbmajor.Items.Add("地球化学");
                    cmbmajor.Items.Add("地球信息科学与技术");
                    break;

                case 3:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("党史");
                    cmbmajor.Items.Add("习近平新思想");
                    cmbmajor.Items.Add("毛泽东思想概论");
                    break;
                case 4:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("口腔医学");
                    cmbmajor.Items.Add("临床医学");
                    cmbmajor.Items.Add("康复运动学");
                    break;
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
            for (int i = 0; i < dgvparty.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvparty.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvparty.Rows.Count; r++)//这里表示数据的行标,dgvparty.Rows.Count表示行数
            {
                for (int i = 0; i < dgvparty.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvparty.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvparty.Rows[r].Cells[i].Value获取列的r行i值
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


