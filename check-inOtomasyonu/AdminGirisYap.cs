using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_inOtomasyonu
{
    public partial class AdminGirisYap : Form
    {
        public AdminGirisYap()
        {
            InitializeComponent();
            label3.Text = "";
            if (VeriTabani.BaglantiKontrol()) 
            {
               
            }
            else
            {
                MessageBox.Show("Veritabanı Bağlantısı Kurulamadı");
            }

       
        }

    
        public string MD5_Sifrele(string Sifrelenecek_Deger) 
        {
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            byte[] ByteDizi = Encoding.UTF8.GetBytes(Sifrelenecek_Deger);

            //Dizinin Hash Değerinin Çıkarılması
            ByteDizi= MD5.ComputeHash(ByteDizi);   
            StringBuilder SBuilder = new StringBuilder();
            foreach (byte item in ByteDizi)
            {
                SBuilder.Append(item.ToString());
            }
           
            return SBuilder.ToString();
        }

        public string SHA256_Sifrele(string Sifrelenecek_Deger)
        {
            SHA256 SHA256 =SHA256.Create();
            //byte[] ByteDizi = SHA256.ComputeHash(Encoding.UTF8.GetBytes(Sifrelenecek_Deger));
            byte[] ByteDizi = Encoding.UTF8.GetBytes(Sifrelenecek_Deger);
            ByteDizi = SHA256.ComputeHash(ByteDizi);
            StringBuilder SBuilder = new StringBuilder();
            foreach (byte item in ByteDizi)
            {
                SBuilder.Append(item.ToString());
            }

            return SBuilder.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AdminGirisYap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        SqlConnection SQLConnect;
        SqlDataAdapter DA;
        SqlDataReader DR;
        DataSet DS;
        SqlCommand CMD;
        private void button1_Click(object sender, EventArgs e)
        {
            string SQLS = "select * from Calisanlar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre";
            SQLConnect = new SqlConnection(VeriTabani.SQLCon);   
            CMD =new SqlCommand(SQLS, SQLConnect);
            CMD.Parameters.AddWithValue("@KullaniciAdi",textBox1.Text);
            CMD.Parameters.AddWithValue("@Sifre",textBox2.Text);
            SQLConnect.Open();
            DR=CMD.ExecuteReader();
            if (DR.Read()) 
            {
                if (DR[8].ToString() == "1")
                {
                    label3.Text = "Giriş Başarılı";
                    AdminPanel PersonelPanel = new AdminPanel();
                    PersonelPanel.Show();
                    this.Hide();
                }
                else 
                {
                    label3.Text = "Giriş Başarılı";
                    AdminPanel PersonelPanel = new AdminPanel();
                    PersonelPanel.Show();
                    this.Hide();
                }
         
            }
            else 
            {
                label3.Text = "Kullanıcı Adı veya Sifre Hatalı";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
