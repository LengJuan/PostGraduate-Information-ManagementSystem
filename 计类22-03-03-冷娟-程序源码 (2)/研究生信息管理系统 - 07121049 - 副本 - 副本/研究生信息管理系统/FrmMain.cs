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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMajor major = new FrmMajor();
            major.Show();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = ClassShared.userinfo[0] + "--" + ClassShared.userinfo[1];
        }
        private void btncourse_Click(object sender, EventArgs e)
        {
            FrmCourse course = new FrmCourse();
            course.Show();
        }
        private void btngrade_Click(object sender, EventArgs e)
        {
            FrmGrade grade = new FrmGrade();
            grade.Show();
        }
        private void btnprofessor_Click(object sender, EventArgs e)
        {
            FrmProfessor professor = new FrmProfessor();
            professor.Show();
        }
        private void btnpaper_Click(object sender, EventArgs e)
        {
            FrmPaper paper = new FrmPaper();
            paper.Show();
        }
        private void btnexercitation_Click(object sender, EventArgs e)
        {
            FrmExercitation exercitation = new FrmExercitation();
            exercitation.Show();
        }
        private void btnparty_Click(object sender, EventArgs e)
        {
            FrmParty party = new FrmParty();
            party.Show();
        }
        private void btnstudent_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();
            student.Show();
        }
        private void btnuser_Click(object sender, EventArgs e)
        {
            FrmUser user = new FrmUser();
            user.Show();
        }
    }
}
