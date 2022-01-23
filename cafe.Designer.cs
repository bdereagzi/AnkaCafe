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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMasalar = new System.Windows.Forms.ComboBox();
            this.btnTasi = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOdemeTutari = new System.Windows.Forms.Label();
            this.btnSiparisiptal = new System.Windows.Forms.Button();
            this.btnÖdemeAl = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet";
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.BackColor = System.Drawing.Color.Indigo;
            this.cmbUrunler.ForeColor = System.Drawing.Color.Black;
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(21, 48);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunler.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Indigo;
            this.numericUpDown1.Location = new System.Drawing.Point(162, 49);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Yellow;
            this.btnEkle.ForeColor = System.Drawing.Color.Indigo;
            this.btnEkle.Location = new System.Drawing.Point(255, 46);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 296);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Masa";
            // 
            // cmbMasalar
            // 
            this.cmbMasalar.BackColor = System.Drawing.Color.Indigo;
            this.cmbMasalar.FormattingEnabled = true;
            this.cmbMasalar.Location = new System.Drawing.Point(475, 49);
            this.cmbMasalar.Name = "cmbMasalar";
            this.cmbMasalar.Size = new System.Drawing.Size(65, 21);
            this.cmbMasalar.TabIndex = 7;
            this.cmbMasalar.SelectedIndexChanged += new System.EventHandler(this.cmbMasalar_SelectedIndexChanged);
            // 
            // btnTasi
            // 
            this.btnTasi.BackColor = System.Drawing.Color.Yellow;
            this.btnTasi.ForeColor = System.Drawing.Color.Indigo;
            this.btnTasi.Location = new System.Drawing.Point(561, 47);
            this.btnTasi.Name = "btnTasi";
            this.btnTasi.Size = new System.Drawing.Size(75, 23);
            this.btnTasi.TabIndex = 8;
            this.btnTasi.Text = "Taşı";
            this.btnTasi.UseVisualStyleBackColor = false;
            this.btnTasi.Click += new System.EventHandler(this.btnTasi_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.BackColor = System.Drawing.Color.Indigo;
            this.lblMasaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMasaNo.ForeColor = System.Drawing.Color.Yellow;
            this.lblMasaNo.Location = new System.Drawing.Point(410, 99);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(226, 148);
            this.lblMasaNo.TabIndex = 9;
            this.lblMasaNo.Text = "00";
            this.lblMasaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutari
            // 
            this.lblOdemeTutari.AutoSize = true;
            this.lblOdemeTutari.Location = new System.Drawing.Point(505, 282);
            this.lblOdemeTutari.Name = "lblOdemeTutari";
            this.lblOdemeTutari.Size = new System.Drawing.Size(19, 13);
            this.lblOdemeTutari.TabIndex = 11;
            this.lblOdemeTutari.Text = "0₺";
            // 
            // btnSiparisiptal
            // 
            this.btnSiparisiptal.BackColor = System.Drawing.Color.Yellow;
            this.btnSiparisiptal.ForeColor = System.Drawing.Color.Indigo;
            this.btnSiparisiptal.Location = new System.Drawing.Point(413, 309);
            this.btnSiparisiptal.Name = "btnSiparisiptal";
            this.btnSiparisiptal.Size = new System.Drawing.Size(100, 34);
            this.btnSiparisiptal.TabIndex = 12;
            this.btnSiparisiptal.Text = "Siparis iptal";
            this.btnSiparisiptal.UseVisualStyleBackColor = false;
            this.btnSiparisiptal.Click += new System.EventHandler(this.btnSiparisiptal_Click);
            // 
            // btnÖdemeAl
            // 
            this.btnÖdemeAl.BackColor = System.Drawing.Color.Yellow;
            this.btnÖdemeAl.ForeColor = System.Drawing.Color.Indigo;
            this.btnÖdemeAl.Location = new System.Drawing.Point(519, 309);
            this.btnÖdemeAl.Name = "btnÖdemeAl";
            this.btnÖdemeAl.Size = new System.Drawing.Size(92, 34);
            this.btnÖdemeAl.TabIndex = 13;
            this.btnÖdemeAl.Text = "Ödeme Al";
            this.btnÖdemeAl.UseVisualStyleBackColor = false;
            this.btnÖdemeAl.Click += new System.EventHandler(this.btnÖdemeAl_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.Yellow;
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.Indigo;
            this.btnAnaSayfa.Location = new System.Drawing.Point(417, 349);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(194, 35);
            this.btnAnaSayfa.TabIndex = 14;
            this.btnAnaSayfa.Text = "Ana Sayfaya Dön";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 445);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnÖdemeAl);
            this.Controls.Add(this.btnSiparisiptal);
            this.Controls.Add(this.lblOdemeTutari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnTasi);
            this.Controls.Add(this.cmbMasalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cmbUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMasalar;
        private System.Windows.Forms.Button btnTasi;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOdemeTutari;
        private System.Windows.Forms.Button btnSiparisiptal;
        private System.Windows.Forms.Button btnÖdemeAl;
        private System.Windows.Forms.Button btnAnaSayfa;
    }
}