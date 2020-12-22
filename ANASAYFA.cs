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
    public partial class ANASAYFA : Form
    {
        public ANASAYFA()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void Stok()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select URUNAD,Sum(ADET) as 'ADET' From TBL_URUNLER group by URUNAD having Sum(ADET)<=150000 order by Sum(ADET)", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void Ajanda()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select top 10 NOTTARIH,NOTSAAT,NOTBASLIK From TBL_NOTLAR order by NOTID desc", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void firma()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BANKAADI From TBL_BANKALAR",bgl.baglanti());
            da.Fill(dt);
            gridControl3.DataSource = dt;
        }

        void Musg()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD From TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl4.DataSource = dt;
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {
            Stok();
            Ajanda();
            firma();
            Musg();
            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
          
        }
    }
}
