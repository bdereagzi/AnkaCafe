namespace AnkaCafe
{
    partial class SiparisForm
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
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvUrunListesi = new System.Windows.Forms.DataGridView();
            this.cmbMasalar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTasi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(12, 31);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunler.TabIndex = 1;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(139, 31);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(65, 20);
            this.nudAdet.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEkle.Location = new System.Drawing.Point(210, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvUrunListesi
            // 
            this.dgvUrunListesi.AllowUserToAddRows = false;
            this.dgvUrunListesi.AllowUserToDeleteRows = false;
            this.dgvUrunListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunListesi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListesi.Location = new System.Drawing.Point(12, 67);
            this.dgvUrunListesi.MultiSelect = false;
            this.dgvUrunListesi.Name = "dgvUrunListesi";
            this.dgvUrunListesi.ReadOnly = true;
            this.dgvUrunListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUrunListesi.Size = new System.Drawing.Size(419, 371);
            this.dgvUrunListesi.TabIndex = 4;
            this.dgvUrunListesi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUrunListesi_KeyDown);
            // 
            // cmbMasalar
            // 
            this.cmbMasalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMasalar.FormattingEnabled = true;
            this.cmbMasalar.Location = new System.Drawing.Point(451, 31);
            this.cmbMasalar.Name = "cmbMasalar";
            this.cmbMasalar.Size = new System.Drawing.Size(121, 21);
            this.cmbMasalar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(136, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(448, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Masa No";
            // 
            // btnTasi
            // 
            this.btnTasi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTasi.Location = new System.Drawing.Point(578, 31);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(75, 23);
            this.btnTasi.TabIndex = 6;
            this.btnTasi.Text = "TAŞI";
            this.btnTasi.UseVisualStyleBackColor = false;
            this.btnTasi.Click += new System.EventHandler(this.btnTasi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Location = new System.Drawing.Point(578, 305);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(34, 13);
            this.lblOdemeTutari.TabIndex = 0;
            this.lblOdemeTutari.Text = "0,00₺";
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.SlateGray;
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIptal.Location = new System.Drawing.Point(469, 334);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 46);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "SİPARİŞ İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnOdeme
            // 
            this.btnOdeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOdeme.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnOdeme.Location = new System.Drawing.Point(565, 334);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(90, 46);
            this.btnOdeme.TabIndex = 7;
            this.btnOdeme.Text = "ÖDEME AL";
            this.btnOdeme.UseVisualStyleBackColor = false;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Yellow;
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.Black;
            this.btnAnaSayfa.Location = new System.Drawing.Point(469, 386);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(186, 46);
            this.btnAnaSayfa.TabIndex = 7;
            this.btnAnaSayfa.Text = "ANASAYFAYA DÖN";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMasaNo.Location = new System.Drawing.Point(448, 67);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(205, 197);
            this.lblMasaNo.TabIndex = 8;
            this.lblMasaNo.Text = "01";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cmbMasalar);
            this.Controls.Add(this.dgvUrunListesi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SiparisForm_FormClosing);
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvUrunListesi;
        private System.Windows.Forms.ComboBox cmbMasalar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Label lblMasaNo;
    }
}