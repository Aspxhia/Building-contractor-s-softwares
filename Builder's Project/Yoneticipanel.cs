using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder_s_Project
{
    public partial class Yoneticipanel : Form
    {
        public Yoneticipanel()
        {
            InitializeComponent();
        }

        private void finansalBtn_Click(object sender, EventArgs e)
        {
            finansalform finansalform = new finansalform();
            finansalform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            malzemeler maz = new malzemeler();
            maz.Show();
        }

        private void FirmaBtn_Click(object sender, EventArgs e)
        {
            Firmalar firmaform = new Firmalar();
            firmaform.Show();
        }

        private void personelBtn_Click(object sender, EventArgs e)
        {
            personel per = new personel();
            per.Show();
        }

        private void santiyebtn_Click(object sender, EventArgs e)
        {
            Santiyeler santiye = new Santiyeler();
            santiye.Show();
        }

        private void Yoneticipanel_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rapor rap = new rapor();
            rap.Show();
        }
    }
}
