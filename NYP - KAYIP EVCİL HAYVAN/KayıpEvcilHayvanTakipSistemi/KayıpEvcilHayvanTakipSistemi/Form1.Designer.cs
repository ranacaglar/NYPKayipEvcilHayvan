namespace KayıpEvcilHayvanTakipSistemi
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
            this.grpSahip = new System.Windows.Forms.GroupBox();
            this.btnGuncelleSahip = new System.Windows.Forms.Button();
            this.dataGridViewSahipler = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.grpHayvan = new System.Windows.Forms.GroupBox();
            this.btnGuncelleHayvan = new System.Windows.Forms.Button();
            this.btnHayvanSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewHayvanlar = new System.Windows.Forms.DataGridView();
            this.cmbSahip = new System.Windows.Forms.ComboBox();
            this.btnHayvanKaydet = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpKaybolma = new System.Windows.Forms.DateTimePicker();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtHayvanAd = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpIlan = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewIlanlar = new System.Windows.Forms.DataGridView();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpIlanTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnIlanKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbHayvanlar = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grpSahip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSahipler)).BeginInit();
            this.grpHayvan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanlar)).BeginInit();
            this.grpIlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSahip
            // 
            this.grpSahip.BackColor = System.Drawing.Color.LightGray;
            this.grpSahip.Controls.Add(this.btnGuncelleSahip);
            this.grpSahip.Controls.Add(this.dataGridViewSahipler);
            this.grpSahip.Controls.Add(this.btnSil);
            this.grpSahip.Controls.Add(this.btnKaydet);
            this.grpSahip.Controls.Add(this.txtEposta);
            this.grpSahip.Controls.Add(this.txtTelefon);
            this.grpSahip.Controls.Add(this.txtAdSoyad);
            this.grpSahip.Controls.Add(this.label3);
            this.grpSahip.Controls.Add(this.label2);
            this.grpSahip.Controls.Add(this.label1);
            this.grpSahip.Location = new System.Drawing.Point(12, 36);
            this.grpSahip.Name = "grpSahip";
            this.grpSahip.Size = new System.Drawing.Size(407, 542);
            this.grpSahip.TabIndex = 0;
            this.grpSahip.TabStop = false;
            this.grpSahip.Text = "Sahip Bilgileri";
            // 
            // btnGuncelleSahip
            // 
            this.btnGuncelleSahip.BackColor = System.Drawing.Color.Lime;
            this.btnGuncelleSahip.Location = new System.Drawing.Point(22, 305);
            this.btnGuncelleSahip.Name = "btnGuncelleSahip";
            this.btnGuncelleSahip.Size = new System.Drawing.Size(87, 32);
            this.btnGuncelleSahip.TabIndex = 10;
            this.btnGuncelleSahip.Text = "Güncelle";
            this.btnGuncelleSahip.UseVisualStyleBackColor = false;
            this.btnGuncelleSahip.Click += new System.EventHandler(this.btnGuncelleSahip_Click);
            // 
            // dataGridViewSahipler
            // 
            this.dataGridViewSahipler.AllowUserToAddRows = false;
            this.dataGridViewSahipler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSahipler.Location = new System.Drawing.Point(23, 374);
            this.dataGridViewSahipler.Name = "dataGridViewSahipler";
            this.dataGridViewSahipler.ReadOnly = true;
            this.dataGridViewSahipler.RowHeadersWidth = 51;
            this.dataGridViewSahipler.RowTemplate.Height = 24;
            this.dataGridViewSahipler.Size = new System.Drawing.Size(361, 150);
            this.dataGridViewSahipler.TabIndex = 8;
            this.dataGridViewSahipler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSahipler_CellClick_1);
            this.dataGridViewSahipler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSahipler_CellContentClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSil.Location = new System.Drawing.Point(297, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 32);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Location = new System.Drawing.Point(139, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 34);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(169, 119);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(150, 22);
            this.txtEposta.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(169, 81);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(169, 46);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(150, 22);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // grpHayvan
            // 
            this.grpHayvan.BackColor = System.Drawing.Color.LightGray;
            this.grpHayvan.Controls.Add(this.btnGuncelleHayvan);
            this.grpHayvan.Controls.Add(this.btnHayvanSil);
            this.grpHayvan.Controls.Add(this.label11);
            this.grpHayvan.Controls.Add(this.dataGridViewHayvanlar);
            this.grpHayvan.Controls.Add(this.cmbSahip);
            this.grpHayvan.Controls.Add(this.btnHayvanKaydet);
            this.grpHayvan.Controls.Add(this.label10);
            this.grpHayvan.Controls.Add(this.cmbCinsiyet);
            this.grpHayvan.Controls.Add(this.dtpKaybolma);
            this.grpHayvan.Controls.Add(this.txtRenk);
            this.grpHayvan.Controls.Add(this.txtHayvanAd);
            this.grpHayvan.Controls.Add(this.txtCins);
            this.grpHayvan.Controls.Add(this.txtTur);
            this.grpHayvan.Controls.Add(this.label8);
            this.grpHayvan.Controls.Add(this.label7);
            this.grpHayvan.Controls.Add(this.label6);
            this.grpHayvan.Controls.Add(this.label5);
            this.grpHayvan.Controls.Add(this.label4);
            this.grpHayvan.Location = new System.Drawing.Point(445, 36);
            this.grpHayvan.Name = "grpHayvan";
            this.grpHayvan.Size = new System.Drawing.Size(413, 542);
            this.grpHayvan.TabIndex = 6;
            this.grpHayvan.TabStop = false;
            this.grpHayvan.Text = "Hayvan Bilgileri";
            // 
            // btnGuncelleHayvan
            // 
            this.btnGuncelleHayvan.BackColor = System.Drawing.Color.Lime;
            this.btnGuncelleHayvan.Location = new System.Drawing.Point(27, 305);
            this.btnGuncelleHayvan.Name = "btnGuncelleHayvan";
            this.btnGuncelleHayvan.Size = new System.Drawing.Size(87, 32);
            this.btnGuncelleHayvan.TabIndex = 16;
            this.btnGuncelleHayvan.Text = "Güncelle";
            this.btnGuncelleHayvan.UseVisualStyleBackColor = false;
            this.btnGuncelleHayvan.Click += new System.EventHandler(this.btnGuncelleHayvan_Click);
            // 
            // btnHayvanSil
            // 
            this.btnHayvanSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHayvanSil.Location = new System.Drawing.Point(302, 305);
            this.btnHayvanSil.Name = "btnHayvanSil";
            this.btnHayvanSil.Size = new System.Drawing.Size(87, 32);
            this.btnHayvanSil.TabIndex = 15;
            this.btnHayvanSil.Text = "Kayıt Sil";
            this.btnHayvanSil.UseVisualStyleBackColor = false;
            this.btnHayvanSil.Click += new System.EventHandler(this.btnHayvanSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Sahip Seçin";
            // 
            // dataGridViewHayvanlar
            // 
            this.dataGridViewHayvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHayvanlar.Location = new System.Drawing.Point(27, 374);
            this.dataGridViewHayvanlar.Name = "dataGridViewHayvanlar";
            this.dataGridViewHayvanlar.RowHeadersWidth = 51;
            this.dataGridViewHayvanlar.RowTemplate.Height = 24;
            this.dataGridViewHayvanlar.Size = new System.Drawing.Size(362, 150);
            this.dataGridViewHayvanlar.TabIndex = 9;
            this.dataGridViewHayvanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHayvanlar_CellClick);
            // 
            // cmbSahip
            // 
            this.cmbSahip.FormattingEnabled = true;
            this.cmbSahip.Location = new System.Drawing.Point(196, 223);
            this.cmbSahip.Name = "cmbSahip";
            this.cmbSahip.Size = new System.Drawing.Size(150, 24);
            this.cmbSahip.TabIndex = 13;
            this.cmbSahip.SelectedIndexChanged += new System.EventHandler(this.cmbSahip_SelectedIndexChanged);
            // 
            // btnHayvanKaydet
            // 
            this.btnHayvanKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHayvanKaydet.Location = new System.Drawing.Point(145, 268);
            this.btnHayvanKaydet.Name = "btnHayvanKaydet";
            this.btnHayvanKaydet.Size = new System.Drawing.Size(130, 34);
            this.btnHayvanKaydet.TabIndex = 12;
            this.btnHayvanKaydet.Text = "Kaydet";
            this.btnHayvanKaydet.UseVisualStyleBackColor = false;
            this.btnHayvanKaydet.Click += new System.EventHandler(this.btnHayvanKaydet_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cinsiyet";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(196, 194);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmbCinsiyet.TabIndex = 10;
            // 
            // dtpKaybolma
            // 
            this.dtpKaybolma.Location = new System.Drawing.Point(196, 166);
            this.dtpKaybolma.Name = "dtpKaybolma";
            this.dtpKaybolma.Size = new System.Drawing.Size(150, 22);
            this.dtpKaybolma.TabIndex = 9;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(196, 137);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(150, 22);
            this.txtRenk.TabIndex = 8;
            // 
            // txtHayvanAd
            // 
            this.txtHayvanAd.Location = new System.Drawing.Point(196, 43);
            this.txtHayvanAd.Name = "txtHayvanAd";
            this.txtHayvanAd.Size = new System.Drawing.Size(150, 22);
            this.txtHayvanAd.TabIndex = 5;
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(196, 107);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(150, 22);
            this.txtCins.TabIndex = 7;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(196, 77);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(150, 22);
            this.txtTur.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kaybolma Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Renk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad";
            // 
            // grpIlan
            // 
            this.grpIlan.BackColor = System.Drawing.Color.LightGray;
            this.grpIlan.Controls.Add(this.button2);
            this.grpIlan.Controls.Add(this.dataGridViewIlanlar);
            this.grpIlan.Controls.Add(this.btnIlanSil);
            this.grpIlan.Controls.Add(this.label13);
            this.grpIlan.Controls.Add(this.dtpIlanTarihi);
            this.grpIlan.Controls.Add(this.btnIlanKaydet);
            this.grpIlan.Controls.Add(this.label12);
            this.grpIlan.Controls.Add(this.cmbHayvanlar);
            this.grpIlan.Controls.Add(this.txtAciklama);
            this.grpIlan.Controls.Add(this.label9);
            this.grpIlan.Location = new System.Drawing.Point(881, 36);
            this.grpIlan.Name = "grpIlan";
            this.grpIlan.Size = new System.Drawing.Size(404, 542);
            this.grpIlan.TabIndex = 7;
            this.grpIlan.TabStop = false;
            this.grpIlan.Text = "İlan";
            this.grpIlan.Enter += new System.EventHandler(this.grpIlan_Enter);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(25, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 12;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewIlanlar
            // 
            this.dataGridViewIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIlanlar.Location = new System.Drawing.Point(25, 374);
            this.dataGridViewIlanlar.Name = "dataGridViewIlanlar";
            this.dataGridViewIlanlar.RowHeadersWidth = 51;
            this.dataGridViewIlanlar.RowTemplate.Height = 24;
            this.dataGridViewIlanlar.Size = new System.Drawing.Size(362, 150);
            this.dataGridViewIlanlar.TabIndex = 10;
            this.dataGridViewIlanlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIlanlar_CellClick);
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnIlanSil.Location = new System.Drawing.Point(300, 305);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(87, 32);
            this.btnIlanSil.TabIndex = 11;
            this.btnIlanSil.Text = "Kayıt Sil";
            this.btnIlanSil.UseVisualStyleBackColor = false;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "İlan Tarihi";
            // 
            // dtpIlanTarihi
            // 
            this.dtpIlanTarihi.Location = new System.Drawing.Point(188, 165);
            this.dtpIlanTarihi.Name = "dtpIlanTarihi";
            this.dtpIlanTarihi.Size = new System.Drawing.Size(150, 22);
            this.dtpIlanTarihi.TabIndex = 6;
            // 
            // btnIlanKaydet
            // 
            this.btnIlanKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIlanKaydet.Location = new System.Drawing.Point(148, 268);
            this.btnIlanKaydet.Name = "btnIlanKaydet";
            this.btnIlanKaydet.Size = new System.Drawing.Size(130, 34);
            this.btnIlanKaydet.TabIndex = 5;
            this.btnIlanKaydet.Text = "Kaydet";
            this.btnIlanKaydet.UseVisualStyleBackColor = false;
            this.btnIlanKaydet.Click += new System.EventHandler(this.btnIlanKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Hangi hayvana ait ";
            // 
            // cmbHayvanlar
            // 
            this.cmbHayvanlar.FormattingEnabled = true;
            this.cmbHayvanlar.Location = new System.Drawing.Point(188, 105);
            this.cmbHayvanlar.Name = "cmbHayvanlar";
            this.cmbHayvanlar.Size = new System.Drawing.Size(150, 24);
            this.cmbHayvanlar.TabIndex = 2;
            this.cmbHayvanlar.SelectedIndexChanged += new System.EventHandler(this.cmbHayvanlar_SelectedIndexChanged);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(188, 37);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(150, 22);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Açıklama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1297, 608);
            this.Controls.Add(this.grpIlan);
            this.Controls.Add(this.grpHayvan);
            this.Controls.Add(this.grpSahip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSahip.ResumeLayout(false);
            this.grpSahip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSahipler)).EndInit();
            this.grpHayvan.ResumeLayout(false);
            this.grpHayvan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHayvanlar)).EndInit();
            this.grpIlan.ResumeLayout(false);
            this.grpIlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIlanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSahip;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpHayvan;
        private System.Windows.Forms.DateTimePicker dtpKaybolma;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtHayvanAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpIlan;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnHayvanKaydet;
        private System.Windows.Forms.ComboBox cmbSahip;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnIlanKaydet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbHayvanlar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpIlanTarihi;
        private System.Windows.Forms.DataGridView dataGridViewSahipler;
        private System.Windows.Forms.DataGridView dataGridViewHayvanlar;
        private System.Windows.Forms.DataGridView dataGridViewIlanlar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnHayvanSil;
        private System.Windows.Forms.Button btnIlanSil;
        private System.Windows.Forms.Button btnGuncelleSahip;
        private System.Windows.Forms.Button btnGuncelleHayvan;
        private System.Windows.Forms.Button button2;
    }
}

