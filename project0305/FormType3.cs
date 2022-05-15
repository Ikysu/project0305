using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project0305
{
    public partial class FormType3 : Form
    {
        int sid;
        string sfilename;
        string sfin;
        bool srM;
        public FormType3()
        {
            InitializeComponent();
        }

        public void init(int id, string name, string desc, string[] quests, string filename, string fin, bool rM)
        {
            if (rM) textBox1.Enabled = false;
            srM = rM;
            sfin = fin;
            sid = id;
            sfilename = filename;
            this.Text = name;
            this.desc.Text = desc;
            textBox1.Text = quests[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student frm = new student();
            frm.FormClosed += (es, v) => this.Close();
            frm.goQuest(sid + 1, sfilename, sfin+"~"+this.Text + "`" + desc.Text + "`3`" + textBox1.Text, srM);
            this.Hide();
        }
    }
}
