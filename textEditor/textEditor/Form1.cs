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

namespace textEditor
{
    public partial class Form1 : Form
    {
        string openedFilename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                openedFilename = openFileDialog1.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openedFilename == "")
            {
                MessageBox.Show("the file path doesn't exist.");
            }
            else
            {
                File.WriteAllText(openedFilename, textBox1.Text, Encoding.Default);
            }
        }

        private void saveAsNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "text file (*.txt)|*.txt|others (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            string editFilePath = saveFileDialog1.FileName;
            File.WriteAllText(editFilePath, textBox1.Text, Encoding.Default);
            this.Text = GetFileNameString(editFilePath, '\\');
            openedFilename = editFilePath;
        }

        private string GetFileNameString(string filePath, char separateChar)
        {
            try
            {
                string[] strArray = filePath.Split(separateChar);
                return strArray[strArray.Length - 1];
            }
            catch
            { return ""; }
        }
    }
}
