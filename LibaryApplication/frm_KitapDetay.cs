using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class frm_KitapDetay : Form
    {
        public int id;
        public string kid;
        public string base64Image;

        ProjectContext Database = new ProjectContext();
        public frm_KitapDetay()
        {
            InitializeComponent();
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KitapDetay_Load(object sender, EventArgs e)
        {
            List<Kitap> kitaps = new List<Kitap>();
            kitaps = Database.Kitaps.Where(a => a.ID == id).ToList();

            foreach (Kitap kitap in kitaps)
            {
                txt_kitapadı.Text = kitap.KitapAdı.ToString();
                txt_baskısayısı.Text = kitap.BaskıSayısı.ToString();
                txt_basıyılı.Text = kitap.BasımYılı.ToString();
                txt_ciltno.Text = kitap.CiltNo.ToString();
                txt_sayfasayısı.Text = kitap.SayfaSayısı.ToString();
                txt_yayınevi.Text = kitap.Yayınevi.ToString();
                txt_yazar.Text = kitap.Yazar.ToString();
                pb_KitapResim.Image = ConvertToBase64Image(kitap.ImageUrl);
            }
        }
        private Image ConvertToBase64Image(string imageUrl)
        {
            byte[] imageBytes = Convert.FromBase64String(imageUrl);
            using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                return Image.FromStream(ms, true);
            }
        }
    }
}
