using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yonetici"] != null)
            {
                Yonetici yon = (Yonetici)Session["yonetici"];
                lbtn_kullanici.Text = yon.KullaniciAdi;
            }
            else
            {
                Response.Redirect("AdminPanelGiris.aspx");
            }

        }

        protected void lbtn_cikis_Click(object sender, EventArgs e)
        {
           Session["yonetici"] = null;
            Response.Redirect("AdminPanelGiris.aspx");
        }
    }
}