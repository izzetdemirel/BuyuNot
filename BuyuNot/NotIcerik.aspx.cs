using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot
{
    public partial class NotIcerik : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString.Count != 0)
            {
                int id = Convert.ToInt32(Request.QueryString["nid"]);
                rp_Notlar.DataSource = dv.NotListele();
                rp_Notlar.DataBind();

                rp_yorumlar.DataSource = dv.YorumListele();
                rp_yorumlar.DataBind();

                if (Session["uye"] != null)
                {
                    pnl_girisvar.Visible = true;
                    pnl_girisyok.Visible = false;
                }
                else
                {
                    pnl_girisvar.Visible = false;
                    pnl_girisyok.Visible = true;
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }
        }

        protected void lbtn_yorumyap_Click(object sender, EventArgs e)
        {
            Yorum y = new Yorum();
            Uye u = (Uye)Session["uye"];
            y.Uye_ID = u.ID;
            y.Icerik = tb_yorum.Text;
            if(!string.IsNullOrEmpty(tb_yorum.Text.Trim()))
            {
                try
                {
                    int id = Convert.ToInt32(Request.QueryString["nid"]);
                    y.Notlar_ID = id;
                    y.Icerik = tb_yorum.Text;
                    y.YorumTarihi = DateTime.Today;
                    pnl_paylasildi.Visible = true;
                    pnl_paylasilmadi.Visible = false;
                    dv.YorumEkle(y);
                    tb_yorum.Text = " ";
                }
                catch 
                {
                    pnl_paylasildi.Visible = false;
                    pnl_paylasilmadi.Visible=true;
                    lbl_mesaj.Text = "Yorumun Paylaşılırken bir hata oluştu";
                }
            }
            else
            {
                pnl_paylasildi.Visible = false;
                pnl_paylasilmadi.Visible = true;
                lbl_mesaj.Text = "Yorum alanı doldurulmalıdır";
            }
        }

        protected void lbtn_girisyonlendir_Click(object sender, EventArgs e)
        {
            Session["link"] = "NotIcerik.aspx?nid=" + Request.QueryString["nid"];
            Response.Redirect("UyeGiris.aspx");
        }
    }
}