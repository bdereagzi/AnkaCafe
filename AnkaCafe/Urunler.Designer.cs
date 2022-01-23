namespace AnkaCafe
{
    partial class Urunler
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
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nudUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.dgvEklenenUrunler = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEklenenUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(124, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birim Fiyatı ₺";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 41);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 26);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // nudUrunFiyati
            // 
            this.nudUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudUrunFiyati.Location = new System.Drawing.Point(128, 41);
            this.nudUrunFiyati.Name = "nudUrunFiyati";
            this.nudUrunFiyati.Size = new System.Drawing.Size(120, 26);
            this.nudUrunFiyati.TabIndex = 2;
            // 
            // dgvEklenenUrunler
            // 
            this.dgvEklenenUrunler.AllowUserToAddRows = false;
            this.dgvEklenenUrunler.AllowUserToDeleteRows = false;
            this.dgvEklenenUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEklenenUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEklenenUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEklenenUrunler.Location = new System.Drawing.Point(12, 82);
            this.dgvEklenenUrunler.MultiSelect = false;
            this.dgvEklenenUrunler.Name = "dgvEklenenUrunler";
            this.dgvEklenenUrunler.ReadOnly = true;
            this.dgvEklenenUrunler.RowHeadersVisible = false;
            this.dgvEklenenUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEklenenUrunler.Size = new System.Drawing.Size(425, 323);
            this.dgvEklenenUrunler.TabIndex = 3;
            this.dgvEklenenUrunler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgwEklenenUrunler_KeyDown);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(323, 41);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 35);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 426);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvEklenenUrunler);
            this.Controls.Add(this.nudUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Urunler_FormClosing);
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEklenenUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nudUrunFiyati;
        private System.Windows.Forms.DataGridView dgvEklenenUrunler;
        private System.Windows.Forms.Button btnEkle;
    }
}