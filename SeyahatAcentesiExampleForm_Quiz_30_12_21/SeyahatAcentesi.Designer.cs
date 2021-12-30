namespace SeyahatAcentesiExampleForm_Quiz_30_12_21
{
    partial class SeyahatAcentesi
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
            this.flwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grbKisisel = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKoltuk = new System.Windows.Forms.TextBox();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lboxSatilanKoltuklar = new System.Windows.Forms.ListBox();
            this.grbKisisel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flwPanel
            // 
            this.flwPanel.Location = new System.Drawing.Point(0, 0);
            this.flwPanel.Name = "flwPanel";
            this.flwPanel.Size = new System.Drawing.Size(225, 637);
            this.flwPanel.TabIndex = 0;
            // 
            // grbKisisel
            // 
            this.grbKisisel.Controls.Add(this.btnKaydet);
            this.grbKisisel.Controls.Add(this.txtKoltuk);
            this.grbKisisel.Controls.Add(this.rdbBayan);
            this.grbKisisel.Controls.Add(this.rdbBay);
            this.grbKisisel.Controls.Add(this.txtTelNo);
            this.grbKisisel.Controls.Add(this.label5);
            this.grbKisisel.Controls.Add(this.label4);
            this.grbKisisel.Controls.Add(this.label3);
            this.grbKisisel.Controls.Add(this.txtSoyad);
            this.grbKisisel.Controls.Add(this.label2);
            this.grbKisisel.Controls.Add(this.txtAd);
            this.grbKisisel.Controls.Add(this.label1);
            this.grbKisisel.Location = new System.Drawing.Point(231, -1);
            this.grbKisisel.Name = "grbKisisel";
            this.grbKisisel.Size = new System.Drawing.Size(396, 177);
            this.grbKisisel.TabIndex = 1;
            this.grbKisisel.TabStop = false;
            this.grbKisisel.Text = "Kişisel Bilgiler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(112, 137);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(63, 24);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.Enter += new System.EventHandler(this.btnKaydet_Enter);
            this.btnKaydet.Leave += new System.EventHandler(this.btnKaydet_Leave);
            this.btnKaydet.MouseLeave += new System.EventHandler(this.btnKaydet_MouseLeave);
            this.btnKaydet.MouseHover += new System.EventHandler(this.btnKaydet_MouseHover);
            // 
            // txtKoltuk
            // 
            this.txtKoltuk.Enabled = false;
            this.txtKoltuk.Location = new System.Drawing.Point(75, 138);
            this.txtKoltuk.Name = "txtKoltuk";
            this.txtKoltuk.Size = new System.Drawing.Size(31, 23);
            this.txtKoltuk.TabIndex = 5;
            this.txtKoltuk.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtKoltuk.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Location = new System.Drawing.Point(118, 113);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(57, 19);
            this.rdbBayan.TabIndex = 4;
            this.rdbBayan.TabStop = true;
            this.rdbBayan.Text = "Bayan";
            this.rdbBayan.UseVisualStyleBackColor = true;
            this.rdbBayan.Enter += new System.EventHandler(this.rdbBay_Enter);
            this.rdbBayan.Leave += new System.EventHandler(this.rdbBay_Leave);
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Location = new System.Drawing.Point(75, 113);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(44, 19);
            this.rdbBay.TabIndex = 3;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "Bay";
            this.rdbBay.UseVisualStyleBackColor = true;
            this.rdbBay.Enter += new System.EventHandler(this.rdbBay_Enter);
            this.rdbBay.Leave += new System.EventHandler(this.rdbBay_Leave);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(75, 77);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(100, 23);
            this.txtTelNo.TabIndex = 2;
            this.txtTelNo.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtTelNo.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Koltuk No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cinsiyet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tel No :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(75, 48);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 23);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtSoyad.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(75, 19);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // lboxSatilanKoltuklar
            // 
            this.lboxSatilanKoltuklar.FormattingEnabled = true;
            this.lboxSatilanKoltuklar.ItemHeight = 15;
            this.lboxSatilanKoltuklar.Location = new System.Drawing.Point(231, 182);
            this.lboxSatilanKoltuklar.Name = "lboxSatilanKoltuklar";
            this.lboxSatilanKoltuklar.Size = new System.Drawing.Size(396, 454);
            this.lboxSatilanKoltuklar.TabIndex = 5;
            // 
            // SeyahatAcentesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 648);
            this.Controls.Add(this.lboxSatilanKoltuklar);
            this.Controls.Add(this.grbKisisel);
            this.Controls.Add(this.flwPanel);
            this.Name = "SeyahatAcentesi";
            this.Text = "Seyahat Acentesi";
            this.Load += new System.EventHandler(this.SeyahatAcentesi_Load);
            this.grbKisisel.ResumeLayout(false);
            this.grbKisisel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flwPanel;
        private GroupBox grbKisisel;
        private Button btnKaydet;
        private TextBox txtKoltuk;
        private RadioButton rdbBayan;
        private RadioButton rdbBay;
        private TextBox txtTelNo;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtAd;
        private Label label1;
        private ListBox lboxSatilanKoltuklar;
    }
}