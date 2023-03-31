using AkbilYonetimiVeriKatmani;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI;

public partial class FrmKayitOl : Form
{
    AkbilDbContext context = new AkbilDbContext();
    public FrmKayitOl()
    {
        InitializeComponent();
    }

    private void FrmKayitOl_Load(object sender, EventArgs e)
    {
        #region Ayarlar
        txtSifre.PasswordChar = '*';
        dtpDogumTarihi.MaxDate = new DateTime(2016, 1, 1);
        dtpDogumTarihi.Value = new DateTime(2016, 1, 1);
        dtpDogumTarihi.Format = DateTimePickerFormat.Short;
        #endregion
    }

    private void btnKayıtOl_Click(object sender, EventArgs e)
    {
        try
        {
            btnKayıtOl.Enabled = false;
            btnGiris.Enabled = false;
            foreach (var item in Controls)
            {
                if (item is TextBox txt && string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Zorunlu alanları doldurunuz");
                    btnKayıtOl.Enabled = true;
                    btnGiris.Enabled = true;
                    return;
                }
            }
            if(context.Kullanicilars.FirstOrDefault(x=>x.Email == txtEmail.Text.Trim()) != null)
            {
                MessageBox.Show("Bu email sisteme kayıtlıdır");
                btnKayıtOl.Enabled = true;
                btnGiris.Enabled = true;
                return;
            }
            Kullanicilar yeniKullanici = new Kullanicilar()
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                EklenmeTarihi = DateTime.Now,
                Email = txtEmail.Text.Trim(),
                Parola = GenelIslemler.MD5Encryption(txtSifre.Text.Trim()),
                DogumTarihi = dtpDogumTarihi.Value
            };
            context.Kullanicilars.Add(yeniKullanici);
            if(context.SaveChanges() > 0 )
            {
                MessageBox.Show("Yeni Kullanici Eklendi.");
                foreach (var item in Controls)
                {
                    if(item is TextBox txt)
                    {
                        txt.Clear();
                    }
                    if(item is DateTimePicker dtp)
                    {
                        dtp.Value = dtpDogumTarihi.MaxDate;
                    }
                }

                DialogResult cevap = MessageBox.Show("Giriş sayfasına gitmek ister misiniz?","SORU",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(cevap == DialogResult.Yes) 
                {
                    FrmGiris frmG = new FrmGiris();
                    frmG.Email = yeniKullanici.Email;
                    this.Hide();
                    frmG.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanici ekleme başarısız oldu.");
            }
            btnKayıtOl.Enabled = true;
            btnGiris.Enabled = true;
        }
        catch (Exception ex)
        {

            //ex log.txt'ye yazaılacak (loglama)
            MessageBox.Show("Beklenmedik bir hata oluştu! Litfen Tekrar deneyiniz.");
            btnGiris.Enabled=true;
            btnKayıtOl.Enabled=true;
        }
    }

    private void GirisFromunaGit()
    {
        FrmGiris frmG = new FrmGiris();
        frmG.Email = txtEmail.Text.Trim();
        this.Hide();
        frmG.Show();
    }

    private void FrmKayitOl_FormClosed(object sender, FormClosedEventArgs e)
    {
        GirisFromunaGit();
    }

    private void btnGiris_Click(object sender, EventArgs e)
    {
        GirisFromunaGit();
    }
}
