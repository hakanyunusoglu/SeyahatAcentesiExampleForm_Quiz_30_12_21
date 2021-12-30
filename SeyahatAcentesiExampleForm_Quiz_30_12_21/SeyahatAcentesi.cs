using System.Text;

namespace SeyahatAcentesiExampleForm_Quiz_30_12_21
{
    public partial class SeyahatAcentesi : Form
    {
        public SeyahatAcentesi()
        {
            InitializeComponent();
        }
        static int sayac=3,textsayac = 1;
        string[] man, woman;
        StringBuilder KoltukRezervasyon = new StringBuilder();
        private void SeyahatAcentesi_Load(object sender, EventArgs e)
        {
            woman = Directory.GetFiles("../../../images", "woman.png");
            man = Directory.GetFiles("../../../images", "man.png");
            rdbBay.Checked = true;

            for (int i = 1; i < 69; i++)
            {
            Button btn = new Button();           
            flwPanel.Controls.Add(btn);
            btn.Click += btn_click;
                if (i != sayac)
                {
                    btn.Width = btn.Height = 37;
                    btn.Tag = i;
                }
                else if(i == sayac)
                {
                    btn.Width = 37;
                    btn.Height = 0;
                    btn.Tag = 0.ToString();
                    sayac += 5;                    
                }
                btn.Padding = new Padding(0);

                if (btn.Tag != 0.ToString())
                {
                    btn.Text = textsayac.ToString();
                    textsayac += 1;
                }
            }
            Label lbl = new Label();
            lbl.Text = "KAPI";
            lbl.BackColor = Color.Cornsilk;
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.Padding = new Padding(0);
            lbl.Tag = "kapı";
            lbl.Height = 37;
            lbl.Width = 77;
            flwPanel.Controls.Add(lbl);
            
                grbKisisel.Enabled = false;

        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void rdbBay_Enter(object sender, EventArgs e)
        {
            RadioButton R = (RadioButton)sender;
            R.BackColor = Color.Yellow;
        }

        private void rdbBay_Leave(object sender, EventArgs e)
        {
            RadioButton R = (RadioButton)sender;
            R.BackColor = Color.White;
        }
        private void btnKaydet_MouseLeave(object sender, EventArgs e)
        {
            btnKaydet.BackColor = default;
        }

        private void btnKaydet_MouseHover(object sender, EventArgs e)
        {
            btnKaydet.BackColor = Color.Gray;
        }

        private void btnKaydet_Enter(object sender, EventArgs e)
        {
            btnKaydet.BackColor = Color.Gray;
        }

        private void btnKaydet_Leave(object sender, EventArgs e)
        {
            btnKaydet.BackColor = default;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtAd.Text) && !string.IsNullOrEmpty(txtSoyad.Text) && !string.IsNullOrEmpty(txtTelNo.Text) && !string.IsNullOrEmpty(txtKoltuk.Text))
            {

                if (rdbBay.Checked)
                {
                    foreach (Control c in flwPanel.Controls)
                    {
                        if (c is Button)
                        {
                            if (c.Text == txtKoltuk.Text)
                            {
                                c.ForeColor = Color.Red;
                                c.BackgroundImage = Image.FromFile(man[0]);
                                c.BackgroundImageLayout = ImageLayout.Stretch;
                                c.Enabled = false;
                            }
                        }
                    }
                }
                else if (rdbBayan.Checked)
                {
                    foreach (Control c in flwPanel.Controls)
                    {
                        if (c is Button)
                        {
                            if (c.Text == txtKoltuk.Text)
                            {
                                c.ForeColor = Color.Red;
                                c.BackgroundImage = Image.FromFile(woman[0]);
                                c.BackgroundImageLayout = ImageLayout.Stretch;
                                c.Enabled = false;
                            }
                        }
                    }
                }
                KoltukRezervasyon.Clear();
            KoltukRezervasyon.Append($"Koltuk No: {txtKoltuk.Text} ");
            KoltukRezervasyon.Append($"İsim: {txtAd.Text} {txtSoyad.Text} ");
            if(rdbBay.Checked)
            {
                KoltukRezervasyon.Append("Cinsiyet : Bay ");
            }
            else if(rdbBayan.Checked)
            {
                KoltukRezervasyon.Append("Cinsiyet : Bayan ");
            }
            KoltukRezervasyon.Append($"Tel No: {txtTelNo.Text} ");
            lboxSatilanKoltuklar.Items.Add(KoltukRezervasyon.ToString());
                        
            txtAd.Clear();
            txtKoltuk.Clear();
            txtSoyad.Clear();
            txtTelNo.Clear();
            rdbBay.Checked = false;
            rdbBayan.Checked = false;
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            txtKoltuk.Text = clicked.Text;
            grbKisisel.Enabled = true;
        }
    }
}