namespace AkbilYonetimiUI;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

public partial class FrmGiris : Form
{
    AkbilDbContext context = new AkbilDbContext();
    public string Email { get; set; } //Kayıt ol formunda kayıt olan kullanıcının emaili buraya gelsin.

    public FrmGiris()
    {
        InitializeComponent();
    }
    private void FrmGiris_Load(object sender, EventArgs e)
    {
        if (Email != null)
        {
            txtEmail.Text = Email;
        }
        txtSifre.PasswordChar = '*';
        if (Properties.Settings1.Default.BeniHatirla == true)
        {
            txtEmail.Text = Properties.Settings1.Default.KullaniciEmail;
            txtSifre.Text = Properties.Settings1.Default.KullaniciSifre;
            checkBoxHatirla.Checked = true;
        }
    }

    private void btnKayitOl_Click(object sender, EventArgs e)
    {
        this.Hide();
        FrmKayitOl frm = new FrmKayitOl();
        frm.Show();
    }

    private void btnGiris_Click(object sender, EventArgs e)
    {
        GirisYap();
    }

    private void GirisYap()
    {
        try
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            var kullanici = context.Kullanicilars.FirstOrDefault(x => x.Email == txtEmail.Text && x.Parola == GenelIslemler.MD5Encryption(txtSifre.Text));
            if (kullanici == null)
            {
                MessageBox.Show("Email ya da şifre yanlış tekrar deneyiniz");
                return;
            }
            else
            {
                MessageBox.Show($"Hoşgeldiniz... {kullanici.Ad} {kullanici.Soyad}");
                GenelIslemler.GirisYapanKullaniciAdSoyad = $"{kullanici.Ad} {kullanici.Soyad}";
                GenelIslemler.GirisYapanKullaniciId = kullanici.Id;
                GenelIslemler.GirisYapanKullaniciEmail = kullanici.Email;
                if (checkBoxHatirla.Checked)
                {
                    Properties.Settings1.Default.BeniHatirla = true;
                    Properties.Settings1.Default.KullaniciEmail = kullanici.Email;
                    Properties.Settings1.Default.KullaniciSifre = txtSifre.Text.Trim();
                    Properties.Settings1.Default.Save();
                }
                else
                {
                    Properties.Settings1.Default.BeniHatirla = false;
                    Properties.Settings1.Default.KullaniciEmail = "";
                    Properties.Settings1.Default.KullaniciSifre = "";
                    Properties.Settings1.Default.Save();
                }
                txtEmail.Clear();
                txtSifre.Clear();
                FrmAnaSayfa frmA = new FrmAnaSayfa();
                this.Hide();
                frmA.Show();
            }
        }
        catch (Exception hata)
        {
            //DipNot exceptionlar asla kullanıcıya gösterilmez
            //Exceptionlar loglanır. Viz şu an çğrenme/geliştirme aşamasında oluğumuz için yazdık.
            MessageBox.Show("Beklenmedik bir sorun oluştu: " + hata.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }

    private void checkBoxHatirla_CheckedChanged(object sender, EventArgs e)
    {
        //Properties.Settings1.Default.BeniHatirla = checkBoxHatirla.Checked;
    }
    private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == Convert.ToChar(Keys.Enter))
            GirisYap();
    }
}
