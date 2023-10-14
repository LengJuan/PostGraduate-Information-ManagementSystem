using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;
namespace 研究生信息管理系统
{
    public class DataBase//公共类
    {
        string strconn = "data source =(local);uid=sa;pwd=1;database=Postgraduate";
        SqlConnection myconn;
        SqlCommand mycmd;
        SqlDataAdapter mydtadp;
        DataSet ds;
        public DataSet GetDataFromDB(string mysql)
        {
            try
            {
                myconn = new SqlConnection(strconn);
                myconn.Open();
                mydtadp = new SqlDataAdapter(mysql, strconn);
                ds = new DataSet();
                mydtadp.Fill(ds);//如果没特殊说明，默认存到第0张表内
                myconn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                myconn.Close();//别忘了关闭数据库
            }
            if (ds.Tables[0].Rows.Count != 0)
            {
                return ds;
            }
            else
            {
                return null;
            }
        }
        public bool UpDataDB(string mysql)
        {
            try
            {
                myconn = new SqlConnection(strconn);
                myconn.Open();
                mycmd = new SqlCommand(mysql, myconn);
                mycmd.ExecuteNonQuery();
                myconn.Close();
                return true;//只要是方法，都要求有返回值
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                myconn.Close();
                return false;//不再执行跳转语句return之后的语句
            }
        }
    }
}