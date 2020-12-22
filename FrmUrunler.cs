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
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //VERİLERİ KAYDETME
            SqlCommand komut = new SqlCommand("insert into TBL_URUNLER(URUNAD,MARKA,MODEL,YIL,ADET,ALISFIYAT,SATISFIYAT,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYıl.Text);
            komut.Parameters.AddWithValue("@p5",int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlış.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatış.Text));
            komut.Parameters.AddWithValue("@p8", RichDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Sisteme Eklendi ");
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //SİSTEMDEN VERİ SİLME KOMUTLARI
            SqlCommand komutsil = new SqlCommand("Delete From TBL_URUNLER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("ÜRÜN SİSTEMDEN SİLİNDİ");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_URUNLER ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ÜRÜNE TIKLANDIGINDA BUTONLARA TAŞIYAN KOMUT 
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["URUNAD"].ToString();
            txtMarka.Text = dr["MARKA"].ToString();
            txtModel.Text = dr["MODEL"].ToString();
            mskYıl.Text = dr["YIL"].ToString();
            NudAdet.Text = dr["ADET"].ToString();
            txtAlış.Text = dr["ALISFIYAT"].ToString();
            txtSatış.Text = dr["SATISFIYAT"].ToString();
            RichDetay.Text = dr["DETAY"].ToString();



        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //ÜRÜNLERİ GÜNCELLEME KOMUTU
            SqlCommand komut = new SqlCommand("update TBL_URUNLER set URUNAD=@p1,MARKA=@p2,MODEL=@p3,YIL=@p4,ADET=@p5,ALISFIYAT=@p6,SATISFIYAT=@p7,DETAY=@p8 where ID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtMarka.Text);
            komut.Parameters.AddWithValue("@p3", txtModel.Text);
            komut.Parameters.AddWithValue("@p4", mskYıl.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NudAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtAlış.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtSatış.Text));
            komut.Parameters.AddWithValue("@p8", RichDetay.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi Sistemi Yeniden Listeleyin Eklendi ");
            listele();
        }
    }
}
