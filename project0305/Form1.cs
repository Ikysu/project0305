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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                var lines = File.ReadAllLines(files[0]);
                if (lines[0][0] == '~')
                {
                    student st = new student();
                    st.init(files[0], true);
                    st.Show();
                    st.FormClosed += (es, v) => this.Close();
                    this.Hide();
                }
                else
                {
                    student st = new student();
                    st.init(files[0], false);
                    st.Show();
                    st.FormClosed += (es, v) => this.Close();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("А где файлы?", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
    }
}
