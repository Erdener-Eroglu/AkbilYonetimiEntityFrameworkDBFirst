namespace AkbilYonetimiUI
{
    partial class FrmTalimatlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            anaMaenuToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            cmbAkbiller = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtYuklenecekTutar = new TextBox();
            btnTalimatıKaydet = new Button();
            lblBekleyenTalimat = new Label();
            chcTumunuGoster = new CheckBox();
            dataGridViewTalimatlar = new DataGridView();
            tmrBekleyenTalimat = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            talimatiYukleToolStripMenuItem = new ToolStripMenuItem();
            talimatiIptalEtToolStripMenuItem = new ToolStripMenuItem();
            grpYukleme = new GroupBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).BeginInit();
            contextMenuStrip1.SuspendLayout();
            grpYukleme.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMaenuToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1146, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMaenuToolStripMenuItem
            // 
            anaMaenuToolStripMenuItem.Name = "anaMaenuToolStripMenuItem";
            anaMaenuToolStripMenuItem.Size = new Size(114, 29);
            anaMaenuToolStripMenuItem.Text = "Ana Menü";
            anaMaenuToolStripMenuItem.Click += anaMaenuToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(100, 29);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // cmbAkbiller
            // 
            cmbAkbiller.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAkbiller.FormattingEnabled = true;
            cmbAkbiller.Location = new Point(12, 69);
            cmbAkbiller.Name = "cmbAkbiller";
            cmbAkbiller.Size = new Size(501, 33);
            cmbAkbiller.TabIndex = 1;
            cmbAkbiller.SelectedIndexChanged += cmbAkbiller_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(549, 69);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 2;
            label1.Text = "Bekleyen Talimat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 26);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 3;
            label2.Text = "Yüklenecek Tutar:";
            // 
            // txtYuklenecekTutar
            // 
            txtYuklenecekTutar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtYuklenecekTutar.Location = new Point(163, 26);
            txtYuklenecekTutar.Name = "txtYuklenecekTutar";
            txtYuklenecekTutar.Size = new Size(131, 31);
            txtYuklenecekTutar.TabIndex = 4;
            // 
            // btnTalimatıKaydet
            // 
            btnTalimatıKaydet.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTalimatıKaydet.Location = new Point(345, 26);
            btnTalimatıKaydet.Name = "btnTalimatıKaydet";
            btnTalimatıKaydet.Size = new Size(138, 35);
            btnTalimatıKaydet.TabIndex = 5;
            btnTalimatıKaydet.Text = "Talimatı Kaydet";
            btnTalimatıKaydet.UseVisualStyleBackColor = true;
            btnTalimatıKaydet.Click += btnTalimatıKaydet_Click;
            // 
            // lblBekleyenTalimat
            // 
            lblBekleyenTalimat.AutoSize = true;
            lblBekleyenTalimat.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblBekleyenTalimat.ForeColor = Color.FromArgb(192, 0, 0);
            lblBekleyenTalimat.Location = new Point(627, 97);
            lblBekleyenTalimat.Name = "lblBekleyenTalimat";
            lblBekleyenTalimat.Size = new Size(35, 41);
            lblBekleyenTalimat.TabIndex = 6;
            lblBekleyenTalimat.Text = "0";
            // 
            // chcTumunuGoster
            // 
            chcTumunuGoster.AutoSize = true;
            chcTumunuGoster.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            chcTumunuGoster.Location = new Point(12, 222);
            chcTumunuGoster.Name = "chcTumunuGoster";
            chcTumunuGoster.Size = new Size(156, 29);
            chcTumunuGoster.TabIndex = 7;
            chcTumunuGoster.Text = "Tümünü Göster";
            chcTumunuGoster.UseVisualStyleBackColor = true;
            chcTumunuGoster.CheckedChanged += chcTumunuGoster_CheckedChanged;
            // 
            // dataGridViewTalimatlar
            // 
            dataGridViewTalimatlar.AllowUserToAddRows = false;
            dataGridViewTalimatlar.AllowUserToDeleteRows = false;
            dataGridViewTalimatlar.AllowUserToOrderColumns = true;
            dataGridViewTalimatlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTalimatlar.Location = new Point(12, 263);
            dataGridViewTalimatlar.Name = "dataGridViewTalimatlar";
            dataGridViewTalimatlar.ReadOnly = true;
            dataGridViewTalimatlar.RowHeadersWidth = 51;
            dataGridViewTalimatlar.RowTemplate.Height = 29;
            dataGridViewTalimatlar.Size = new Size(1100, 189);
            dataGridViewTalimatlar.TabIndex = 8;
            // 
            // tmrBekleyenTalimat
            // 
            tmrBekleyenTalimat.Tick += tmrBekleyenTalimat_Tick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { talimatiYukleToolStripMenuItem, talimatiIptalEtToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(215, 84);
            // 
            // talimatiYukleToolStripMenuItem
            // 
            talimatiYukleToolStripMenuItem.Image = Properties.Resources.tik;
            talimatiYukleToolStripMenuItem.Name = "talimatiYukleToolStripMenuItem";
            talimatiYukleToolStripMenuItem.Size = new Size(214, 26);
            talimatiYukleToolStripMenuItem.Text = "Talimatı Yükle";
            talimatiYukleToolStripMenuItem.Click += talimatiYukleToolStripMenuItem_Click;
            // 
            // talimatiIptalEtToolStripMenuItem
            // 
            talimatiIptalEtToolStripMenuItem.Image = Properties.Resources.cancel;
            talimatiIptalEtToolStripMenuItem.Name = "talimatiIptalEtToolStripMenuItem";
            talimatiIptalEtToolStripMenuItem.Size = new Size(214, 26);
            talimatiIptalEtToolStripMenuItem.Text = "Talimatı İptal Et";
            talimatiIptalEtToolStripMenuItem.Click += talimatiIptalEtToolStripMenuItem_Click;
            // 
            // grpYukleme
            // 
            grpYukleme.Controls.Add(label2);
            grpYukleme.Controls.Add(txtYuklenecekTutar);
            grpYukleme.Controls.Add(btnTalimatıKaydet);
            grpYukleme.Location = new Point(12, 119);
            grpYukleme.Name = "grpYukleme";
            grpYukleme.Size = new Size(501, 84);
            grpYukleme.TabIndex = 9;
            grpYukleme.TabStop = false;
            // 
            // FrmTalimatlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 481);
            Controls.Add(grpYukleme);
            Controls.Add(dataGridViewTalimatlar);
            Controls.Add(chcTumunuGoster);
            Controls.Add(lblBekleyenTalimat);
            Controls.Add(label1);
            Controls.Add(cmbAkbiller);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmTalimatlar";
            Text = "FrmTalimatlar";
            Load += FrmTalimatlar_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTalimatlar).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            grpYukleme.ResumeLayout(false);
            grpYukleme.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMaenuToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ComboBox cmbAkbiller;
        private Label label1;
        private Label label2;
        private TextBox txtYuklenecekTutar;
        private Button btnTalimatıKaydet;
        private Label lblBekleyenTalimat;
        private CheckBox chcTumunuGoster;
        private DataGridView dataGridViewTalimatlar;
        private System.Windows.Forms.Timer tmrBekleyenTalimat;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox grpYukleme;
        private ToolStripMenuItem talimatiYukleToolStripMenuItem;
        private ToolStripMenuItem talimatiIptalEtToolStripMenuItem;
    }
}