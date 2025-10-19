namespace FinansalCRM
{
    partial class FrmBankaHaraketleri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankaHaraketleri));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBankalar = new System.Windows.Forms.Button();
            this.btnCıkısYap = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnHarcamalar = new System.Windows.Forms.Button();
            this.btnGelirGider = new System.Windows.Forms.Button();
            this.btnBankaHaraketleri = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTariheGöre = new System.Windows.Forms.Button();
            this.cmbTariheGöre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBankayaGöre = new System.Windows.Forms.Button();
            this.cmbBankaBilgisi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbİslemTürü = new System.Windows.Forms.ComboBox();
            this.btnİslemTürüneGöre = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIslemTutar = new System.Windows.Forms.TextBox();
            this.lblHarcamaTutarı = new System.Windows.Forms.Label();
            this.txtIslemTitle = new System.Windows.Forms.TextBox();
            this.txtIslemID = new System.Windows.Forms.TextBox();
            this.lblHarcamaName = new System.Windows.Forms.Label();
            this.lblHarcamaId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(870, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 20);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(763, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(763, 35);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 20);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnBankalar);
            this.panel2.Controls.Add(this.btnCıkısYap);
            this.panel2.Controls.Add(this.btnİstatistik);
            this.panel2.Controls.Add(this.btnHarcamalar);
            this.panel2.Controls.Add(this.btnGelirGider);
            this.panel2.Controls.Add(this.btnBankaHaraketleri);
            this.panel2.Controls.Add(this.btnKategoriler);
            this.panel2.Location = new System.Drawing.Point(-2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 697);
            this.panel2.TabIndex = 26;
            // 
            // btnBankalar
            // 
            this.btnBankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBankalar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankalar.ForeColor = System.Drawing.Color.White;
            this.btnBankalar.Location = new System.Drawing.Point(14, 226);
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.Size = new System.Drawing.Size(174, 40);
            this.btnBankalar.TabIndex = 16;
            this.btnBankalar.Text = "Bankalar";
            this.btnBankalar.UseVisualStyleBackColor = false;
            this.btnBankalar.Click += new System.EventHandler(this.btnBankalar_Click);
            // 
            // btnCıkısYap
            // 
            this.btnCıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCıkısYap.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCıkısYap.ForeColor = System.Drawing.Color.White;
            this.btnCıkısYap.Location = new System.Drawing.Point(14, 546);
            this.btnCıkısYap.Name = "btnCıkısYap";
            this.btnCıkısYap.Size = new System.Drawing.Size(174, 40);
            this.btnCıkısYap.TabIndex = 15;
            this.btnCıkısYap.Text = "Çıkış Yap";
            this.btnCıkısYap.UseVisualStyleBackColor = false;
            this.btnCıkısYap.Click += new System.EventHandler(this.btnCıkısYap_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnİstatistik.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİstatistik.ForeColor = System.Drawing.Color.White;
            this.btnİstatistik.Location = new System.Drawing.Point(14, 482);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(174, 40);
            this.btnİstatistik.TabIndex = 14;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = false;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnHarcamalar
            // 
            this.btnHarcamalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHarcamalar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarcamalar.ForeColor = System.Drawing.Color.White;
            this.btnHarcamalar.Location = new System.Drawing.Point(14, 290);
            this.btnHarcamalar.Name = "btnHarcamalar";
            this.btnHarcamalar.Size = new System.Drawing.Size(174, 40);
            this.btnHarcamalar.TabIndex = 13;
            this.btnHarcamalar.Text = "Harcamalar";
            this.btnHarcamalar.UseVisualStyleBackColor = false;
            this.btnHarcamalar.Click += new System.EventHandler(this.btnHarcamalar_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnGelirGider.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirGider.ForeColor = System.Drawing.Color.White;
            this.btnGelirGider.Location = new System.Drawing.Point(14, 354);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(174, 40);
            this.btnGelirGider.TabIndex = 12;
            this.btnGelirGider.Text = "Gelirler / Giderler";
            this.btnGelirGider.UseVisualStyleBackColor = false;
            this.btnGelirGider.Click += new System.EventHandler(this.btnGelirGider_Click);
            // 
            // btnBankaHaraketleri
            // 
            this.btnBankaHaraketleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBankaHaraketleri.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankaHaraketleri.ForeColor = System.Drawing.Color.White;
            this.btnBankaHaraketleri.Location = new System.Drawing.Point(14, 418);
            this.btnBankaHaraketleri.Name = "btnBankaHaraketleri";
            this.btnBankaHaraketleri.Size = new System.Drawing.Size(174, 40);
            this.btnBankaHaraketleri.TabIndex = 11;
            this.btnBankaHaraketleri.Text = "Banka Haraketleri";
            this.btnBankaHaraketleri.UseVisualStyleBackColor = false;
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnKategoriler.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(14, 162);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(174, 40);
            this.btnKategoriler.TabIndex = 10;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Location = new System.Drawing.Point(198, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 86);
            this.panel1.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(177)))), ((int)(((byte)(159)))));
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btnListele);
            this.panel3.Controls.Add(this.btnSil);
            this.panel3.Controls.Add(this.btnEkle);
            this.panel3.Controls.Add(this.btnGüncelle);
            this.panel3.Controls.Add(this.dtDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtIslemTutar);
            this.panel3.Controls.Add(this.lblHarcamaTutarı);
            this.panel3.Controls.Add(this.txtIslemTitle);
            this.panel3.Controls.Add(this.txtIslemID);
            this.panel3.Controls.Add(this.lblHarcamaName);
            this.panel3.Controls.Add(this.lblHarcamaId);
            this.panel3.Location = new System.Drawing.Point(198, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1052, 292);
            this.panel3.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTariheGöre);
            this.groupBox2.Controls.Add(this.cmbTariheGöre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBankayaGöre);
            this.groupBox2.Controls.Add(this.cmbBankaBilgisi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbİslemTürü);
            this.groupBox2.Controls.Add(this.btnİslemTürüneGöre);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(384, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 159);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtreleme İşlemleri";
            // 
            // btnTariheGöre
            // 
            this.btnTariheGöre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnTariheGöre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnTariheGöre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnTariheGöre.Location = new System.Drawing.Point(403, 21);
            this.btnTariheGöre.Name = "btnTariheGöre";
            this.btnTariheGöre.Size = new System.Drawing.Size(253, 28);
            this.btnTariheGöre.TabIndex = 31;
            this.btnTariheGöre.Text = "Tarihe Göre Getir";
            this.btnTariheGöre.UseVisualStyleBackColor = false;
            this.btnTariheGöre.Click += new System.EventHandler(this.btnTariheGöre_Click);
            // 
            // cmbTariheGöre
            // 
            this.cmbTariheGöre.BackColor = System.Drawing.Color.Cornsilk;
            this.cmbTariheGöre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTariheGöre.FormattingEnabled = true;
            this.cmbTariheGöre.Items.AddRange(new object[] {
            "Son 5 Gün",
            "Son 1 Ay",
            "Son 2 Ay",
            "Son 3 Yıl",
            "Son 5 Yıl",
            "Tüm Kayıtlar"});
            this.cmbTariheGöre.Location = new System.Drawing.Point(194, 21);
            this.cmbTariheGöre.Name = "cmbTariheGöre";
            this.cmbTariheGöre.Size = new System.Drawing.Size(184, 28);
            this.cmbTariheGöre.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tarihe Göre Getir :";
            // 
            // btnBankayaGöre
            // 
            this.btnBankayaGöre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnBankayaGöre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnBankayaGöre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnBankayaGöre.Location = new System.Drawing.Point(403, 106);
            this.btnBankayaGöre.Name = "btnBankayaGöre";
            this.btnBankayaGöre.Size = new System.Drawing.Size(253, 28);
            this.btnBankayaGöre.TabIndex = 19;
            this.btnBankayaGöre.Text = "Bankaya Göre Getir";
            this.btnBankayaGöre.UseVisualStyleBackColor = false;
            this.btnBankayaGöre.Click += new System.EventHandler(this.btnBankayaGöre_Click);
            // 
            // cmbBankaBilgisi
            // 
            this.cmbBankaBilgisi.BackColor = System.Drawing.Color.Cornsilk;
            this.cmbBankaBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbBankaBilgisi.FormattingEnabled = true;
            this.cmbBankaBilgisi.Location = new System.Drawing.Point(194, 106);
            this.cmbBankaBilgisi.Name = "cmbBankaBilgisi";
            this.cmbBankaBilgisi.Size = new System.Drawing.Size(184, 28);
            this.cmbBankaBilgisi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Banka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "İşlem Türü :";
            // 
            // cmbİslemTürü
            // 
            this.cmbİslemTürü.BackColor = System.Drawing.Color.Cornsilk;
            this.cmbİslemTürü.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbİslemTürü.FormattingEnabled = true;
            this.cmbİslemTürü.Items.AddRange(new object[] {
            "Gelen Havale",
            "Giden Havale"});
            this.cmbİslemTürü.Location = new System.Drawing.Point(194, 67);
            this.cmbİslemTürü.Name = "cmbİslemTürü";
            this.cmbİslemTürü.Size = new System.Drawing.Size(184, 28);
            this.cmbİslemTürü.TabIndex = 17;
            // 
            // btnİslemTürüneGöre
            // 
            this.btnİslemTürüneGöre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnİslemTürüneGöre.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnİslemTürüneGöre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnİslemTürüneGöre.Location = new System.Drawing.Point(403, 66);
            this.btnİslemTürüneGöre.Name = "btnİslemTürüneGöre";
            this.btnİslemTürüneGöre.Size = new System.Drawing.Size(253, 28);
            this.btnİslemTürüneGöre.TabIndex = 18;
            this.btnİslemTürüneGöre.Text = "İşlem Türüne Göre Getir";
            this.btnİslemTürüneGöre.UseVisualStyleBackColor = false;
            this.btnİslemTürüneGöre.Click += new System.EventHandler(this.btnİslemTürüneGöre_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnListele.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnListele.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnListele.Location = new System.Drawing.Point(9, 191);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(140, 36);
            this.btnListele.TabIndex = 21;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnSil.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnSil.Location = new System.Drawing.Point(162, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(137, 37);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnEkle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnEkle.Location = new System.Drawing.Point(9, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 36);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(236)))), ((int)(((byte)(219)))));
            this.btnGüncelle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.btnGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnGüncelle.Location = new System.Drawing.Point(162, 190);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(137, 36);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dtDate
            // 
            this.dtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(162, 101);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(216, 26);
            this.dtDate.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(5, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "İşlem Tarihi :";
            // 
            // txtIslemTutar
            // 
            this.txtIslemTutar.BackColor = System.Drawing.Color.Cornsilk;
            this.txtIslemTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemTutar.Location = new System.Drawing.Point(162, 148);
            this.txtIslemTutar.Name = "txtIslemTutar";
            this.txtIslemTutar.Size = new System.Drawing.Size(216, 26);
            this.txtIslemTutar.TabIndex = 13;
            // 
            // lblHarcamaTutarı
            // 
            this.lblHarcamaTutarı.AutoSize = true;
            this.lblHarcamaTutarı.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarcamaTutarı.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHarcamaTutarı.Location = new System.Drawing.Point(5, 151);
            this.lblHarcamaTutarı.Name = "lblHarcamaTutarı";
            this.lblHarcamaTutarı.Size = new System.Drawing.Size(136, 20);
            this.lblHarcamaTutarı.TabIndex = 12;
            this.lblHarcamaTutarı.Text = "İşlem Tutarı :";
            // 
            // txtIslemTitle
            // 
            this.txtIslemTitle.BackColor = System.Drawing.Color.Cornsilk;
            this.txtIslemTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemTitle.Location = new System.Drawing.Point(162, 60);
            this.txtIslemTitle.Name = "txtIslemTitle";
            this.txtIslemTitle.Size = new System.Drawing.Size(216, 26);
            this.txtIslemTitle.TabIndex = 5;
            // 
            // txtIslemID
            // 
            this.txtIslemID.BackColor = System.Drawing.Color.Cornsilk;
            this.txtIslemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemID.Location = new System.Drawing.Point(162, 18);
            this.txtIslemID.Name = "txtIslemID";
            this.txtIslemID.Size = new System.Drawing.Size(216, 26);
            this.txtIslemID.TabIndex = 4;
            // 
            // lblHarcamaName
            // 
            this.lblHarcamaName.AutoSize = true;
            this.lblHarcamaName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarcamaName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHarcamaName.Location = new System.Drawing.Point(5, 60);
            this.lblHarcamaName.Name = "lblHarcamaName";
            this.lblHarcamaName.Size = new System.Drawing.Size(144, 20);
            this.lblHarcamaName.TabIndex = 1;
            this.lblHarcamaName.Text = "İşlem Başlığı :";
            // 
            // lblHarcamaId
            // 
            this.lblHarcamaId.AutoSize = true;
            this.lblHarcamaId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHarcamaId.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHarcamaId.Location = new System.Drawing.Point(5, 21);
            this.lblHarcamaId.Name = "lblHarcamaId";
            this.lblHarcamaId.Size = new System.Drawing.Size(101, 20);
            this.lblHarcamaId.TabIndex = 0;
            this.lblHarcamaId.Text = "İşlem Id :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(197)))), ((int)(((byte)(129)))));
            this.dataGridView1.Location = new System.Drawing.Point(198, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 323);
            this.dataGridView1.TabIndex = 28;
            // 
            // FrmBankaHaraketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 696);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankaHaraketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankaHaraketleri";
            this.Load += new System.EventHandler(this.FrmBankaHaraketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBankalar;
        private System.Windows.Forms.Button btnCıkısYap;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnHarcamalar;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnBankaHaraketleri;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnİslemTürüneGöre;
        private System.Windows.Forms.ComboBox cmbİslemTürü;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIslemTutar;
        private System.Windows.Forms.Label lblHarcamaTutarı;
        private System.Windows.Forms.TextBox txtIslemTitle;
        private System.Windows.Forms.TextBox txtIslemID;
        private System.Windows.Forms.Label lblHarcamaName;
        private System.Windows.Forms.Label lblHarcamaId;
        private System.Windows.Forms.ComboBox cmbBankaBilgisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBankayaGöre;
        private System.Windows.Forms.ComboBox cmbTariheGöre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTariheGöre;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGüncelle;
    }
}