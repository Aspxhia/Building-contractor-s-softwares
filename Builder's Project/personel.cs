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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        private void cekBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.personel";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! bir hata oluştu");
            }
        }

        private void kydtBtn_Click(object sender, EventArgs e)
        {
            int cecelist = Convert.ToInt32(comboBox1.SelectedValue);

            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("insert into ozkandb.personel (personel_ismi,personel_mevki,personel_tc,santiye_idsantiye) VALUES ('" + isimtxt.Text + "','" + mevkitxt.Text + "','" + tctxt.Text + "','" + cecelist + "')", baglanti);
                MessageBox.Show("Kayıt Başarıyla eklendi");
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void perEkleBtn_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;

            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("select*from ozkandb.santiye", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oku);

                comboBox1.DataSource = dt.DefaultView;
                comboBox1.DisplayMember = "santiye_ad";
                comboBox1.ValueMember = "idsantiye";
                baglanti.Close();
            }

            catch (Exception ex)
            {


                MessageBox.Show("Hay aksi bir hata oluştu");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void perSilBtn_Click(object sender, EventArgs e)
        {

            panel2.Visible = true;
            

          
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut4 = new MySqlCommand("delete from ozkandb.personel where idpersonel = '" + Convert.ToInt32(perid.Text) + "'", baglanti);
                komut4.ExecuteNonQuery();
                baglanti.Close();
            }

            catch (Exception ex)
            {


                MessageBox.Show("Hay aksi bir hata oluştu");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void personel_Load(object sender, EventArgs e)
        {

        }
    }
}
