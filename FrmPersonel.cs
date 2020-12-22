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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtID.Text = " ";
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            msktc.Text = " ";
            MskTl1.Text = " ";
            txtmaıl.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtGorev.Text = " ";
            MskMaaş.Text = " ";
        }
        void listele()
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            listele();
            SehırLıstesı();
            temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_PERSONELLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {         //VERİLERİ SİSTEME KAYDETME İŞLEMİ
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,MAAS,GOREV) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTl1.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p6", cmbİl.Text);
            komut.Parameters.AddWithValue("@p7", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p8", MskMaaş.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Sisteme Kaydedildi");
            listele();
        }
        public void SehırLıstesı()
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

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ÜRÜNE TIKLANDIGINDA BUTONLARA TAŞIYAN KOMUT 
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dt["ID"].ToString();
            txtAd.Text = dt["AD"].ToString();
            txtSoyad.Text = dt["SOYAD"].ToString();
            MskTl1.Text = dt["TELEFON"].ToString();
            msktc.Text = dt["TC"].ToString();
            txtmaıl.Text = dt["MAIL"].ToString();
            cmbİl.Text = dt["IL"].ToString();
            cmbİlce.Text = dt["ILCE"].ToString();
            MskMaaş.Text = dt["MAAS"].ToString();
            txtGorev.Text = dt["GOREV"].ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //VERİLERİ SİLME 
            SqlCommand komut = new SqlCommand("Delete From TBL_PERSONELLER where  ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Personel Sistemden Silindi");
          
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //GÜNCELLEME KOMUTLARI
            SqlCommand komut = new SqlCommand("Update  TBL_PERSONELLER set AD=@p1,SOYAD=@p2,TELEFON=@p3,TC=@p4,MAIL=@p5,IL=@p6,ILCE=@p7,MAAS=@p8,GOREV=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTl1.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p6", cmbİl.Text);
            komut.Parameters.AddWithValue("@p7", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p8", MskMaaş.Text);
            komut.Parameters.AddWithValue("@p9", txtGorev.Text);
            komut.Parameters.AddWithValue("@p10", txtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Personel Sistemde Güncellendi");
            listele();
        }
        void temizle()
        {
            //TEMİZLEME KOMUTLARI
            txtID.Text = " ";
            txtAd.Text = " ";
            txtSoyad.Text = " ";
            msktc.Text = " ";
            MskTl1.Text = " ";
            txtmaıl.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtGorev.Text = " ";
            MskMaaş.Text = " ";
        }



    }
}
