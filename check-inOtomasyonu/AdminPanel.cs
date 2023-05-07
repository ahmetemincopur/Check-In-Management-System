using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_inOtomasyonu
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
           
            
        }


        public void FormGetir(Form frm) 
        {

           frm.MdiParent =this;
            
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biletler biletler = new Biletler();
            FormGetir(biletler);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
