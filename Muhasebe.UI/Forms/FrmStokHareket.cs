using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Muhasebe.UI.Models;
using RestSharp;

namespace Muhasebe.UI.Forms
{
    public partial class FrmStokHareket : Form
    {
        private List<StokHareketViewModel> tumHareketler = new();
        private List<Product> urunler = new();

        public FrmStokHareket()
        {
            InitializeComponent();
            this.Load += FrmStokHareket_Load;
            btnKaydet.Click += BtnKaydet_Click;
        }

        private async void FrmStokHareket_Load(object sender, EventArgs e)
        {
            dgvHareketlerHazirla(); // Kolonlar burada hazırlanacak
            await UrunleriGetir();
            await HareketleriGetir();
        }

        private async Task UrunleriGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Urun", Method.Get);

            var response = await client.ExecuteAsync<List<Product>>(request);
            if (response.IsSuccessful && response.Data != null)
            {
                urunler = response.Data;
                cmbUrunler.DataSource = urunler;
                cmbUrunler.DisplayMember = "Ad";
                cmbUrunler.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Ürünler alınamadı.");
            }
        }

        private async Task HareketleriGetir()
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/StokHareket", Method.Get);

            var response = await client.ExecuteAsync<List<StokHareketViewModel>>(request);
            if (response.IsSuccessful && response.Data != null)
            {
                tumHareketler = response.Data;
                dgvHareketler.DataSource = tumHareketler
                    .Select(h => new
                    {
                        Id = h.Id,
                        UrunAd = h.UrunAd,
                        Miktar = h.Miktar,
                        Tip = h.GirisMi ? "Giriş" : "Çıkış",
                        Tarih = h.Tarih.ToString("dd.MM.yyyy HH:mm")
                    }).ToList();
            }
            else
            {
                MessageBox.Show("Stok hareketleri alınamadı.");
            }
        }

        private async void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbUrunler.SelectedItem is not Product urun)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (!int.TryParse(nudMiktar.Text.Trim(), out int miktar) || miktar <= 0)
            {
                MessageBox.Show("Lütfen geçerli ve pozitif bir miktar girin.");
                return;
            }

            var yeniHareket = new
            {
                UrunId = urun.Id,
                Miktar = (int)nudMiktar.Value,
                GirisMi = rbGiris.Checked,
                Tarih = dtTarih.Value
            };

            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/StokHareket", Method.Post);
            request.AddJsonBody(yeniHareket);

            var response = await client.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                MessageBox.Show("Stok hareketi kaydedildi.");
                await HareketleriGetir();
                Temizle();
            }
            else
            {
                var hata = response.ErrorMessage ?? response.Content ?? response.StatusDescription;
                MessageBox.Show("Kayıt başarısız: " + hata);
            }
        }

        private void Temizle()
        {
            rbGiris.Checked = true;
            dtTarih.Value = DateTime.Now;
        }

        private void dgvHareketlerHazirla()
        {
            dgvHareketler.AutoGenerateColumns = false;
            dgvHareketler.Columns.Clear();

            dgvHareketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 50
            });


            dgvHareketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Miktar",
                DataPropertyName = "Miktar",
                Width = 80
            });

            dgvHareketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tip",
                DataPropertyName = "Tip",
                Width = 80
            });

            dgvHareketler.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tarih",
                DataPropertyName = "Tarih",
                Width = 130
            });

            // Görsel düzen
            dgvHareketler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvHareketler.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvHareketler.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvHareketler.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvHareketler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHareketler.MultiSelect = false;
            dgvHareketler.ReadOnly = true;
            dgvHareketler.AllowUserToAddRows = false;
            dgvHareketler.AllowUserToDeleteRows = false;
            dgvHareketler.RowHeadersVisible = false;
        }
    }
}
