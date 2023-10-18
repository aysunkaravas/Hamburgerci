namespace Hamburgerci
{
    partial class MalzemeEkle
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
            gbxEkstraMalzeme = new GroupBox();
            numMalzemeFiyat = new NumericUpDown();
            txtMalzemeAd = new TextBox();
            btnEkleMalzeme = new Button();
            lblFiyatMalzeme = new Label();
            lblAdMalzeme = new Label();
            gbxEkstraMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // gbxEkstraMalzeme
            // 
            gbxEkstraMalzeme.Controls.Add(numMalzemeFiyat);
            gbxEkstraMalzeme.Controls.Add(txtMalzemeAd);
            gbxEkstraMalzeme.Controls.Add(btnEkleMalzeme);
            gbxEkstraMalzeme.Controls.Add(lblFiyatMalzeme);
            gbxEkstraMalzeme.Controls.Add(lblAdMalzeme);
            gbxEkstraMalzeme.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gbxEkstraMalzeme.Location = new Point(12, 4);
            gbxEkstraMalzeme.Margin = new Padding(3, 4, 3, 4);
            gbxEkstraMalzeme.Name = "gbxEkstraMalzeme";
            gbxEkstraMalzeme.Padding = new Padding(3, 4, 3, 4);
            gbxEkstraMalzeme.Size = new Size(376, 288);
            gbxEkstraMalzeme.TabIndex = 2;
            gbxEkstraMalzeme.TabStop = false;
            gbxEkstraMalzeme.Text = "Ekstra Malzeme Ekle";
            // 
            // numMalzemeFiyat
            // 
            numMalzemeFiyat.Location = new Point(151, 145);
            numMalzemeFiyat.Margin = new Padding(3, 4, 3, 4);
            numMalzemeFiyat.Name = "numMalzemeFiyat";
            numMalzemeFiyat.Size = new Size(193, 29);
            numMalzemeFiyat.TabIndex = 4;
            // 
            // txtMalzemeAd
            // 
            txtMalzemeAd.Location = new Point(151, 71);
            txtMalzemeAd.Margin = new Padding(3, 4, 3, 4);
            txtMalzemeAd.Name = "txtMalzemeAd";
            txtMalzemeAd.Size = new Size(193, 29);
            txtMalzemeAd.TabIndex = 3;
            // 
            // btnEkleMalzeme
            // 
            btnEkleMalzeme.Location = new Point(151, 215);
            btnEkleMalzeme.Margin = new Padding(3, 4, 3, 4);
            btnEkleMalzeme.Name = "btnEkleMalzeme";
            btnEkleMalzeme.Size = new Size(193, 52);
            btnEkleMalzeme.TabIndex = 2;
            btnEkleMalzeme.Text = "Ekle";
            btnEkleMalzeme.UseVisualStyleBackColor = true;
            btnEkleMalzeme.Click += btnEkleMalzeme_Click_1;
            // 
            // lblFiyatMalzeme
            // 
            lblFiyatMalzeme.AutoSize = true;
            lblFiyatMalzeme.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFiyatMalzeme.Location = new Point(25, 149);
            lblFiyatMalzeme.Name = "lblFiyatMalzeme";
            lblFiyatMalzeme.Size = new Size(47, 19);
            lblFiyatMalzeme.TabIndex = 1;
            lblFiyatMalzeme.Text = "Fiyat";
            // 
            // lblAdMalzeme
            // 
            lblAdMalzeme.AutoSize = true;
            lblAdMalzeme.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdMalzeme.Location = new Point(24, 76);
            lblAdMalzeme.Name = "lblAdMalzeme";
            lblAdMalzeme.Size = new Size(30, 19);
            lblAdMalzeme.TabIndex = 0;
            lblAdMalzeme.Text = "Ad";
            // 
            // MalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxEkstraMalzeme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MalzemeEkle";
            Text = "MalzemeEkle";
            Load += MalzemeEkle_Load;
            gbxEkstraMalzeme.ResumeLayout(false);
            gbxEkstraMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxEkstraMalzeme;
        private NumericUpDown numMalzemeFiyat;
        private TextBox txtMalzemeAd;
        private Button btnEkleMalzeme;
        private Label lblFiyatMalzeme;
        private Label lblAdMalzeme;
    }
}