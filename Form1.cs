using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_096_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            hslPenjumlahan.Text = hasilTambah.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Kurang(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            hslPengurangan.Text = hasilTambah.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Bagi(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
            hslPembagian.Text = hasilTambah.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Kali(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
            hslPerkalian.Text = hasilTambah.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaKoordinat a = new ServiceReference1.MatematikaKoordinat();
            ServiceReference1.MatematikaKoordinat b = new ServiceReference1.MatematikaKoordinat();

            a.X = Convert.ToInt32(textBox9.Text);
            a.Y = Convert.ToInt32(textBox10.Text);

            b.X = Convert.ToInt32(textBox11.Text);
            b.Y = Convert.ToInt32(textBox12.Text);

            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;

            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));

            hslKoordinat.Text = jarak.ToString();
        }
    }
}

