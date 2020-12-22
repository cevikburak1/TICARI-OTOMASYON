using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmFaturaUrunDuzenleme : Form
    {
        public FrmFaturaUrunDuzenleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string urunid;
        private void FrmFaturaUrunDuzenleme_Load(object sender, EventArgs e)
        {
            txtURUNID.Text = urunid;
            SqlCommand komut = new SqlCommand("Select * From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtFıyat.Text = dr[3].ToString();
                txtMıktar.Text = dr[2].ToString();
                txtTutar.Text = dr[4].ToString();
                txtUrunad.Text = dr[1].ToString();

            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURADETAY set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 where FATURAURUNID=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUrunad.Text);
            komut.Parameters.AddWithValue("@p2", txtMıktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtFıyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtTutar.Text));
            komut.Parameters.AddWithValue("@p5", txtURUNID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("SİSTEMDE BAŞARI İLE GÜNCELLENDİ ");


        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURADETAY where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtURUNID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Sistemden Silindi");
        }
    }
}
