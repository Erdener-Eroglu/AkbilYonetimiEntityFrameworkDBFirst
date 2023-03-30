namespace AkbilYonetimiUI
{
    partial class FrmKayitOl
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnKayıtOl = new Button();
            btnGiris = new Button();
            dtpDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(84, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 80);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 0;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(72, 123);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(80, 166);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 0;
            label4.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 213);
            label5.Name = "label5";
            label5.Size = new Size(85, 28);
            label5.TabIndex = 0;
            label5.Text = "D. Tarihi:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(140, 34);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(250, 34);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(140, 77);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(250, 34);
            txtSoyad.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(140, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 34);
            txtEmail.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(140, 163);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(250, 34);
            txtSifre.TabIndex = 3;
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayıtOl.Location = new Point(84, 256);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(306, 42);
            btnKayıtOl.TabIndex = 5;
            btnKayıtOl.Text = "KAYIT OL";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(84, 313);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(306, 42);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "GİRİŞ YAP";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(140, 215);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(250, 27);
            dtpDogumTarihi.TabIndex = 4;
            // 
            // FrmKayitOl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 407);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(btnGiris);
            Controls.Add(btnKayıtOl);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKayitOl";
            Text = "KAYIT OL FORMU";
            FormClosed += FrmKayitOl_FormClosed;
            Load += FrmKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnKayıtOl;
        private Button btnGiris;
        private DateTimePicker dtpDogumTarihi;
    }
}