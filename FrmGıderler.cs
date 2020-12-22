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
    public partial class FrmGıderler : Form
    {
        public FrmGıderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //GİDERLERİ SİSTEME KAYDETME
            SqlCommand komut = new SqlCommand("insert into TBL_GIDERLER(AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            komut.Parameters.AddWithValue("@p2", mskYıl.Text);
            komut.Parameters.AddWithValue("@p3", MskElektrik.Text);
            komut.Parameters.AddWithValue("@p4", mskSu.Text);
            komut.Parameters.AddWithValue("@p5", mskDogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", mskİnternet.Text);
            komut.Parameters.AddWithValue("@p7", mskMaaş.Text);
            komut.Parameters.AddWithValue("@p8", mskEkstra.Text);
            komut.Parameters.AddWithValue("@p9", richNot.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Gider Sisteme Kaydedildi");
            listele();
        }
        void listele()
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            //TEMİZLEME KOMUTLARI
            txtID.Text = " ";
            cmbAy.Text = " ";
            mskDogalgaz.Text = " ";
            mskEkstra.Text = " ";
            mskMaaş.Text = " ";
            mskSu.Text = " ";
            mskYıl.Text = " ";
            mskİnternet.Text = " ";
            MskElektrik.Text = " ";
            richNot.Text = " ";
        }

        private void FrmGıderler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            //ÜRÜNLERİ LİSTELEYEN SQL SORGUSU
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //GİDERLERİ GÜNCELLEME KOMUTU
            SqlCommand komut = new SqlCommand("Update TBL_GIDERLER set AY=@p1,YIL=@p2,ELEKTRIK=@p3,SU=@p4,DOGALGAZ=@p5,INTERNET=@p6,MAASLAR=@p7,EKSTRA=@p8,NOTLAR=@p9 where ID=@p10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            komut.Parameters.AddWithValue("@p2", mskYıl.Text);
            komut.Parameters.AddWithValue("@p3", MskElektrik.Text);
            komut.Parameters.AddWithValue("@p4", mskSu.Text);
            komut.Parameters.AddWithValue("@p5", mskDogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", mskİnternet.Text);
            komut.Parameters.AddWithValue("@p7", mskMaaş.Text);
            komut.Parameters.AddWithValue("@p8", mskEkstra.Text);
            komut.Parameters.AddWithValue("@p9", richNot.Text);
            komut.Parameters.AddWithValue("@p10", txtID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Gider Güncellendi");
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dt["ID"].ToString();
            cmbAy.Text = dt["AY"].ToString();
            mskYıl.Text = dt["YIL"].ToString();
            MskElektrik.Text = dt["ELEKTRIK"].ToString();
            mskSu.Text = dt["SU"].ToString();
            mskDogalgaz.Text = dt["DOGALGAZ"].ToString();
            mskİnternet.Text = dt["INTERNET"].ToString();
            mskMaaş.Text = dt["MAASLAR"].ToString();
            mskEkstra.Text = dt["EKSTRA"].ToString();
            richNot.Text = dt["NOTLAR"].ToString();


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            //TEMİZLEME KOMUTLARI
            txtID.Text = " ";
            cmbAy.Text = " ";
            mskDogalgaz.Text = " ";
            mskEkstra.Text = " ";
            mskMaaş.Text = " ";
            mskSu.Text = " ";
            mskYıl.Text = " ";
            mskİnternet.Text = " ";
            MskElektrik.Text = " ";
            richNot.Text = " ";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //VERİLERİ SİLME 
            SqlCommand komut = new SqlCommand("Delete From TBL_GIDERLER where ID=@p1", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Gider Sistemden Silindi");
        }
    }
}
