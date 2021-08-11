using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class TasKagitMakas : Form
    {
        public TasKagitMakas()
        {
            InitializeComponent();
        }

        int os, pcs; //oyuncu skoru os, bilgisayar skoru pcs
        string d; //d durum
        Random r = new Random();
        private void TasKagitMakas_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = @"C:\Users\Aydanur\Desktop\tas.jpeg";
            pictureBox2.ImageLocation = @"C:\Users\Aydanur\Desktop\kagit.jpeg";
            pictureBox3.ImageLocation = @"C:\Users\Aydanur\Desktop\makas.jpeg";
            pictureBox4.ImageLocation = @"C:\Users\Aydanur\Desktop\x.jpeg";

            label2.Text = "Oyuncu" + os.ToString();
            label3.Text = "Bilgisayar" + pcs.ToString();
            label1.BackColor = Color.Orange;
        }
        public void sec()
        {
            int s;
            s = r.Next(1, 4);
            if (s == 1)
            {
                pictureBox4.ImageLocation = @"C:\Users\Aydanur\Desktop\kagit.jpeg";
                d = "Kağıt";
            }
            if (s == 2)
            {
                pictureBox4.ImageLocation = @"C:\Users\Aydanur\Desktop\tas.jpeg";
                d = "Taş";
            }
            if (s == 3)
            {
                pictureBox4.ImageLocation = @"C:\Users\Aydanur\Desktop\makas.jpeg"; ;
                d = "Makas";
            }
        }

        public void skorkontrol()
        {
            if (os == 10)
            {
                MessageBox.Show("Kazandınız!");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }
            if (pcs == 10)
            {
                MessageBox.Show("Bilgisayar Kazandı");
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
            }

        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Kağıt")
            {
                label1.Text = "Durumlar  Eşit";
                label1.BackColor = Color.Green;

            }
            if (d == "Taş")
            {
                label1.Text = "Kağıt Taşı Sarar Oyuncu +1 Skor";
                os = os + 1;
                label2.Text = "Oyuncu=" + os.ToString();
                label1.BackColor = Color.Blue;
            }
            if (d == "Makas")
            {
                label1.Text = "Makas Kağıtı Keser PC +1 Skor";
                pcs = pcs + 1;
                label3.Text = "PC=" + pcs.ToString();
                label1.BackColor = Color.Red;
            }
            skorkontrol();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Kağıt")
            {
                label1.Text = "Durumlar  Eşit";
                label1.BackColor = Color.Green;

            }
            if (d == "Taş")
            {
                label1.Text = "Kağıt Taşı Sarar Oyuncu +1 Skor";
                os = os + 1;
                label2.Text = "Oyuncu=" + os.ToString();
                label1.BackColor = Color.Blue;
            }
            if (d == "Makas")
            {
                label1.Text = "Makas Kağıtı Keser PC +1 Skor";
                pcs = pcs + 1;
                label3.Text = "PC=" + pcs.ToString();
                label1.BackColor = Color.Red;
            }
            skorkontrol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            os = 0;
            pcs = 0;
            label1.Text = "";
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            label2.Text = "Oyuncu=" + os.ToString();
            label3.Text = "PC=" + pcs.ToString();
            label1.BackColor = Color.Orange;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sec();
            if (d == "Kağıt")
            {
                label1.Text = "Durumlar  Eşit";
                label1.BackColor = Color.Green;

            }
            if (d == "Taş")
            {
                label1.Text = "Kağıt Taşı Sarar Oyuncu +1 Skor";
                os = os + 1;
                label2.Text = "Oyuncu=" + os.ToString();
                label1.BackColor = Color.Blue;
            }
            if (d == "Makas")
            {
                label1.Text = "Makas Kağıtı Keser PC +1 Skor";
                pcs = pcs + 1;
                label3.Text = "PC=" + pcs.ToString();
                label1.BackColor = Color.Red;
            }
            skorkontrol();
        }
    }
}

