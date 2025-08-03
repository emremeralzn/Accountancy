namespace Muhasebe.UI.Forms
{
    partial class CustomersForm
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
            lblAd = new Label();
            lblSoyad = new Label();
            lblTelefon = new Label();
            lblEmail = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            dgvMusteriler = new DataGridView();
            txtAra = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(77, 38);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(31, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(77, 86);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(53, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "Soyad:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(372, 38);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 20);
            lblTelefon.TabIndex = 2;
            lblTelefon.Text = "Telefon:";
            lblTelefon.Click += label3_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(372, 87);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(180, 127);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 53);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Müşteri ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(327, 127);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 53);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Müşteri güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(452, 127);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 53);
            btnSil.TabIndex = 6;
            btnSil.Text = "Müşteriyi sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(180, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(180, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 8;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(475, 38);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 9;
            txtTelefon.TextChanged += textBox3_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(475, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 10;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(57, 197);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(685, 241);
            dgvMusteriler.TabIndex = 11;
            dgvMusteriler.CellClick += dgvMusteriler_CellClick;
            dgvMusteriler.CellContentClick += dgvMusteriler_CellContentClick;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(617, 153);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 12;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAra);
            Controls.Add(dgvMusteriler);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefon);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Name = "CustomersForm";
            Text = "CustomersForm";
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblTelefon;
        private Label lblEmail;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private DataGridView dgvMusteriler;
        private TextBox txtAra;
    }
}