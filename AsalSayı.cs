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
    public partial class AsalSayı : Form
    {
        public AsalSayı()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                listBox1.Items.Clear();
                int ilksayi, sonsayi;
                ilksayi = Convert.ToInt32(textBox1.Text);
                sonsayi = Convert.ToInt32(textBox2.Text);

                int sayi = ilksayi;
                bool durum = true;

                while (sayi < sonsayi)
                {
                    sayi++;

                    for (int i = 2; i < sayi; i++)
                    {
                        if (sayi % i == 0)
                        {
                            durum = false;
                        }
                    }
                    if (durum == true && sayi != 1)
                    {
                        listBox1.Items.Add(sayi.ToString());
                    }
                    durum = true;
                }
                label4.Text = ("İki sayı arasında '" + listBox1.Items.Count.ToString() + "' asal sayı vardır.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void AsalSayı_Load(object sender, EventArgs e)
        {

        }
    }
}
