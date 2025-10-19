namespace FinansalCRM
{
    partial class FrmGelirGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGelirGider));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnBankaHaraketleri = new System.Windows.Forms.Button();
            this.btnGelirGider = new System.Windows.Forms.Button();
            this.btnHarcamalar = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnCıkısYap = new System.Windows.Forms.Button();
            this.btnBankalar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGelirGiderTürü = new System.Windows.Forms.ComboBox();
            this.cmbBankaList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnFiltre = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalGelenHavale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalGidenHavale = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblNetBakiye = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(643, 44);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 20);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(643, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hoşgeldiniz";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(751, 18);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 20);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Location = new System.Drawing.Point(196, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 86);
            this.panel1.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnKategoriler.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(12, 201);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(174, 40);
            this.btnKategoriler.TabIndex = 10;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnBankaHaraketleri
            // 
            this.btnBankaHaraketleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBankaHaraketleri.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankaHaraketleri.ForeColor = System.Drawing.Color.White;
            this.btnBankaHaraketleri.Location = new System.Drawing.Point(12, 489);
            this.btnBankaHaraketleri.Name = "btnBankaHaraketleri";
            this.btnBankaHaraketleri.Size = new System.Drawing.Size(174, 40);
            this.btnBankaHaraketleri.TabIndex = 11;
            this.btnBankaHaraketleri.Text = "Banka Haraketleri";
            this.btnBankaHaraketleri.UseVisualStyleBackColor = false;
            this.btnBankaHaraketleri.Click += new System.EventHandler(this.btnBankaHaraketleri_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnGelirGider.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGelirGider.ForeColor = System.Drawing.Color.White;
            this.btnGelirGider.Location = new System.Drawing.Point(12, 417);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(174, 40);
            this.btnGelirGider.TabIndex = 12;
            this.btnGelirGider.Text = "Gelirler / Giderler";
            this.btnGelirGider.UseVisualStyleBackColor = false;
            // 
            // btnHarcamalar
            // 
            this.btnHarcamalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnHarcamalar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHarcamalar.ForeColor = System.Drawing.Color.White;
            this.btnHarcamalar.Location = new System.Drawing.Point(12, 345);
            this.btnHarcamalar.Name = "btnHarcamalar";
            this.btnHarcamalar.Size = new System.Drawing.Size(174, 40);
            this.btnHarcamalar.TabIndex = 13;
            this.btnHarcamalar.Text = "Harcamalar";
            this.btnHarcamalar.UseVisualStyleBackColor = false;
            this.btnHarcamalar.Click += new System.EventHandler(this.btnHarcamalar_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnİstatistik.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnİstatistik.ForeColor = System.Drawing.Color.White;
            this.btnİstatistik.Location = new System.Drawing.Point(12, 561);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(174, 40);
            this.btnİstatistik.TabIndex = 14;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = false;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnCıkısYap
            // 
            this.btnCıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCıkısYap.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCıkısYap.ForeColor = System.Drawing.Color.White;
            this.btnCıkısYap.Location = new System.Drawing.Point(12, 633);
            this.btnCıkısYap.Name = "btnCıkısYap";
            this.btnCıkısYap.Size = new System.Drawing.Size(174, 40);
            this.btnCıkısYap.TabIndex = 15;
            this.btnCıkısYap.Text = "Çıkış Yap";
            this.btnCıkısYap.UseVisualStyleBackColor = false;
            this.btnCıkısYap.Click += new System.EventHandler(this.btnCıkısYap_Click);
            // 
            // btnBankalar
            // 
            this.btnBankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBankalar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankalar.ForeColor = System.Drawing.Color.White;
            this.btnBankalar.Location = new System.Drawing.Point(12, 273);
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.Size = new System.Drawing.Size(174, 40);
            this.btnBankalar.TabIndex = 16;
            this.btnBankalar.Text = "Bankalar";
            this.btnBankalar.UseVisualStyleBackColor = false;
            this.btnBankalar.Click += new System.EventHandler(this.btnBankalar_Click);
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
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(198, 732);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(204, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "FİLTRE ALANI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(223, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Gelir/Gider Türü";
            // 
            // cmbGelirGiderTürü
            // 
            this.cmbGelirGiderTürü.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbGelirGiderTürü.FormattingEnabled = true;
            this.cmbGelirGiderTürü.Items.AddRange(new object[] {
            "Tümü",
            "Gelen Havale",
            "Giden Havale"});
            this.cmbGelirGiderTürü.Location = new System.Drawing.Point(226, 157);
            this.cmbGelirGiderTürü.Name = "cmbGelirGiderTürü";
            this.cmbGelirGiderTürü.Size = new System.Drawing.Size(160, 25);
            this.cmbGelirGiderTürü.TabIndex = 25;
            // 
            // cmbBankaList
            // 
            this.cmbBankaList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbBankaList.FormattingEnabled = true;
            this.cmbBankaList.Location = new System.Drawing.Point(446, 157);
            this.cmbBankaList.Name = "cmbBankaList";
            this.cmbBankaList.Size = new System.Drawing.Size(160, 25);
            this.cmbBankaList.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(443, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Banka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(658, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Başlangıç Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(661, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 25);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // btnFiltre
            // 
            this.btnFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnFiltre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFiltre.ForeColor = System.Drawing.Color.White;
            this.btnFiltre.Location = new System.Drawing.Point(843, 146);
            this.btnFiltre.Name = "btnFiltre";
            this.btnFiltre.Size = new System.Drawing.Size(99, 36);
            this.btnFiltre.TabIndex = 31;
            this.btnFiltre.Text = "Filtrele";
            this.btnFiltre.UseVisualStyleBackColor = false;
            this.btnFiltre.Click += new System.EventHandler(this.btnFiltre_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalGelenHavale);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(226, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 97);
            this.panel3.TabIndex = 33;
            // 
            // lblTotalGelenHavale
            // 
            this.lblTotalGelenHavale.AutoSize = true;
            this.lblTotalGelenHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalGelenHavale.ForeColor = System.Drawing.Color.White;
            this.lblTotalGelenHavale.Location = new System.Drawing.Point(13, 54);
            this.lblTotalGelenHavale.Name = "lblTotalGelenHavale";
            this.lblTotalGelenHavale.Size = new System.Drawing.Size(62, 29);
            this.lblTotalGelenHavale.TabIndex = 3;
            this.lblTotalGelenHavale.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toplam Gelen Havale";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalGidenHavale);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(520, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 97);
            this.panel4.TabIndex = 34;
            // 
            // lblTotalGidenHavale
            // 
            this.lblTotalGidenHavale.AutoSize = true;
            this.lblTotalGidenHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalGidenHavale.ForeColor = System.Drawing.Color.White;
            this.lblTotalGidenHavale.Location = new System.Drawing.Point(13, 54);
            this.lblTotalGidenHavale.Name = "lblTotalGidenHavale";
            this.lblTotalGidenHavale.Size = new System.Drawing.Size(62, 29);
            this.lblTotalGidenHavale.TabIndex = 3;
            this.lblTotalGidenHavale.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Toplam Giden Havale";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblNetBakiye);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(814, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 97);
            this.panel5.TabIndex = 35;
            // 
            // lblNetBakiye
            // 
            this.lblNetBakiye.AutoSize = true;
            this.lblNetBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNetBakiye.ForeColor = System.Drawing.Color.White;
            this.lblNetBakiye.Location = new System.Drawing.Point(13, 54);
            this.lblNetBakiye.Name = "lblNetBakiye";
            this.lblNetBakiye.Size = new System.Drawing.Size(62, 29);
            this.lblNetBakiye.TabIndex = 3;
            this.lblNetBakiye.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(15, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Net Bakiye";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(226, 323);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SeaGreen;
            series1.Legend = "Legend1";
            series1.Name = "Gelir";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.IndianRed;
            series2.Legend = "Legend1";
            series2.Name = "Gider";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(826, 160);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
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
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.dataGridView1.Location = new System.Drawing.Point(198, 489);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(912, 243);
            this.dataGridView1.TabIndex = 37;
            // 
            // FrmGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1109, 733);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnFiltre);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBankaList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGelirGiderTürü);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGelirGider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGelirGider";
            this.Load += new System.EventHandler(this.FrmGelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnBankaHaraketleri;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnHarcamalar;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnCıkısYap;
        private System.Windows.Forms.Button btnBankalar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGelirGiderTürü;
        private System.Windows.Forms.ComboBox cmbBankaList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnFiltre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalGelenHavale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalGidenHavale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNetBakiye;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}