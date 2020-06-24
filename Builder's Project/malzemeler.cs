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
    public partial class malzemeler : Form
    {
        public malzemeler()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        
        private void vericekBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.malzemeler";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }


            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
            }


        

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand("INSERT INTO ozkandb.malzemeler (malzemeisim,malzemebirimtur,birimfiyat,firmalar_idfirmalar) VALUES ('" + isimTxt.Text + "','" + türTxt.Text + "','" + fiyatTxt.Text + "','" + firmaCmb.SelectedValue + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme başarılı");
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }
            }
        

        private void malzemeler_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("select idfirmalar,firmaisim from ozkandb.firmalar", baglanti);
                DataTable dt2 = new DataTable();
                MySqlDataReader oku = cmd.ExecuteReader();
                dt2.Load(oku);
                firmaCmb.ValueMember = "idfirmalar";
                firmaCmb.DisplayMember = "firmaisim";
                firmaCmb.DataSource = dt2;
                baglanti.Close();
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void gizleBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("Delete from ozkandb.malzemeler where idmalzemeler = '" + Convert.ToInt32(textBox1.Text) + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı!");
            }

            catch(Exception exx)
            {

                MessageBox.Show("Lütfen sayı olarak değeri giriniz");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
