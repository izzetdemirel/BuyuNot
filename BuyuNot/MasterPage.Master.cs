using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {
            rp_kategoriler.DataSource = dv.KategoriListele(true);
            rp_kategoriler.DataBind();
        }
    }
}