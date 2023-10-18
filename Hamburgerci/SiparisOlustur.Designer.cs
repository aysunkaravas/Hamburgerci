namespace Hamburgerci
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cbMenu = new ComboBox();
            rbBuyuk = new RadioButton();
            rbOrta = new RadioButton();
            rbKucuk = new RadioButton();
            btnEkle = new Button();
            numAdet = new NumericUpDown();
            label1 = new Label();
            lstSiparislerim = new ListBox();
            label3 = new Label();
            label2 = new Label();
            btnSiparisOnayla = new Button();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 261);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(224, 184);
            flowLayoutPanel1.TabIndex = 28;
            // 
            // cbMenu
            // 
            cbMenu.FormattingEnabled = true;
            cbMenu.Location = new Point(12, 204);
            cbMenu.Margin = new Padding(3, 4, 3, 4);
            cbMenu.Name = "cbMenu";
            cbMenu.Size = new Size(223, 28);
            cbMenu.TabIndex = 27;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbBuyuk.Location = new Point(183, 493);
            rbBuyuk.Margin = new Padding(3, 4, 3, 4);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(79, 27);
            rbBuyuk.TabIndex = 31;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbOrta.Location = new Point(99, 493);
            rbOrta.Margin = new Padding(3, 4, 3, 4);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(65, 27);
            rbOrta.TabIndex = 30;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rbKucuk.Location = new Point(9, 493);
            rbKucuk.Margin = new Padding(3, 4, 3, 4);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(78, 27);
            rbKucuk.TabIndex = 29;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(12, 614);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(240, 51);
            btnEkle.TabIndex = 34;
            btnEkle.Text = "Siparişi Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(87, 544);
            numAdet.Margin = new Padding(3, 4, 3, 4);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(165, 27);
            numAdet.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 544);
            label1.Name = "label1";
            label1.Size = new Size(46, 23);
            label1.TabIndex = 32;
            label1.Text = "Adet";
            // 
            // lstSiparislerim
            // 
            lstSiparislerim.FormattingEnabled = true;
            lstSiparislerim.ItemHeight = 20;
            lstSiparislerim.Location = new Point(412, 13);
            lstSiparislerim.Margin = new Padding(3, 4, 3, 4);
            lstSiparislerim.Name = "lstSiparislerim";
            lstSiparislerim.Size = new Size(563, 564);
            lstSiparislerim.TabIndex = 38;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(617, 614);
            label3.Name = "label3";
            label3.Size = new Size(114, 51);
            label3.TabIndex = 37;
            label3.Text = "0 ₺";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(513, 616);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 36;
            label2.Text = "Toplam : ";
            // 
            // btnSiparisOnayla
            // 
            btnSiparisOnayla.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisOnayla.Location = new Point(773, 616);
            btnSiparisOnayla.Margin = new Padding(3, 4, 3, 4);
            btnSiparisOnayla.Name = "btnSiparisOnayla";
            btnSiparisOnayla.Size = new Size(202, 47);
            btnSiparisOnayla.TabIndex = 35;
            btnSiparisOnayla.Text = "Siparişi Onayla";
            btnSiparisOnayla.UseVisualStyleBackColor = true;
            btnSiparisOnayla.Click += btnSiparisOnayla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(63, 172);
            label4.Name = "label4";
            label4.Size = new Size(112, 19);
            label4.TabIndex = 40;
            label4.Text = "Menü Seçiniz";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(63, 470);
            label5.Name = "label5";
            label5.Size = new Size(101, 19);
            label5.TabIndex = 41;
            label5.Text = "Boy Seçiniz";
            // 
            // SiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 715);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lstSiparislerim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnSiparisOnayla);
            Controls.Add(btnEkle);
            Controls.Add(numAdet);
            Controls.Add(label1);
            Controls.Add(rbBuyuk);
            Controls.Add(rbOrta);
            Controls.Add(rbKucuk);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(cbMenu);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SiparisOlustur";
            Text = "SiparisOlustur";
            Load += SiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbMenu;
        private RadioButton rbBuyuk;
        private RadioButton rbOrta;
        private RadioButton rbKucuk;
        private Button btnEkle;
        private NumericUpDown numAdet;
        private Label label1;
        private ListBox lstSiparislerim;
        private Label label3;
        private Label label2;
        private Button btnSiparisOnayla;
        private Label label4;
        private Label label5;
    }
}