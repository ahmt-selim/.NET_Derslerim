namespace Mail_Gönderme
{
    partial class Form1
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
            this.textgndrn = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textkonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textdosya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textmesaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_gozat = new System.Windows.Forms.Button();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textsifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textalici = new System.Windows.Forms.TextBox();
            this.textadsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textgndrn
            // 
            this.textgndrn.Location = new System.Drawing.Point(172, 40);
            this.textgndrn.Name = "textgndrn";
            this.textgndrn.Size = new System.Drawing.Size(304, 22);
            this.textgndrn.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(482, 123);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gönderici E-Posta";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(585, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 132);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Konu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textkonu
            // 
            this.textkonu.Location = new System.Drawing.Point(172, 166);
            this.textkonu.Multiline = true;
            this.textkonu.Name = "textkonu";
            this.textkonu.Size = new System.Drawing.Size(304, 40);
            this.textkonu.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dosya/Ek";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textdosya
            // 
            this.textdosya.Location = new System.Drawing.Point(172, 223);
            this.textdosya.Name = "textdosya";
            this.textdosya.Size = new System.Drawing.Size(304, 22);
            this.textdosya.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mesaj";
            // 
            // textmesaj
            // 
            this.textmesaj.Location = new System.Drawing.Point(172, 263);
            this.textmesaj.Multiline = true;
            this.textmesaj.Name = "textmesaj";
            this.textmesaj.Size = new System.Drawing.Size(304, 206);
            this.textmesaj.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(679, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alıcı E-Postalar";
            // 
            // btn_gozat
            // 
            this.btn_gozat.Location = new System.Drawing.Point(482, 223);
            this.btn_gozat.Name = "btn_gozat";
            this.btn_gozat.Size = new System.Drawing.Size(75, 23);
            this.btn_gozat.TabIndex = 11;
            this.btn_gozat.Text = "Gözat";
            this.btn_gozat.UseVisualStyleBackColor = true;
            this.btn_gozat.Click += new System.EventHandler(this.btn_gozat_Click);
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(401, 475);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(75, 23);
            this.btn_gonder.TabIndex = 12;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gönderici Şifre";
            // 
            // textsifre
            // 
            this.textsifre.Location = new System.Drawing.Point(172, 68);
            this.textsifre.Name = "textsifre";
            this.textsifre.Size = new System.Drawing.Size(304, 22);
            this.textsifre.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Alıcı E-Posta";
            // 
            // textalici
            // 
            this.textalici.Location = new System.Drawing.Point(172, 126);
            this.textalici.Name = "textalici";
            this.textalici.Size = new System.Drawing.Size(304, 22);
            this.textalici.TabIndex = 15;
            // 
            // textadsoyad
            // 
            this.textadsoyad.Location = new System.Drawing.Point(172, 12);
            this.textadsoyad.Name = "textadsoyad";
            this.textadsoyad.Size = new System.Drawing.Size(304, 22);
            this.textadsoyad.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Gönderici Adı Soyadı";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(585, 40);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(313, 52);
            this.listBox2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 20;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(679, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Gönderici Bilgileri";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(369, 96);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 20);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 510);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textadsoyad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textalici);
            this.Controls.Add(this.textsifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.btn_gozat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textmesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textdosya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textkonu);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.textgndrn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textgndrn;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textkonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textdosya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textmesaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_gozat;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textsifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textalici;
        private System.Windows.Forms.TextBox textadsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

