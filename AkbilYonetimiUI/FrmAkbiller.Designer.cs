namespace AkbilYonetimiUI
{
    partial class FrmAkbiller
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
            menuStrip1 = new MenuStrip();
            anaMenüToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnKaydet = new Button();
            cmbAkbilTipler = new ComboBox();
            maskedTextBoxAkbilNo = new MaskedTextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewAkbiller = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { anaMenüToolStripMenuItem, cikisYapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(702, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // anaMenüToolStripMenuItem
            // 
            anaMenüToolStripMenuItem.Name = "anaMenüToolStripMenuItem";
            anaMenüToolStripMenuItem.Size = new Size(121, 32);
            anaMenüToolStripMenuItem.Text = "Ana Sayfa";
            anaMenüToolStripMenuItem.Click += anaMenüToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(109, 32);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(cmbAkbilTipler);
            groupBox1.Controls.Add(maskedTextBoxAkbilNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 149);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnKaydet.Location = new Point(493, 40);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(150, 93);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "YENİ AKBİL KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // cmbAkbilTipler
            // 
            cmbAkbilTipler.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAkbilTipler.FormattingEnabled = true;
            cmbAkbilTipler.Items.AddRange(new object[] { "Öğrenci Akbili", "Tam Akbili", "Anne Kartı", "65+ Kartı", "Öğretmen Kartı" });
            cmbAkbilTipler.Location = new Point(120, 97);
            cmbAkbilTipler.Name = "cmbAkbilTipler";
            cmbAkbilTipler.Size = new Size(348, 36);
            cmbAkbilTipler.TabIndex = 2;
            // 
            // maskedTextBoxAkbilNo
            // 
            maskedTextBoxAkbilNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBoxAkbilNo.Location = new Point(120, 43);
            maskedTextBoxAkbilNo.Mask = "0000000000000000";
            maskedTextBoxAkbilNo.Name = "maskedTextBoxAkbilNo";
            maskedTextBoxAkbilNo.Size = new Size(348, 34);
            maskedTextBoxAkbilNo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 100);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 0;
            label2.Text = "Akbil Tipi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 43);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 0;
            label1.Text = "Akbil No:";
            // 
            // dataGridViewAkbiller
            // 
            dataGridViewAkbiller.AllowUserToAddRows = false;
            dataGridViewAkbiller.AllowUserToDeleteRows = false;
            dataGridViewAkbiller.AllowUserToOrderColumns = true;
            dataGridViewAkbiller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAkbiller.Location = new Point(12, 225);
            dataGridViewAkbiller.Name = "dataGridViewAkbiller";
            dataGridViewAkbiller.ReadOnly = true;
            dataGridViewAkbiller.RowHeadersWidth = 51;
            dataGridViewAkbiller.RowTemplate.Height = 29;
            dataGridViewAkbiller.Size = new Size(662, 204);
            dataGridViewAkbiller.TabIndex = 2;
            // 
            // FrmAkbiller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 472);
            Controls.Add(dataGridViewAkbiller);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmAkbiller";
            Text = "FrmAkbiller";
            Load += FrmAkbiller_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAkbiller).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem anaMenüToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private GroupBox groupBox1;
        private Button btnKaydet;
        private ComboBox cmbAkbilTipler;
        private MaskedTextBox maskedTextBoxAkbilNo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewAkbiller;
    }
}