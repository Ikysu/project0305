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
    public partial class FormType2 : Form
    {
        int sid;
        string sfilename;
        string sfin;
        bool srM;
        public FormType2()
        {
            InitializeComponent();
        }

        public void init(int id, string name, string desc, string[] quests, string filename, string fin, bool rM)
        {
            if (rM)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            srM = rM;
            sfin = fin;
            sid = id;
            sfilename = filename;
            this.Text = name;
            this.desc.Text = desc;
            if (quests.Length > 0)
            {
                checkBox1.Visible = true;
                checkBox1.Text = quests[0];
            }
            if (quests.Length > 1)
            {
                checkBox2.Visible = true;
                checkBox2.Text = quests[1];
            }
            if (quests.Length > 2)
            {
                checkBox3.Visible = true;
                checkBox3.Text = quests[2];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string otv = this.Text + "`" + desc.Text + "`2`";
            if (checkBox1.Checked) otv += checkBox1.Text + ((checkBox2.Checked || checkBox3.Checked) ? "$" : "");
            if (checkBox2.Checked) otv += checkBox2.Text + ((checkBox3.Checked) ? "$" : "");
            if (checkBox3.Checked) otv += checkBox3.Text;

            student frm = new student();
            frm.FormClosed += (es, v) => this.Close();
            frm.goQuest(sid + 1, sfilename, sfin + "~" + otv, srM);
            this.Hide();
        }
    }
}
