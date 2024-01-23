using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class NotDüzenle : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.QueryString.Count !=0)
                {
                    int id = Convert.ToInt32(Request.QueryString["kid"]);
                    Notlar nt = dv.NotGetir(id);
                    if(nt != null)
                    {
                        tb_baslik.Text = nt.Baslik;
                        tb_ozet.Text = nt.Ozet;
                        cb_durum.Checked = nt.Durum;
                        tb_icerik.Text = nt.Icerik;
                    }
                    else
                    {
                        Response.Redirect("NotListe.aspx");
                    }
                }
                else
                {
                    Response.Redirect("NotListe.aspx");
                }
            }

        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["kid"]);
            Notlar nt = new Notlar();
            nt.ID = id;
            nt.Baslik = tb_baslik.Text;
            nt.Ozet = tb_ozet.Text;
            nt.Durum = cb_durum.Checked;
            nt.Icerik = tb_icerik.Text;
            if(dv.NotDuzenle(nt))
            {
                pnl_basarili.Visible = true;
                pnl_hata.Visible = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_hata.Visible = true;
                lbl_mesaj.Text = "Not Düzenlerken hata oluştu";
            }

        }
    }
}