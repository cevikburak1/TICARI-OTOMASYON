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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
      void listele()
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
    public   void SehirListesi()
        {
            //ŞEHİRLERİ COMBOX'A TAŞIYAN KOMUT
            SqlCommand komut = new SqlCommand("Select SEHIR From TBL_ILLER ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbİl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
       
        private void FrmMusteriler_Load(object sender, EventArgs e)
        {    //ÜRÜNLERİ LİSTELEYEN SQL SORGUSUNU ÇAGIRIYORUZ 
            listele();
            SehirListesi();
        }

        private void cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //İLCELERİ COMBOBOX'A TAŞIYAN KOMUT
            cmbİlce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE From TBL_ILCELER where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbİl.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbİlce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
    }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //VERİLERİ SİLME 
            SqlCommand komutsil = new SqlCommand("Delete From TBL_MUSTERILER where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("MÜŞTERİ SİSTEMDEN SİLİNDİ ");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //VERİLERİ SİSTEME KAYDETME İŞLEMİ
            SqlCommand komut = new SqlCommand("insert into TBL_MUSTERILER(AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,ADRES,VERGIDAIRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTl1.Text);
            komut.Parameters.AddWithValue("@p4", Msktl2.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.Parameters.AddWithValue("@p6", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p7", cmbİl.Text);
            komut.Parameters.AddWithValue("@p8", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p9", RichAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi");
            listele();

        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ÜRÜNE TIKLANDIGINDA BUTONLARA TAŞIYAN KOMUT 
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["ID"].ToString();
            txtAd.Text = dr["AD"].ToString();
            txtSoyad.Text = dr["SOYAD"].ToString();
            MskTl1.Text = dr["TELEFON"].ToString();
            Msktl2.Text = dr["TELEFON2"].ToString();
            msktc.Text = dr["TC"].ToString();
            txtmaıl.Text = dr["MAIL"].ToString();
            cmbİl.Text = dr["IL"].ToString();
            cmbİlce.Text = dr["ILCE"].ToString();
            RichAdres.Text = dr["ADRES"].ToString();
            txtVergi.Text = dr["VERGIDAIRE"].ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //MÜŞTERİLERİ LİSTEYEN KOMUT
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUSTERILER ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //MÜŞTERİLERİ GÜNCELLEYEN KOMUT
            SqlCommand komut = new SqlCommand("Update TBL_MUSTERILER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,ADRES=@p9,VERGIDAIRE=@p10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTl1.Text);
            komut.Parameters.AddWithValue("@p4", Msktl2.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.Parameters.AddWithValue("@p6", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p7", cmbİl.Text);
            komut.Parameters.AddWithValue("@p8", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p9", RichAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtVergi.Text);
            komut.Parameters.AddWithValue("@p11", txtID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Bilgileri Güncellendi Sistemi Yeniden Listeleyin  ");
            listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
