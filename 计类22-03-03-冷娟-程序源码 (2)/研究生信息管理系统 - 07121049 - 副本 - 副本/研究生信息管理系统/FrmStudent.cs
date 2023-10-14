using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace 研究生信息管理系统
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DataClose()
        {
            txtname.Enabled = false;
            txtage.Enabled = false;
            txtno.Enabled = false;
            cmbdept.Enabled = false;
            cmbmajor.Enabled = false;
            cmbsex.Enabled = false;
        }
        void DataOpen()
        {
            txtname.Enabled = true;
            txtage.Enabled = true;
            txtno.Enabled = true;
            cmbdept.Enabled = true;
            cmbmajor.Enabled = true;
            cmbsex.Enabled = true;
        }
        void DataClear()
        {
            txtname.Text = "";
            txtage.Text = "";
            txtno.Text = "";
            cmbdept.Text = "";
            cmbmajor.Text = "";
            cmbsex.Text = "";
        }
        void refreshdata()
        {
            DataBase DB = new DataBase();
            DataSet myds = new DataSet();
            string mysql = "select * from tbl_student";
            myds = DB.GetDataFromDB(mysql);
            if (myds.Tables[0].Rows.Count != 0)
            {
                dgvstudent.DataSource = myds.Tables[0];
                SetHeaderText();
            }
            else
            {
                MessageBox.Show("未能查询到相关数据！", "提示");
            }
        }
        void SetHeaderText()
        {
            dgvstudent.Columns[0].HeaderText = "学号";
            dgvstudent.Columns[1].HeaderText = "姓名";
            dgvstudent.Columns[2].HeaderText = "学院";
            dgvstudent.Columns[3].HeaderText = "性别";
            dgvstudent.Columns[4].HeaderText = "年龄";
            dgvstudent.Columns[5].HeaderText = "专业";
        }
        private void dgvstudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = dgvstudent.CurrentCell.RowIndex;
            txtno.Text = dgvstudent[0, i].Value.ToString();
            txtname.Text = dgvstudent[1, i].Value.ToString();
            cmbdept.Text = dgvstudent[2, i].Value.ToString();
            cmbsex.Text = dgvstudent[3, i].Value.ToString();
            txtage.Text = dgvstudent[4, i].Value.ToString();
            cmbmajor.Text = dgvstudent[5, i].Value.ToString();
        }
        private void frmstudent_Load(object sender, EventArgs e)
        {
            refreshdata();
            DataClose();
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || txtage.Text == "" || cmbdept.Text == "" || cmbmajor.Text == "" || cmbsex.Text == "")
            {
                MessageBox.Show("您输入的信息不完整，请选中或继续输入！");
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
                    dgvstudent.Enabled = false;
                }
                else
                {
                    btnupdate.Text = "修改";
                    txtno.Enabled = true;
                    DataClose();
                    btnadd.Enabled = true;
                    btndelete.Enabled = true;
                    dgvstudent.Enabled = true;
                    btnexit.Enabled = true;
                    DataBase DB = new DataBase();
                    DataSet myds = new DataSet();
                    string mysql = "update tbl_student set Sname='" + txtname.Text.Trim() + "',Sdepartment='" + cmbdept.Text.Trim() + "',Ssex='" + cmbsex.Text.Trim() + "',Sage='" + txtage.Text.Trim() + "',Smajor='" + cmbmajor.Text.Trim() + "'where Sno='" + txtno.Text.Trim() + "'";
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
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (btndelete.Text == "删除")
            {
                if (txtno.Text == "" || txtname.Text == "" || txtage.Text == "" || cmbdept.Text == "" || cmbmajor.Text == "" || cmbsex.Text == "")
                {
                    MessageBox.Show("未选中！");
                }
                else
                {
                    btndelete.Text = "确定";
                    if (DialogResult.Yes == MessageBox.Show("您真的确定要删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    {
                        DataBase DB = new DataBase();
                        string mysql = "delete from tbl_student where Sno='" + txtno.Text.Trim() + "'";
                        bool i = DB.UpDataDB(mysql);
                        if (i)
                        {
                            btndelete.Text = "删除";
                            MessageBox.Show("您已成功删除该条记录！");
                            refreshdata();
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
                        refreshdata();
                        return;
                    }
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (btnadd.Text == "添加")
            {
                DataClear();
                btnadd.Text = "确定";
                DataOpen();
                dgvstudent.Enabled = false;
                btndelete.Enabled = false;
                btnupdate.Enabled = false;
                btnexit.Enabled = false;
            }
            else
            {
                if (txtname.Text == "" || txtage.Text == "" || txtno.Text == "" || cmbdept.Text == "" || cmbmajor.Text == "" || cmbsex.Text == "")
                {
                    MessageBox.Show("输入的数据不得为空，请继续添加！");
                    return;
                }
                else
                {
                    btnadd.Text = "添加";
                    dgvstudent.Enabled = true;
                    btndelete.Enabled = true;
                    btnupdate.Enabled = true;
                    btnexit.Enabled = true;
                    DataClose();
                    DataBase DB = new DataBase();
                    string mysql = "insert into tbl_student values('" + txtno.Text.Trim() + "','" + txtname.Text.Trim() + "','" + cmbdept.Text.Trim() + "','" + cmbsex.Text.Trim() + "','" + txtage.Text.Trim() + "','" + cmbmajor.Text.Trim() + "')";
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
                            refreshdata();
                            return;
                        }
                    }
                    else
                    {
                        DataClear();
                        MessageBox.Show("添加错误，请重新添加！", "提示");
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
                    cmbmajor.Items.Add("大数据");
                    cmbmajor.Items.Add("云计算");
                    cmbmajor.Items.Add("计算机科学与技术");
                    break;
                case 1:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("口腔医学");
                    cmbmajor.Items.Add("临床医学");
                    cmbmajor.Items.Add("康复运动学");
                    break;
                case 2:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("党史");
                    cmbmajor.Items.Add("习近平新思想");
                    cmbmajor.Items.Add("毛泽东思想概论");
                    break;
                case 3:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("石油工程");
                    cmbmajor.Items.Add("海上石油开采");
                    cmbmajor.Items.Add("石油勘测");
                    break;
                case 4:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("地质化学");
                    cmbmajor.Items.Add("地球信息科学与技术");
                    cmbmajor.Items.Add("地质勘测");
                    break;
                case 5:
                    cmbmajor.Items.Clear();
                    cmbmajor.Items.Add("商务英语");
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
            for (int i = 0; i < dgvstudent.ColumnCount; i++)//遍历循环获取DataGridView标题
            { worksheet.Cells[1, i + 1] = dgvstudent.Columns[i].HeaderText; }// worksheet.Cells[1, i + 1]表示工作簿第一行第i+1列，Columns[i].HeaderText表示第i列的表头
            //写入数值
            for (int r = 0; r < dgvstudent.Rows.Count; r++)//这里表示数据的行标,dgvstudent.Rows.Count表示行数
            {
                for (int i = 0; i < dgvstudent.ColumnCount; i++)//遍历r行的列数
                {
                    worksheet.Cells[r + 2, i + 1] = dgvstudent.Rows[r].Cells[i].Value;//Cells[r + 2, i + 1]表示工作簿从第二行开始第一行保存为表头了，dgvstudent.Rows[r].Cells[i].Value获取列的r行i值
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

