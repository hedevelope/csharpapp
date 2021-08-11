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
    public partial class Faktoriyel : Form
    {
        public Faktoriyel()
        {
            InitializeComponent();
        }

        public long Faktor(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Faktor(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            long sonuc = Faktor(sayi);
            label1.Text = "Sonuç  " + sonuc.ToString();
                }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void Faktoriyel_Load(object sender, EventArgs e)
        {

        }
    }
}
