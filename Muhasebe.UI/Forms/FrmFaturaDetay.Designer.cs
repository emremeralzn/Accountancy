namespace Muhasebe.UI.Forms
{
    partial class FrmFaturaDetay
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
            lblFatura = new Label();
            lblUrun = new Label();
            lblMiktar = new Label();
            lblBirimFiyat = new Label();
            cmbFaturalar = new ComboBox();
            cmbUrunler = new ComboBox();
            nudMiktar = new NumericUpDown();
            txtBirimFiyat = new TextBox();
            dgvDetaylar = new DataGridView();
            btnEkle = new Button();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            SuspendLayout();
            // 
            // lblFatura
            // 
            lblFatura.AutoSize = true;
            lblFatura.Location = new Point(42, 95);
            lblFatura.Name = "lblFatura";
            lblFatura.Size = new Size(52, 20);
            lblFatura.TabIndex = 0;
            lblFatura.Text = "Fatura:";
            // 
            // lblUrun
            // 
            lblUrun.AutoSize = true;
            lblUrun.Location = new Point(42, 143);
            lblUrun.Name = "lblUrun";
            lblUrun.Size = new Size(43, 20);
            lblUrun.TabIndex = 1;
            lblUrun.Text = "Ürün:";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(41, 193);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(54, 20);
            lblMiktar.TabIndex = 2;
            lblMiktar.Text = "Miktar:";
            // 
            // lblBirimFiyat
            // 
            lblBirimFiyat.AutoSize = true;
            lblBirimFiyat.Location = new Point(40, 240);
            lblBirimFiyat.Name = "lblBirimFiyat";
            lblBirimFiyat.Size = new Size(82, 20);
            lblBirimFiyat.TabIndex = 3;
            lblBirimFiyat.Text = "Birim Fiyat:";
            // 
            // cmbFaturalar
            // 
            cmbFaturalar.FormattingEnabled = true;
            cmbFaturalar.Location = new Point(128, 95);
            cmbFaturalar.Name = "cmbFaturalar";
            cmbFaturalar.Size = new Size(151, 28);
            cmbFaturalar.TabIndex = 4;
            // 
            // cmbUrunler
            // 
            cmbUrunler.FormattingEnabled = true;
            cmbUrunler.Location = new Point(128, 145);
            cmbUrunler.Name = "cmbUrunler";
            cmbUrunler.Size = new Size(151, 28);
            cmbUrunler.TabIndex = 5;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(128, 191);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 6;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(138, 237);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(125, 27);
            txtBirimFiyat.TabIndex = 7;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(358, 78);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.Size = new Size(402, 246);
            dgvDetaylar.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(58, 295);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(201, 295);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmFaturaDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(btnEkle);
            Controls.Add(dgvDetaylar);
            Controls.Add(txtBirimFiyat);
            Controls.Add(nudMiktar);
            Controls.Add(cmbUrunler);
            Controls.Add(cmbFaturalar);
            Controls.Add(lblBirimFiyat);
            Controls.Add(lblMiktar);
            Controls.Add(lblUrun);
            Controls.Add(lblFatura);
            Name = "FrmFaturaDetay";
            Text = "FrmFaturaDetay";
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFatura;
        private Label lblUrun;
        private Label lblMiktar;
        private Label lblBirimFiyat;
        private ComboBox cmbFaturalar;
        private ComboBox cmbUrunler;
        private NumericUpDown nudMiktar;
        private TextBox txtBirimFiyat;
        private DataGridView dgvDetaylar;
        private Button btnEkle;
        private Button btnKaydet;
    }
}