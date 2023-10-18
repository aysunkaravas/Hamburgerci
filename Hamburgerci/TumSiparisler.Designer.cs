namespace Hamburgerci
{
    partial class TumSiparisler
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
            lstTumSiparis = new ListBox();
            gbxSatılanUrunAdedi = new GroupBox();
            lblSatılanÜrünAdedi = new Label();
            gbxEksstraMalzemeGeliri = new GroupBox();
            lblEkstraMalzemeGeliri = new Label();
            gbxToplamSiparis = new GroupBox();
            lblToplamSiparis = new Label();
            gbxCiro = new GroupBox();
            lblCiro = new Label();
            label1 = new Label();
            gbxSatılanUrunAdedi.SuspendLayout();
            gbxEksstraMalzemeGeliri.SuspendLayout();
            gbxToplamSiparis.SuspendLayout();
            gbxCiro.SuspendLayout();
            SuspendLayout();
            // 
            // lstTumSiparis
            // 
            lstTumSiparis.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lstTumSiparis.FormattingEnabled = true;
            lstTumSiparis.ItemHeight = 21;
            lstTumSiparis.Location = new Point(13, 56);
            lstTumSiparis.Margin = new Padding(4, 5, 4, 5);
            lstTumSiparis.Name = "lstTumSiparis";
            lstTumSiparis.Size = new Size(542, 760);
            lstTumSiparis.TabIndex = 12;
            // 
            // gbxSatılanUrunAdedi
            // 
            gbxSatılanUrunAdedi.Controls.Add(lblSatılanÜrünAdedi);
            gbxSatılanUrunAdedi.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbxSatılanUrunAdedi.Location = new Point(563, 411);
            gbxSatılanUrunAdedi.Margin = new Padding(4, 5, 4, 5);
            gbxSatılanUrunAdedi.Name = "gbxSatılanUrunAdedi";
            gbxSatılanUrunAdedi.Padding = new Padding(4, 5, 4, 5);
            gbxSatılanUrunAdedi.Size = new Size(440, 66);
            gbxSatılanUrunAdedi.TabIndex = 11;
            gbxSatılanUrunAdedi.TabStop = false;
            gbxSatılanUrunAdedi.Text = "Satılan Ürün Adedi";
            // 
            // lblSatılanÜrünAdedi
            // 
            lblSatılanÜrünAdedi.AutoSize = true;
            lblSatılanÜrünAdedi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSatılanÜrünAdedi.ForeColor = Color.Red;
            lblSatılanÜrünAdedi.Location = new Point(372, 14);
            lblSatılanÜrünAdedi.Margin = new Padding(4, 0, 4, 0);
            lblSatılanÜrünAdedi.Name = "lblSatılanÜrünAdedi";
            lblSatılanÜrünAdedi.Size = new Size(20, 23);
            lblSatılanÜrünAdedi.TabIndex = 0;
            lblSatılanÜrünAdedi.Text = "0";
            // 
            // gbxEksstraMalzemeGeliri
            // 
            gbxEksstraMalzemeGeliri.Controls.Add(lblEkstraMalzemeGeliri);
            gbxEksstraMalzemeGeliri.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbxEksstraMalzemeGeliri.Location = new Point(563, 293);
            gbxEksstraMalzemeGeliri.Margin = new Padding(4, 5, 4, 5);
            gbxEksstraMalzemeGeliri.Name = "gbxEksstraMalzemeGeliri";
            gbxEksstraMalzemeGeliri.Padding = new Padding(4, 5, 4, 5);
            gbxEksstraMalzemeGeliri.Size = new Size(440, 89);
            gbxEksstraMalzemeGeliri.TabIndex = 10;
            gbxEksstraMalzemeGeliri.TabStop = false;
            gbxEksstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzemeGeliri
            // 
            lblEkstraMalzemeGeliri.AutoSize = true;
            lblEkstraMalzemeGeliri.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblEkstraMalzemeGeliri.ForeColor = Color.Red;
            lblEkstraMalzemeGeliri.Location = new Point(372, 32);
            lblEkstraMalzemeGeliri.Margin = new Padding(4, 0, 4, 0);
            lblEkstraMalzemeGeliri.Name = "lblEkstraMalzemeGeliri";
            lblEkstraMalzemeGeliri.Size = new Size(35, 23);
            lblEkstraMalzemeGeliri.TabIndex = 0;
            lblEkstraMalzemeGeliri.Text = "₺ 0";
            // 
            // gbxToplamSiparis
            // 
            gbxToplamSiparis.Controls.Add(lblToplamSiparis);
            gbxToplamSiparis.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbxToplamSiparis.Location = new Point(563, 198);
            gbxToplamSiparis.Margin = new Padding(4, 5, 4, 5);
            gbxToplamSiparis.Name = "gbxToplamSiparis";
            gbxToplamSiparis.Padding = new Padding(4, 5, 4, 5);
            gbxToplamSiparis.Size = new Size(440, 85);
            gbxToplamSiparis.TabIndex = 9;
            gbxToplamSiparis.TabStop = false;
            gbxToplamSiparis.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(372, 26);
            lblToplamSiparis.Margin = new Padding(4, 0, 4, 0);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(25, 23);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = " 0";
            // 
            // gbxCiro
            // 
            gbxCiro.Controls.Add(lblCiro);
            gbxCiro.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbxCiro.Location = new Point(563, 56);
            gbxCiro.Margin = new Padding(4, 5, 4, 5);
            gbxCiro.Name = "gbxCiro";
            gbxCiro.Padding = new Padding(4, 5, 4, 5);
            gbxCiro.Size = new Size(440, 86);
            gbxCiro.TabIndex = 8;
            gbxCiro.TabStop = false;
            gbxCiro.Text = "Ciro";
            // 
            // lblCiro
            // 
            lblCiro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCiro.ForeColor = Color.Red;
            lblCiro.Location = new Point(331, 14);
            lblCiro.Margin = new Padding(4, 0, 4, 0);
            lblCiro.Name = "lblCiro";
            lblCiro.Size = new Size(109, 33);
            lblCiro.TabIndex = 0;
            lblCiro.Text = "₺ 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 21);
            label1.TabIndex = 7;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 884);
            Controls.Add(lstTumSiparis);
            Controls.Add(gbxSatılanUrunAdedi);
            Controls.Add(gbxEksstraMalzemeGeliri);
            Controls.Add(gbxToplamSiparis);
            Controls.Add(gbxCiro);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "TumSiparisler";
            Text = "TumSiparisler";
            Load += TumSiparisler_Load;
            gbxSatılanUrunAdedi.ResumeLayout(false);
            gbxSatılanUrunAdedi.PerformLayout();
            gbxEksstraMalzemeGeliri.ResumeLayout(false);
            gbxEksstraMalzemeGeliri.PerformLayout();
            gbxToplamSiparis.ResumeLayout(false);
            gbxToplamSiparis.PerformLayout();
            gbxCiro.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTumSiparis;
        private GroupBox gbxSatılanUrunAdedi;
        private Label lblSatılanÜrünAdedi;
        private GroupBox gbxEksstraMalzemeGeliri;
        private Label lblEkstraMalzemeGeliri;
        private GroupBox gbxToplamSiparis;
        private Label lblToplamSiparis;
        private GroupBox gbxCiro;
        private Label lblCiro;
        private Label label1;
    }
}