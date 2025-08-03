using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Muhasebe.UI.Models;
using RestSharp;

namespace Muhasebe.UI.Forms
{
    public partial class ProductsForm : Form
    {
        private List<Product> tumUrunler = new List<Product>();

        public ProductsForm()
        {
            InitializeComponent();
            this.Load += ProductsForm_Load;
            dgvUrunler.CellClick += dgvUrunler_CellClick;
        }


        private async void ProductsForm_Load(object sender, EventArgs e)
        {
            await UrunleriGetir();
        }

        private async Task UrunleriGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Get);

            try
            {
                var response = await client.ExecuteAsync<List<Product>>(request);
                if (response.IsSuccessful && response.Data != null)
                {
                    dgvUrunler.DataSource = response.Data;
                    tumUrunler = response.Data;
                    dgvUrunler.DataSource = tumUrunler;
                    DataGridViewStilAyarla();
                }
                else
                {
                    MessageBox.Show("Veri alınamadı: " + response.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Post);

            var yeniUrun = new Product
            {
                Ad = txtUrunAd.Text,
                Fiyat = decimal.Parse(txtFiyat.Text),
                Stok = int.Parse(txtStok.Text)
            };

            request.AddJsonBody(yeniUrun);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Ürün eklendi.");
                await UrunleriGetir();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız.");
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null) return;

            int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["Id"].Value);

            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Put);

            var guncelUrun = new Product
            {
                Id = urunId,
                Ad = txtUrunAd.Text,
                Fiyat = decimal.Parse(txtFiyat.Text),
                Stok = int.Parse(txtStok.Text)
            };

            request.AddJsonBody(guncelUrun);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Ürün güncellendi.");
                await UrunleriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız.");
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null) return;

            int urunId = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["Id"].Value);

            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest($"api/Urun/{urunId}", Method.Delete);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Ürün silindi.");
                await UrunleriGetir();
                Temizle();
            }
            else
            {
                MessageBox.Show("Silme başarısız.");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvUrunler.Rows[e.RowIndex];

                txtUrunAd.Text = row.Cells["Ad"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                txtStok.Text = row.Cells["Stok"].Value.ToString();
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();

            var filtreli = tumUrunler.Where(m =>
                m.Ad.ToLower().Contains(aranan)
            ).ToList();

            dgvUrunler.DataSource = filtreli;

            // ID sütununu yine gizle
            if (dgvUrunler.Columns.Contains("Id"))
                dgvUrunler.Columns["Id"].Visible = false;
        }


        private void Temizle()
        {
            txtUrunAd.Clear();
            txtFiyat.Clear();
            txtStok.Clear();
        }

        private void DataGridViewStilAyarla()
        {
            dgvUrunler.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUrunler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvUrunler.RowTemplate.Height = 28;
            dgvUrunler.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);
            dgvUrunler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvUrunler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUrunler.EnableHeadersVisualStyles = false;
            dgvUrunler.AllowUserToAddRows = false;
            dgvUrunler.AllowUserToResizeRows = false;
            dgvUrunler.AllowUserToResizeColumns = false;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvUrunler.Columns.Contains("Id"))
                dgvUrunler.Columns["Id"].Visible = false;

        }

    }
}
