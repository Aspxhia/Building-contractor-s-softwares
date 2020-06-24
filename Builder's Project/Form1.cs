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
using MySql.Data;

namespace Builder_s_Project
{
    public partial class Form1 : Form
    {

        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
           

        }

        private void GirBtn_Click(object sender, EventArgs e)
        {
            string kullanici, sifre;

            kullanici = kAdTxt.Text;
            sifre = sifreTxt.Text;


                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM user WHERE ad='" + kAdTxt.Text + "' and pw='" + sifreTxt.Text + "'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    this.Hide();
                    userpanel panel2 = new userpanel();
                    panel2.Show();

                }




                else if (kullanici == "admin" && sifre == "admin")
                {
                    adminpanel panel = new adminpanel();
                    panel.Show();
                    this.Hide();
                }



                else
                {

                    MessageBox.Show("Kulanici adi veya şifre yanlış");
                }

                baglanti.Close();
            }
            
        private void yntcGir_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM yetkili WHERE kad='" + kAdTxt.Text + "' and sifre='" + sifreTxt.Text + "'", baglanti);
                MySqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    this.Hide();
                    Yoneticipanel panelyonetici = new Yoneticipanel();
                    panelyonetici.Show();

                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
        }

    }
}
