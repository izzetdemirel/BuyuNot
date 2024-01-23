using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class NotListe : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            olmazsa();
        }

        protected void lv_Notlar_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "durum")
            {
                dv.NotDurum(id);
            }
            if (e.CommandName == "sil")
            {
                dv.NotSil(id);
            }
            olmazsa();
           

        }
         private void olmazsa()
        {
            lv_Notlar.DataSource = dv.NotListele();
            lv_Notlar.DataBind();
        }
    }
}