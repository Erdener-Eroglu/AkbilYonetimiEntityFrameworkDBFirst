namespace AkbilYonetimiUI
{
    partial class FrmAnaSayfa
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
            btnAkbil = new Button();
            btnTalimatlar = new Button();
            btnAyarlar = new Button();
            SuspendLayout();
            // 
            // btnAkbil
            // 
            btnAkbil.BackColor = SystemColors.ActiveCaption;
            btnAkbil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAkbil.Location = new Point(95, 62);
            btnAkbil.Name = "btnAkbil";
            btnAkbil.Size = new Size(124, 96);
            btnAkbil.TabIndex = 0;
            btnAkbil.Text = "Akbil İşlemleri";
            btnAkbil.UseVisualStyleBackColor = false;
            btnAkbil.Click += btnAkbil_Click;
            // 
            // btnTalimatlar
            // 
            btnTalimatlar.BackColor = SystemColors.ActiveCaption;
            btnTalimatlar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTalimatlar.Location = new Point(95, 171);
            btnTalimatlar.Name = "btnTalimatlar";
            btnTalimatlar.Size = new Size(124, 96);
            btnTalimatlar.TabIndex = 0;
            btnTalimatlar.Text = "Talimatlar";
            btnTalimatlar.UseVisualStyleBackColor = false;
            btnTalimatlar.Click += btnTalimatlar_Click;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = SystemColors.ActiveCaption;
            btnAyarlar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAyarlar.Location = new Point(95, 280);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(124, 96);
            btnAyarlar.TabIndex = 0;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 455);
            Controls.Add(btnAyarlar);
            Controls.Add(btnTalimatlar);
            Controls.Add(btnAkbil);
            Name = "FrmAnaSayfa";
            Text = "FrmAnaSayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAkbil;
        private Button btnTalimatlar;
        private Button btnAyarlar;
    }
}