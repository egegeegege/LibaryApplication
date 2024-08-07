using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryApplication
{
    public partial class frm_YoneticiPanel : Form
    {
        public frm_YoneticiPanel()
        {
            InitializeComponent();
        }

        private void btn_kitapEkle_Click(object sender, EventArgs e)
        {
            frm_KitapEkle frm_KitapEkle = new frm_KitapEkle();
            frm_KitapEkle.Show();
        }

        private void btn_kitaplar_Click(object sender, EventArgs e)
        {
            frm_KitapListesi frm_KitapListesi = new frm_KitapListesi();
            frm_KitapListesi.Show();
        }
    }
}
