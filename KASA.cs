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
using DevExpress.Charts;

namespace WindowsFormsApp1
{
    public partial class KASA : Form
    {
        public KASA()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void MusterıHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Select * From TBL_FATURADETAY", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void FırmaHareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec FirmaHareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void KASA_Load(object sender, EventArgs e)
        {
            FırmaHareket();
            MusterıHareket();
            lust();
            maas();
            musteri();
            fırma();
            sehır();
            stok();
            kullanıcı();
            Chart();
            Chart1();
            
            Gıderler();
            //KASA TUTARI HESAAPLAMA 
            SqlCommand komut = new SqlCommand("Select Sum(TUTAR) From TBL_FATURADETAY", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblToplam.Text = dr[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();

           void maas()
            {
                //Son AY
                SqlCommand komut2 = new SqlCommand("Select MAASLAR From TBL_GIDERLER", bgl.baglanti());
                SqlDataReader dr3 = komut2.ExecuteReader();
                while (dr3.Read())
                {
                    label4.Text = dr3[0].ToString() + " TL ";
                }
                bgl.baglanti().Close();
            }
        }
        void lust()
        {
            //Son AY
            SqlCommand komut1 = new SqlCommand("Select (DOGALGAZ+INTERNET+MAASLAR+EKSTRA) From  TBL_GIDERLER order by ID asc", bgl.baglanti());
            SqlDataReader dr7 = komut1.ExecuteReader();
            while (dr7.Read())
            {
                label2.Text = dr7[0].ToString() + " TL ";
            }
            bgl.baglanti().Close();
        }
        void musteri()
        {
            SqlCommand komut1 = new SqlCommand("Select ID From  TBL_MUSTERILER ", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label6.Text = dr2[0].ToString() + " KİŞİ ";
            }
            bgl.baglanti().Close();
        }
        void fırma()
        {
            SqlCommand komut1 = new SqlCommand("Select ID From  TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label8.Text = dr2[0].ToString() + " FİRMA ";
            }
            bgl.baglanti().Close();
        }
        void sehır()
        {
            SqlCommand komut1 = new SqlCommand("Select ID From  TBL_ILLER", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label10.Text = dr2[0].ToString() + " ŞEHİR";
            }
            bgl.baglanti().Close();
        }
        void stok()
        {
            SqlCommand komut1 = new SqlCommand("Select Sum(STOKADET) From  TBL_STOKLAR ", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label12.Text = dr2[0].ToString() + " STOK MEVCUT";
            }
            bgl.baglanti().Close();
        }
        void kullanıcı()
        {
            SqlCommand komut1 = new SqlCommand("Select ID From  TBL_MUSTERILER ", bgl.baglanti());
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())
            {
                label14.Text = dr2[0].ToString() + " AKTİF KULLANICI MEVCUT";
            }
            bgl.baglanti().Close();
        }
        //CHART KONTROL ELEKTRİ FATURASI SON 4 AY LİSTELEME 
      
        void Gıderler()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_GIDERLER", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void Chart()
        {
          
                SqlCommand komut1 = new SqlCommand("Select top 4 AY,ELEKTRIK from TBL_GIDERLER order by ID  Desc", bgl.baglanti());
                SqlDataReader dr2 = komut1.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));
                }
                bgl.baglanti().Close();
            
        }
        void Chart1()
        {
           
                SqlCommand komut1 = new SqlCommand("Select top 4 AY,SU from TBL_GIDERLER order by ID  Desc", bgl.baglanti());
                SqlDataReader dr2 = komut1.ExecuteReader();
                while (dr2.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr2[0], dr2[1]));
                }
                bgl.baglanti().Close();
            
        }
    }
       

      
   

                   
                }
               
           
        
    

