using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotDefteri
{
    public partial class Form1 : Form
    {
        private List<Not> notlar = new List<Not>();
        private string dosyaYolu = "notlar.txt";
        private int seciliNotIndex = -1;

        public Form1()
        {
            InitializeComponent();
            NotlariYukle();
            NotListesiniGuncelle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        private void NotlariYukle()
        {
            try
            {
                if (File.Exists(dosyaYolu))
                {
                    notlar.Clear();
                    string[] satirlar = File.ReadAllLines(dosyaYolu);
                    foreach (string satir in satirlar)
                    {
                        string[] parcalar = satir.Split('|');
                        if (parcalar.Length >= 3)
                        {
                            Not not = new Not
                            {
                                Baslik = parcalar[0],
                                Icerik = parcalar[1],
                                Tarih = DateTime.Parse(parcalar[2]),
                                Onemli = parcalar.Length > 3 ? bool.Parse(parcalar[3]) : false
                            };
                            notlar.Add(not);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notlar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotlariKaydet()
        {
            try
            {
                List<string> satirlar = new List<string>();
                foreach (Not not in notlar)
                {
                    satirlar.Add($"{not.Baslik}|{not.Icerik}|{not.Tarih}|{not.Onemli}");
                }
                File.WriteAllLines(dosyaYolu, satirlar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Notlar kaydedilirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NotListesiniGuncelle()
        {
            lstNotlar.Items.Clear();
            foreach (Not not in notlar)
            {
                string goruntuleme = not.Onemli ? $"[ÖNEMLİ] {not.Baslik}" : not.Baslik;
                lstNotlar.Items.Add(goruntuleme);
            }
        }

        private void btnYeniNot_Click(object sender, EventArgs e)
        {
            string baslik = txtBaslik.Text.Trim();
            string icerik = txtIcerik.Text.Trim();

            if (string.IsNullOrEmpty(baslik))
            {
                MessageBox.Show("Not başlığı boş olamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seciliNotIndex == -1)
            {
                // Yeni not ekle
                Not yeniNot = new Not
                {
                    Baslik = baslik,
                    Icerik = icerik,
                    Tarih = DateTime.Now,
                    Onemli = chkOnemli.Checked
                };
                notlar.Add(yeniNot);
            }
            else
            {
                // Notu güncelle
                notlar[seciliNotIndex].Baslik = baslik;
                notlar[seciliNotIndex].Icerik = icerik;
                notlar[seciliNotIndex].Tarih = DateTime.Now;
                notlar[seciliNotIndex].Onemli = chkOnemli.Checked;
            }

            NotlariKaydet();
            NotListesiniGuncelle();
            FormuTemizle();
            seciliNotIndex = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliNotIndex != -1 && seciliNotIndex < notlar.Count)
            {
                DialogResult result = MessageBox.Show("Notu silmek istediğinizden emin misiniz?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    notlar.RemoveAt(seciliNotIndex);
                    NotlariKaydet();
                    NotListesiniGuncelle();
                    FormuTemizle();
                    seciliNotIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir not seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormuTemizle();
            seciliNotIndex = -1;
        }

        private void FormuTemizle()
        {
            txtBaslik.Clear();
            txtIcerik.Clear();
            chkOnemli.Checked = false;
            lblTarih.Text = "Tarih: -";
        }

        private void lstNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedIndex != -1)
            {
                seciliNotIndex = lstNotlar.SelectedIndex;
                Not seciliNot = notlar[seciliNotIndex];

                txtBaslik.Text = seciliNot.Baslik;
                txtIcerik.Text = seciliNot.Icerik;
                chkOnemli.Checked = seciliNot.Onemli;
                lblTarih.Text = $"Tarih: {seciliNot.Tarih:dd.MM.yyyy HH:mm}";
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtAra.Text.Trim().ToLower();
            lstNotlar.Items.Clear();

            foreach (Not not in notlar)
            {
                if (not.Baslik.ToLower().Contains(aramaMetni) || not.Icerik.ToLower().Contains(aramaMetni))
                {
                    string goruntuleme = not.Onemli ? $"[ÖNEMLİ] {not.Baslik}" : not.Baslik;
                    lstNotlar.Items.Add(goruntuleme);
                }
            }
        }

        private void btnOnemliNotlar_Click(object sender, EventArgs e)
        {
            lstNotlar.Items.Clear();
            foreach (Not not in notlar)
            {
                if (not.Onemli)
                {
                    lstNotlar.Items.Add($"[ÖNEMLİ] {not.Baslik}");
                }
            }
        }

        private void btnTumNotlar_Click(object sender, EventArgs e)
        {
            txtAra.Clear();
            NotListesiniGuncelle();
        }
    }

    public class Not
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public DateTime Tarih { get; set; }
        public bool Onemli { get; set; }
    }
}