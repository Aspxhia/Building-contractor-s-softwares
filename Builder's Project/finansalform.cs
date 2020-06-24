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
    public partial class finansalform : Form
    {
        public finansalform()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM ozkandb.finansal", baglanti);
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
            }

            catch (Exception ex)
            {

                MessageBox.Show("Hay aksi! Bir hata oluştu");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = true;

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked && !checkBox2.Checked)
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("INSERT INTO ozkandb.finansal (aciklama,borc,tarih) VALUES ('" + aciklamaTxt.Text + "','" + miktarTxt.Text + "','"+dateTimePicker1.Text+"')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla Kayıtı eklediniz");
                }

                else if (!checkBox1.Checked && checkBox2.Checked)
                {
                    MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                    baglanti.Open();
                    MySqlCommand komut = new MySqlCommand("INSERT INTO ozkandb.finansal (aciklama,alacak,tarih) VALUES ('" + aciklamaTxt.Text + "','" + miktarTxt.Text + "','"+dateTimePicker1.Text+"')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Başarıyla Kayıtı eklediniz");

                }

                
                
                
            }

            catch(Exception ex)
            {
                MessageBox.Show("Hay Aksi! Bir hata oluştu");
                

            }
        }

        private void gizleBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void finansalSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3;Database=ozkandb;Uid=tugkanozkan;Pwd='ozkan123';");
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand("DELETE FROM finansal WHERE idfinansal = (SELECT max_fin FROM(SELECT MAX(idfinansal) AS max_fin FROM finansal) x);", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
            }

            catch (Exception ex)
            {


                MessageBox.Show("Hay aksi! Bir hata oluştu");

            }
        }



                


        
       

        private void finansalform_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox2.Checked = false;

            }

            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if(checkBox2.Checked)
            {

                checkBox1.Checked = false;
            }
        }
    }
}
