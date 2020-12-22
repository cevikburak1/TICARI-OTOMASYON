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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
      
        private void simpleButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
           
        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtFATURAID.Text == " ")
            {
                SqlCommand komut = new SqlCommand("insert into TBL_FATURABILGI(SERI,SIRANO,TARIH,SAAT,VERGIDAIRE,ALICI,TESLIMEDEN,TESLIMALAN) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtSeri.Text);
                komut.Parameters.AddWithValue("@p2", txtSıraNo.Text);
                komut.Parameters.AddWithValue("@p3", mskTarih.Text);
                komut.Parameters.AddWithValue("@p4", mskSaat.Text);
                komut.Parameters.AddWithValue("@p5", txtVergi.Text);
                komut.Parameters.AddWithValue("@p6", txtAlıcı.Text);
                komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
                komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Başarı İle Kaydeildi");
                listele();
            }
            if(txtFATURAID.Text != " ")
            {
                double mıktar, tutar, fıyat;
                fıyat = Convert.ToDouble(txtFıyat.Text);
                mıktar = Convert.ToDouble(txtMıktar.Text);
                tutar = mıktar * fıyat;
                txtTutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("insert into TBL_FATURADETAY(URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtUrunad.Text);
                komut2.Parameters.AddWithValue("@p2", txtMıktar.Text);
                komut2.Parameters.AddWithValue("@p3", txtFıyat.Text);
                komut2.Parameters.AddWithValue("@p4", txtTutar.Text);
                komut2.Parameters.AddWithValue("@p5", txtFATURAID.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün  Sisteme Başarı İle Kaydeildi");
             
               
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
           
                txtID.Text = dr["FATURABILGIID"].ToString();
                txtSeri.Text = dr["SERI"].ToString();
                txtSıraNo.Text = dr["SIRANO"].ToString();
                mskTarih.Text = dr["TARIH"].ToString();
                mskSaat.Text = dr["SAAT"].ToString();
                txtVergi.Text = dr["VERGIDAIRE"].ToString();
                txtAlıcı.Text = dr["ALICI"].ToString();
                txtTeslimEden.Text = dr["TESLIMEDEN"].ToString();
                txtTeslimAlan.Text = dr["TESLIMALAN"].ToString();
            
            }
        void temizle()
        {
            txtID.Text = " ";
            txtSeri.Text =" " ;
            txtSıraNo.Text = " ";
            mskTarih.Text =" " ;
            mskSaat.Text = " ";
            txtVergi.Text = " ";
            txtAlıcı.Text = " ";
            txtTeslimEden.Text =" " ;
            txtTeslimAlan.Text =" " ;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            temizle();
        }

        private void BtnListele_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_FATURABILGI", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            
        }

        private void BtnSil_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_FATURABILGI where FATURABILGIID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Sistemden Silindi");
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtUrunad.Text = " ";
            txtMıktar.Text = " ";
            txtFıyat.Text = " ";
            txtTutar.Text = " ";
            txtFATURAID.Text = " ";
        }

        private void BtnGuncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_FATURABILGI set SERI=@p1,SIRANO=@p2,TARIH=@p3,SAAT=@p4,VERGIDAIRE=@p5,ALICI=@p6,TESLIMEDEN=@p7,TESLIMALAN=@p8 where FATURABILGIID=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtSeri.Text);
            komut.Parameters.AddWithValue("@p2", txtSıraNo.Text);
            komut.Parameters.AddWithValue("@p3", mskTarih.Text);
            komut.Parameters.AddWithValue("@p4", mskSaat.Text);
            komut.Parameters.AddWithValue("@p5", txtVergi.Text);
            komut.Parameters.AddWithValue("@p6", txtAlıcı.Text);
            komut.Parameters.AddWithValue("@p7", txtTeslimEden.Text);
            komut.Parameters.AddWithValue("@p8", txtTeslimAlan.Text);
            komut.Parameters.AddWithValue("@p9", txtID.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgi Sistemi Güncellendi");
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaUrunDetay fr = new FrmFaturaUrunDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr != null)
            {
                fr.id = dr["FATURABILGIID"].ToString();
            }
            fr.Show();
        }
    }
}
