using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Tanir_Et
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection Baglanti = new SqlConnection(@"Data Source=AA-BILGISAYAR\SQLEXPRESS;initial catalog=TELEFON_TAMIRCISI;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KULLANICILAR where KULL_ADI='" + textBox1.Text + "' and KULL_SIFRE='" + textBox2.Text + "'", Baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 a = new Form1();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Baglanti.Close();
        }
    }
}
