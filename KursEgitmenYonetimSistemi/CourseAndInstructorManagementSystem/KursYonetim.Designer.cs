namespace CourseAndInstructorManagementSystem
{
    partial class KursYonetim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtKursAdi = new System.Windows.Forms.TextBox();
            this.txtDil = new System.Windows.Forms.TextBox();
            this.txtSeviye = new System.Windows.Forms.TextBox();
            this.txtProgramlamaDili = new System.Windows.Forms.TextBox();
            this.txtZorluk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKursTuru = new System.Windows.Forms.ComboBox();
            this.dgvKurslar = new System.Windows.Forms.DataGridView();
            this.btnEgitmeneDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurslar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kurs Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurs Türü: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dil: ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(359, 143);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(88, 34);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(467, 143);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 34);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(574, 143);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(88, 34);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtKursAdi
            // 
            this.txtKursAdi.Location = new System.Drawing.Point(195, 37);
            this.txtKursAdi.Name = "txtKursAdi";
            this.txtKursAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKursAdi.TabIndex = 6;
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(195, 125);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(100, 22);
            this.txtDil.TabIndex = 8;
            // 
            // txtSeviye
            // 
            this.txtSeviye.Location = new System.Drawing.Point(195, 170);
            this.txtSeviye.Name = "txtSeviye";
            this.txtSeviye.Size = new System.Drawing.Size(100, 22);
            this.txtSeviye.TabIndex = 9;
            // 
            // txtProgramlamaDili
            // 
            this.txtProgramlamaDili.Location = new System.Drawing.Point(493, 37);
            this.txtProgramlamaDili.Name = "txtProgramlamaDili";
            this.txtProgramlamaDili.Size = new System.Drawing.Size(100, 22);
            this.txtProgramlamaDili.TabIndex = 10;
            // 
            // txtZorluk
            // 
            this.txtZorluk.Location = new System.Drawing.Point(493, 81);
            this.txtZorluk.Name = "txtZorluk";
            this.txtZorluk.Size = new System.Drawing.Size(100, 22);
            this.txtZorluk.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dil Seviyesi: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Programlama Dili: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Zorluk Seviyesi: ";
            // 
            // cmbKursTuru
            // 
            this.cmbKursTuru.FormattingEnabled = true;
            this.cmbKursTuru.Location = new System.Drawing.Point(195, 81);
            this.cmbKursTuru.Name = "cmbKursTuru";
            this.cmbKursTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbKursTuru.TabIndex = 16;
            // 
            // dgvKurslar
            // 
            this.dgvKurslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurslar.Location = new System.Drawing.Point(12, 276);
            this.dgvKurslar.Name = "dgvKurslar";
            this.dgvKurslar.RowHeadersWidth = 51;
            this.dgvKurslar.RowTemplate.Height = 24;
            this.dgvKurslar.Size = new System.Drawing.Size(776, 150);
            this.dgvKurslar.TabIndex = 17;
            // 
            // btnEgitmeneDon
            // 
            this.btnEgitmeneDon.Location = new System.Drawing.Point(359, 206);
            this.btnEgitmeneDon.Name = "btnEgitmeneDon";
            this.btnEgitmeneDon.Size = new System.Drawing.Size(303, 34);
            this.btnEgitmeneDon.TabIndex = 18;
            this.btnEgitmeneDon.Text = "Eğitmen Yönetime Dön";
            this.btnEgitmeneDon.UseVisualStyleBackColor = true;
            this.btnEgitmeneDon.Click += new System.EventHandler(this.btnEgitmeneDon_Click);
            // 
            // KursYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEgitmeneDon);
            this.Controls.Add(this.dgvKurslar);
            this.Controls.Add(this.cmbKursTuru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZorluk);
            this.Controls.Add(this.txtProgramlamaDili);
            this.Controls.Add(this.txtSeviye);
            this.Controls.Add(this.txtDil);
            this.Controls.Add(this.txtKursAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KursYonetim";
            this.Text = "Kurs Yönetimi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurslar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtKursAdi;
        private System.Windows.Forms.TextBox txtDil;
        private System.Windows.Forms.TextBox txtSeviye;
        private System.Windows.Forms.TextBox txtProgramlamaDili;
        private System.Windows.Forms.TextBox txtZorluk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbKursTuru;
        private System.Windows.Forms.DataGridView dgvKurslar;
        private System.Windows.Forms.Button btnEgitmeneDon;
    }
}

