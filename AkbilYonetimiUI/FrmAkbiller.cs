namespace AkbilYonetimiUI
{
    public partial class FrmAkbiller : Form
    {
        public FrmAkbiller()
        {
            InitializeComponent();
        }
        private void anaMenüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
                if(maskedTextBoxAkbilNo.Text.Length < 16)
                {
                    MessageBox.Show("Akbil NO 16 haneli olmak zorundadır");
                    return;
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
    }
}
