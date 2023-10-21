namespace OOPHamburgerciUi
{
    partial class SiparisBilgileri
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
            label1 = new Label();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(100, -28);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 36;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.Location = new Point(400, 277);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(226, 52);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(400, 187);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(226, 62);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(400, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 52);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Sipariş SAyısı";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(400, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(226, 52);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ciro";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(26, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(332, 468);
            richTextBox1.TabIndex = 31;
            richTextBox1.Text = "";
            // 
            // SiparisBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 522);
            Controls.Add(label1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "SiparisBilgileri";
            Text = "SiparisBilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}