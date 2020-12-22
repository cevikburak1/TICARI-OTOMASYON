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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["NOTID"].ToString();
            MskTarih.Text = dr["NOTTARIH"].ToString();
            Msksaat.Text = dr["NOTSAAT"].ToString();
            txtBaşlık.Text = dr["NOTBASLIK"].ToString();
            txtOluşturan.Text = dr["NOTOLUSTURAN"].ToString();
            txthıtap.Text = dr["NOTHITAP"].ToString();
            RichDetay.Text = dr["NOTDETAY"].ToString();


        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();

        }
        void Temizle()
        {
            txtID.Text = " ";
            MskTarih.Text = " ";
            Msksaat.Text = " ";
            txtBaşlık.Text = " ";
            txtOluşturan.Text = " ";
            txthıtap.Text = " ";
            RichDetay.Text = " ";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Temizle();
            MessageBox.Show("Notlar Listelendi");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR(NOTTARIH,NOTSAAT,NOTBASLIK,NOTOLUSTURAN,NOTHITAP,NOTDETAY) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", Msksaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaşlık.Text);
            komut.Parameters.AddWithValue("@p4", txtOluşturan.Text);
            komut.Parameters.AddWithValue("@p5", txthıtap.Text);
            komut.Parameters.AddWithValue("@p6", RichDetay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sisteme Kaydedildi");
            listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where NOTID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi");
            


        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  TBL_NOTLAR set NOTTARIH=@p1,NOTSAAT=@p2,NOTBASLIK=@p3,NOTOLUSTURAN=@p4,NOTHITAP=@p5,NOTDETAY=@p6 where NOTID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut.Parameters.AddWithValue("@p2", Msksaat.Text);
            komut.Parameters.AddWithValue("@p3", txtBaşlık.Text);
            komut.Parameters.AddWithValue("@p4", txtOluşturan.Text);
            komut.Parameters.AddWithValue("@p5", txthıtap.Text);
            komut.Parameters.AddWithValue("@p6", RichDetay.Text);
            komut.Parameters.AddWithValue("@p7", txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemede Güncellendi ");
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmNotDetay fr = new FrmNotDetay();

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                fr.metin = dr["NOTDETAY"].ToString();
            }
            fr.Show();
        }
    }
}
