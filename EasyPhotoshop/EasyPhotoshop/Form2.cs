﻿using System;
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
    public partial class Form2 : Form
    {
        private Image obrazek;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Image image)
        {
            InitializeComponent();
            this.obrazek = image;
        }

        //przezroczystosc znaku
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(trackBar1.Value);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //czcionki
            FontFamily[] family = FontFamily.Families;
            foreach (FontFamily font in family)
            {
                comboBox1.Items.Add(font.GetName(1).ToString());
            }
        }
        //wstawianie
        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap bmp = (Bitmap)obrazek;
            //to wszystko tylko przykladowe [poza tekstem]
            Font font = new Font(FontFamily.GenericMonospace, 30.0F, FontStyle.Bold);
            Graphics wodnyznak = Graphics.FromImage(bmp);
            SolidBrush sb = new SolidBrush(Color.FromArgb(70, Color.White));
            int i = 0;
            int j = 0;
            string tekst = textBox1.Text.ToString();
            if (string.IsNullOrEmpty(tekst))
                {
                MessageBox.Show("Brak tekstu!");
            }
            else {
                //Font font = cvt.ConvertFromString(s) as Font;

                wodnyznak.DrawString(tekst, font, sb, i, j);
                Image gotowy = (Image)bmp;
                Form1 form1 = new Form1(gotowy);
                form1.Show();
            }
        }
    }
}
/*TO DO
LEPSZE PRZEJSCIE Z FORM 2 NA FORM 1, ALBO USUNIECIE FORM 1 STAREGO
ROZMIAR
CZCIONKA
KOLOR
POLOZENIE
PRZEZROCZYSTOSC