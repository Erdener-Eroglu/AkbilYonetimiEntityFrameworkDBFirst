using System.Collections;
using AkbilYonetimiIsKatmani;
using AkbilYonetimiVeriKatmani;
using AkbilYonetimiVeriKatmani.Models;

namespace AkbilYonetimiUI;

public partial class FrmTalimatlar : Form
{
    AkbilDbContext context = new AkbilDbContext();

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
            var bekleyen = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciId && !x.YuklendiMi);
            if (cmbAkbiller.SelectedIndex >= 0)
            {
                lblBekleyenTalimat.Text = bekleyen.Count(x=>x.Akbil.Substring(0,16) == cmbAkbiller.SelectedValue.ToString()).ToString();
            }
            else
            {
                lblBekleyenTalimat.Text = bekleyen.Count().ToString();
            }
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
            dataGridViewTalimatlar.DataSource = context.KullanicininTalimatlaris.Where(x => x.KullaniciId == GenelIslemler.GirisYapanKullaniciId).ToList();
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
            cmbAkbiller.DataSource = context.Akbillers.Where(x => x.AkbilSahibiId == GenelIslemler.GirisYapanKullaniciId).ToList();
            cmbAkbiller.DisplayMember = "AkbilNo";
            cmbAkbiller.ValueMember = "AkbilNo";
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
            Talimatlar yeniTalimat = new Talimatlar()
            {
                OlusturulmaTarihi = DateTime.Now,
                AkbilId = cmbAkbiller.SelectedValue.ToString(),
                YuklendiMi = false,
                YuklenecekTutar = Convert.ToDecimal(txtYuklenecekTutar.Text),
                YuklenmeTarih = null
            };
            context.Talimatlars.Add(yeniTalimat);
            if(context.SaveChanges() > 0)
            {
                MessageBox.Show("Yeni talimat eklendi");
                cmbAkbiller.SelectedIndex = -1;
                cmbAkbiller.Text = "Akbil Seçiniz...";
                txtYuklenecekTutar.Clear();
            }
            else
            {
                MessageBox.Show("Talimat Eklenemedi");
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
                var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);
                if(secilenTalimat != null)
                {
                    context.Talimatlars.Remove(secilenTalimat);
                    sayac += context.SaveChanges();
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
                var secilenTalimat = context.Talimatlars.FirstOrDefault(x => x.Id == (int)item.Cells["Id"].Value);
                if(secilenTalimat != null)
                {
                    secilenTalimat.YuklendiMi = true;
                    secilenTalimat.YuklenmeTarih = DateTime.Now;
                    secilenTalimat.Akbil.Bakiye += Convert.ToDecimal(item.Cells["YuklenecekTutar"].Value);
                    context.Talimatlars.Update(secilenTalimat);
                    context.Akbillers.Update(secilenTalimat.Akbil);
                    context.SaveChanges();
                    sayac++;
                }

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
