using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BuyuNot
{
    public partial class KayitOl : System.Web.UI.Page
    {
        DataV dv = new DataV();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_kayit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_isim.Text.Trim()))
            {
                if(!string.IsNullOrEmpty(tb_soyisim.Text.Trim()))
                {
                    if(!string.IsNullOrEmpty(tb_kullaniciadi.Text.Trim()))
                    {
                        if(!string.IsNullOrEmpty(tb_mail.Text.Trim()))
                        {
                            if(!string.IsNullOrEmpty(tb_sifre.Text.Trim()))
                            {
                                Uye u = new Uye();
                                u.Isim = tb_isim.Text;
                                u.Soyisim = tb_soyisim.Text;
                                u.KullaniciAdi = tb_kullaniciadi.Text;
                                u.Mail = tb_mail.Text;
                                u.Sifre = tb_sifre.Text;
                                u.KayitTarih = DateTime.Now;
                                u.Durum = true;
                                if(dv.UyeEkle(u))
                                {
                                    pnl_basarili.Visible = true;
                                    pnl_basarisiz.Visible = false;
                                }
                                else
                                {
                                    pnl_basarili.Visible = false;
                                    pnl_basarisiz.Visible = true;
                                    lbl_mesaj.Text = "Kayıt olurken bir hata oluştu";
                                }
                            }
                            else
                            {
                                pnl_basarili.Visible = false;
                                pnl_basarisiz.Visible= true;
                                lbl_mesaj.Text = "Şifre Boş BIrakılamaz";
                            }
                        }
                        else
                        {
                            pnl_basarili.Visible = false;
                            pnl_basarisiz.Visible = true;
                            lbl_mesaj.Text = "E-posta boş bırakılamaz";
                        }
                    }
                    else
                    {
                        pnl_basarili.Visible = false;
                        pnl_basarisiz.Visible = true;
                        lbl_mesaj.Text = "Kullanıcı Adı Boş Bırakılamaz";
                    }
                }
                else
                {
                    pnl_basarili.Visible = false;
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Soyisim Boş Bırakılamaz";
                }
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "İsim Boş Bırakılamaz";
            }
        }
    }
}