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
    public partial class Biletler : Form
    {   
        public Biletler()
        {
            InitializeComponent();
        
            if (VeriTabani.BaglantiKontrol())
            {
                
            }
            else
            {
                MessageBox.Show("Veritabanı Bağlantısı Kurulamadı");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static string bilgi = "";
       
  
        private void DGVBiletler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       




            //dateTimePicker_B.Text = DGVBiletler.CurrentRow.Cells[2].Value.ToString(); Tarih Bilgisi Girilmesi Gerek




        }

        private void Biletler_Load(object sender, EventArgs e)
        {
            //String SQLS = "Select * from Calisanlar";
            //VeriTabani.DGV(DGVBiletler,SQLS);
            VeriTabani.DGV(DGVdeneme,"Select UcusNo,HavalimaniBinisYeri,HavalimaniKalkisYeri,UcusTarih,BinisSaat,KalkisSaat,TahminiUcusSaat from Ucus");
            //DGV Column görünürlüğü ayarlama
            //DGVBiletler.Columns[0].Visible=false;
            DGVdeneme.Columns[0].HeaderText = "Uçuş No";
      
            DGVdeneme.Columns[1].HeaderText = "Nereden";
         
            DGVdeneme.Columns[2].HeaderText = "Nereye";
          
            DGVdeneme.Columns[3].HeaderText = "Tarih";
       
            DGVdeneme.Columns[4].HeaderText = "Kalkış";
         
            DGVdeneme.Columns[5].HeaderText = "Varış";
         
            DGVdeneme.Columns[6].HeaderText = "Uçuş Süresi";
    
            //DGVBiletler.Columns[1].HeaderText="Başlık Değiştirme"; 
            //DGVBiletler.Columns[1].HeaderCell.Value="Başlık Değiştirme2";
            //DGVBiletler.Columns[1].Width=100; Genişlik Ayarlama
            /*
             string[] satir=new string[]
            {
                "","","",""    Veritabanı Bağlantısından Sonra Kullanılabilir, DGV'ye Veri Ekler
            };
            DGV.Rows.Add(satir);
             */




        }
        
        private void button_Ekle_Click(object sender, EventArgs e)
        {
            String SQLS = "Update Koltuklar set KoltukSıra='" + comboBox1.Text.ToString() + "' ";
            VeriTabani.DGV(DGVBiletler, SQLS);

            //bilgi = DGVBiletler.CurrentRow.Cells[1].Value.ToString();


            //label4.Text = Biletler.bilgi.ToString();


            /* DataGridViewTextBoxColumn columnekle = new DataGridViewTextBoxColumn();
             columnekle.HeaderText = "ID";
             DGVdeneme.Columns.Add(columnekle);

             DGVdeneme.Rows.Add(label4.Text);
             DGVdeneme.Rows.Add("123");
             DGVdeneme.Rows.Add("Text");
            */


        }

        private void button_BiletGetir_Click(object sender, EventArgs e)
        {
            String SQLS = "select Yolcu.Ad,Yolcu.Soyad,Yolcu.TCKN,Ucus.UcusNo,Bilet.BiletNo,Bilet.TerminalNo,Bilet.KoltukSınıf,Koltuklar.KoltukSıra,Bilet.Bagaj from Yolcu inner join Bilet on Yolcu.BiletID=Bilet.BiletID inner join Ucus on Ucus.UcusID=Bilet.UcusID inner join Koltuklar on Koltuklar.KoltukID=Ucus.KoltukID where Ucus.UcusNo='" + DGVdeneme.CurrentRow.Cells[0].Value.ToString() + "'";
            VeriTabani.DGV(DGVBiletler,SQLS);
        }

        private void button_BagajEkle_Click(object sender, EventArgs e)
        {

            String SQLS = "Update Bilet set Bagaj='" + textBox1.Text.ToString()+ "'";
            VeriTabani.DGV(DGVBiletler, SQLS);




            MessageBox.Show(label6.Text);
           
            /* String numeric = (numericUpDown_Bagaj.Value.ToString());

             numeric = DGVBiletler.CurrentRow.Cells[9].ToString();
             //String numeric=numericUpDown_Bagaj.Value.ToString();
           */

        }

        private void DGVB_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
          string label= DGVBiletler.CurrentRow.Cells[8].Value.ToString();
            String Sınıf = comboBox_KoltukTur.SelectedIndex.ToString();
            Sınıf = DGVBiletler.CurrentRow.Cells[1].Value.ToString();
            //String Koltuk = comboBox1.Text.ToString();
            //Koltuk = comboBox1.SelectedIndex.ToString();
            label6.Text = label;
            textBox1.Text= label6.Text;
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            String SQLS = "select Yolcu.Ad,Yolcu.Soyad,Yolcu.TCKN,Ucus.UcusNo,Bilet.BiletNo,Bilet.TerminalNo,Bilet.KoltukSınıf,Koltuklar.KoltukSıra,Bilet.Bagaj from Yolcu inner join Bilet on Yolcu.BiletID=Bilet.BiletID inner join Ucus on Ucus.UcusID=Bilet.UcusID inner join Koltuklar on Koltuklar.KoltukID=Ucus.KoltukID where Ucus.UcusNo='" + DGVdeneme.CurrentRow.Cells[0].Value.ToString() + "'";
            VeriTabani.DGV(DGVBiletler, SQLS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SQLS = "Update Bilet set KoltukSınıf='" + comboBox_KoltukTur.SelectedItem.ToString() + "' where BiletNo='" + DGVBiletler.CurrentRow.Cells[4].Value.ToString() + "'";
            //String SQLS = "Update Bilet set KoltukSınıf='" + comboBox_KoltukTur.SelectedItem.ToString() + "',KoltukNo='" + comboBox1.SelectedItem.ToString() +  "' from Bilet join Koltuklar on Biletler.KoltukNo where BiletNo='"+ DGVBiletler.CurrentRow.Cells[4].Value.ToString() + "'";
            VeriTabani.DGV(DGVBiletler, SQLS);
        }

        private void comboBox_BHavalimani_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
