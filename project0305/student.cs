using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project0305
{
    public partial class student : Form
    {
        Regex testerName = new Regex("[а-яА-Я ]");
        Regex testerGroup = new Regex("[0-9а-яА-Я-]");
        string filename;
        bool rM = false;

        public student()
        {
            InitializeComponent();
        }

        public void init(string fn, bool readerMode)
        {
            filename = fn;
            if (readerMode)
            {
                rM=true;
                var st = File.ReadAllText(fn);
                string[] rr = st.Split('~');
                login.Text=rr[1];
                passwd.Text=rr[2];
                login.Enabled = false;
                passwd.Enabled = false;
                authBtn.Enabled = true;
                authBtn.Text = "Проверить";
            }
        } 

        private void authBtn_Click(object sender, EventArgs e)
        {
            if(testerName.IsMatch(login.Text) && testerGroup.IsMatch(passwd.Text))
            {
                goQuest(0, filename, "~"+login.Text+"~"+passwd.Text, rM);
            }
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !testerName.IsMatch("" + e.KeyChar))
            {
                e.Handled = true;
            }

            authBtn.Enabled = testerName.IsMatch(login.Text) && testerGroup.IsMatch(passwd.Text);

        }

        private void passwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !testerGroup.IsMatch("" + e.KeyChar))
            {
                e.Handled = true;
            }

            authBtn.Enabled = testerName.IsMatch(login.Text) && testerGroup.IsMatch(passwd.Text);
        }


        public void goQuest(int id, string filename, string fin, bool readMode)
        {
            rM = readMode;
            var lines = File.ReadAllLines(filename);
            if (rM) {
                lines = lines[0].Split('~').Skip(3).ToArray();
            }
            if (lines.Length > id)
            {
                string param = lines[id];
                string[] pms = param.Split('`');
                string name = pms[0];
                string desc = pms[1];
                string type = pms[2];
                string[] quests = pms[3].Split('$');
                switch (type)
                {
                    case "1":
                        FormType1 frm1 = new FormType1();
                        frm1.init(id, name, desc, quests, filename, fin, rM);
                        frm1.Show();
                        frm1.FormClosed += (es, v) => this.Close();
                        this.Hide();
                        break;
                    case "2":
                        FormType2 frm2 = new FormType2();
                        frm2.init(id, name, desc, quests, filename, fin, rM);
                        frm2.Show();
                        frm2.FormClosed += (es, v) => this.Close();
                        this.Hide();
                        break;
                    case "3":
                        FormType3 frm3 = new FormType3();
                        frm3.init(id, name, desc, quests, filename, fin, rM);
                        frm3.Show();
                        frm3.FormClosed += (es, v) => this.Close();
                        this.Hide();
                        break;

                }
            }
            else
            {
                if(!rM)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                    saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog1.FilterIndex = 2;
                    saveFileDialog1.RestoreDirectory = true;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, fin);
                    }
                }  

                this.Close();
                
            }
        }
    }
}
