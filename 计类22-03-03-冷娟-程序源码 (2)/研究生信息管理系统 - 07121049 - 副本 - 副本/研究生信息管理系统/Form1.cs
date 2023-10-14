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
namespace 研究生信息管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "Skins\\DiamondBlue.ssk";
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
        }
        private void 主题一ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile ="Skins\\SportsBlue.ssk";
        }
        private void 登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoad load = new FrmLoad();
            load.Show();
        }
        private void 注册ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgreement agreement = new FrmAgreement();
            agreement.Show();
        }
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdate update = new FrmUpdate();
            update.Show();
        }
        private void 主题二ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile =  "Skins\\SteelBlue.ssk";
        }
        private void 主题三ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.skinEngine1.SkinFile =  "Skins\\DiamondBlue.ssk";
        }
    }
}


