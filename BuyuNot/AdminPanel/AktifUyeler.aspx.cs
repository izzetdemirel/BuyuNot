﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class AktifUyeler : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_uyeler.DataSource = dv.UyeListele(1);
            lv_uyeler.DataBind();

        }

        protected void lv_uyeler_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if(e.CommandName == "banla")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                dv.UyeBanla(id);
            }
            lv_uyeler.DataSource = dv.UyeListele(1);
            lv_uyeler.DataBind();

        }


    }
}