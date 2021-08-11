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
    public partial class KarPayıVade : Form
    {
        public KarPayıVade()
        {
            InitializeComponent();
        }

        double maas = 0;
        double maas1 = 0;
        double yillikartisorani = 0;
        double yillkartis = 0;
        int yıl = 0;

        private void KarPayıVade_Load(object sender, EventArgs e)
        {
        Environment.Exit(0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            maas = Convert.ToDouble(textBox1.Text);
            maas1 = maas;
            yillikartisorani = Convert.ToDouble(textBox3.Text);
            yillikartisorani = Convert.ToInt32(textBox2.Text);

            for(int i = 1; i <= yillikartisorani; i++){
                yillkartis = (maas1 / 100) * yillikartisorani;
                    maas1 = maas1 + yillkartis;
            }
            textBox4.Text = (maas1 - maas).ToString();
            textBox5.Text = maas1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }
    }
}
