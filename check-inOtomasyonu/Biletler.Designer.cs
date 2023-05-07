namespace check_inOtomasyonu
{
    partial class Biletler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVBiletler = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_KoltukTur = new System.Windows.Forms.ComboBox();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_BagajEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_BHavalimani = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_VHavalimani = new System.Windows.Forms.ComboBox();
            this.button_BiletGetir = new System.Windows.Forms.Button();
            this.dateTimePicker_B = new System.Windows.Forms.DateTimePicker();
            this.button_UcusBul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVdeneme = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_S = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiletler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeneme)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVBiletler
            // 
            this.DGVBiletler.BackgroundColor = System.Drawing.Color.Snow;
            this.DGVBiletler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBiletler.Location = new System.Drawing.Point(327, 165);
            this.DGVBiletler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVBiletler.Name = "DGVBiletler";
            this.DGVBiletler.RowHeadersWidth = 51;
            this.DGVBiletler.RowTemplate.Height = 24;
            this.DGVBiletler.Size = new System.Drawing.Size(1059, 807);
            this.DGVBiletler.TabIndex = 0;
            this.DGVBiletler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVB_CellClick);
            this.DGVBiletler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBiletler_CellContentClick);
            this.DGVBiletler.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBiletler_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1A",
            "2A",
            "3A"});
            this.comboBox1.Location = new System.Drawing.Point(993, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(905, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koltuk Seç:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(613, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koltuk Türü Seç:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox_KoltukTur
            // 
            this.comboBox_KoltukTur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_KoltukTur.FormattingEnabled = true;
            this.comboBox_KoltukTur.Items.AddRange(new object[] {
            "Business",
            "Ekonomi"});
            this.comboBox_KoltukTur.Location = new System.Drawing.Point(734, 31);
            this.comboBox_KoltukTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_KoltukTur.Name = "comboBox_KoltukTur";
            this.comboBox_KoltukTur.Size = new System.Drawing.Size(121, 24);
            this.comboBox_KoltukTur.TabIndex = 3;
            this.comboBox_KoltukTur.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.FloralWhite;
            this.button_Ekle.Location = new System.Drawing.Point(1020, 64);
            this.button_Ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(75, 27);
            this.button_Ekle.TabIndex = 5;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.FloralWhite;
            this.button_Guncelle.Location = new System.Drawing.Point(993, 110);
            this.button_Guncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(107, 34);
            this.button_Guncelle.TabIndex = 6;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = false;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_BagajEkle
            // 
            this.button_BagajEkle.Location = new System.Drawing.Point(1240, 62);
            this.button_BagajEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BagajEkle.Name = "button_BagajEkle";
            this.button_BagajEkle.Size = new System.Drawing.Size(121, 27);
            this.button_BagajEkle.TabIndex = 8;
            this.button_BagajEkle.Text = "Bagaj Ekle";
            this.button_BagajEkle.UseVisualStyleBackColor = true;
            this.button_BagajEkle.Click += new System.EventHandler(this.button_BagajEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label5.Location = new System.Drawing.Point(109, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Uçuş Başlangıç Havalimanı";
            // 
            // comboBox_BHavalimani
            // 
            this.comboBox_BHavalimani.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_BHavalimani.FormattingEnabled = true;
            this.comboBox_BHavalimani.Items.AddRange(new object[] {
            "İstanbul",
            "Hatay"});
            this.comboBox_BHavalimani.Location = new System.Drawing.Point(131, 69);
            this.comboBox_BHavalimani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BHavalimani.Name = "comboBox_BHavalimani";
            this.comboBox_BHavalimani.Size = new System.Drawing.Size(121, 24);
            this.comboBox_BHavalimani.TabIndex = 37;
            this.comboBox_BHavalimani.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_BHavalimani_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label4.Location = new System.Drawing.Point(128, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Varılacak Havalimanı";
            // 
            // comboBox_VHavalimani
            // 
            this.comboBox_VHavalimani.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_VHavalimani.FormattingEnabled = true;
            this.comboBox_VHavalimani.Location = new System.Drawing.Point(131, 126);
            this.comboBox_VHavalimani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_VHavalimani.Name = "comboBox_VHavalimani";
            this.comboBox_VHavalimani.Size = new System.Drawing.Size(121, 24);
            this.comboBox_VHavalimani.TabIndex = 35;
            // 
            // button_BiletGetir
            // 
            this.button_BiletGetir.BackColor = System.Drawing.Color.FloralWhite;
            this.button_BiletGetir.Location = new System.Drawing.Point(487, 122);
            this.button_BiletGetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BiletGetir.Name = "button_BiletGetir";
            this.button_BiletGetir.Size = new System.Drawing.Size(116, 27);
            this.button_BiletGetir.TabIndex = 34;
            this.button_BiletGetir.Text = "Biletleri Getir";
            this.button_BiletGetir.UseVisualStyleBackColor = false;
            this.button_BiletGetir.Click += new System.EventHandler(this.button_BiletGetir_Click);
            // 
            // dateTimePicker_B
            // 
            this.dateTimePicker_B.Location = new System.Drawing.Point(384, 48);
            this.dateTimePicker_B.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_B.Name = "dateTimePicker_B";
            this.dateTimePicker_B.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_B.TabIndex = 33;
            // 
            // button_UcusBul
            // 
            this.button_UcusBul.BackColor = System.Drawing.Color.FloralWhite;
            this.button_UcusBul.Location = new System.Drawing.Point(375, 122);
            this.button_UcusBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UcusBul.Name = "button_UcusBul";
            this.button_UcusBul.Size = new System.Drawing.Size(93, 27);
            this.button_UcusBul.TabIndex = 32;
            this.button_UcusBul.Text = "Uçuş Bul";
            this.button_UcusBul.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Location = new System.Drawing.Point(282, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Sefer Seç";
            // 
            // DGVdeneme
            // 
            this.DGVdeneme.BackgroundColor = System.Drawing.Color.Snow;
            this.DGVdeneme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdeneme.Location = new System.Drawing.Point(9, 175);
            this.DGVdeneme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVdeneme.Name = "DGVdeneme";
            this.DGVdeneme.RowHeadersWidth = 51;
            this.DGVdeneme.RowTemplate.Height = 24;
            this.DGVdeneme.Size = new System.Drawing.Size(190, 807);
            this.DGVdeneme.TabIndex = 30;
            // 
            // dateTimePicker_S
            // 
            this.dateTimePicker_S.Location = new System.Drawing.Point(384, 85);
            this.dateTimePicker_S.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_S.Name = "dateTimePicker_S";
            this.dateTimePicker_S.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker_S.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label7.Location = new System.Drawing.Point(1172, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Bagaj:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1117, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1229, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 42;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(764, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 43;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Biletler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1906, 993);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_BHavalimani);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_VHavalimani);
            this.Controls.Add(this.button_BiletGetir);
            this.Controls.Add(this.dateTimePicker_B);
            this.Controls.Add(this.button_UcusBul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGVdeneme);
            this.Controls.Add(this.dateTimePicker_S);
            this.Controls.Add(this.button_BagajEkle);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.button_Ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_KoltukTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DGVBiletler);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Biletler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Biletler";
            this.Load += new System.EventHandler(this.Biletler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBiletler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdeneme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_KoltukTur;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_BagajEkle;
        public System.Windows.Forms.DataGridView DGVBiletler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_BHavalimani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_VHavalimani;
        private System.Windows.Forms.Button button_BiletGetir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_B;
        private System.Windows.Forms.Button button_UcusBul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVdeneme;
        private System.Windows.Forms.DateTimePicker dateTimePicker_S;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}