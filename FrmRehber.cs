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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            //MÜŞTERİ BİLGİLERİ
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select AD,SOYAD,TELEFON,TELEFON2,MAIL from TBL_MUSTERILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            //FİRMA BİLGİLERİ
            DataTable du = new DataTable();
            SqlDataAdapter dı = new SqlDataAdapter("Select AD,YETKILIADSOYAD,YETKILISTATU,SEKTOR from TBL_FIRMALAR", bgl.baglanti());
            dı.Fill(du);
            gridControl2.DataSource = du;

        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
          


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
          

        }
    }
}
