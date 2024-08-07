using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryApplication
{
    public partial class frm_KitapListesi : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public string kid;
        public int id;
        public string ImageBase64;
        public frm_KitapListesi()
        {
            InitializeComponent();
        }
        void verigetir()
        {
            baglanti = new SqlConnection("Server=.;Initial Catalog=Libary;Integrated Security=SSPI");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM Kitaps", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dgv_KitapListesi.DataSource = tablo;
            baglanti.Close();
        }

        private void frm_KitapListesi_Load(object sender, EventArgs e)
        {
            verigetir();
            dgv_KitapListesi.DefaultCellStyle.BackColor = Color.LightBlue;
            dgv_KitapListesi.DefaultCellStyle.ForeColor = Color.Black;
            dgv_KitapListesi.DefaultCellStyle.Font = new Font("Arial", 10);

            dgv_KitapListesi.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
            dgv_KitapListesi.Columns[0].HeaderCell.Style.ForeColor = Color.White;

            dgv_KitapListesi.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv_KitapListesi.EnableHeadersVisualStyles = false;

            dgv_KitapListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_KitapListesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //frmPersonelDetay frmPersonelDetay = new frmPersonelDetay();
            //frmPersonelDetay.kid = kid;
            //id = int.Parse(dgv_PersonelListesi.CurrentRow.Cells[0].Value.ToString());
            //ImageBase64 = db.UserProperties.Where(a => a.ID == id).First().Vesikalık.ToString();
            //frmPersonelDetay.id = id;
            //frmPersonelDetay.base64Image = ImageBase64;
            //frmPersonelDetay.Show();
        }
    }
}
