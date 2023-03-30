namespace AkbilYonetimiUI
{
    partial class FrmAyarlar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnGuncelle = new Button();
            txtEmail = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSifre = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 28);
            label2.TabIndex = 0;
            label2.Text = "İsim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 121);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 0;
            label3.Text = "Soyisim:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(312, 32);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 0;
            label4.Text = "D.Tarihi:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(297, 115);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 0;
            label5.Text = "Yeni Şifre:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.Location = new Point(21, 201);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(561, 58);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "BİLGİLERİ GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(88, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 34);
            txtEmail.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(88, 75);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(184, 34);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(88, 118);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(184, 34);
            txtSoyad.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(398, 115);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(184, 34);
            txtSifre.TabIndex = 2;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarihi.Location = new Point(398, 27);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(184, 34);
            dtpDogumTarihi.TabIndex = 3;
            // 
            // FrmAyarlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 322);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(txtSifre);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtEmail);
            Controls.Add(btnGuncelle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAyarlar";
            Text = "FrmAyarlar";
            Load += FrmAyarlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnGuncelle;
        private TextBox txtEmail;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtSifre;
        private DateTimePicker dtpDogumTarihi;
    }
}