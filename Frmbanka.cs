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
    public partial class Frmbanka : Form
    {
        public Frmbanka()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void Frmbanka_Load(object sender, EventArgs e)
        {
            listele();
            SehirListesi();
            FirmaListesi();
            Temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //BANKAYI SİSTEME EKLEME
            SqlCommand komut = new SqlCommand("insert into TBL_BANKALAR (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", cmbİl.Text);
            komut.Parameters.AddWithValue("@p3", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p4", txtŞube.Text);
            komut.Parameters.AddWithValue("@p5", mskİban.Text);
            komut.Parameters.AddWithValue("@p6", mskHesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkılı.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mskTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtTür.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            listele();
            MessageBox.Show("BANKA SİSTEME EKLENDİ");
        }
        public void SehirListesi()
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
        void FirmaListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD From TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //BANKAYI SİSTEMDEN SİLEN KOMUT
            SqlCommand komut = new SqlCommand("Delete From TBL_BANKALAR where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            Temizle();
            MessageBox.Show("Banka Sistemden Kaldırıldı");
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //ÜRÜNE TIKLANDIGINDA BUTONLARA TAŞIYAN KOMUT 
           
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                
                txtıd.Text = dr["ID"].ToString();
                txtAd.Text = dr["BANKAADI"].ToString();
                cmbİl.Text = dr["IL"].ToString();
                cmbİlce.Text = dr["ILCE"].ToString();
                txtŞube.Text = dr["SUBE"].ToString();
                mskİban.Text = dr["IBAN"].ToString();
                mskHesapno.Text = dr["HESAPNO"].ToString();
                txtYetkılı.Text = dr["YETKILI"].ToString();
                mskTelefon.Text = dr["TELEFON"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                txtTür.Text = dr["HESAPTURU"].ToString();
                
            
        }
        void Temizle()
        {
            txtıd.Text =" " ;
            txtAd.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtŞube.Text = " ";
            mskİban.Text = " ";
            mskHesapno.Text = " ";
            txtYetkılı.Text = " ";
            mskTelefon.Text = " ";
            mskTarih.Text = " ";
            txtTür.Text = " ";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtıd.Text = " ";
            txtAd.Text = " ";
            cmbİl.Text = " ";
            cmbİlce.Text = " ";
            txtŞube.Text = " ";
            mskİban.Text = " ";
            mskHesapno.Text = " ";
            txtYetkılı.Text = " ";
            mskTelefon.Text = " ";
            mskTarih.Text = " ";
            txtTür.Text = " ";
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //LİSTEYİ GETİREN KMOUT
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            MessageBox.Show("SİSTEM  TEKRAR LİSTELENDİ");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //SİSTEM GÜNCELLEME
            SqlCommand komut = new SqlCommand("Update  TBL_BANKALAR set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 where ID=@p12",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", cmbİl.Text);
            komut.Parameters.AddWithValue("@p3", cmbİlce.Text);
            komut.Parameters.AddWithValue("@p4", txtŞube.Text);
            komut.Parameters.AddWithValue("@p5", mskİban.Text);
            komut.Parameters.AddWithValue("@p6", mskHesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtYetkılı.Text);
            komut.Parameters.AddWithValue("@p8", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p9", mskTarih.Text);
            komut.Parameters.AddWithValue("@p10", txtTür.Text);
            komut.Parameters.AddWithValue("@p11", lookUpEdit1.EditValue);
            komut.Parameters.AddWithValue("@p12", txtıd.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("BANKA SİSTEMi GÜNCELLENDİ");
            listele();
           
        }
    }
}
