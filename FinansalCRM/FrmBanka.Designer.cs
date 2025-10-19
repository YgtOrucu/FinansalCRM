namespace FinansalCRM
{
    partial class FrmBanka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanka));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBankProsess5 = new System.Windows.Forms.Label();
            this.lblBankProsess4 = new System.Windows.Forms.Label();
            this.lblBankProsess3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBankProsess2 = new System.Windows.Forms.Label();
            this.lblBankProsess1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblİsBakasıBalance = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblVakıfBakasıBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblZiraatBakasıBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 86);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(933, 9);
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
            this.label1.Location = new System.Drawing.Point(826, 9);
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
            this.lblDateTime.Location = new System.Drawing.Point(826, 35);
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
            this.panel2.Controls.Add(this.btnBankalar);
            this.panel2.Controls.Add(this.btnCıkısYap);
            this.panel2.Controls.Add(this.btnİstatistik);
            this.panel2.Controls.Add(this.btnHarcamalar);
            this.panel2.Controls.Add(this.btnGelirGider);
            this.panel2.Controls.Add(this.btnBankaHaraketleri);
            this.panel2.Controls.Add(this.btnKategoriler);
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 464);
            this.panel2.TabIndex = 1;
            // 
            // btnBankalar
            // 
            this.btnBankalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBankalar.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBankalar.ForeColor = System.Drawing.Color.White;
            this.btnBankalar.Location = new System.Drawing.Point(12, 81);
            this.btnBankalar.Name = "btnBankalar";
            this.btnBankalar.Size = new System.Drawing.Size(174, 40);
            this.btnBankalar.TabIndex = 16;
            this.btnBankalar.Text = "Bankalar";
            this.btnBankalar.UseVisualStyleBackColor = false;
            // 
            // btnCıkısYap
            // 
            this.btnCıkısYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnCıkısYap.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCıkısYap.ForeColor = System.Drawing.Color.White;
            this.btnCıkısYap.Location = new System.Drawing.Point(12, 401);
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
            this.btnİstatistik.Location = new System.Drawing.Point(12, 337);
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
            this.btnHarcamalar.Location = new System.Drawing.Point(12, 145);
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
            this.btnGelirGider.Location = new System.Drawing.Point(12, 209);
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
            this.btnBankaHaraketleri.Location = new System.Drawing.Point(12, 273);
            this.btnBankaHaraketleri.Name = "btnBankaHaraketleri";
            this.btnBankaHaraketleri.Size = new System.Drawing.Size(174, 40);
            this.btnBankaHaraketleri.TabIndex = 11;
            this.btnBankaHaraketleri.Text = "Banka Haraketleri";
            this.btnBankaHaraketleri.UseVisualStyleBackColor = false;
            this.btnBankaHaraketleri.Click += new System.EventHandler(this.btnBankaHaraketleri_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnKategoriler.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategoriler.ForeColor = System.Drawing.Color.White;
            this.btnKategoriler.Location = new System.Drawing.Point(12, 17);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(174, 40);
            this.btnKategoriler.TabIndex = 10;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = false;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblBankProsess5);
            this.groupBox1.Controls.Add(this.lblBankProsess4);
            this.groupBox1.Controls.Add(this.lblBankProsess3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblBankProsess2);
            this.groupBox1.Controls.Add(this.lblBankProsess1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(217, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 301);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Son 5 Banka Haraketi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(872, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(872, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(872, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(872, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // lblBankProsess5
            // 
            this.lblBankProsess5.AutoSize = true;
            this.lblBankProsess5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProsess5.ForeColor = System.Drawing.Color.Black;
            this.lblBankProsess5.Location = new System.Drawing.Point(6, 250);
            this.lblBankProsess5.Name = "lblBankProsess5";
            this.lblBankProsess5.Size = new System.Drawing.Size(61, 20);
            this.lblBankProsess5.TabIndex = 12;
            this.lblBankProsess5.Text = "Metin 1";
            // 
            // lblBankProsess4
            // 
            this.lblBankProsess4.AutoSize = true;
            this.lblBankProsess4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProsess4.ForeColor = System.Drawing.Color.Black;
            this.lblBankProsess4.Location = new System.Drawing.Point(6, 196);
            this.lblBankProsess4.Name = "lblBankProsess4";
            this.lblBankProsess4.Size = new System.Drawing.Size(61, 20);
            this.lblBankProsess4.TabIndex = 10;
            this.lblBankProsess4.Text = "Metin 1";
            // 
            // lblBankProsess3
            // 
            this.lblBankProsess3.AutoSize = true;
            this.lblBankProsess3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProsess3.ForeColor = System.Drawing.Color.Black;
            this.lblBankProsess3.Location = new System.Drawing.Point(6, 140);
            this.lblBankProsess3.Name = "lblBankProsess3";
            this.lblBankProsess3.Size = new System.Drawing.Size(61, 20);
            this.lblBankProsess3.TabIndex = 8;
            this.lblBankProsess3.Text = "Metin 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(872, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -" +
    " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            // 
            // lblBankProsess2
            // 
            this.lblBankProsess2.AutoSize = true;
            this.lblBankProsess2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProsess2.ForeColor = System.Drawing.Color.Black;
            this.lblBankProsess2.Location = new System.Drawing.Point(6, 91);
            this.lblBankProsess2.Name = "lblBankProsess2";
            this.lblBankProsess2.Size = new System.Drawing.Size(61, 20);
            this.lblBankProsess2.TabIndex = 5;
            this.lblBankProsess2.Text = "Metin 1";
            // 
            // lblBankProsess1
            // 
            this.lblBankProsess1.AutoSize = true;
            this.lblBankProsess1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankProsess1.ForeColor = System.Drawing.Color.Black;
            this.lblBankProsess1.Location = new System.Drawing.Point(6, 36);
            this.lblBankProsess1.Name = "lblBankProsess1";
            this.lblBankProsess1.Size = new System.Drawing.Size(61, 20);
            this.lblBankProsess1.TabIndex = 3;
            this.lblBankProsess1.Text = "Metin 1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.panel5.Controls.Add(this.lblİsBakasıBalance);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(818, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 124);
            this.panel5.TabIndex = 7;
            // 
            // lblİsBakasıBalance
            // 
            this.lblİsBakasıBalance.AutoSize = true;
            this.lblİsBakasıBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblİsBakasıBalance.ForeColor = System.Drawing.Color.White;
            this.lblİsBakasıBalance.Location = new System.Drawing.Point(13, 54);
            this.lblİsBakasıBalance.Name = "lblİsBakasıBalance";
            this.lblİsBakasıBalance.Size = new System.Drawing.Size(69, 29);
            this.lblİsBakasıBalance.TabIndex = 3;
            this.lblİsBakasıBalance.Text = "0.00 ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "İş Bankası Bakiye";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            this.panel4.Controls.Add(this.lblVakıfBakasıBalance);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(517, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 124);
            this.panel4.TabIndex = 8;
            // 
            // lblVakıfBakasıBalance
            // 
            this.lblVakıfBakasıBalance.AutoSize = true;
            this.lblVakıfBakasıBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVakıfBakasıBalance.ForeColor = System.Drawing.Color.White;
            this.lblVakıfBakasıBalance.Location = new System.Drawing.Point(13, 54);
            this.lblVakıfBakasıBalance.Name = "lblVakıfBakasıBalance";
            this.lblVakıfBakasıBalance.Size = new System.Drawing.Size(69, 29);
            this.lblVakıfBakasıBalance.TabIndex = 3;
            this.lblVakıfBakasıBalance.Text = "0.00 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "VakıfBank Bakiye";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(92)))), ((int)(((byte)(231)))));
            this.panel3.Controls.Add(this.lblZiraatBakasıBalance);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(217, 92);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 124);
            this.panel3.TabIndex = 6;
            // 
            // lblZiraatBakasıBalance
            // 
            this.lblZiraatBakasıBalance.AutoSize = true;
            this.lblZiraatBakasıBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZiraatBakasıBalance.ForeColor = System.Drawing.Color.White;
            this.lblZiraatBakasıBalance.Location = new System.Drawing.Point(13, 54);
            this.lblZiraatBakasıBalance.Name = "lblZiraatBakasıBalance";
            this.lblZiraatBakasıBalance.Size = new System.Drawing.Size(62, 29);
            this.lblZiraatBakasıBalance.TabIndex = 3;
            this.lblZiraatBakasıBalance.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ziraat Bankası Bakiye";
            // 
            // FrmBanka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1109, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBanka";
            this.Load += new System.EventHandler(this.FrmBanka_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCıkısYap;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnHarcamalar;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnBankaHaraketleri;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnBankalar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBankProsess5;
        private System.Windows.Forms.Label lblBankProsess4;
        private System.Windows.Forms.Label lblBankProsess3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBankProsess2;
        private System.Windows.Forms.Label lblBankProsess1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblİsBakasıBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblVakıfBakasıBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblZiraatBakasıBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
    }
}