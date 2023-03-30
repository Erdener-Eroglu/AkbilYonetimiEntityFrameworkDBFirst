using System.Collections;

namespace AkbilYonetimiUI;

public partial class FrmGiris : Form
{
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
        txtEmail.Text = "erdener.eroglu98@hotmail.com";
        txtSifre.Text = "123456";
        checkBoxHatirla.Checked = true;
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
            //1) Email ve şifre text boxları dolu mu?
            //2)Girdiği email ve  şifre veri tabanında mevcut mu?
            //Eğer email şifre doğru ise
            //Eğer beni hatırla tıklıysa Bilgileri hatırlanacak...
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Bilgileri eksiksiz giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
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
