namespace OOPHamburgerciUi
{
    partial class FrmMenuEkle
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
            numericFiyat = new NumericUpDown();
            btnMenuyuKaydet = new Button();
            label2 = new Label();
            txtMenuAdi = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFiyat).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericFiyat);
            groupBox1.Controls.Add(btnMenuyuKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMenuAdi);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(54, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(269, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MENÜ BİLGİLERİ";
            // 
            // numericFiyat
            // 
            numericFiyat.Increment = new decimal(new int[] { 500, 0, 0, 131072 });
            numericFiyat.Location = new Point(105, 61);
            numericFiyat.Name = "numericFiyat";
            numericFiyat.Size = new Size(141, 23);
            numericFiyat.TabIndex = 5;
            // 
            // btnMenuyuKaydet
            // 
            btnMenuyuKaydet.Location = new Point(105, 94);
            btnMenuyuKaydet.Name = "btnMenuyuKaydet";
            btnMenuyuKaydet.Size = new Size(141, 42);
            btnMenuyuKaydet.TabIndex = 4;
            btnMenuyuKaydet.Text = "MENÜYÜ KAYDET";
            btnMenuyuKaydet.UseVisualStyleBackColor = true;
            btnMenuyuKaydet.Click += btnMenuyuKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Fiyatı:";
            // 
            // txtMenuAdi
            // 
            txtMenuAdi.Location = new Point(105, 22);
            txtMenuAdi.Name = "txtMenuAdi";
            txtMenuAdi.Size = new Size(141, 23);
            txtMenuAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Menü Adı:";
            // 
            // FrmMenuEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 253);
            Controls.Add(groupBox1);
            Name = "FrmMenuEkle";
            Text = "FrmMenuEkle";
            Load += FrmMenuEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericFiyat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMenuyuKaydet;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtMenuAdi;
        private NumericUpDown numericFiyat;
    }
}