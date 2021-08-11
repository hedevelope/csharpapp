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
    public partial class YazıTura : Form
    {
        public YazıTura()
        {
            InitializeComponent();
        }

        int yz, tr;
        string durum;
        private void button1_Click(object sender, EventArgs e)
        {

            yz = 0;
            tr = 0;

            label4.Text = yz.ToString();

            Random r = new Random();
            for (int i=0; i<2; i++)
            {
                int yt = r.Next(1, 3);
                if (yt == 1)
                {
                    label3.Text = ("Yazı");
                    yz++;
                }
                else
                {
                    label3.Text = ("Tura");
                }
                if(label3.Text == "Tura")
                {
                    
                }
            }
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void YazıTura_Load(object sender, EventArgs e)
        {

        }
    }
}
