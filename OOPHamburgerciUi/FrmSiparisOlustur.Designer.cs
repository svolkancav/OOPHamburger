namespace OOPHamburgerciUi
{
    partial class FrmSiparisOlustur
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
            pictureBox1 = new PictureBox();
            grpBoyutSeciniz = new GroupBox();
            radioButtonBüyük = new RadioButton();
            radioButtonOrta = new RadioButton();
            radioButtonKüçük = new RadioButton();
            label1 = new Label();
            comboBoxMenuler = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDownAdet = new NumericUpDown();
            btnSiparisEkle = new Button();
            buttonSiparisiTamamla = new Button();
            label4 = new Label();
            label5 = new Label();
            checkListBoxMalzeme = new CheckedListBox();
            listBoxSiparisBilgileri = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBoyutSeciniz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 116);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // grpBoyutSeciniz
            // 
            grpBoyutSeciniz.Controls.Add(radioButtonBüyük);
            grpBoyutSeciniz.Controls.Add(radioButtonOrta);
            grpBoyutSeciniz.Controls.Add(radioButtonKüçük);
            grpBoyutSeciniz.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grpBoyutSeciniz.Location = new Point(12, 228);
            grpBoyutSeciniz.Name = "grpBoyutSeciniz";
            grpBoyutSeciniz.Size = new Size(300, 43);
            grpBoyutSeciniz.TabIndex = 27;
            grpBoyutSeciniz.TabStop = false;
            grpBoyutSeciniz.Text = "BOYUT SEÇİNİZ";
            // 
            // radioButtonBüyük
            // 
            radioButtonBüyük.AutoSize = true;
            radioButtonBüyük.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonBüyük.Location = new Point(129, 18);
            radioButtonBüyük.Name = "radioButtonBüyük";
            radioButtonBüyük.Size = new Size(60, 19);
            radioButtonBüyük.TabIndex = 2;
            radioButtonBüyük.TabStop = true;
            radioButtonBüyük.Text = "Büyük";
            radioButtonBüyük.UseVisualStyleBackColor = true;
            
            // 
            // radioButtonOrta
            // 
            radioButtonOrta.AutoSize = true;
            radioButtonOrta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonOrta.Location = new Point(76, 18);
            radioButtonOrta.Name = "radioButtonOrta";
            radioButtonOrta.Size = new Size(50, 19);
            radioButtonOrta.TabIndex = 1;
            radioButtonOrta.TabStop = true;
            radioButtonOrta.Text = "Orta";
            radioButtonOrta.UseVisualStyleBackColor = true;
           
            // 
            // radioButtonKüçük
            // 
            radioButtonKüçük.AutoSize = true;
            radioButtonKüçük.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonKüçük.Location = new Point(6, 18);
            radioButtonKüçük.Name = "radioButtonKüçük";
            radioButtonKüçük.Size = new Size(60, 19);
            radioButtonKüçük.TabIndex = 0;
            radioButtonKüçük.TabStop = true;
            radioButtonKüçük.Text = "Küçük";
            radioButtonKüçük.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 176);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 28;
            label1.Text = "MENÜ SEÇİN";
            // 
            // comboBoxMenuler
            // 
            comboBoxMenuler.FormattingEnabled = true;
            comboBoxMenuler.Location = new Point(12, 199);
            comboBoxMenuler.Name = "comboBoxMenuler";
            comboBoxMenuler.Size = new Size(300, 23);
            comboBoxMenuler.TabIndex = 29;
            comboBoxMenuler.SelectedIndexChanged += comboBoxMenuler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 287);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "MALZEME SEÇİN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 413);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 36;
            label3.Text = "ADET";
            // 
            // numericUpDownAdet
            // 
            numericUpDownAdet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDownAdet.Location = new Point(97, 405);
            numericUpDownAdet.Name = "numericUpDownAdet";
            numericUpDownAdet.Size = new Size(120, 23);
            numericUpDownAdet.TabIndex = 37;
            numericUpDownAdet.TextAlign = HorizontalAlignment.Center;
            numericUpDownAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSiparisEkle.Location = new Point(18, 454);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(156, 64);
            btnSiparisEkle.TabIndex = 38;
            btnSiparisEkle.Text = "SİPARİŞ EKLE";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            btnSiparisEkle.Click += btnSiparisEkle_Click;
            // 
            // buttonSiparisiTamamla
            // 
            buttonSiparisiTamamla.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSiparisiTamamla.Location = new Point(603, 454);
            buttonSiparisiTamamla.Name = "buttonSiparisiTamamla";
            buttonSiparisiTamamla.Size = new Size(171, 64);
            buttonSiparisiTamamla.TabIndex = 39;
            buttonSiparisiTamamla.Text = "SİPARİŞİ TAMAMLA";
            buttonSiparisiTamamla.UseVisualStyleBackColor = true;
            buttonSiparisiTamamla.Click += buttonSiparisiTamamla_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(213, 482);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 40;
            label4.Text = "TOPLAM TUTAR:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(357, 483);
            label5.Name = "label5";
            label5.Size = new Size(14, 15);
            label5.TabIndex = 41;
            label5.Text = "0";
            
            // 
            // checkListBoxMalzeme
            // 
            checkListBoxMalzeme.CheckOnClick = true;
            checkListBoxMalzeme.FormattingEnabled = true;
            checkListBoxMalzeme.Location = new Point(12, 305);
            checkListBoxMalzeme.Name = "checkListBoxMalzeme";
            checkListBoxMalzeme.Size = new Size(294, 94);
            checkListBoxMalzeme.TabIndex = 42;
           
            
            
            
            // 
            // listBoxSiparisBilgileri
            // 
            listBoxSiparisBilgileri.FormattingEnabled = true;
            listBoxSiparisBilgileri.ItemHeight = 15;
            listBoxSiparisBilgileri.Location = new Point(417, 39);
            listBoxSiparisBilgileri.Name = "listBoxSiparisBilgileri";
            listBoxSiparisBilgileri.Size = new Size(357, 364);
            listBoxSiparisBilgileri.TabIndex = 43;
            // 
            // FrmSiparisOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(listBoxSiparisBilgileri);
            Controls.Add(checkListBoxMalzeme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonSiparisiTamamla);
            Controls.Add(btnSiparisEkle);
            Controls.Add(numericUpDownAdet);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMenuler);
            Controls.Add(label1);
            Controls.Add(grpBoyutSeciniz);
            Controls.Add(pictureBox1);
            Name = "FrmSiparisOlustur";
            Text = "Form2";
            Load += FrmSiparisOlustur_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBoyutSeciniz.ResumeLayout(false);
            grpBoyutSeciniz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox grpBoyutSeciniz;
        private RadioButton radioButtonBüyük;
        private RadioButton radioButtonOrta;
        private RadioButton radioButtonKüçük;
        private Label label1;
        private ComboBox comboBoxMenuler;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDownAdet;
        private Button btnSiparisEkle;
        private Button buttonSiparisiTamamla;
        private Label label4;
        private Label label5;
        private CheckedListBox checkListBoxMalzeme;
        private ListBox listBoxSiparisBilgileri;
    }
}