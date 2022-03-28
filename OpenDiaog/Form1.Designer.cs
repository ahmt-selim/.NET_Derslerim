namespace OpenDiaog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxRsm = new System.Windows.Forms.PictureBox();
            this.pictureBoxSlayt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rsmsec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.slytbslt = new System.Windows.Forms.Button();
            this.solagit = new System.Windows.Forms.Button();
            this.sagagit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fontayarla = new System.Windows.Forms.Button();
            this.renkayarla = new System.Windows.Forms.Button();
            this.rsmdosyasec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRsm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlayt)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRsm
            // 
            this.pictureBoxRsm.Location = new System.Drawing.Point(27, 50);
            this.pictureBoxRsm.Name = "pictureBoxRsm";
            this.pictureBoxRsm.Size = new System.Drawing.Size(311, 296);
            this.pictureBoxRsm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRsm.TabIndex = 0;
            this.pictureBoxRsm.TabStop = false;
            // 
            // pictureBoxSlayt
            // 
            this.pictureBoxSlayt.Location = new System.Drawing.Point(466, 50);
            this.pictureBoxSlayt.Name = "pictureBoxSlayt";
            this.pictureBoxSlayt.Size = new System.Drawing.Size(311, 296);
            this.pictureBoxSlayt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSlayt.TabIndex = 1;
            this.pictureBoxSlayt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klasörden Seçilen Resim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rsmsec
            // 
            this.rsmsec.Location = new System.Drawing.Point(112, 366);
            this.rsmsec.Name = "rsmsec";
            this.rsmsec.Size = new System.Drawing.Size(112, 45);
            this.rsmsec.TabIndex = 3;
            this.rsmsec.Text = "Resim Seç";
            this.rsmsec.UseVisualStyleBackColor = true;
            this.rsmsec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Slayt Resimler";
            // 
            // slytbslt
            // 
            this.slytbslt.Location = new System.Drawing.Point(563, 435);
            this.slytbslt.Name = "slytbslt";
            this.slytbslt.Size = new System.Drawing.Size(112, 45);
            this.slytbslt.TabIndex = 5;
            this.slytbslt.Text = "Slaytı Başlat";
            this.slytbslt.UseVisualStyleBackColor = true;
            this.slytbslt.Click += new System.EventHandler(this.slytbslt_Click);
            // 
            // solagit
            // 
            this.solagit.Location = new System.Drawing.Point(417, 180);
            this.solagit.Name = "solagit";
            this.solagit.Size = new System.Drawing.Size(43, 29);
            this.solagit.TabIndex = 6;
            this.solagit.Text = "<- -";
            this.solagit.UseVisualStyleBackColor = true;
            this.solagit.Click += new System.EventHandler(this.solagit_Click);
            // 
            // sagagit
            // 
            this.sagagit.Location = new System.Drawing.Point(783, 180);
            this.sagagit.Name = "sagagit";
            this.sagagit.Size = new System.Drawing.Size(43, 29);
            this.sagagit.TabIndex = 7;
            this.sagagit.Text = "- ->";
            this.sagagit.UseVisualStyleBackColor = true;
            this.sagagit.Click += new System.EventHandler(this.sagagit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(904, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 296);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // fontayarla
            // 
            this.fontayarla.Location = new System.Drawing.Point(904, 366);
            this.fontayarla.Name = "fontayarla";
            this.fontayarla.Size = new System.Drawing.Size(112, 45);
            this.fontayarla.TabIndex = 9;
            this.fontayarla.Text = "Font Ayarları";
            this.fontayarla.UseVisualStyleBackColor = true;
            this.fontayarla.Click += new System.EventHandler(this.fontayarla_Click);
            // 
            // renkayarla
            // 
            this.renkayarla.Location = new System.Drawing.Point(1047, 366);
            this.renkayarla.Name = "renkayarla";
            this.renkayarla.Size = new System.Drawing.Size(112, 45);
            this.renkayarla.TabIndex = 10;
            this.renkayarla.Text = "Arka Plan Rengi";
            this.renkayarla.UseVisualStyleBackColor = true;
            this.renkayarla.Click += new System.EventHandler(this.renkayarla_Click);
            // 
            // rsmdosyasec
            // 
            this.rsmdosyasec.Location = new System.Drawing.Point(563, 352);
            this.rsmdosyasec.Name = "rsmdosyasec";
            this.rsmdosyasec.Size = new System.Drawing.Size(112, 45);
            this.rsmdosyasec.TabIndex = 11;
            this.rsmdosyasec.Text = "Resim Dosyası Seç";
            this.rsmdosyasec.UseVisualStyleBackColor = true;
            this.rsmdosyasec.Click += new System.EventHandler(this.rsmdosyasec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Multiselect = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1002, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yazı Stili";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(466, 403);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 873);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rsmdosyasec);
            this.Controls.Add(this.renkayarla);
            this.Controls.Add(this.fontayarla);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sagagit);
            this.Controls.Add(this.solagit);
            this.Controls.Add(this.slytbslt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rsmsec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSlayt);
            this.Controls.Add(this.pictureBoxRsm);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRsm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSlayt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRsm;
        private System.Windows.Forms.PictureBox pictureBoxSlayt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rsmsec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button slytbslt;
        private System.Windows.Forms.Button solagit;
        private System.Windows.Forms.Button sagagit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button fontayarla;
        private System.Windows.Forms.Button renkayarla;
        private System.Windows.Forms.Button rsmdosyasec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

