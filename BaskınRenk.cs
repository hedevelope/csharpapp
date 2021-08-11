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
    public partial class BaskınRenk : Form
    {
        public BaskınRenk()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
            {
                openFileDialog1.ShowDialog();
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                try
                {
                    this.BackColor = Color.FromArgb(baskinRengiBul());
                }
                catch
                {
                    MessageBox.Show("Saydam renk uygulanamıyor.");
                }
            }

            Dictionary<int, int> renk = new Dictionary<int, int>();
            private int baskinRengiBul()
            {
                renk.Clear();

                Bitmap resim = (Bitmap)pictureBox1.Image;

                for (int x = 0; x < resim.Width; x++)
                {
                    for (int y = 0; y < resim.Height; y++)
                    {
                        //Saydam alanlar hesaplanmıyor
                        if (resim.GetPixel(x, y).A != 0)
                        {
                            int pikseldekiRenk = resim.GetPixel(x, y).ToArgb();

                            if (renk.ContainsKey(pikseldekiRenk))
                                renk[pikseldekiRenk]++;
                            else
                                renk.Add(pikseldekiRenk, 1);
                        }
                    }
                }

                int baskinRenk = renk.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).First().Key;
                return baskinRenk;
            }

        }
    }