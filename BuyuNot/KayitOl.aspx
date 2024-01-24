<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KayitOl.aspx.cs" Inherits="BuyuNot.KayitOl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/arayüz.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="kayitFormu">
            <div class="kayit">
                <h3>Kullanıcı Kayıt Formu</h3>
            </div>
            <div>
                <asp:TextBox ID="tb_isim" runat="server" CssClass="input" placeholder="isim"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="tb_soyisim" runat="server" CssClass="input"
                    placeholder="Soyisim"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="tb_kullaniciadi" runat="server" CssClass="input" Placeholder="Kullanıcı Adı"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="tb_mail" runat="server" CssClass="input" placeholder="E-posta"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="tb_sifre" runat="server" CssClass="input" TextMode="Password" placeholder="Şifre"></asp:TextBox>
            </div><br />
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarili" Visible="false">Kayıt Başarılı</asp:Panel>
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisiz" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </asp:Panel><br /><br />
            <div>
                <asp:LinkButton ID="lbtn_kayit" runat="server" CssClass="loginbutton" OnClick="lbtn_kayit_Click">Kayıt Ol</asp:LinkButton>
            </div><br /><br />
            <a href="Default.aspx" class="don">Anasayfaya Dön</a>
        </div>
    </form>
</body>
</html>
