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
        bool draw = false;
        bool czyjestobrazek = false;
        int x, y, lx, ly = 0;
        Item currItem;
        private Bitmap originalBitmap = null;
        //bool czybylfiltr = false;
        private Image znaczekwodny;

        public Form1()
        {
            InitializeComponent();
            paintcolor = pictureBox2.BackColor;
        }

        public Form1(Image image)
        {
            InitializeComponent();
            this.znaczekwodny = image;
            pictureBox1.Image = image;
        }

        public enum Item
        {
            Rectange, Elipse, Line, Text, Brush, ColorPicker, ereaser
        }

        //nowy
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            pictureBox1.Image = null;
        }
       
        //otwórz
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworz = new OpenFileDialog();
            otworz.Title = "Otworz plik graficzny.";
            otworz.Filter = "(*.png)|*.png|(*.jpg)|*.jpg";
            otworz.Filter += "|(*.bmp)|*.bmp";

            if (otworz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(otworz.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();
                pictureBox1.ImageLocation = otworz.FileName;
                czyjestobrazek = true;
            }
        }
        //zapisz
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Jpeg files|*.jpg|Png files|*.png|Bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        //zapisz jako
        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Jpeg files|*.jpg|Png files|*.png|Bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        //zamknij
        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //otwieranie manu znak wodny
        private void znakWodnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(pictureBox1.Image);
            form2.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //suwak czerwony
        private void red_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label2.Text = paintcolor.R.ToString();
        }

        //suwak zielony
        private void green_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label3.Text =paintcolor.G.ToString();
        }

        //suwak niebieski
        private void blue_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label5.Text = paintcolor.B.ToString();
        }

        //suwak aplha
        private void alpha_Scroll(object sender, EventArgs e)
        {
            paintcolor = Color.FromArgb(alpha.Value, red.Value, green.Value, blue.Value);
            pictureBox2.BackColor = paintcolor;
            label7.Text = paintcolor.A.ToString();
        }

        //paleta barw
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
        }

        //paleta barw
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        //paleta barw obsługa
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

        //wybór czcionki
        private void Form1_Load(object sender, EventArgs e)
        {
            //czcionki
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                toolStripComboBox1.Items.Add(font.GetName(1).ToString());
            }
        }

        //rysowanie
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        //rysowanie obsługa AAAAAAAA
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
            if (currItem == Item.Line)
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(new SolidBrush(paintcolor)), new Point(x, y), new Point(lx, ly));
                g.Dispose();
            }
        }

        //prostokąt
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            currItem = Item.Rectange;
        }

        //elipsa
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            currItem = Item.Elipse;
        }
       
        //pędzel
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            currItem = Item.Brush;
        }

        //linia
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            currItem = Item.Line;
        }

        //ColorCliper
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            currItem = Item.ColorPicker;
        }

        //ColorCliper obsługa
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (currItem == Item.ColorPicker)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);
                Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
                g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
                g.Dispose();
                paintcolor = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = paintcolor;
                red.Value = paintcolor.R;
                green.Value = paintcolor.G;
                blue.Value = paintcolor.B;
                alpha.Value = paintcolor.A;
                label2.Text = paintcolor.R.ToString();
                label3.Text = paintcolor.G.ToString();
                label5.Text = paintcolor.B.ToString();
                label7.Text = paintcolor.A.ToString();
                bmp.Dispose();

            }
        }
        
        //gumka
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            currItem = Item.ereaser;
        }

        //wstawianie tekstu
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            currItem = Item.Text;
            Graphics g = pictureBox1.CreateGraphics();
            if (toolStripComboBox3.Text == "Regular")
            {
                g.DrawString(toolStripTextBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripComboBox2.Text), FontStyle.Regular), new SolidBrush(paintcolor), new PointF(x, y));
            }
            else if (toolStripComboBox3.Text == "Bold")
            {
                 g.DrawString(toolStripTextBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripComboBox2.Text), FontStyle.Bold), new SolidBrush(paintcolor), new PointF(x, y));
            }
            else if (toolStripComboBox3.Text == "Underline")
            {
                g.DrawString(toolStripTextBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripComboBox2.Text), FontStyle.Underline), new SolidBrush(paintcolor), new PointF(x, y));
            }
            else if (toolStripComboBox3.Text == "Strikeout")
            {
            g.DrawString(toolStripTextBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripComboBox2.Text), FontStyle.Strikeout), new SolidBrush(paintcolor), new PointF(x, y));
            }
            else if (toolStripComboBox3.Text == "Italic")
            {
                g.DrawString(toolStripTextBox1.Text, new Font(toolStripComboBox1.Text, Convert.ToInt32(toolStripComboBox2.Text), FontStyle.Italic), new SolidBrush(paintcolor), new PointF(x, y));
            }
        }

        //obsługa narzęci
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = pictureBox1.CreateGraphics();

                switch (currItem)
                {
                    case Item.Rectange:
                        g.FillRectangle(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Elipse:
                        g.FillEllipse(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Brush:
                        g.FillEllipse(new SolidBrush(paintcolor), e.X - x + x, e.Y - y + y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                        break;
                    case Item.ereaser:
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), e.X - x + x, e.Y - y + y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                        break;
                }
                g.Dispose();
            }
        }

        //Cofnij
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // pictureBox1.Image = previousBitmap;
        }

        //FILTRY

        //filtr wyostrzenie
        private void wyostrzenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Sharpen FiltrSharp = new Sharpen();
                bmp = FiltrSharp.Apply(bmp);
                pictureBox1.Image = bmp;
            }
        }

        //filtr negatyw
        private void negatywToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                for (int x = 0; x < bmp.Width; x++)
                {
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Color pixel = bmp.GetPixel(x, y);
                        int red = pixel.R;
                        int green = pixel.G;
                        int blue = pixel.B;

                        bmp.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                    }
                }
                pictureBox1.Image = bmp;
            }
        }

        //filtr czarno-biał
        private void czarnoBiałyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Grayscale FiltrGray = new Grayscale(0.2, 0.2, 0.2); // te liczby troche z dupy
                bmp = FiltrGray.Apply(bmp);
                pictureBox1.Image = bmp;
            }
        }

        //filtr sepia
        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Sepia FiltrSepia = new Sepia();
                FiltrSepia.ApplyInPlace(bmp);
                pictureBox1.Image = bmp;
            }
        }

        // cofniecie filtru
        private void barkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalBitmap;
        }

        //filtr większy kontrast
        private void większyKontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                ContrastCorrection FiltrKontrast = new ContrastCorrection(15);
                FiltrKontrast.ApplyInPlace(bmp);
                pictureBox1.Image = bmp;
            }

        }

        //filtr rozmycie
        private void rozmyjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czyjestobrazek == false)
            {
                MessageBox.Show("Wstaw wpierw obrazek!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Blur FiltrBlur = new Blur();
                bmp = FiltrBlur.Apply(bmp);
                pictureBox1.Image = bmp;
            }
        }

        //grubość pędzla
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }
    }
}
