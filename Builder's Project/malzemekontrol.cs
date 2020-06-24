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
    public partial class malzemekontrol : Form
    {
        public malzemekontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

           
            








        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void malzemekontrol_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("select idsantiye,santiye_ad from ozkandb.santiye", baglanti);
                DataTable dt2 = new DataTable();
                MySqlDataReader oku = cmd.ExecuteReader();
                dt2.Load(oku);
                comboBox1.ValueMember = "idsantiye";
                comboBox1.DisplayMember = "santiye_ad";
                comboBox1.DataSource = dt2;

                MySqlCommand cmd2 = new MySqlCommand("select idmalzemeler,malzemeisim from ozkandb.malzemeler", baglanti);
                MySqlDataReader okuu = cmd2.ExecuteReader();
                DataTable dt3 = new DataTable();
                dt3.Load(okuu);
                comboBox2.ValueMember = "idmalzemeler";
                comboBox2.DisplayMember = "malzemeisim";
                comboBox2.DataSource = dt3;

                MySqlCommand cmd3 = new MySqlCommand("select idsantiye,santiye_ad from ozkandb.santiye", baglanti);
                MySqlDataReader okuuu = cmd3.ExecuteReader();
                DataTable dt4 = new DataTable();
                dt4.Load(okuuu);
                santiyeCombo.ValueMember = "idsantiye";
                santiyeCombo.DisplayMember = "santiye_ad";
                santiyeCombo.DataSource = dt4;

                MySqlCommand cmd7 = new MySqlCommand("select idmalzemeler,malzemeisim from ozkandb.malzemeler", baglanti);
                MySqlDataReader okuma = cmd7.ExecuteReader();
                DataTable dt7 = new DataTable();
                dt7.Load(okuma);
                malzemeCombo.ValueMember = "idmalzemeler";
                malzemeCombo.DisplayMember = "malzemeisim";
                malzemeCombo.DataSource = dt7;
                baglanti.Close();
            }


            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }








        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();


                string query = "SELECT malzemebirimtur FROM malzemeler WHERE malzemeisim= '" + comboBox2.Text + "'";

                MySqlCommand komut = new MySqlCommand(query, baglanti);

                MySqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {

                    degiscekLabel.Text = dr.GetValue(0).ToString();

                }
            }

            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {





            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("insert into ozkandb.malkontrol(tarih,birimtur,harcanan,kalan,santiye_idsantiye,malzemeler_idmalzemeler) VALUES(@tarih,@birimtur,@harcanan,@kalan,@santiyeidpar,@malzemeleridpar)", baglanti);
                komut.Parameters.Add(new MySqlParameter("@tarih", dateTimePicker1.Text));
                komut.Parameters.Add(new MySqlParameter("@birimtur", degiscekLabel.Text));
                komut.Parameters.Add(new MySqlParameter("@harcanan", textBox3.Text));
                komut.Parameters.Add(new MySqlParameter("@kalan", textBox4.Text));
                komut.Parameters.Add(new MySqlParameter("@santiyeidpar", comboBox1.SelectedValue));
                komut.Parameters.Add(new MySqlParameter("@malzemeleridpar", comboBox2.SelectedValue));
                MessageBox.Show("Kayıt Başarıyla eklendi");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand cmd7 = new MySqlCommand("select sum(kalan) - sum(harcanan) from malkontrol where santiye_idsantiye='" + santiyeCombo.SelectedValue + "' and malzemeler_idmalzemeler='" + malzemeCombo.SelectedValue + "'", baglanti);
                MySqlDataReader okuma = cmd7.ExecuteReader();
                listBox3.Items.Clear();
                while (okuma.Read())
                {

                    listBox3.Items.Add(okuma["sum(kalan) - sum(harcanan)"]);
                }
            }

            catch(Exception ex)
            {


                MessageBox.Show("Hay aksi bir hata oluştu");
            }
        }

       
    }
}
