<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UyeGiris.aspx.cs" Inherits="BuyuNot.UyeGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/arayüz.css" rel="stylesheet" />
</head>
<body style="background-color:darkblue; font-family:Calibri;">
    <form id="form1" runat="server">
        <div class="kayitFormu">
            <div class="kayit">
                <h3>Hesabınıza Giriş yapın</h3>
            </div>
            <div>
                <asp:TextBox ID="tb_mail" runat="server" CssClass="input" placeholder="E-Postanız"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="input" TextMode="Password" placeholder="Şifre"></asp:TextBox>
            </div><br />
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarili" Visible="false">Giriş Başarılı</asp:Panel>
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisiz" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel><br /><br />
            <div>
                <asp:LinkButton ID="lbtn_login" runat="server" CssClass="loginbutton" OnClick="lbtn_login_Click" >Giriş Yap</asp:LinkButton>
            </div><br /><br />
            <a href="Default.aspx" class="don">Anasayfaya Dön</a>
        </div>
    </form>
</body>
</html>
