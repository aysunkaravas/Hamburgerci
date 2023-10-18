using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();

            YeniSiparisler = new List<Siparis>();
        }

        List<Siparis> YeniSiparisler;

        double toplam = 0;


        private void SiparisOlustur_Load(object sender, EventArgs e)
        {

            foreach (Menu menu in Form1.Menuler)
            {
                cbMenu.Items.Add(menu);
            }

            foreach (Malzeme malzeme in Form1.Malzemeler)
            {

                flowLayoutPanel1.Controls.Add(new CheckBox() { Text = malzeme.Ad, Tag = malzeme });
            }

            cbMenu.SelectedItem = 0;
            rbKucuk.Checked = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;




        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();



            siparis.Menu = (Menu)cbMenu.SelectedItem;

            foreach (CheckBox cbox in flowLayoutPanel1.Controls)
            {
                if (cbox.Checked)
                {
                    siparis.Malzemeler.Add((Malzeme)cbox.Tag);

                }
            }

            if (rbOrta.Checked)
            {
                siparis.Boy = Boy.Orta;
            }
            else if (rbBuyuk.Checked)
            {
                siparis.Boy = Boy.Büyük;
            }
            else
            {
                siparis.Boy = Boy.Küçük;
            }

            siparis.Adet = (int)numAdet.Value;

            toplam += siparis.ToplamFiyat;
            label3.Text = toplam.ToString("C2");

            YeniSiparisler.Add(siparis);
            lstSiparislerim.Items.Add(siparis);

            Helper.Temizle(this.Controls);
        }

        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Siparişinizi Onaylamak İstediğinize Emin Misiniz?", "Hata Mesajı", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {

                Form1.Siparisler.AddRange(YeniSiparisler);
                lstSiparislerim.Items.Clear();
                YeniSiparisler.Clear();

                MessageBox.Show("Siparişiniz Başarıyla Oluşturuldu.\nBizi Tercih Ettiğiniz için Teşekkür Ederiz.\nAfiyet Olsun:)");

            }

            Helper.Temizle(this.Controls);



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
