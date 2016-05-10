using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using AForge.Imaging.Filters;

namespace EasyPhotoshop
{
    public partial class Form1 : Form
    {
        Color paintcolor;
        bool choose = false;

        public Form1()
        {
            InitializeComponent();
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

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void red_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label2.Text = paintcolor.R.ToString();
        }

        private void green_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label3.Text =paintcolor.G.ToString();
        }

        private void blue_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label5.Text = paintcolor.B.ToString();
        }

        private void alpha_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label7.Text = paintcolor.A.ToString();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {

            if (choose)
            {
                Bitmap bmp = (Bitmap)pictureBox3.Image.Clone();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                red.Value = paintcolor.R;
                green.Value = paintcolor.G;
                blue.Value = paintcolor.B;
                alpha.Value = paintcolor.A;
                label2.Text = paintcolor.R.ToString();
                label3.Text = paintcolor.G.ToString();
                label5.Text = paintcolor.B.ToString();
                label7.Text = paintcolor.A.ToString();
                pictureBox2.BackColor = paintcolor;
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox1.Image = null;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wyostrzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Sharpen FiltrSharp = new Sharpen();
            FiltrSharp.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }

        private void negatywToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Invert FiltrInvert = new Invert();
            //FiltrInvert.ApplyInPlace(bmp); bo coś nie działa
            pictureBox1.Image = bmp;
        }

        private void czarnoBiałyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Grayscale FiltrGray= new Grayscale(0.2,0.2,0.2); // te liczby troche z dupy
            bmp = FiltrGray.Apply(bmp);
            pictureBox1.Image = bmp;
        }

        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Sepia FiltrSepia = new Sepia();
            FiltrSepia.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }

        private void większyKontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            ContrastCorrection FiltrKontrast = new ContrastCorrection();
            FiltrKontrast.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }

        private void rozmyjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Blur FiltrBlur = new Blur();
            FiltrBlur.ApplyInPlace(bmp);
            pictureBox1.Image = bmp;
        }
    }
}
