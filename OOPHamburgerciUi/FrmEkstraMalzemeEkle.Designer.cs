namespace OOPHamburgerciUi
{
    partial class FrmEkstraMalzemeEkle
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
            groupBox1 = new GroupBox();
            numericMalzemeFiyat = new NumericUpDown();
            txtEkstraMalzemeAdi = new TextBox();
            btnEkstraMalzemeyiKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericMalzemeFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericMalzemeFiyat);
            groupBox1.Controls.Add(txtEkstraMalzemeAdi);
            groupBox1.Controls.Add(btnEkstraMalzemeyiKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 174);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // numericMalzemeFiyat
            // 
            numericMalzemeFiyat.Location = new Point(174, 74);
            numericMalzemeFiyat.Name = "numericMalzemeFiyat";
            numericMalzemeFiyat.Size = new Size(120, 23);
            numericMalzemeFiyat.TabIndex = 5;
            // 
            // txtEkstraMalzemeAdi
            // 
            txtEkstraMalzemeAdi.Location = new Point(174, 34);
            txtEkstraMalzemeAdi.Name = "txtEkstraMalzemeAdi";
            txtEkstraMalzemeAdi.Size = new Size(120, 23);
            txtEkstraMalzemeAdi.TabIndex = 4;
            // 
            // btnEkstraMalzemeyiKaydet
            // 
            btnEkstraMalzemeyiKaydet.Location = new Point(129, 103);
            btnEkstraMalzemeyiKaydet.Name = "btnEkstraMalzemeyiKaydet";
            btnEkstraMalzemeyiKaydet.Size = new Size(165, 52);
            btnEkstraMalzemeyiKaydet.TabIndex = 2;
            btnEkstraMalzemeyiKaydet.Text = "EKSTRA MALZEMEYİ KAYDET";
            btnEkstraMalzemeyiKaydet.UseVisualStyleBackColor = true;
            btnEkstraMalzemeyiKaydet.Click += btnEkstraMalzemeyiKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 71);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Fiyatı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 37);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "Ekstra Malzeme Adı:";
            // 
            // FrmEkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 259);
            Controls.Add(groupBox1);
            Name = "FrmEkstraMalzemeEkle";
            Text = "FrmEkstraMalzemeEkle";
            Load += FrmEkstraMalzemeEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericMalzemeFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtEkstraMalzemeAdi;
        private Button btnEkstraMalzemeyiKaydet;
        private Label label2;
        private Label label1;
        private NumericUpDown numericMalzemeFiyat;
    }
}