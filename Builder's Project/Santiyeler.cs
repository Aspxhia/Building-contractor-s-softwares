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
    public partial class Santiyeler : Form
    {
        public Santiyeler()
        {
            InitializeComponent();
        }

        

        private void Santiyeler_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select*from ozkandb.santiye", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    comboBox1.Items.Add(oku["santiye_ad"]);
                }
                baglanti.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }
            }


        private void santiyeEkleBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("insert into santiye (santiye_ad,adres,baslangic_tarih,bitis_tarih) VALUES ('" + isimBtn.Text + "','" + adresBtn.Text + "','" + baslaBtn.Text + "','" + bitisBtn.Text + "')", baglanti);
                MessageBox.Show("Kayıt Başarıyla eklendi");
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Lütfen tarihleri yıl-ay-gün formatında giriniz");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            string sql = "SELECT * FROM ozkandb.santiye where santiye_ad Like'%" + comboBox1.SelectedItem + "%'";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds, "ozkandb.santiye");
            dataGridView1.DataSource = ds.Tables["ozkandb.santiye"];
            da.Dispose();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
