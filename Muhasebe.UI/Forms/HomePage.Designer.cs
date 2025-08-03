namespace Muhasebe.UI.Forms
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            lblWelcome = new Label();
            btnCustomers = new Button();
            btnInvoices = new Button();
            btnInvoiceDetails = new Button();
            btnProducts = new Button();
            btnReports = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(457, 60);
            lblWelcome.Margin = new Padding(5, 0, 5, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(355, 62);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Hoş Geldiniz, lütfen seçim yapınız\n\n";
            // 
            // btnCustomers
            // 
            btnCustomers.Cursor = Cursors.Hand;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.Location = new Point(73, 179);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(181, 168);
            btnCustomers.TabIndex = 1;
            btnCustomers.Text = "Müşteriler";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnInvoices
            // 
            btnInvoices.Cursor = Cursors.Hand;
            btnInvoices.FlatStyle = FlatStyle.Flat;
            btnInvoices.Location = new Point(309, 179);
            btnInvoices.Name = "btnInvoices";
            btnInvoices.Size = new Size(181, 168);
            btnInvoices.TabIndex = 2;
            btnInvoices.Text = "Faturalar";
            btnInvoices.UseVisualStyleBackColor = true;
            btnInvoices.Click += btnInvoices_Click;
            // 
            // btnInvoiceDetails
            // 
            btnInvoiceDetails.Cursor = Cursors.Hand;
            btnInvoiceDetails.FlatStyle = FlatStyle.Flat;
            btnInvoiceDetails.Location = new Point(546, 179);
            btnInvoiceDetails.Name = "btnInvoiceDetails";
            btnInvoiceDetails.Size = new Size(181, 168);
            btnInvoiceDetails.TabIndex = 3;
            btnInvoiceDetails.Text = "Fatura Detayları";
            btnInvoiceDetails.UseVisualStyleBackColor = true;
            btnInvoiceDetails.Click += btnInvoiceDetails_Click;
            // 
            // btnProducts
            // 
            btnProducts.Cursor = Cursors.Hand;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Location = new Point(788, 179);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(181, 168);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Ürünler";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Location = new Point(1029, 179);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(181, 168);
            btnReports.TabIndex = 5;
            btnReports.Text = "Stok Hareketler";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 698);
            Controls.Add(btnReports);
            Controls.Add(btnProducts);
            Controls.Add(btnInvoiceDetails);
            Controls.Add(btnInvoices);
            Controls.Add(btnCustomers);
            Controls.Add(lblWelcome);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnCustomers;
        private Button btnInvoices;
        private Button btnInvoiceDetails;
        private Button btnProducts;
        private Button btnReports;
        private System.Windows.Forms.Timer timer1;
    }
}