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
    public partial class FrmFırmalar : Form
    {
        public FrmFırmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            //VERİLERİ LİSTELEYE ÇEKEN KOMUT
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
     public void SehirListesi()
        {
            //ŞEHİRLERİ COMBOX'A TAŞIYAN KOMUT
            SqlCommand komut2 = new SqlCommand("Select SEHIR From TBL_ILLER ", bgl.baglanti());
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                cmbİl.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void FrmFırmalar_Load(object sender, EventArgs e)
        {
            listele();
            SehirListesi();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
        }


        private void cmbİl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }
        void temizle()
        {
            //TEMİZLEME KOMUTLARI
            txtID.Text = " ";
            txtAd.Text = " ";
            txtStatü.Text = " ";
            txtYetkılı.Text = " ";
            msktc.Text = " ";
            txtSektor.Text = " ";
            MskTl1.Text = " ";
            Msktl2.Text = " ";
            mskTel3.Text = " ";
            txtmaıl.Text = " ";
            mskFax.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtVergi.Text = " ";
            RichAdres.Text = " ";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
         
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_FIRMALAR(AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRE,ADRES) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtStatü.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkılı.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTl1.Text);
            komut.Parameters.AddWithValue("@p7", Msktl2.Text);
            komut.Parameters.AddWithValue("@p8", mskTel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbİl.Text);
            komut.Parameters.AddWithValue("@p12", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergi.Text);
            komut.Parameters.AddWithValue("@p14", RichAdres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Eklendi");
            listele();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // VERİLERİ TEXT LERE ÇEKEN KOMUT
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                txtID.Text = dr["ID"].ToString();
                txtAd.Text = dr["AD"].ToString();
                txtStatü.Text = dr["YETKILISTATU"].ToString();
                txtYetkılı.Text = dr["YETKILIADSOYAD"].ToString();
                msktc.Text = dr["YETKILITC"].ToString();
                txtSektor.Text = dr["SEKTOR"].ToString();
                MskTl1.Text = dr["TELEFON1"].ToString();
                Msktl2.Text = dr["TELEFON2"].ToString();
                mskTel3.Text = dr["TELEFON3"].ToString();
                txtmaıl.Text = dr["MAIL"].ToString();
                mskFax.Text = dr["FAX"].ToString();
                cmbİl.Text = dr["IL"].ToString();
                cmbİlce.Text = dr["ILCE"].ToString();
                txtVergi.Text = dr["VERGIDAIRE"].ToString();
                RichAdres.Text = dr["ADRES"].ToString();
            }
        }

        private void cmbİl_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
            //TEMİZLEME KOMUTLARI
            txtID.Text = " ";
            txtAd.Text = " ";
            txtStatü.Text = " ";
            txtYetkılı.Text = " ";
            msktc.Text = " ";
            txtSektor.Text = " ";
            MskTl1.Text = " ";
            Msktl2.Text = " ";
            mskTel3.Text = " ";
            txtmaıl.Text = " ";
            mskFax.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtVergi.Text = " ";
            RichAdres.Text = " ";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //VERİLERİ SİLME 
            SqlCommand komutsil = new SqlCommand("Delete From TBL_FIRMALAR where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("FİRMA SİSTEMDEN SİLİNDİ ");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FIRMALAR ", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  TBL_FIRMALAR set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p10,IL=@p11,ILCE=@p12,VERGIDAIRE=@p13,ADRES=@p14 where ID=@p15", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtStatü.Text);
            komut.Parameters.AddWithValue("@p3", txtYetkılı.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", txtSektor.Text);
            komut.Parameters.AddWithValue("@p6", MskTl1.Text);
            komut.Parameters.AddWithValue("@p7", Msktl2.Text);
            komut.Parameters.AddWithValue("@p8", mskTel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmaıl.Text);
            komut.Parameters.AddWithValue("@p10", mskFax.Text);
            komut.Parameters.AddWithValue("@p11", cmbİl.Text);
            komut.Parameters.AddWithValue("@p12", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p13", txtVergi.Text);
            komut.Parameters.AddWithValue("@p14", RichAdres.Text);
            komut.Parameters.AddWithValue("@p15", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sistemi Güncellendi");
            listele();
        }
    }
}
