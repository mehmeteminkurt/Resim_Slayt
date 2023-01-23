using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace resimslayt
{
    public partial class Form1 : Form
    {
        String dizin = "";
        int index = 0;
        String[] dizi;
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void klasorsecbtn_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            dizin = folderBrowserDialog1.SelectedPath;
            dizi = Directory.GetFiles(dizin,"*.jpg");
            g = this.CreateGraphics();
            g.DrawImage(Image.FromFile(dizi[index]), 50, 50, 250, 250);
        }

        private void sagabtn_Click(object sender, EventArgs e)
        {
            index++;
            g.DrawImage(Image.FromFile(dizi[index]), 50, 50, 250, 250);
        }

        private void solabtn_Click(object sender, EventArgs e)
        {
            index--;
            g.DrawImage(Image.FromFile(dizi[index]), 50, 50, 250, 250);
        }
    }
}
