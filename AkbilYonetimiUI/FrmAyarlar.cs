using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI;

public partial class FrmAyarlar : Form
{
    public FrmAyarlar()
    {
        InitializeComponent();
    }
    AkbilDbContext context = new AkbilDbContext();
    private void FrmAyarlar_Load(object sender, EventArgs e)
    {
        txtSifre.PasswordChar = '*';
        dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
        dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
        dtpDogumTarihi.Format = DateTimePickerFormat.Short;
        KullanicininBilgileriniGetir();
    }

    private void KullanicininBilgileriniGetir()
    {
        try
        {
            var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Id == GenelIslemler.GirisYapanKullaniciId);
            if (kullanici != null)
            {
                txtAd.Text = kullanici.Ad;
                txtEmail.Text = kullanici.Email;
                txtEmail.Enabled = false;
                txtSoyad.Text = kullanici.Soyad;
                dtpDogumTarihi.Value = kullanici.DogumTarihi.Value;
            }
            else
            {
                MessageBox.Show("Kullanıcı bilgileri getirilemedi");
            }
        }
        catch (Exception hata)
        {

            MessageBox.Show("Beklenmedik bir hata oluştu! Litfen Tekrar deneyiniz." + hata.Message);

        }
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        try
        {
            var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Id == GenelIslemler.GirisYapanKullaniciId);
            if (kullanici != null)
            {
                kullanici.Ad = txtAd.Text.Trim();
                kullanici.Soyad = txtSoyad.Text.Trim();
                kullanici.DogumTarihi = dtpDogumTarihi.Value;
                if (!string.IsNullOrEmpty(txtSifre.Text.Trim()) && kullanici.Parola != GenelIslemler.MD5Encryption(txtSifre.Text.Trim()))
                {
                    kullanici.Parola = GenelIslemler.MD5Encryption(txtSifre.Text.Trim());
                    //MessageBox.Show("Yeni şifre girdiniz.");
                }

            }
            context.Kullanicilars.Update(kullanici);
            if (context.SaveChanges() > 0)
            {
                MessageBox.Show("Güncelleme Başarılı.");
                FrmAnaSayfa frmA = new FrmAnaSayfa();
                this.Hide();
                frmA.Show();
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız!!!");
                KullanicininBilgileriniGetir();
            }
        }
        catch (Exception hata)
        {
            MessageBox.Show("Güncelleme Başarısızdır!" + hata.Message);
        }
    }
}
