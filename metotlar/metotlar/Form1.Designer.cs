namespace metotlar
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
            this.lblSayı1 = new System.Windows.Forms.Label();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.lblSayı2 = new System.Windows.Forms.Label();
            this.btnHesap = new System.Windows.Forms.Button();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.sonuc = new System.Windows.Forms.Label();
            this.btnSekil = new System.Windows.Forms.Button();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnRenk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // lblSayı1
            // 
            this.lblSayı1.AutoSize = true;
            this.lblSayı1.Location = new System.Drawing.Point(42, 47);
            this.lblSayı1.Name = "lblSayı1";
            this.lblSayı1.Size = new System.Drawing.Size(34, 13);
            this.lblSayı1.TabIndex = 0;
            this.lblSayı1.Text = "sayı 1";
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(106, 47);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(144, 20);
            this.txtSayı1.TabIndex = 1;
            // 
            // lblSayı2
            // 
            this.lblSayı2.AutoSize = true;
            this.lblSayı2.Location = new System.Drawing.Point(42, 90);
            this.lblSayı2.Name = "lblSayı2";
            this.lblSayı2.Size = new System.Drawing.Size(34, 13);
            this.lblSayı2.TabIndex = 2;
            this.lblSayı2.Text = "sayı 2";
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(121, 182);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(113, 34);
            this.btnHesap.TabIndex = 3;
            this.btnHesap.Text = "hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(106, 87);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(144, 20);
            this.txtSayı2.TabIndex = 4;
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Location = new System.Drawing.Point(37, 218);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(39, 13);
            this.sonuc.TabIndex = 5;
            this.sonuc.Text = "sonuc:";
            // 
            // btnSekil
            // 
            this.btnSekil.Location = new System.Drawing.Point(410, 87);
            this.btnSekil.Name = "btnSekil";
            this.btnSekil.Size = new System.Drawing.Size(116, 46);
            this.btnSekil.TabIndex = 6;
            this.btnSekil.Text = "sekil";
            this.btnSekil.UseVisualStyleBackColor = true;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(42, 135);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(34, 13);
            this.lblMesaj.TabIndex = 7;
            this.lblMesaj.Text = "mesaj";
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(106, 132);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(144, 20);
            this.txtMesaj.TabIndex = 8;
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(273, 185);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(75, 31);
            this.btnRenk.TabIndex = 9;
            this.btnRenk.Text = "renk";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 324);
            this.Controls.Add(this.btnRenk);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnSekil);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.lblSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.lblSayı1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayı1;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.Label lblSayı2;
        private System.Windows.Forms.Button btnHesap;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.Label sonuc;
        private System.Windows.Forms.Button btnSekil;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

