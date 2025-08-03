namespace Muhasebe.UI.Forms
{
    partial class FrmStokHareket
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
            cmbUrunler = new ComboBox();
            nudMiktar = new NumericUpDown();
            rbGiris = new RadioButton();
            rbCikis = new RadioButton();
            dtTarih = new DateTimePicker();
            btnKaydet = new Button();
            dgvHareketler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHareketler).BeginInit();
            SuspendLayout();
            // 
            // cmbUrunler
            // 
            cmbUrunler.FormattingEnabled = true;
            cmbUrunler.Location = new Point(50, 40);
            cmbUrunler.Name = "cmbUrunler";
            cmbUrunler.Size = new Size(151, 28);
            cmbUrunler.TabIndex = 0;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(51, 101);
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 1;
            // 
            // rbGiris
            // 
            rbGiris.AutoSize = true;
            rbGiris.Location = new Point(51, 150);
            rbGiris.Name = "rbGiris";
            rbGiris.Size = new Size(59, 24);
            rbGiris.TabIndex = 2;
            rbGiris.TabStop = true;
            rbGiris.Text = "Giriş";
            rbGiris.UseVisualStyleBackColor = true;
            // 
            // rbCikis
            // 
            rbCikis.AutoSize = true;
            rbCikis.Location = new Point(51, 200);
            rbCikis.Name = "rbCikis";
            rbCikis.Size = new Size(60, 24);
            rbCikis.TabIndex = 3;
            rbCikis.TabStop = true;
            rbCikis.Text = "Çıkış";
            rbCikis.UseVisualStyleBackColor = true;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(51, 254);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(250, 27);
            dtTarih.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(68, 310);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // dgvHareketler
            // 
            dgvHareketler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHareketler.Location = new Point(379, 84);
            dgvHareketler.Name = "dgvHareketler";
            dgvHareketler.RowHeadersWidth = 51;
            dgvHareketler.Size = new Size(395, 267);
            dgvHareketler.TabIndex = 6;
            // 
            // FrmStokHareket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHareketler);
            Controls.Add(btnKaydet);
            Controls.Add(dtTarih);
            Controls.Add(rbCikis);
            Controls.Add(rbGiris);
            Controls.Add(nudMiktar);
            Controls.Add(cmbUrunler);
            Name = "FrmStokHareket";
            Text = "FrmStokHareket";
            Load += FrmStokHareket_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHareketler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbUrunler;
        private NumericUpDown nudMiktar;
        private RadioButton rbGiris;
        private RadioButton rbCikis;
        private DateTimePicker dtTarih;
        private Button btnKaydet;
        private DataGridView dgvHareketler;
    }
}