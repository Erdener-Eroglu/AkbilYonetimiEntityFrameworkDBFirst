namespace AkbilYonetimiUI
{
    partial class FrmGiris
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
            btnGiris = new Button();
            btnKayitOl = new Button();
            checkBoxHatirla = new CheckBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Snow;
            btnGiris.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(12, 152);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(274, 43);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.Snow;
            btnKayitOl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnKayitOl.Location = new Point(12, 201);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(274, 43);
            btnKayitOl.TabIndex = 4;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // checkBoxHatirla
            // 
            checkBoxHatirla.AutoSize = true;
            checkBoxHatirla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxHatirla.Location = new Point(146, 114);
            checkBoxHatirla.Name = "checkBoxHatirla";
            checkBoxHatirla.Size = new Size(140, 32);
            checkBoxHatirla.TabIndex = 2;
            checkBoxHatirla.Text = "Beni Hatırla!";
            checkBoxHatirla.UseVisualStyleBackColor = true;
            checkBoxHatirla.CheckedChanged += checkBoxHatirla_CheckedChanged;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(105, 64);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(181, 34);
            txtSifre.TabIndex = 1;
            txtSifre.KeyPress += txtSifre_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(105, 22);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 34);
            txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 11;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 12;
            label1.Text = "Email:";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.galata_kulesi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(639, 414);
            Controls.Add(btnGiris);
            Controls.Add(btnKayitOl);
            Controls.Add(checkBoxHatirla);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGiris";
            Text = "HOŞGELDİNİZ...";
            Load += FrmGiris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Button btnKayitOl;
        private CheckBox checkBoxHatirla;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
    }
}