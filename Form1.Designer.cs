
namespace kullaniciBilgileri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kaydet = new System.Windows.Forms.Button();
            this.kullanimKosullari = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FOTOSEC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kadın = new System.Windows.Forms.RadioButton();
            this.Erkek = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.sehir = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kaydedilenBilgilerGroupBox = new System.Windows.Forms.GroupBox();
            this.TcKayit = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İSİM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CİNSİYET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ŞEHİR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOĞUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresKayit = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dogumKayit = new System.Windows.Forms.Label();
            this.sehirKayit = new System.Windows.Forms.Label();
            this.cinsiyetKayit = new System.Windows.Forms.Label();
            this.soyadKayit = new System.Windows.Forms.Label();
            this.adKayit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.kaydedilenBilgilerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kaydet);
            this.groupBox1.Controls.Add(this.kullanimKosullari);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.FOTOSEC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.sehir);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ad);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(286, 699);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formu Doldurun";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kaydet
            // 
            this.kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(106, 641);
            this.kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(85, 25);
            this.kaydet.TabIndex = 17;
            this.kaydet.Text = "KAYDET";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // kullanimKosullari
            // 
            this.kullanimKosullari.Location = new System.Drawing.Point(44, 603);
            this.kullanimKosullari.Margin = new System.Windows.Forms.Padding(2);
            this.kullanimKosullari.Name = "kullanimKosullari";
            this.kullanimKosullari.Size = new System.Drawing.Size(195, 20);
            this.kullanimKosullari.TabIndex = 16;
            this.kullanimKosullari.Text = "Kullanım Koşullarını Kabul Edilyorum";
            this.kullanimKosullari.UseVisualStyleBackColor = true;
            this.kullanimKosullari.CheckedChanged += new System.EventHandler(this.kullanimKosullari_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(89, 470);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FOTOSEC
            // 
            this.FOTOSEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FOTOSEC.Location = new System.Drawing.Point(89, 427);
            this.FOTOSEC.Margin = new System.Windows.Forms.Padding(2);
            this.FOTOSEC.Name = "FOTOSEC";
            this.FOTOSEC.Size = new System.Drawing.Size(118, 22);
            this.FOTOSEC.TabIndex = 14;
            this.FOTOSEC.Text = "FOTO SEC";
            this.FOTOSEC.UseVisualStyleBackColor = true;
            this.FOTOSEC.Click += new System.EventHandler(this.FOTOSEC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 427);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "FOTO SEC : ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(89, 310);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.MaxLength = 200;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(151, 79);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ADRES : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kadın);
            this.groupBox2.Controls.Add(this.Erkek);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(29, 231);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(210, 57);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cinsiyet";
            // 
            // kadın
            // 
            this.kadın.Location = new System.Drawing.Point(106, 22);
            this.kadın.Margin = new System.Windows.Forms.Padding(2);
            this.kadın.Name = "kadın";
            this.kadın.Size = new System.Drawing.Size(72, 21);
            this.kadın.TabIndex = 11;
            this.kadın.TabStop = true;
            this.kadın.Text = "Kadın";
            this.kadın.UseVisualStyleBackColor = true;
            this.kadın.CheckedChanged += new System.EventHandler(this.kadın_CheckedChanged);
            // 
            // Erkek
            // 
            this.Erkek.Location = new System.Drawing.Point(15, 22);
            this.Erkek.Margin = new System.Windows.Forms.Padding(2);
            this.Erkek.Name = "Erkek";
            this.Erkek.Size = new System.Drawing.Size(72, 21);
            this.Erkek.TabIndex = 0;
            this.Erkek.TabStop = true;
            this.Erkek.Text = "Erkek";
            this.Erkek.UseVisualStyleBackColor = true;
            this.Erkek.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 192);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // sehir
            // 
            this.sehir.FormattingEnabled = true;
            this.sehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.sehir.Location = new System.Drawing.Point(89, 158);
            this.sehir.Margin = new System.Windows.Forms.Padding(2);
            this.sehir.Name = "sehir";
            this.sehir.Size = new System.Drawing.Size(86, 21);
            this.sehir.TabIndex = 8;
            this.sehir.SelectedIndexChanged += new System.EventHandler(this.sehir_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 126);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.MaxLength = 11;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 92);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MaxLength = 40;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 58);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(23, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DOGUM : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEHİR : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOYAD : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad.Location = new System.Drawing.Point(51, 58);
            this.ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(36, 13);
            this.ad.TabIndex = 0;
            this.ad.Text = "AD : ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kaydedilenBilgilerGroupBox
            // 
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.TcKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label13);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.dataGridView1);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.adresKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label18);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.dogumKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.sehirKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.cinsiyetKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.soyadKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.adKayit);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label7);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label8);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label9);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label10);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.label11);
            this.kaydedilenBilgilerGroupBox.Controls.Add(this.pictureBox2);
            this.kaydedilenBilgilerGroupBox.Location = new System.Drawing.Point(362, 28);
            this.kaydedilenBilgilerGroupBox.Name = "kaydedilenBilgilerGroupBox";
            this.kaydedilenBilgilerGroupBox.Size = new System.Drawing.Size(1002, 699);
            this.kaydedilenBilgilerGroupBox.TabIndex = 1;
            this.kaydedilenBilgilerGroupBox.TabStop = false;
            this.kaydedilenBilgilerGroupBox.Text = "Kaydedilen Bilgiler";
            this.kaydedilenBilgilerGroupBox.Enter += new System.EventHandler(this.kaydedilenBilgilerGroupBox_Enter);
            // 
            // TcKayit
            // 
            this.TcKayit.Location = new System.Drawing.Point(81, 190);
            this.TcKayit.Name = "TcKayit";
            this.TcKayit.Size = new System.Drawing.Size(95, 15);
            this.TcKayit.TabIndex = 34;
            this.TcKayit.Text = "TC";
            this.TcKayit.Click += new System.EventHandler(this.TcKayit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(41, 190);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "TC : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.İSİM,
            this.SOYAD,
            this.CİNSİYET,
            this.ŞEHİR,
            this.DOĞUM,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(234, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 610);
            this.dataGridView1.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TC";
            this.Column1.Name = "Column1";
            // 
            // İSİM
            // 
            this.İSİM.HeaderText = "İSİM";
            this.İSİM.Name = "İSİM";
            // 
            // SOYAD
            // 
            this.SOYAD.HeaderText = "SOYAD";
            this.SOYAD.Name = "SOYAD";
            // 
            // CİNSİYET
            // 
            this.CİNSİYET.HeaderText = "CİNSİYET";
            this.CİNSİYET.Name = "CİNSİYET";
            // 
            // ŞEHİR
            // 
            this.ŞEHİR.HeaderText = "ŞEHİR";
            this.ŞEHİR.Name = "ŞEHİR";
            // 
            // DOĞUM
            // 
            this.DOĞUM.HeaderText = "DOĞUM";
            this.DOĞUM.Name = "DOĞUM";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ADRES";
            this.Column2.Name = "Column2";
            // 
            // adresKayit
            // 
            this.adresKayit.Location = new System.Drawing.Point(81, 386);
            this.adresKayit.Name = "adresKayit";
            this.adresKayit.Size = new System.Drawing.Size(95, 15);
            this.adresKayit.TabIndex = 31;
            this.adresKayit.Text = "ADRES";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(16, 386);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "ADRES : ";
            // 
            // dogumKayit
            // 
            this.dogumKayit.Location = new System.Drawing.Point(82, 353);
            this.dogumKayit.Name = "dogumKayit";
            this.dogumKayit.Size = new System.Drawing.Size(95, 15);
            this.dogumKayit.TabIndex = 28;
            this.dogumKayit.Text = "DOGUM";
            // 
            // sehirKayit
            // 
            this.sehirKayit.Location = new System.Drawing.Point(82, 320);
            this.sehirKayit.Name = "sehirKayit";
            this.sehirKayit.Size = new System.Drawing.Size(95, 15);
            this.sehirKayit.TabIndex = 27;
            this.sehirKayit.Text = "SEHİR";
            // 
            // cinsiyetKayit
            // 
            this.cinsiyetKayit.Location = new System.Drawing.Point(82, 287);
            this.cinsiyetKayit.Name = "cinsiyetKayit";
            this.cinsiyetKayit.Size = new System.Drawing.Size(95, 15);
            this.cinsiyetKayit.TabIndex = 26;
            this.cinsiyetKayit.Text = "CİNSİYET";
            // 
            // soyadKayit
            // 
            this.soyadKayit.Location = new System.Drawing.Point(82, 253);
            this.soyadKayit.Name = "soyadKayit";
            this.soyadKayit.Size = new System.Drawing.Size(95, 15);
            this.soyadKayit.TabIndex = 25;
            this.soyadKayit.Text = "SOYAD";
            // 
            // adKayit
            // 
            this.adKayit.Location = new System.Drawing.Point(82, 219);
            this.adKayit.Name = "adKayit";
            this.adKayit.Size = new System.Drawing.Size(95, 15);
            this.adKayit.TabIndex = 24;
            this.adKayit.Text = "AD";
            this.adKayit.Click += new System.EventHandler(this.adKayit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 353);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "DOGUM : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(21, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "SEHİR : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "CİNSİYET : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(16, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "SOYAD : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(40, 219);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "AD : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(34, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 751);
            this.Controls.Add(this.kaydedilenBilgilerGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.kaydedilenBilgilerGroupBox.ResumeLayout(false);
            this.kaydedilenBilgilerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ad;
        private System.Windows.Forms.RadioButton Erkek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox sehir;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton kadın;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.CheckBox kullanimKosullari;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FOTOSEC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox kaydedilenBilgilerGroupBox;
        private System.Windows.Forms.Label dogumKayit;
        private System.Windows.Forms.Label sehirKayit;
        private System.Windows.Forms.Label cinsiyetKayit;
        private System.Windows.Forms.Label soyadKayit;
        private System.Windows.Forms.Label adKayit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label adresKayit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label TcKayit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn İSİM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CİNSİYET;
        private System.Windows.Forms.DataGridViewTextBoxColumn ŞEHİR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOĞUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

