namespace Muhasebe.UI.Forms
{
    partial class ProductsForm
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
            txtUrunAd = new TextBox();
            txtStok = new TextBox();
            txtFiyat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvUrunler = new DataGridView();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(127, 48);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(125, 27);
            txtUrunAd.TabIndex = 0;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(548, 52);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(125, 27);
            txtStok.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(127, 99);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(125, 27);
            txtFiyat.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 3;
            label1.Text = "Ürün adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 102);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 4;
            label2.Text = "Ürün fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 55);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 5;
            label3.Text = "Ürün başlangıç stoğu";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(127, 170);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ürün ekle\n\n";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(266, 170);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(416, 170);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Location = new Point(127, 220);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidth = 51;
            dgvUrunler.Size = new Size(504, 218);
            dgvUrunler.TabIndex = 9;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
            dgvUrunler.CellContentClick += dgvUrunler_CellClick;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(560, 172);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(71, 27);
            txtAra.TabIndex = 10;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAra);
            Controls.Add(dgvUrunler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFiyat);
            Controls.Add(txtStok);
            Controls.Add(txtUrunAd);
            Name = "ProductsForm";
            Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAd;
        private TextBox txtStok;
        private TextBox txtFiyat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvUrunler;
        private TextBox txtAra;
    }
}