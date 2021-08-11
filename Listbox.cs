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
    public partial class Listbox : Form
    {
        public Listbox()
        {
            InitializeComponent();
        }

        private void Listbox_Load(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox2.Items.Add(listBox2.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Lütfen Seçim Yapınız");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }
    }
    }

