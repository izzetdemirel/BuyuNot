﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class ReddedilenYorumlar : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_yorumlar.DataSource = dv.YorumListele(false);
            lv_yorumlar.DataBind();
        }

        protected void lv_yorumlar_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName == "onayla")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dv.YorumOnayla(id);
            }
            lv_yorumlar.DataSource = dv.YorumListele(false);
            lv_yorumlar.DataBind();
            if(e.CommandName == "sil")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dv.YorumSil(id);
            }
            lv_yorumlar.DataSource= dv.YorumListele(false);
            lv_yorumlar.DataBind();
        }
    }
}