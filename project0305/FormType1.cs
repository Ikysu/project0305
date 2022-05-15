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
    public partial class FormType1 : Form
    {
        int sid;
        string sfilename;
        string sfin;
        bool srM;
        public FormType1()
        {
            InitializeComponent();
        }

        public void init(int id, string name, string desc, string[] quests, string filename, string fin, bool rM)
        {
            if(rM)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
            }
            srM = rM;
            sfin = fin;
            sid = id;
            sfilename = filename;
            this.Text = name;
            this.desc.Text = desc;
            if (quests.Length > 0)
            {
                radioButton1.Visible = true;
                radioButton1.Text = quests[0];
            }
            if (quests.Length > 1)
            {
                radioButton2.Visible = true;
                radioButton2.Text = quests[1];
            }
            if (quests.Length > 2)
            {
                radioButton3.Visible = true;
                radioButton3.Text = quests[2];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string otv = (radioButton1.Checked)?radioButton1.Text:(radioButton2.Checked)?radioButton2.Text:(radioButton3.Checked)?radioButton3.Text:"{ELSE}";
            student frm = new student();
            frm.FormClosed += (es, v) => this.Close();
            frm.goQuest(sid + 1, sfilename, sfin + "~" + this.Text+"`"+desc.Text+"`1`"+otv, srM);
            this.Hide();
        }
    }
}
