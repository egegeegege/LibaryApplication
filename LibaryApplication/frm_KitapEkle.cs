using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibaryApplication.Orm.Context;
using LibaryApplication.Orm.Entity;

namespace LibaryApplication
{
    public partial class frm_KitapEkle : Form
    {
        ProjectContext Database = new ProjectContext();
        public frm_KitapEkle()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_resimyukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg;*.png;*.gif;*.bmp) | *.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_kitapresim.Image = new Bitmap(ofd.FileName);
                FileName.Text = ofd.FileName;
            }
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            string base64;
            using (Image image = pic_kitapresim.Image.Clone() as Image)
            {
                base64 = ConvertImageToBase64(image);
            }
            Kitap kitap = new Kitap()
            {
                KitapAdı = txt_kitapadı.Text,
                BaskıSayısı = Convert.ToInt32(txt_baskısayısı.Text),
                BasımYılı = Convert.ToInt32(txt_basımyılı.Text),
                CiltNo = Convert.ToInt32(txt_ciltno.Text),
                SayfaSayısı = Convert.ToInt32(txt_sayfasayısı.Text),
                Yayınevi = txt_yayınevi.Text,
                Yazar = txt_yazar.Text,
                Aktifmi = true,
                AddDate = DateTime.Now,
                ImageUrl = base64,
            };
            Database.Kitaps.Add(kitap);
            Database.SaveChanges();
            MessageBox.Show("Kitap Başarıyla Eklendi");
            this.Hide();
        }
        private string ConvertImageToBase64(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, image.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
    }
}
