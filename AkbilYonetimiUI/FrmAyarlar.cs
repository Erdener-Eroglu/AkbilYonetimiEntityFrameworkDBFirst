namespace AkbilYonetimiUI;

public partial class FrmAyarlar : Form
{
    public FrmAyarlar()
    {
        InitializeComponent();
    }

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

    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        try
        {
            
        }
        catch (Exception hata)
        {
            MessageBox.Show("Güncelleme Başarısızdır!" + hata.Message);
        }
    }
}
