using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace asitakip
{
    public partial class Form1: Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Sabit kullanıcı adı ve şifre kontrolü
            if (kullaniciAdi == "nisanur" && sifre == "8787Nisa.")
            {
                // Yeni formu aç
                Form2 yeniForm = new Form2();
                yeniForm.Show();

                // Bu formu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
 

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
