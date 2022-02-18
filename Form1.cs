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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void doldur()
        {
            Baglanti.Open();
            string kayit = "SELECT * FROM MUSTERILER";
            SqlCommand komut = new SqlCommand(kayit, Baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }
        string mus_id;
        SqlConnection Baglanti = new SqlConnection(@"Data Source=AA-BILGISAYAR\SQLEXPRESS;initial catalog=TELEFON_TAMIRCISI;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (MessageBox.Show("Kayıt Etme İşlemini Gerçekleştirmek İstediğinize Eminmisiniz", "UYARI !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    Baglanti.Open();
                    string deger = textBox2.Text;
                    SqlCommand komut = new SqlCommand("insert into MUSTERILER (MUSTERI_ARIZA_OZET,MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI,MUSTERININ_ULASIM_ADRESI,MUSTERININ_TC_NUMARASI) values ('" + deger+ "','" + textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"')", Baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    Baglanti.Close();
                    doldur();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow _selectedRow = dataGridView1.Rows[e.RowIndex];
            mus_id = _selectedRow.Cells["MUSTERI_ID"].Value.ToString();
            textBox2.Text = _selectedRow.Cells["MUSTERI_ARIZA_OZET"].Value.ToString();
            textBox3.Text = _selectedRow.Cells["MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI"].Value.ToString();
            textBox4.Text = _selectedRow.Cells["MUSTERININ_ULASIM_ADRESI"].Value.ToString();
            textBox5.Text = _selectedRow.Cells["MUSTERININ_TC_NUMARASI"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Kayıt Etme İşlemini Gerçekleştirmek İstediğinize Eminmisiniz", "UYARI !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    Baglanti.Open();
                    SqlCommand komut = new SqlCommand("Delete from MUSTERILER where MUSTERI_ID = '" + Convert.ToUInt32(mus_id) + "'", Baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    Baglanti.Close();
                    doldur();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Güncelleme İşlemini Gerçekleştirmek İstediğinize Eminmisiniz", "UYARI !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                case DialogResult.OK:
                    Baglanti.Open();
                    SqlCommand komut = new SqlCommand("UPDATE MUSTERILER SET MUSTERI_ARIZA_OZET = '"+textBox2.Text+"', MUSTERININ_TESLIM_ETTIGI_TELEFON_MODELI = '"+textBox3.Text+ "',MUSTERININ_ULASIM_ADRESI = '"+textBox4.Text+ "',MUSTERININ_TC_NUMARASI= '"+textBox5.Text+ "' where MUSTERI_ID = '"+Convert.ToInt32(mus_id)+"'", Baglanti);
                    SqlDataReader dr = komut.ExecuteReader();
                    Baglanti.Close();
                    doldur();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Baglanti.Open();
            string kayit = "SELECT * FROM MUSTERILER where MUSTERININ_TC_NUMARASI = '" + textBox6.Text+"'";
            SqlCommand komut = new SqlCommand(kayit, Baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
