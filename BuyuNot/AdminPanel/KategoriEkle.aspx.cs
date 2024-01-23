using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_kaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                if (tb_isim.Text.Length > 3)
                {
                    Kategori k = new Kategori();
                    k.Isim = tb_isim.Text;
                    if (dv.KategoriEkle(k))
                    {
                        pnl_basarili.Visible = true;
                        pnl_hata.Visible = false;
                    }
                    else
                    {
                        lbl_mesaj.Text = "Kategori eklerken hata oluştu";
                        pnl_hata.Visible = true;
                        pnl_basarili.Visible = false;
                    }
                }
                else
                {
                    lbl_mesaj.Text = "Kategori Adı en az 2 karakter olmalıdır";
                    pnl_hata.Visible = true;
                    pnl_basarili.Visible = false;
                }
            }
            else
            {
                lbl_mesaj.Text = "Kategori Adı boş olamaz";
                pnl_hata.Visible = true;
                pnl_basarili.Visible = false;
            }
        }

    }
}