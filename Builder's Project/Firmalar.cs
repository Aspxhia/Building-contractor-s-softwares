using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Builder_s_Project
{
    public partial class Firmalar : Form
    {
        public Firmalar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            string sql = "SELECT * FROM ozkandb.firmalar";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand("INSERT INTO ozkandb.firmalar (firmaisim,telefon,santiye_idsantiye) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + santiyeCmb.SelectedValue + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme başarılı");


            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! bir hata oluştu");
            }
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void sil2btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("Delete from ozkandb.firmalar where idfirmalar = '" + Convert.ToInt32(texttbox.Text) + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı!");
            }

            catch (Exception exxxx)
            {
                MessageBox.Show("Lütfen sayı olarak firmanın id'sini giriniz");
            }
        }

        private void gizle2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void gizle1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("select idsantiye,santiye_ad from ozkandb.santiye", baglanti);
                DataTable dt2 = new DataTable();
                MySqlDataReader oku = cmd.ExecuteReader();
                dt2.Load(oku);
                santiyeCmb.ValueMember = "idsantiye";
                santiyeCmb.DisplayMember = "santiye_ad";
                santiyeCmb.DataSource = dt2;
                baglanti.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay Aksi! Bir hata oluştu");
            }
        }
    }
}
