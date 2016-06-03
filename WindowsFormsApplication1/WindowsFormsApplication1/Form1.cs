using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = maskedTextBox1.Text;
            label2.Text = str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString();
        }

        private void fight_Click(object sender, EventArgs e)
        {
            if (gu.Checked.Equals(true)) {
                label3.Text = "グー";
            } else if (choki.Checked.Equals(true))
            {
                label3.Text = "チョキ";
            } else
            {
                label3.Text = "パー";
            }
        }
    }
}
