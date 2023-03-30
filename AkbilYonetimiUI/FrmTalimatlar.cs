using System.Collections;

namespace AkbilYonetimiUI;

public partial class FrmTalimatlar : Form
{
    public FrmTalimatlar()
    {
        InitializeComponent();
    }

    private void FrmTalimatlar_Load(object sender, EventArgs e)
    {
        lblBekleyenTalimat.Font = new Font("Segoe UI", 25);
        lblBekleyenTalimat.ForeColor = Color.Red;
        ComboBoxaKullanicininAkbilleriniGetir();
        cmbAkbiller.SelectedIndex = -1;
        cmbAkbiller.Text = "Akbil Seçiniz...";
        grpYukleme.Enabled = false;
        //cmbAkbiller.DropDownStyle = ComboBoxStyle.DropDownList;
        dataGridViewTalimatlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        TalimatlariDataGrideGetir();
        dataGridViewTalimatlar.ContextMenuStrip = contextMenuStrip1;
        chcTumunuGoster.Checked = false;
        BekleyenTalimatSayisiniGetir();
        tmrBekleyenTalimat.Interval = 1000;
        tmrBekleyenTalimat.Enabled = true;
    }

    private void BekleyenTalimatSayisiniGetir()
    {
        try
        {

        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
        }
    }

    private void TalimatlariDataGrideGetir(bool tumunuGoster = false, string akbilno = null)
    {
        try
        {

            foreach (DataGridViewColumn item in dataGridViewTalimatlar.Columns)
            {
                item.Width = 200;
            }
            dataGridViewTalimatlar.Columns["Id"].Visible = false;
            dataGridViewTalimatlar.Columns["Akbil"].Width = 300;
            dataGridViewTalimatlar.Columns["YuklendiMi"].HeaderText = "Talimat Yuklendi Mi?";
            dataGridViewTalimatlar.Columns["YuklendiMi"].Width = 150;
            dataGridViewTalimatlar.Columns["KullaniciId"].Visible = false;

        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
        }
    }

    private void ComboBoxaKullanicininAkbilleriniGetir()
    {
        try
        {

        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
        }
    }

    private void cmbAkbiller_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cmbAkbiller.SelectedIndex >= 0)
        {
            txtYuklenecekTutar.Clear();
            grpYukleme.Enabled = true;
        }
        else
        {
            txtYuklenecekTutar.Clear();
            grpYukleme.Enabled = false;
        }
        BekleyenTalimatSayisiniGetir();
        TalimatlariDataGrideGetir(chcTumunuGoster.Checked);
    }

    private void btnTalimatıKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            if (cmbAkbiller.SelectedIndex < 0)
            {
                MessageBox.Show("Akbil seçmeden talimat kaydedilemez! ");
                return;
            }
            if (string.IsNullOrEmpty(txtYuklenecekTutar.Text))
            {
                MessageBox.Show("Yükleme miktarı girişi zorunludur.");
                return;
            }
            if (!decimal.TryParse(txtYuklenecekTutar.Text.Trim(), out decimal tutar))
            {
                MessageBox.Show("Yükleme miktarı girişi uygun formatta olmalıdır.");
                return;
            }

            
        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
        }
    }

    private void chcTumunuGoster_CheckedChanged(object sender, EventArgs e)
    {
        TalimatlariDataGrideGetir(chcTumunuGoster.Checked);
    }

    private void anaMaenuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        FrmAnaSayfa frmA = new FrmAnaSayfa();
        this.Hide();
        frmA.Show();
    }

    private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Güle güle çıkış yapıldı.");
        //GenelIslemler.GirisYapanKullaniciAdSoyad = string.Empty;
        //GenelIslemler.GirisYapanKullaniciId = 0;
        foreach (Form item in Application.OpenForms)
        {
            if (item.Name != "FrmGiris")
            {
                item.Hide();
            }
        }
        Application.OpenForms["FrmGiris"].Show();
    }

    private void tmrBekleyenTalimat_Tick(object sender, EventArgs e)
    {
        if (lblBekleyenTalimat.Text != "0")
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                lblBekleyenTalimat.Font = new Font("Segoe UI", 40);
                lblBekleyenTalimat.ForeColor = Color.Green;
            }
            else
            {
                lblBekleyenTalimat.Font = new Font("Segoe UI", 25);
                lblBekleyenTalimat.ForeColor = Color.Red;
            }
        }
    }

    private void talimatiIptalEtToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            int sayac = 0;
            foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
            {
                //Yüklenmiş bir talimat iptal edilemez silinemez.
                if ((bool)item.Cells["YuklendiMi"].Value)
                {
                    MessageBox.Show($"DİKKAT! {item.Cells["Akbil"].Value} {item.Cells["YuklenecekTutar"].Value} liralık yüklemesi yapılmıştır. YÜKLENEN TALİMAT İPTAL EDİLEMEZ/SİLİNEMEZ!\nİşlemlerinize devam etmek için tamama basınız.");
                    continue;
                }
               
            }
            MessageBox.Show($"Seçtiğiniz {sayac} adet talimat iptal edilmiştir.");
            TalimatlariDataGrideGetir();
            BekleyenTalimatSayisiniGetir();
        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu!" + hata.Message);
        }
    }

    private void talimatiYukleToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            int sayac = 0;
            foreach (DataGridViewRow item in dataGridViewTalimatlar.SelectedRows)
            {
                if ((bool)item.Cells["YuklendiMi"].Value)
                {
                    continue;
                }
                //talimatlar tablosunu güncellemek
                
            } // foreach bitti.
            MessageBox.Show($"{sayac} adet talimat akbile yüklendi!");
            TalimatlariDataGrideGetir();
            BekleyenTalimatSayisiniGetir();
        }
        catch (Exception hata)
        {
            MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message);
        }
    }
}
