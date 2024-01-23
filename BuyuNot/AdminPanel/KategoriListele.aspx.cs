using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class KategoriListele : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            olmazsa();

        }

        protected void lv_kategoriler_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if(e.CommandName == "durum")
            {
                dv.KategoriDurum(id);
            }
            if(e.CommandName == "sil")
            {
                dv.KategoriSil(id);
            }
            olmazsa();
        }

        private void olmazsa()
        {
            lv_kategoriler.DataSource = dv.KategoriListele();
            lv_kategoriler.DataBind();
        }
    }
}