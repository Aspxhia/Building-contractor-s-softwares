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
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        private void rapor_Load(object sender, EventArgs e)
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
            santiyeCombobox.ValueMember = "idsantiye";
            santiyeCombobox.DisplayMember = "santiye_ad";
            santiyeCombobox.DataSource = dt2;

            MySqlCommand cmd2 = new MySqlCommand("select idmalzemeler,malzemeisim from ozkandb.malzemeler", baglanti);
            MySqlDataReader okuu = cmd2.ExecuteReader();
            DataTable dt3 = new DataTable();
            dt3.Load(okuu);
            malzemeCombo.ValueMember = "idmalzemeler";
            malzemeCombo.DisplayMember = "malzemeisim";
            malzemeCombo.DataSource = dt3;

            MySqlCommand komut8 = new MySqlCommand("Select tarihfisbugun from ozkandb.kantarfis",baglanti);
            MySqlDataReader okutarihfis = komut8.ExecuteReader();
            while(okutarihfis.Read())
            {

                tariheGoreListBox.Items.Add(okutarihfis["tarihfisbugun"]);
            }

            


            


















        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from finansal where day(tarih) = day(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["aciklama"]);
                listBox2.Items.Add(oku["borc"]);
                listBox3.Items.Add(oku["alacak"]);
                listBox4.Items.Add(oku["tarih"]);



            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komuta = new MySqlCommand("select sum(borc),sum(alacak),sum(alacak)-sum(borc) from finansal where day(tarih) = day(curdate())", baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                BorcLbl.Text = Convert.ToString(dr["sum(borc)"]);
                AlacakLbl.Text = Convert.ToString(dr["sum(alacak)"]);
                netLbl.Text = Convert.ToString(dr["sum(alacak)-sum(borc)"]);

            }
            baglanti.Close();

        }




    
        

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from finansal where month(tarih) = month(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["aciklama"]);
                listBox2.Items.Add(oku["borc"]);
                listBox3.Items.Add(oku["alacak"]);
                listBox4.Items.Add(oku["tarih"]);

            }

            baglanti.Close();

            baglanti.Open();
            MySqlCommand komuta = new MySqlCommand("select sum(borc),sum(alacak),sum(alacak)-sum(borc) from finansal where month(tarih) = month(curdate())", baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                BorcLbl.Text = Convert.ToString(dr["sum(borc)"]);
                AlacakLbl.Text = Convert.ToString(dr["sum(alacak)"]);
                netLbl.Text = Convert.ToString(dr["sum(alacak)-sum(borc)"]);

            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from finansal where year(tarih) = year(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["aciklama"]);
                listBox2.Items.Add(oku["borc"]);
                listBox3.Items.Add(oku["alacak"]);
                listBox4.Items.Add(oku["tarih"]);

            }
            baglanti.Close();

            baglanti.Open();
            MySqlCommand komuta = new MySqlCommand("select sum(borc),sum(alacak),sum(alacak)-sum(borc) from finansal where year(tarih) = year(curdate())", baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                BorcLbl.Text = Convert.ToString(dr["sum(borc)"]);
                AlacakLbl.Text = Convert.ToString(dr["sum(alacak)"]);
                netLbl.Text = Convert.ToString(dr["sum(alacak)-sum(borc)"]);

            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from malkontrol where santiye_idsantiye='"+santiyeCombo.SelectedValue+"' and malzemeler_idmalzemeler='"+malzemeCombo.SelectedValue+"' and day(tarih) = day(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            harcananListbox.Items.Clear();
            kalanListbox.Items.Clear();
            tarihListbox.Items.Clear();
            while (oku.Read())
            {
                harcananListbox.Items.Add(oku["harcanan"]);
                kalanListbox.Items.Add(oku["kalan"]);
                tarihListbox.Items.Add(oku["tarih"]);
                

            }

            baglanti.Close();
            baglanti.Open();
            MySqlCommand komuta = new MySqlCommand("select sum(harcanan) from malkontrol where day(tarih) = day(curdate())",baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                harcananLbl.Text = Convert.ToString(dr["sum(harcanan)"]);
                

            }
            baglanti.Close();

            baglanti.Open();

            MySqlCommand komutnew = new MySqlCommand("SELECT sum(malkontrol.harcanan) FROM malkontrol INNER JOIN malzemeler ON malzemeler.idmalzemeler = malkontrol.malzemeler_idmalzemeler where malzemeler_idmalzemeler='" + malzemeCombo.SelectedValue + "' and day(tarih) = day(curdate())", baglanti);
            MySqlDataReader dark = komutnew.ExecuteReader();
            while(dark.Read())
            {

                harcananLbl.Text = Convert.ToString(dark["sum(malkontrol.harcanan)"]); 

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from malkontrol where santiye_idsantiye='" + santiyeCombo.SelectedValue + "' and malzemeler_idmalzemeler='" + malzemeCombo.SelectedValue + "' and month(tarih) = month(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            harcananListbox.Items.Clear();
            kalanListbox.Items.Clear();
            tarihListbox.Items.Clear();
            while (oku.Read())
            {
                harcananListbox.Items.Add(oku["harcanan"]);
                kalanListbox.Items.Add(oku["kalan"]);
                tarihListbox.Items.Add(oku["tarih"]);


            }

            baglanti.Close();
            baglanti.Open();
            MySqlCommand komuta = new MySqlCommand("select sum(harcanan) from malkontrol where month(tarih) = month(curdate())", baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                harcananLbl.Text = Convert.ToString(dr["sum(harcanan)"]);


            }
           

          

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select * from malkontrol where santiye_idsantiye='" + santiyeCombo.SelectedValue + "' and malzemeler_idmalzemeler='" + malzemeCombo.SelectedValue + "' and year(tarih) = year(curdate())", baglanti);
            MySqlDataReader oku = komut.ExecuteReader();
            harcananListbox.Items.Clear();
            kalanListbox.Items.Clear();
            tarihListbox.Items.Clear();
            while (oku.Read())
            {
                harcananListbox.Items.Add(oku["harcanan"]);
                kalanListbox.Items.Add(oku["kalan"]);
                tarihListbox.Items.Add(oku["tarih"]);


            }

            baglanti.Close();
            baglanti.Open();

            MySqlCommand komuta = new MySqlCommand("select sum(harcanan) from malkontrol where year(tarih) = year(curdate())", baglanti);
            MySqlDataReader dr = komuta.ExecuteReader();
            while (dr.Read())
            {

                harcananLbl.Text = Convert.ToString(dr["sum(harcanan)"]);


            }
            baglanti.Close();

       

           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.kantarfis where tarihfisbugun Like'%" + dateTimePicker1.Text + "%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataSet ds = new DataSet();
                ds.Clear();
                da.Fill(ds, "ozkandb.kantarfis");
                dataGridView1.DataSource = ds.Tables["ozkandb.kantarfis"];
                da.Dispose();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata olutu");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("select tarihfisbugun from kantarfis", baglanti);
        }

        private void santiyeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.personel where santiye_idsantiye='"+santiyeCombobox.SelectedValue+"'";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataTable dt8 = new DataTable();
                da.Fill(dt8);
                dataGridView2.DataSource = dt8;
                baglanti.Close();


                
            }


            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
        }
    }
}
