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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsalSayı login = new AsalSayı();
            login.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VizeFinal login = new VizeFinal();
            login.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listbox login = new Listbox();
            login.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            KarPayıVade login = new KarPayıVade();
            login.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaskınRenk login = new BaskınRenk();
            login.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            HesapMakinesi login = new HesapMakinesi();
            login.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            TasKagitMakas login = new TasKagitMakas();
            login.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            YazıTura login = new YazıTura();
            login.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Faktoriyel login = new Faktoriyel();
            login.ShowDialog();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlappyBird login = new FlappyBird();
            login.ShowDialog();
        }
    }
}
