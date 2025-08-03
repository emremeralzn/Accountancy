using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muhasebe.Entities;
using Muhasebe.UI.Models;
using RestSharp;


namespace Muhasebe.UI.Forms
{
    public partial class CustomersForm : Form
    {
        private List<Customer> tumMusteriler = new List<Customer>();

        public CustomersForm()
        {
            InitializeComponent();
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            await MusterileriGetir();


        }
        private async Task MusterileriGetir()
        {
            var client = new RestClient("https://localhost:7282");
            var request = new RestRequest("api/Musteri", Method.Get);

            try
            {
                var response = await client.ExecuteAsync<List<Customer>>(request);
                if (response.IsSuccessful && response.Data != null)
                {
                    dgvMusteriler.DataSource = response.Data;
                    tumMusteriler = response.Data;
                    dgvMusteriler.DataSource = tumMusteriler;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvMusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];

                txtAd.Text = row.Cells["Ad"].Value.ToString();
                txtSoyad.Text = row.Cells["Soyad"].Value.ToString();
                txtTelefon.Text = row.Cells["Telefon"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }


        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest("api/Musteri", Method.Post);

            var yeniMusteri = new Customer
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text
            };

            request.AddJsonBody(yeniMusteri);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Müşteri eklendi.");
                MusterileriGetir();
            }
            else
            {
                MessageBox.Show("Ekleme başarısız.");
            }
        }



        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;

            int musteriId = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["id"].Value);

            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest($"api/Musteri", Method.Put);

            var guncelMusteri = new Customer
            {
                Id = musteriId,
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Email = txtEmail.Text
            };

            request.AddJsonBody(guncelMusteri);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Müşteri güncellendi.");
                MusterileriGetir();
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız.");
            }
        }



        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;

            int musteriId = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["id"].Value);

            var client = new RestClient("https://localhost:7282/");
            var request = new RestRequest($"api/Musteri/{musteriId}", Method.Delete);

            var response = await client.ExecuteAsync(request);
            if (response.IsSuccessful)
            {
                MessageBox.Show("Müşteri silindi.");
                MusterileriGetir();
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız.");
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtAra.Text.ToLower();

            var filtreli = tumMusteriler.Where(m =>
                m.Ad.ToLower().Contains(aranan) ||
                m.Soyad.ToLower().Contains(aranan) ||
                m.Email.ToLower().Contains(aranan) ||
                m.Telefon.ToLower().Contains(aranan)
            ).ToList();

            dgvMusteriler.DataSource = filtreli;

            // ID sütununu yine gizle
            if (dgvMusteriler.Columns.Contains("Id"))
                dgvMusteriler.Columns["Id"].Visible = false;
        }
        private void DataGridViewStilAyarla()
        {
            dgvMusteriler.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMusteriler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMusteriler.RowTemplate.Height = 28;
            dgvMusteriler.DefaultCellStyle.Padding = new Padding(4, 2, 4, 2);
            dgvMusteriler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dgvMusteriler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMusteriler.EnableHeadersVisualStyles = false;
            dgvMusteriler.AllowUserToAddRows = false;
            dgvMusteriler.AllowUserToResizeRows = false;
            dgvMusteriler.AllowUserToResizeColumns = false;
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


    }
}
