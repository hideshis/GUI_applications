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

namespace soundNovel
{
    public partial class Form1 : Form
    {
        string pictureBox1_state = "opening";
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            switch (pictureBox1_state)
            {
                case "opening":
                    pictureBox1.Image = Properties.Resources.title;
                    pictureBox1_state = "title";
                    break;
                case "title":
                    pictureBox1.Image = Properties.Resources.page1;
                    pictureBox1_state = "page1";
                    break;
                case "page1":
                    pictureBox1.Image = Properties.Resources.page2;
                    pictureBox1_state = "page2";
                    break;
                case "page2":
                    pictureBox1.Image = Properties.Resources.ending;
                    pictureBox1_state = "ending";
                    playSound();
                    break;
                case "ending":
                    pictureBox1.Image = Properties.Resources.opening;
                    pictureBox1_state = "opening";
                    break;
            }
        }

        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            string path = System.Reflection.Assembly.GetEntryAssembly().Location; // like "C:\Users\hideshi\Source\Repos\GUI_applications\soundNovel\soundNovel\bin\Debug\soundNovel.exe"
            path = path.Split(new string[] { "bin" }, StringSplitOptions.None)[0];
            path = Path.Combine(path, @"Resources\explosion.wav");
            player.SoundLocation = path;
            player.Play();
        }
    }
}
