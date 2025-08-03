namespace Muhasebe.UI.Forms
{
    partial class FrmFatura
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
            cmbMusteri = new ComboBox();
            dtpFaturaTarihi = new DateTimePicker();
            cmbUrun = new ComboBox();
            nudMiktar = new NumericUpDown();
            txtBirimFiyat = new TextBox();
            btnUrunEkle = new Button();
            dgvFaturaDetaylar = new DataGridView();
            lblToplamTutar = new Label();
            btnFaturaKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaDetaylar).BeginInit();
            SuspendLayout();
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(36, 48);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(151, 28);
            cmbMusteri.TabIndex = 0;
            // 
            // dtpFaturaTarihi
            // 
            dtpFaturaTarihi.Location = new Point(36, 101);
            dtpFaturaTarihi.Name = "dtpFaturaTarihi";
            dtpFaturaTarihi.Size = new Size(250, 27);
            dtpFaturaTarihi.TabIndex = 1;
            // 
            // cmbUrun
            // 
            cmbUrun.FormattingEnabled = true;
            cmbUrun.Location = new Point(36, 148);
            cmbUrun.Name = "cmbUrun";
            cmbUrun.Size = new Size(151, 28);
            cmbUrun.TabIndex = 2;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(37, 198);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 3;
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(37, 242);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(125, 27);
            txtBirimFiyat.TabIndex = 4;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(37, 289);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(125, 29);
            btnUrunEkle.TabIndex = 5;
            btnUrunEkle.Text = "Ürün ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // dgvFaturaDetaylar
            // 
            dgvFaturaDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaturaDetaylar.Location = new Point(377, 48);
            dgvFaturaDetaylar.Name = "dgvFaturaDetaylar";
            dgvFaturaDetaylar.RowHeadersWidth = 51;
            dgvFaturaDetaylar.Size = new Size(329, 225);
            dgvFaturaDetaylar.TabIndex = 6;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(37, 337);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(50, 20);
            lblToplamTutar.TabIndex = 7;
            lblToplamTutar.Text = "label1";
            // 
            // btnFaturaKaydet
            // 
            btnFaturaKaydet.Location = new Point(37, 379);
            btnFaturaKaydet.Name = "btnFaturaKaydet";
            btnFaturaKaydet.Size = new Size(125, 29);
            btnFaturaKaydet.TabIndex = 8;
            btnFaturaKaydet.Text = "Faturayı kaydet";
            btnFaturaKaydet.UseVisualStyleBackColor = true;
            btnFaturaKaydet.Click += btnFaturaKaydet_Click;
            // 
            // FrmFatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFaturaKaydet);
            Controls.Add(lblToplamTutar);
            Controls.Add(dgvFaturaDetaylar);
            Controls.Add(btnUrunEkle);
            Controls.Add(txtBirimFiyat);
            Controls.Add(nudMiktar);
            Controls.Add(cmbUrun);
            Controls.Add(dtpFaturaTarihi);
            Controls.Add(cmbMusteri);
            Name = "FrmFatura";
            Text = "FrmFatura";
            Load += FrmFatura_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaDetaylar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMusteri;
        private DateTimePicker dtpFaturaTarihi;
        private ComboBox cmbUrun;
        private NumericUpDown nudMiktar;
        private TextBox txtBirimFiyat;
        private Button btnUrunEkle;
        private DataGridView dgvFaturaDetaylar;
        private Label lblToplamTutar;
        private Button btnFaturaKaydet;
    }
}