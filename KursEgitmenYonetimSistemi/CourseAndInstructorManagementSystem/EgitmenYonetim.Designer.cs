namespace CourseAndInstructorManagementSystem
{
    partial class EgitmenYonetim
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtBildigiDiller = new System.Windows.Forms.TextBox();
            this.cmbUzmanlikAlani = new System.Windows.Forms.ComboBox();
            this.btnGuncelleEgitmen = new System.Windows.Forms.Button();
            this.btnSilEgitmen = new System.Windows.Forms.Button();
            this.btnEkleEgitmen = new System.Windows.Forms.Button();
            this.dgvEgitmenler = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMalzemeler = new System.Windows.Forms.TextBox();
            this.txtEnstrumanlar = new System.Windows.Forms.TextBox();
            this.btnKursYonetim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgitmenler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı-Soyadı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uzmanlık Alanı: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bildiği Diller: ";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(197, 47);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txtBildigiDiller
            // 
            this.txtBildigiDiller.Location = new System.Drawing.Point(197, 148);
            this.txtBildigiDiller.Name = "txtBildigiDiller";
            this.txtBildigiDiller.Size = new System.Drawing.Size(100, 22);
            this.txtBildigiDiller.TabIndex = 5;
            // 
            // cmbUzmanlikAlani
            // 
            this.cmbUzmanlikAlani.FormattingEnabled = true;
            this.cmbUzmanlikAlani.Location = new System.Drawing.Point(197, 96);
            this.cmbUzmanlikAlani.Name = "cmbUzmanlikAlani";
            this.cmbUzmanlikAlani.Size = new System.Drawing.Size(121, 24);
            this.cmbUzmanlikAlani.TabIndex = 8;
            // 
            // btnGuncelleEgitmen
            // 
            this.btnGuncelleEgitmen.Location = new System.Drawing.Point(590, 151);
            this.btnGuncelleEgitmen.Name = "btnGuncelleEgitmen";
            this.btnGuncelleEgitmen.Size = new System.Drawing.Size(88, 34);
            this.btnGuncelleEgitmen.TabIndex = 11;
            this.btnGuncelleEgitmen.Text = "Güncelle";
            this.btnGuncelleEgitmen.UseVisualStyleBackColor = true;
            this.btnGuncelleEgitmen.Click += new System.EventHandler(this.btnGuncelleEgitmen_Click);
            // 
            // btnSilEgitmen
            // 
            this.btnSilEgitmen.Location = new System.Drawing.Point(480, 151);
            this.btnSilEgitmen.Name = "btnSilEgitmen";
            this.btnSilEgitmen.Size = new System.Drawing.Size(88, 34);
            this.btnSilEgitmen.TabIndex = 10;
            this.btnSilEgitmen.Text = "Sil";
            this.btnSilEgitmen.UseVisualStyleBackColor = true;
            this.btnSilEgitmen.Click += new System.EventHandler(this.btnSilEgitmen_Click);
            // 
            // btnEkleEgitmen
            // 
            this.btnEkleEgitmen.Location = new System.Drawing.Point(371, 151);
            this.btnEkleEgitmen.Name = "btnEkleEgitmen";
            this.btnEkleEgitmen.Size = new System.Drawing.Size(88, 34);
            this.btnEkleEgitmen.TabIndex = 9;
            this.btnEkleEgitmen.Text = "Ekle";
            this.btnEkleEgitmen.UseVisualStyleBackColor = true;
            this.btnEkleEgitmen.Click += new System.EventHandler(this.btnEkleEgitmen_Click);
            // 
            // dgvEgitmenler
            // 
            this.dgvEgitmenler.AllowUserToAddRows = false;
            this.dgvEgitmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgitmenler.Location = new System.Drawing.Point(12, 279);
            this.dgvEgitmenler.Name = "dgvEgitmenler";
            this.dgvEgitmenler.ReadOnly = true;
            this.dgvEgitmenler.RowHeadersWidth = 51;
            this.dgvEgitmenler.RowTemplate.Height = 24;
            this.dgvEgitmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEgitmenler.Size = new System.Drawing.Size(776, 150);
            this.dgvEgitmenler.TabIndex = 12;
            this.dgvEgitmenler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEgitmenler_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kullanılan Malzemeler: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Çalınan Enstrümanlar: ";
            // 
            // txtMalzemeler
            // 
            this.txtMalzemeler.Location = new System.Drawing.Point(532, 47);
            this.txtMalzemeler.Name = "txtMalzemeler";
            this.txtMalzemeler.Size = new System.Drawing.Size(100, 22);
            this.txtMalzemeler.TabIndex = 15;
            // 
            // txtEnstrumanlar
            // 
            this.txtEnstrumanlar.Location = new System.Drawing.Point(532, 96);
            this.txtEnstrumanlar.Name = "txtEnstrumanlar";
            this.txtEnstrumanlar.Size = new System.Drawing.Size(100, 22);
            this.txtEnstrumanlar.TabIndex = 16;
            // 
            // btnKursYonetim
            // 
            this.btnKursYonetim.Location = new System.Drawing.Point(371, 202);
            this.btnKursYonetim.Name = "btnKursYonetim";
            this.btnKursYonetim.Size = new System.Drawing.Size(307, 34);
            this.btnKursYonetim.TabIndex = 17;
            this.btnKursYonetim.Text = "Kurs Yönetime Git";
            this.btnKursYonetim.UseVisualStyleBackColor = true;
            this.btnKursYonetim.Click += new System.EventHandler(this.btnKursYonetim_Click);
            // 
            // EgitmenYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKursYonetim);
            this.Controls.Add(this.txtEnstrumanlar);
            this.Controls.Add(this.txtMalzemeler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEgitmenler);
            this.Controls.Add(this.btnGuncelleEgitmen);
            this.Controls.Add(this.btnSilEgitmen);
            this.Controls.Add(this.btnEkleEgitmen);
            this.Controls.Add(this.cmbUzmanlikAlani);
            this.Controls.Add(this.txtBildigiDiller);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EgitmenYonetim";
            this.Text = "Eğitmen Yönetim";
            this.Load += new System.EventHandler(this.EgitmenYonetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgitmenler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtBildigiDiller;
        private System.Windows.Forms.ComboBox cmbUzmanlikAlani;
        private System.Windows.Forms.Button btnGuncelleEgitmen;
        private System.Windows.Forms.Button btnSilEgitmen;
        private System.Windows.Forms.Button btnEkleEgitmen;
        private System.Windows.Forms.DataGridView dgvEgitmenler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMalzemeler;
        private System.Windows.Forms.TextBox txtEnstrumanlar;
        private System.Windows.Forms.Button btnKursYonetim;
    }
}