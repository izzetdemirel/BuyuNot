using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class NotEkle : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ddl_kategoriler.DataSource = dv.KategoriListele(true);
                ddl_kategoriler.DataBind();
            }
        }

        protected void lbtn_kaydet_Click(object sender, EventArgs e)
        {
            Notlar not = new Notlar();
            not.Baslik = tb_baslik.Text;
            not.Ozet = tb_ozet.Text;
            not.Icerik = tb_icerik.Text;
            not.Durum = cb_aktif.Checked;
            Yonetici y = (Yonetici)Session["yonetici"];
            not.Yazar_ID = y.ID;
            not.EklenmeTarih = DateTime.Now;
            not.Kategori_ID = Convert.ToInt32(ddl_kategoriler.SelectedItem.Value);

            if(dv.NotEkle(not))
            {
                pnl_basarili.Visible = true;
                pnl_hata.Visible = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                lbl_mesaj.Text = "Not eklerken hata meydana geldi";
                pnl_hata.Visible = true;
            }

        }
    }
}