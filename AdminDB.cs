using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistrationAndLogin
{
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();
        }
        static string constring = (@"Data Source = AYDANUR\SQLEXPRESS;Initial Catalog = Website; Integrated Security = True");
        SqlConnection baglan = new SqlConnection(constring);


        private void AdminDB_Load(object sender, EventArgs e)
        {

        }

        public void kayitsil()
        {
            string sil = "Delete * From LoginTable";
            SqlCommand komut = new SqlCommand(sil, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        public void kayitlari_getir()
        {
            
            string getir = "Select * From LoginTable";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            kayitlari_getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                string kayit = "insert into LoginTable(username,password)values(@username,@password)";
                SqlCommand komut = new SqlCommand(kayit,baglan);
                komut.Parameters.AddWithValue("@username", textBox1.Text);
                komut.Parameters.AddWithValue("@password", textBox2.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Ekleme Başarılı!");


            }
            catch(Exception hata)
            {
                MessageBox.Show("Kayıtta Hata Oluştu" + hata.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
