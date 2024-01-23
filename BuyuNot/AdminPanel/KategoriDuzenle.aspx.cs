using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class KategoriDuzenle : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.QueryString.Count !=0)
                {
                    int id = Convert.ToInt32(Request.QueryString["kid"]);
                    Kategori kt = dv.KategoriGetir(id);
                    if(kt != null)
                    {
                        tb_isim.Text = kt.Isim;
                        cb_durum.Checked = kt.Durum;
                    }
                    else
                    {
                        Response.Redirect("KategoriListele.aspx");
                    }
                }
                else
                {
                    Response.Redirect("KategoriListele.aspx");
                }
            }
        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kid"]);
            Kategori kt = new Kategori();
            kt.ID = id;
            kt.Isim = tb_isim.Text;
            kt.Durum = cb_durum.Checked;
            if(dv.KategoriDuzenle(kt))
            {
                pnl_basarili.Visible = true;
                pnl_hata.Visible = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_hata.Visible = true;
                lbl_mesaj.Text = "Kategori düzenlerken hata oluştu";
            }
        }
    }
}