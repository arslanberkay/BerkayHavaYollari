namespace WFAHavaYollariProjesi.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            btnDegis = new Button();
            dtpTarih = new DateTimePicker();
            cbNereye = new ComboBox();
            cbNereden = new ComboBox();
            mtxtSaat = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnKaydet = new Button();
            mtxtTc = new MaskedTextBox();
            mtxtTelefon = new MaskedTextBox();
            txtMail = new TextBox();
            txtAdSoyad = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lstUcusBilgileri = new ListBox();
            btnMailGonder = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(btnDegis);
            groupBox1.Controls.Add(dtpTarih);
            groupBox1.Controls.Add(cbNereye);
            groupBox1.Controls.Add(cbNereden);
            groupBox1.Controls.Add(mtxtSaat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(66, 200);
            groupBox1.Margin = new Padding(5, 3, 5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 3, 5, 3);
            groupBox1.Size = new Size(395, 267);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // btnDegis
            // 
            btnDegis.Location = new Point(325, 70);
            btnDegis.Name = "btnDegis";
            btnDegis.Size = new Size(53, 45);
            btnDegis.TabIndex = 4;
            btnDegis.Text = "<>";
            btnDegis.UseVisualStyleBackColor = true;
            btnDegis.Click += btnDegis_Click;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(122, 151);
            dtpTarih.Margin = new Padding(4, 3, 4, 3);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(189, 34);
            dtpTarih.TabIndex = 3;
            // 
            // cbNereye
            // 
            cbNereye.FormattingEnabled = true;
            cbNereye.Items.AddRange(new object[] { "Ankara", "Istanbul", "Izmir", "Aydın", "Samsun", "Trabzon", "Urfa" });
            cbNereye.Location = new Point(122, 100);
            cbNereye.Margin = new Padding(4, 3, 4, 3);
            cbNereye.Name = "cbNereye";
            cbNereye.Size = new Size(196, 34);
            cbNereye.TabIndex = 2;
            // 
            // cbNereden
            // 
            cbNereden.FormattingEnabled = true;
            cbNereden.Items.AddRange(new object[] { "Ankara", "Istanbul", "Izmir", "Aydın", "Samsun", "Trabzon", "Urfa" });
            cbNereden.Location = new Point(122, 53);
            cbNereden.Margin = new Padding(4, 3, 4, 3);
            cbNereden.Name = "cbNereden";
            cbNereden.Size = new Size(196, 34);
            cbNereden.TabIndex = 2;
            // 
            // mtxtSaat
            // 
            mtxtSaat.Location = new Point(122, 200);
            mtxtSaat.Margin = new Padding(4, 3, 4, 3);
            mtxtSaat.Mask = "00:00";
            mtxtSaat.Name = "mtxtSaat";
            mtxtSaat.Size = new Size(82, 34);
            mtxtSaat.TabIndex = 1;
            mtxtSaat.ValidatingType = typeof(DateTime);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 206);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 0;
            label5.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 155);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 0;
            label4.Text = "Tarih :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 0;
            label3.Text = "Nereye :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 0;
            label2.Text = "Nereden :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(255, 224, 192);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(mtxtTc);
            groupBox2.Controls.Add(mtxtTelefon);
            groupBox2.Controls.Add(txtMail);
            groupBox2.Controls.Add(txtAdSoyad);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(517, 200);
            groupBox2.Margin = new Padding(5, 3, 5, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 3, 5, 3);
            groupBox2.Size = new Size(367, 303);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.PaleGreen;
            btnKaydet.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            btnKaydet.Location = new Point(146, 243);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(176, 49);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // mtxtTc
            // 
            mtxtTc.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            mtxtTc.Location = new Point(136, 98);
            mtxtTc.Margin = new Padding(4, 3, 4, 3);
            mtxtTc.Mask = "00000000000";
            mtxtTc.Name = "mtxtTc";
            mtxtTc.Size = new Size(186, 34);
            mtxtTc.TabIndex = 1;
            mtxtTc.ValidatingType = typeof(int);
            // 
            // mtxtTelefon
            // 
            mtxtTelefon.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            mtxtTelefon.Location = new Point(136, 150);
            mtxtTelefon.Margin = new Padding(4, 3, 4, 3);
            mtxtTelefon.Mask = "(999) 000-0000";
            mtxtTelefon.Name = "mtxtTelefon";
            mtxtTelefon.Size = new Size(186, 34);
            mtxtTelefon.TabIndex = 1;
            // 
            // txtMail
            // 
            txtMail.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            txtMail.Location = new Point(136, 200);
            txtMail.Margin = new Padding(4, 3, 4, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(186, 34);
            txtMail.TabIndex = 1;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            txtAdSoyad.Location = new Point(136, 47);
            txtAdSoyad.Margin = new Padding(4, 3, 4, 3);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(186, 34);
            txtAdSoyad.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            label8.Location = new Point(34, 153);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 28);
            label8.TabIndex = 0;
            label8.Text = "Telefon :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            label9.Location = new Point(62, 206);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 28);
            label9.TabIndex = 0;
            label9.Text = "Mail :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            label6.Location = new Point(9, 53);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 0;
            label6.Text = "Ad Soyad :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poor Richard", 14F, FontStyle.Bold);
            label7.Location = new Point(78, 101);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 28);
            label7.TabIndex = 0;
            label7.Text = "TC :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 255, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(66, 12);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 167);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(448, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 49);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 58);
            label1.TabIndex = 0;
            label1.Text = "Berkay Hava Yolları";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstUcusBilgileri
            // 
            lstUcusBilgileri.FormattingEnabled = true;
            lstUcusBilgileri.HorizontalScrollbar = true;
            lstUcusBilgileri.ItemHeight = 26;
            lstUcusBilgileri.Location = new Point(66, 527);
            lstUcusBilgileri.Name = "lstUcusBilgileri";
            lstUcusBilgileri.Size = new Size(818, 134);
            lstUcusBilgileri.TabIndex = 3;
            // 
            // btnMailGonder
            // 
            btnMailGonder.BackColor = SystemColors.ActiveCaption;
            btnMailGonder.Location = new Point(350, 684);
            btnMailGonder.Name = "btnMailGonder";
            btnMailGonder.Size = new Size(239, 51);
            btnMailGonder.TabIndex = 3;
            btnMailGonder.Text = "Mail ile Gönder";
            btnMailGonder.UseVisualStyleBackColor = false;
            btnMailGonder.Click += btnMailGonder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 747);
            Controls.Add(btnMailGonder);
            Controls.Add(lstUcusBilgileri);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Poor Richard", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpTarih;
        private ComboBox cbNereye;
        private ComboBox cbNereden;
        private MaskedTextBox mtxtSaat;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private MaskedTextBox mtxtTc;
        private MaskedTextBox mtxtTelefon;
        private TextBox txtAdSoyad;
        private Label label8;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Label label1;
        private Button btnDegis;
        private PictureBox pictureBox1;
        private ListBox lstUcusBilgileri;
        private Button btnKaydet;
        private Button btnMailGonder;
        private TextBox txtMail;
        private Label label9;
    }
}
