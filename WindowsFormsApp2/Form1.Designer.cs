namespace NotDefteri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lstNotlar = new System.Windows.Forms.ListBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.txtIcerik = new System.Windows.Forms.TextBox();
            this.chkOnemli = new System.Windows.Forms.CheckBox();
            this.btnYeniNot = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.btnOnemliNotlar = new System.Windows.Forms.Button();
            this.btnTumNotlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNotlar
            // 
            this.lstNotlar.FormattingEnabled = true;
            this.lstNotlar.ItemHeight = 16;
            this.lstNotlar.Location = new System.Drawing.Point(12, 40);
            this.lstNotlar.Name = "lstNotlar";
            this.lstNotlar.Size = new System.Drawing.Size(300, 500);
            this.lstNotlar.TabIndex = 0;
            this.lstNotlar.SelectedIndexChanged += new System.EventHandler(this.lstNotlar_SelectedIndexChanged);
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(330, 40);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(450, 22);
            this.txtBaslik.TabIndex = 1;
            // 
            // txtIcerik
            // 
            this.txtIcerik.Location = new System.Drawing.Point(330, 100);
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            this.txtIcerik.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIcerik.Size = new System.Drawing.Size(450, 350);
            this.txtIcerik.TabIndex = 2;
            // 
            // chkOnemli
            // 
            this.chkOnemli.AutoSize = true;
            this.chkOnemli.Location = new System.Drawing.Point(330, 470);
            this.chkOnemli.Name = "chkOnemli";
            this.chkOnemli.Size = new System.Drawing.Size(121, 21);
            this.chkOnemli.TabIndex = 3;
            this.chkOnemli.Text = "Önemli Not";
            this.chkOnemli.UseVisualStyleBackColor = true;
            // 
            // btnYeniNot
            // 
            this.btnYeniNot.Location = new System.Drawing.Point(330, 510);
            this.btnYeniNot.Name = "btnYeniNot";
            this.btnYeniNot.Size = new System.Drawing.Size(120, 30);
            this.btnYeniNot.TabIndex = 4;
            this.btnYeniNot.Text = "Kaydet";
            this.btnYeniNot.UseVisualStyleBackColor = true;
            this.btnYeniNot.Click += new System.EventHandler(this.btnYeniNot_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(470, 510);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 30);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(610, 510);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 30);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(327, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(79, 17);
            this.lblBaslik.TabIndex = 7;
            this.lblBaslik.Text = "Not Başlığı:";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(327, 80);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(46, 17);
            this.lblIcerik.TabIndex = 8;
            this.lblIcerik.Text = "İçerik:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(470, 470);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(54, 17);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "Tarih: -";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 12);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 22);
            this.txtAra.TabIndex = 10;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Location = new System.Drawing.Point(218, 15);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(94, 17);
            this.lblAra.TabIndex = 11;
            this.lblAra.Text = "Notlarda Ara:";
            // 
            // btnOnemliNotlar
            // 
            this.btnOnemliNotlar.Location = new System.Drawing.Point(12, 550);
            this.btnOnemliNotlar.Name = "btnOnemliNotlar";
            this.btnOnemliNotlar.Size = new System.Drawing.Size(140, 30);
            this.btnOnemliNotlar.TabIndex = 12;
            this.btnOnemliNotlar.Text = "Önemli Notlar";
            this.btnOnemliNotlar.UseVisualStyleBackColor = true;
            this.btnOnemliNotlar.Click += new System.EventHandler(this.btnOnemliNotlar_Click);
            // 
            // btnTumNotlar
            // 
            this.btnTumNotlar.Location = new System.Drawing.Point(172, 550);
            this.btnTumNotlar.Name = "btnTumNotlar";
            this.btnTumNotlar.Size = new System.Drawing.Size(140, 30);
            this.btnTumNotlar.TabIndex = 13;
            this.btnTumNotlar.Text = "Tüm Notlar";
            this.btnTumNotlar.UseVisualStyleBackColor = true;
            this.btnTumNotlar.Click += new System.EventHandler(this.btnTumNotlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 593);
            this.Controls.Add(this.btnTumNotlar);
            this.Controls.Add(this.btnOnemliNotlar);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYeniNot);
            this.Controls.Add(this.chkOnemli);
            this.Controls.Add(this.txtIcerik);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.lstNotlar);
            this.Name = "Form1";
            this.Text = "Not Defteri Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotlar;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.TextBox txtIcerik;
        private System.Windows.Forms.CheckBox chkOnemli;
        private System.Windows.Forms.Button btnYeniNot;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Button btnOnemliNotlar;
        private System.Windows.Forms.Button btnTumNotlar;
    }
}