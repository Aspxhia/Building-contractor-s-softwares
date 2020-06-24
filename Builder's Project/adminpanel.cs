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
    public partial class adminpanel : Form
    {


        public adminpanel()
        {
            InitializeComponent();
        }






        private void ekleBtn_Click(object sender, EventArgs e)
        {



            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
            baglanti.Open();

            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(Convert.ToString(((TextBox)ctl).Name + " boş!"));
                        
                    }


                    

                    else
                    {
                        
                        MySqlCommand komut2 = new MySqlCommand("insert into user (ad,pw) VALUES ('" + kAdTxt.Text + "','" + sifreTxt.Text + "')", baglanti);
                        komut2.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla ekledin eklediğin kullanıcı adı ->  " + kAdTxt.Text + "Sifre ->  " + sifreTxt.Text);
                        baglanti.Close();

                    }

                    
                }
        }

            
                        



                    

                

            

         



            
        

                
                           
                        



                    

                
            

        

    
















            

        private void silBtn_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut3 = new MySqlCommand("delete from ozkandb.user where ad = '" + kAdTxt.Text + "' or pw = '" + sifreTxt.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                MessageBox.Show("Başarıyla kullanıcıyı sildiniz");
                baglanti.Close();
            }


            catch(Exception ex)
            {

                MessageBox.Show("Hay Aksi! Bir hata meydana geldi");
            }







        }

        private void YoneticiEkleBtn_Click(object sender, EventArgs e)
        {
            



            
                        MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                        baglanti.Open();
            MySqlCommand komut3 = new MySqlCommand("insert into yetkili (kad,sifre) VALUES ('" + kAdTxt.Text + "','" + sifreTxt.Text + "')", baglanti);
            komut3.ExecuteNonQuery();
            MessageBox.Show("Başarıyla ekledin eklediğin yetkilinin kullanıcı adı ->  " + kAdTxt.Text + " ve Yetkilinin Sifresi ->  " + sifreTxt.Text);
             baglanti.Close();
                    

            



        }

            

        
        


        

        private void YoneticiSilBtn_Click(object sender, EventArgs e)
        {
            try
            {

                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut4 = new MySqlCommand("delete from ozkandb.yetkili where kad = '" + kAdTxt.Text + "' or sifre = '" + sifreTxt.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
                MessageBox.Show("Başarıyla yöneticiyi sildiniz");
                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay Aksi! Bir hata meydana geldi");
            }
        }

        private void veriCekBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                string sql = "SELECT * FROM ozkandb.user ";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                MySqlCommand cmd4 = new MySqlCommand("select idyetkili,kad,sifre from ozkandb.yetkili", baglanti);
                DataTable dt4 = new DataTable();
                MySqlDataReader oku4 = cmd4.ExecuteReader();
                dt4.Load(oku4);
                dataGridView2.DataSource = dt4;
                baglanti.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi bir hata oluştu");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminpanel_Load(object sender, EventArgs e)
        {

        }

        
    }
}
