using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace kullaniciBilgileri
{


    public partial class Form1 : Form
    {
        string isim,soyisim, adres, il,cinsiyet;
        long TC;
        DateTime dogumTarihi;
        OpenFileDialog file = new OpenFileDialog();
        string dosyaYolu, dosyaAdi;

        public bool sayiMi(string a)
        {
            bool sonuc = true;
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]))
                {
                    sonuc = false;      //Eğer karakter sayı değilse false döner
                }
            }

            return sonuc;
        }


        public Form1()
        {
            InitializeComponent();
            adKayit.Text = "";
            soyadKayit.Text = "";
            cinsiyetKayit.Text = "";
            sehirKayit.Text = "";
            dogumKayit.Text = "";
            adresKayit.Text = "";
            TcKayit.Text = "";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Erkek";
        }

        private void sehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            il = sehir.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   //AD
        {

            isim = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //SOYAD
        {
            
            soyisim = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dogumTarihi = dateTimePicker1.Value;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            adres = richTextBox1.Text;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;

            }
        }

        private void kadın_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "Kadın";
        }

        private void FOTOSEC_Click(object sender, EventArgs e)
        {
            file.InitialDirectory = "C:\\Users\\resul\\Desktop";
            file.Filter = "Jpg Dosyası |*.jpg| Png Dosyası|*.png";
            file.ShowDialog();
            dosyaYolu = file.FileName;
            dosyaAdi = file.SafeFileName;
            pictureBox1.ImageLocation = dosyaYolu;
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
            if (sayiMi(isim) == false)
            {
                MessageBox.Show("Ad içerisinde sayi olamaz");

            }

            else if (sayiMi(soyisim) == false)
            {
                MessageBox.Show("Soyad içerisinde sayi olamaz");

            }

            else if (cinsiyet != "Erkek" && cinsiyet != "Kadın")
            {
                MessageBox.Show("Cinsiyet seciniz");
            }

            else if (richTextBox1.Text == "")
            {
                MessageBox.Show("Adres bos olamaz");
            }

            else if (textBox3.Text == "")
            {
                MessageBox.Show("TC bos olamaz");
            }

            else if (textBox3.TextLength != 11)
            {
                MessageBox.Show("11 haneli degil");
            }

            else if (sehir.Text == "")
            {
                MessageBox.Show("Sehir bos olamaz");
            }

            else if (file.FileName == "" || file.SafeFileName == "")
            {
                MessageBox.Show("Fotograf seciniz");
            }

            else if (kullanimKosullari.Checked == false)
            {
                MessageBox.Show("Kullanım kosullarını kabul etmediniz");
            }

            else
            {

                if (textBox3.TextLength == 11)
                {
                    TC = (long)Convert.ToDouble(textBox3.Text);

                    adKayit.Text = isim;
                    soyadKayit.Text = soyisim;
                    cinsiyetKayit.Text = cinsiyet;
                    sehirKayit.Text = il;
                    dogumKayit.Text = dogumTarihi.ToString("dd/MM/yyyy");
                    adresKayit.Text = adres;
                    TcKayit.Text = Convert.ToString(TC);
                    pictureBox2.ImageLocation = dosyaYolu;

                    dataGridView1.Rows.Add(TcKayit.Text,adKayit.Text, soyadKayit.Text, cinsiyetKayit.Text, sehirKayit.Text, dogumKayit.Text, adresKayit.Text);

                    textBox1.Text = "";         //adın içini bosaltma
                    textBox2.Text = "";         //soyadın içini bosaltma
                    Erkek.Checked = false;
                    kadın.Checked = false;
                    sehir.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    richTextBox1.Text = "";     //adresin içini bosaltma
                    textBox3.Text = "";         //TC içini bosaltma
                    pictureBox1.Image = null;

                    kullanimKosullari.Checked = false;


                }

            }

             
        }
    }
}
