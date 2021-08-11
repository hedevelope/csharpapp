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
    public partial class VizeFinal : Form
    {
        public VizeFinal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize, final, ort;
            vize = Convert.ToInt16(textBox1.Text);
            final = Convert.ToInt16(textBox2.Text);
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            label5.Text = ort.ToString();
            if (ort < 50 || final < 50)
                label6.Text = "Kaldınız";
            else
                label6.Text = "Geçtiniz";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void VizeFinal_Load(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
    }

