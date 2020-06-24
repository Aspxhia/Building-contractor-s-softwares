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
    public partial class kantarfis : Form
    {
        public kantarfis()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

            





        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut2 = new MySqlCommand("INSERT INTO ozkandb.kantarfis (tarihfisbugun,plakano,giristarih,cikistarih,geldigiadres,ilktartim,sontartim,netagirlik,kantarismi,kantaradres,santiye_idsantiye,malzemeler_idmalzemeler,malzemeler_firmalar_idfirmalar) VALUES ('" + dateTimePicker2.Text + "','" + PlakaTxt.Text + "','" + girisDate.Text + "','" + dateTimePicker2.Text + "','" + GeldigiAdresTxt.Text + "','" + ilkTartimTxt.Text + "','" + sonTartimTxt.Text + "','" + netAgirlikTxt.Text + "','" + kantarIsimTxt.Text + "','" + kantarAdresTxt.Text + "','" + santiyeCombo.SelectedValue + "','" + MalzemeCombo.SelectedValue + "','" + FirmaCombo.SelectedValue + "')", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme başarılı");
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi!Bir hata oluştu");
            }
        }

        private void kantarfis_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("select idsantiye,santiye_ad from ozkandb.santiye", baglanti);
                DataTable dt2 = new DataTable();
                MySqlDataReader oku = cmd.ExecuteReader();
                dt2.Load(oku);
                santiyeCombo.ValueMember = "idsantiye";
                santiyeCombo.DisplayMember = "santiye_ad";
                santiyeCombo.DataSource = dt2;

                MySqlCommand cmd2 = new MySqlCommand("select idmalzemeler,malzemeisim from ozkandb.malzemeler", baglanti);
                MySqlDataReader okuu = cmd2.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(okuu);
                MalzemeCombo.ValueMember = "idmalzemeler";
                MalzemeCombo.DisplayMember = "malzemeisim";
                MalzemeCombo.DataSource = dt3;

                MySqlCommand cmd4 = new MySqlCommand("select idfirmalar,firmaisim from ozkandb.firmalar", baglanti);
                DataTable dt4 = new DataTable();
                MySqlDataReader oku4 = cmd4.ExecuteReader();
                dt4.Load(oku4);
                FirmaCombo.ValueMember = "idfirmalar";
                FirmaCombo.DisplayMember = "firmaisim";
                FirmaCombo.DataSource = dt4;
                baglanti.Close();
            }

            catch (Exception ex)
            {


                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void kantarSilBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("Delete from ozkandb.kantarfis where idkantarfis = '" + Convert.ToInt32(idTxt.Text) + "'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı!");
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.kantarfis where tarihfisbugun Like'%" + dateTimePicker3.Text + "%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "ozkandb.kantarfis");
                dataGridView1.DataSource = ds.Tables["ozkandb.kantarfis"];
                da.Dispose();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata olutu");
            }
        }
    }
}
