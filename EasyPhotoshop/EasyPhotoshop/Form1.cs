using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPhotoshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();//test
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pilk graficzny|*.jpg*";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plik graficzny|*.jpg*";
            saveFileDialog1.ShowDialog();
            pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void znakWodnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}
