using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }
        FrmUrunler fr;
        private void BtnÜrünler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr== null) { 
            fr = new FrmUrunler();
            fr.MdiParent = this;
            fr.Show();
        }
        }
        FrmMusteriler ms;
        private void BtnMüşteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ms== null)
            {
                ms = new FrmMusteriler();
                ms.MdiParent = this;
                ms.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (fr78 == null)
            {
                fr78 = new ANASAYFA();
                fr78.MdiParent = this;
                fr78.Show();
            }
        }
        FrmFırmalar fm;
        private void BtnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fm == null)
            {
                fm = new FrmFırmalar();
                fm.MdiParent = this;
                fm.Show();
            }
        }
        ANASAYFA fr78;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr78 == null)
            {
                fr78 = new ANASAYFA();
                fr78.MdiParent = this;
                fr78.Show();
            }

        }
        FrmPersonel fü;
        private void BtnPersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fü == null)
            {
                fü = new FrmPersonel();
                fü.MdiParent = this;
                fü.Show();
            }
        }
        FrmRehber Frm5;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Frm5 == null)
            {
                Frm5 = new FrmRehber();
                Frm5.MdiParent = this;
                Frm5.Show();
            }
        }
        FrmGıderler frm6;
        private void BtnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null)
            {
                frm6 = new FrmGıderler();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }
        Frmbanka frm7;
        private void BtnBankalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null)
            {
                frm7 = new Frmbanka();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        FrmFaturalar frm8;
        private void BtnFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null)
            {
                frm8 = new FrmFaturalar();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }
        FrmNotlar frm9;
        private void BtnNotlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm9 == null)
            {
                frm9 = new FrmNotlar();
                frm9.MdiParent = this ;
                frm9.Show();
            }
        }
        FrmHareketler frm10;
        private void BtnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm10 == null)
            {
                frm10 = new FrmHareketler();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }
        FrmRaporlar dı;
        private void BtnRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dı == null)
            {
               dı = new FrmRaporlar();
                dı.MdiParent = this;
                dı.Show();
            }
        }
        FrmStoklar aq;
        private void BtnStoklar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (aq == null)
            {
                aq = new FrmStoklar();
                aq.MdiParent = this;
                aq.Show();
            }
        }
        FrmAyarlar fr20;
        private void BtnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr20 == null)
            {
                fr20 = new FrmAyarlar();
                fr20.MdiParent= this;
                fr20.Show();
            }
        }
        KASA ks;
        private void BtnKasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ks == null)
            {
                ks = new KASA();
                ks.MdiParent = this;
                ks.Show();
            }
        }
    }
}
