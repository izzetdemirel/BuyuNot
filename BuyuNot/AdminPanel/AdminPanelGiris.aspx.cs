using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot.AdminPanel
{
    public partial class AdminPanelGiris : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty (tb_kullaniciAdi.Text) && !string.IsNullOrEmpty(tb_sifre.Text))
            {
                Yonetici admin = dv.AdminGiris(tb_kullaniciAdi.Text, tb_sifre.Text);
                if (admin != null)
                {
                    Session["yonetici"] = admin;
                    Response.Redirect("Anasayfa.aspx");
                }
                else
                {
                    pnl_hata.Visible = true;
                    lbl_mesaj.Text = "Kullanıcı bulunamadı Bilgileri kontrol edin";
                   
                }
            }
            else
            {
                pnl_hata.Visible = true;
                lbl_mesaj.Text = "Kullanıcı Adı ve Şifre boş bırakılamaz";
            }
        }

        
    }
}