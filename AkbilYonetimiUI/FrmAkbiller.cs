using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI
{
    public partial class FrmAkbiller : Form
    {
        AkbilDbContext context = new AkbilDbContext();
        public FrmAkbiller()
        {
            InitializeComponent();
        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAnaSayfa frmA = new FrmAnaSayfa();
            frmA.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAkbilTipler.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen ekleyeceğiniz akbilin türünü seçiniz.");
                    return;
                }
                if (maskedTextBoxAkbilNo.Text.Length < 16)
                {
                    MessageBox.Show("Akbil NO 16 haneli olmak zorundadır");
                    return;
                }
                Akbiller yeniAkbil = new Akbiller()
                {
                    AkbilNo = maskedTextBoxAkbilNo.Text,
                    AkbilSahibiId = GenelIslemler.GirisYapanKullaniciId,
                    AkbilTipi = cmbAkbilTipler.SelectedItem.ToString(),
                    EklenmeTarihi = DateTime.Now,
                    Bakiye = 0,
                    VizelendigiTarihi = null
                };
                context.Akbillers.Add(yeniAkbil);
                int sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    MessageBox.Show("Akbiliniz kaydedilmiştir");
                }
                else
                {
                    MessageBox.Show("Akbiliniz Kaydedilmedi!!!");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu" + hata.Message);
            }
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            cmbAkbilTipler.Text = "Akbil tipi seçiniz....";
            cmbAkbilTipler.SelectedIndex = -1;
            dataGridViewAkbiller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewiDoldur();
        }

        private void DataGridViewiDoldur()
        {
            try
            {
                dataGridViewAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciId).ToList();
                //Bazı kolonlar Gizlensin
                dataGridViewAkbiller.Columns["AkbilSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarihi"].HeaderText = "Vizelendiği Tarih";
                dataGridViewAkbiller.Columns["VizelendigiTarihi"].Width = 200;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Akbilleri listeleyemedim" + hata.Message);
            }
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle Çıkış Yapıldı");
            GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
            GenelIslemler.GirisYapanKullaniciId = 0;

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name != "FrmGiris")
                {
                    item.Hide();
                }
            }
            Application.OpenForms["FrmGiris"].Show();
        }
    }
}
