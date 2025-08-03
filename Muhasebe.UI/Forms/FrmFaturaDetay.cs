using Muhasebe.UI.Models;
using RestSharp;
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
    public partial class FrmFaturaDetay : Form
    {
        private List<FaturaDetayViewModel> detayListesi = new();

        public FrmFaturaDetay()
        {
            InitializeComponent();
            this.Load += FrmFaturaDetay_Load;
        }


        private async void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            await FaturalariGetir();
            await UrunleriGetir();
        }

        private async Task FaturalariGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Fatura", Method.Get);

            var response = await client.ExecuteAsync<List<FaturaViewModel>>(request);

            if (response.IsSuccessful)
            {
                cmbFaturalar.DataSource = response.Data;
                cmbFaturalar.DisplayMember = "Id";  // dilersen tarih göster
                cmbFaturalar.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Faturalar yüklenemedi.");
            }
        }

        private async Task UrunleriGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Get);

            var response = await client.ExecuteAsync<List<Product>>(request);

            if (response.IsSuccessful)
            {
                cmbUrunler.DataSource = response.Data;
                cmbUrunler.DisplayMember = "Ad";
                cmbUrunler.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Ürünler yüklenemedi.");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbFaturalar.SelectedItem is not FaturaViewModel fatura ||
                cmbUrunler.SelectedItem is not Product urun)
            {
                MessageBox.Show("Fatura ve ürün seçiniz.");
                return;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, out decimal birimFiyat))
            {
                MessageBox.Show("Geçerli bir birim fiyat girin.");
                return;
            }

            var detay = new FaturaDetayViewModel
            {
                FaturaId = fatura.Id,
                UrunId = urun.Id,
                UrunAd = urun.Ad,
                Miktar = (int)nudMiktar.Value,
                BirimFiyat = birimFiyat
            };


            detayListesi.Add(detay);

            dgvDetaylar.DataSource = null;
            dgvDetaylar.DataSource = detayListesi;
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!detayListesi.Any())
            {
                MessageBox.Show("Kaydedilecek detay yok.");
                return;
            }

            var client = new RestClient("https://localhost:7282/");

            foreach (var detay in detayListesi)
            {
                var request = new RestRequest("api/FaturaDetay", Method.Post);
                request.AddJsonBody(detay);

                var response = await client.ExecuteAsync(request);

                if (!response.IsSuccessful)
                {
                    MessageBox.Show("Bazı detaylar kaydedilemedi.");
                    return;
                }
            }

            MessageBox.Show("Tüm fatura detayları başarıyla kaydedildi.");
            detayListesi.Clear();
            dgvDetaylar.DataSource = null;
        }
    }

}
