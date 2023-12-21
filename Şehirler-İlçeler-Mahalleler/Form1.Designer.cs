namespace Şehirler_İlçeler_Mahalleler
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
            this.sehirler = new System.Windows.Forms.ListBox();
            this.ilceler = new System.Windows.Forms.ListBox();
            this.mahalleler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sehirler
            // 
            this.sehirler.FormattingEnabled = true;
            this.sehirler.ItemHeight = 16;
            this.sehirler.Location = new System.Drawing.Point(33, 123);
            this.sehirler.Name = "sehirler";
            this.sehirler.Size = new System.Drawing.Size(167, 244);
            this.sehirler.TabIndex = 1;
            this.sehirler.SelectedIndexChanged += new System.EventHandler(this.sehirler_SelectedIndexChanged);
            // 
            // ilceler
            // 
            this.ilceler.FormattingEnabled = true;
            this.ilceler.ItemHeight = 16;
            this.ilceler.Location = new System.Drawing.Point(279, 123);
            this.ilceler.Name = "ilceler";
            this.ilceler.Size = new System.Drawing.Size(171, 244);
            this.ilceler.TabIndex = 2;
            this.ilceler.SelectedIndexChanged += new System.EventHandler(this.ilceler_SelectedIndexChanged);
            // 
            // mahalleler
            // 
            this.mahalleler.FormattingEnabled = true;
            this.mahalleler.ItemHeight = 16;
            this.mahalleler.Location = new System.Drawing.Point(521, 123);
            this.mahalleler.Name = "mahalleler";
            this.mahalleler.Size = new System.Drawing.Size(171, 244);
            this.mahalleler.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şehirler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(274, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlçeler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(516, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mahalleler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mahalleler);
            this.Controls.Add(this.ilceler);
            this.Controls.Add(this.sehirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox sehirler;
        private System.Windows.Forms.ListBox ilceler;
        private System.Windows.Forms.ListBox mahalleler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

