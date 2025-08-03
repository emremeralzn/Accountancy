using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.UI.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            FrmFatura form = new FrmFatura();
            form.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnCustomers, "Müşteri listesine erişin");
            toolTip.SetToolTip(btnInvoices, "Fatura işlemleri");
            toolTip.SetToolTip(btnInvoiceDetails, "Fatura detaylarını görüntüleyin");
            toolTip.SetToolTip(btnProducts, "Ürün envanterine erişin");
            toolTip.SetToolTip(btnReports, "Stok hareketlerini takip edin");

        }
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();
            form.ShowDialog();
        }

        private void btnInvoiceDetails_Click(object sender, EventArgs e)
        {
            FrmFaturaDetay form = new FrmFaturaDetay();
            form.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmStokHareket form = new FrmStokHareket();
            form.ShowDialog();
        }

    }
}
