namespace AkbilYonetimiUI;

public partial class FrmKayitOl : Form
{
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
            foreach (var item in Controls)
            {
                if (item is TextBox txt && string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Zorunlu alanları doldurunuz");
                    return;
                }
            }
            
        }
        catch (Exception ex)
        {

            //ex log.txt'ye yazaılacak (loglama)
            MessageBox.Show("Beklenmedik bir hata oluştu! Litfen Tekrar deneyiniz.");
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
