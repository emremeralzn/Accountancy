using Muhasebe.UI.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.UI.Forms
{
    public partial class FrmFatura : Form
    {
        private List<FaturaDetayViewModel> detaylarListesi = new();

        public FrmFatura()
        {
            InitializeComponent();
        }

        private async void FrmFatura_Load(object sender, EventArgs e)
        {
            await MusterileriGetir();
            await UrunleriGetir();
        }

        private async Task MusterileriGetir()
        {

            var client = new RestClient("https://localhost:7282");
            var request = new RestRequest("api/Musteri", Method.Get);

            var response = await client.ExecuteAsync<List<Customer>>(request);

            if (response.IsSuccessful)
            {
                cmbMusteri.DataSource = response.Data;
                cmbMusteri.DisplayMember = "Ad";
                cmbMusteri.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Müşteriler getirilemedi.");
            }
        }

        private async Task UrunleriGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Get);

            var response = await client.ExecuteAsync<List<Product>>(request);

            if (response.IsSuccessful)
            {
                cmbUrun.DataSource = response.Data;
                cmbUrun.DisplayMember = "Ad";
                cmbUrun.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Ürünler getirilemedi.");
            }
        }

        private void HesaplaToplamTutar()
        {
            decimal toplam = detaylarListesi.Sum(x => x.Miktar * x.BirimFiyat);
            lblToplamTutar.Text = toplam.ToString("0.00") + " ₺";
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedItem is not Product urun)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (!decimal.TryParse(txtBirimFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Geçerli bir birim fiyat giriniz.");
                return;
            }

            var detay = new FaturaDetayViewModel
            {
                UrunAd = urun.Ad,
                Miktar = (int)nudMiktar.Value,
                BirimFiyat = fiyat
            };

            detaylarListesi.Add(detay);

            dgvFaturaDetaylar.DataSource = null;
            dgvFaturaDetaylar.DataSource = detaylarListesi;

            HesaplaToplamTutar();
        }
        private int GetUrunIdFromName(string urunAd)
        {
            var urun = (cmbUrun.DataSource as List<Product>)?.FirstOrDefault(x => x.Ad == urunAd);
            return urun?.Id ?? 0;
        }


        private async void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            if (cmbMusteri.SelectedItem is not Customer musteri)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            decimal.TryParse(lblToplamTutar.Text.Replace(" ₺", ""), out decimal toplamTutar);

            var fatura = new
            {
                MusteriId = musteri.Id,
                Tarih = dtpFaturaTarihi.Value,
                ToplamTutar = toplamTutar,
                FaturaDetaylar = detaylarListesi.Select(x => new
                {
                    UrunAd = x.UrunAd,           // opsiyonel: DB karşılığı yoksa çıkar
                    Miktar = x.Miktar,
                    BirimFiyat = x.BirimFiyat,
                    UrunId = GetUrunIdFromName(x.UrunAd) // BURASI AÇIKLAMADA 👇
                }).ToList()
            };

            var client = new RestClient("https://localhost:7282");
            var request = new RestRequest("api/Fatura", Method.Post);
            request.AddJsonBody(fatura);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
                MessageBox.Show("Fatura başarıyla kaydedildi!");
            else
                MessageBox.Show("Fatura kaydedilemedi.");
        }

    }
}
