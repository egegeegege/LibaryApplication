using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibaryApplication.Orm.Context;
using LibaryApplication.Orm.Entity;

namespace LibaryApplication
{
    public partial class frm_KullanıcıKayıtol : Form
    {
        ProjectContext db = new ProjectContext();
        public frm_KullanıcıKayıtol()
        {
            InitializeComponent();
        }

        private void btn_KayıtOl_Click(object sender, EventArgs e)
        {
            List<Kullanıcı> Kul = new List<Kullanıcı>();
            Kul =db.Kullanıcıs.ToList();
            bool kullanıcımevcut = false;

            foreach (Kullanıcı kullanıcı in Kul)
            {
                if (kullanıcı.TelefonNo == txt_Telefon.Text)
                {
                    kullanıcımevcut = true;
                }
            }
            if (kullanıcımevcut)
            {
                MessageBox.Show("Bu telefon numrasına ait kullanıcı mevcut");
            }
            else
            {
                Kullanıcı kullanıcı = new Kullanıcı()
                {
                    Ad = txt_Ad.Text,
                    Soyad = txt_Soyad.Text,
                    Email = txt_gmail.Text,
                    Sifre = txt_sifre.Text,
                    TelefonNo = txt_Telefon.Text,
                    Aktifmi = true,
                    AddDate = DateTime.Now,
                };

                db.Kullanıcıs.Add(kullanıcı);
                db.SaveChanges();
                MessageBox.Show("Kayıt başarıyla oluşturuldu sayın okur");
                this.Hide();

            }

        }

        private void link_kayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_KullanıcıGirisYap frm_KullanıcıGirisYap = new frm_KullanıcıGirisYap();
            this.Hide();
            frm_KullanıcıGirisYap.Show();
        }
    }
}
