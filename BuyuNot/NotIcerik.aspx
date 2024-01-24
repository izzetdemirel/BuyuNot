<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="NotIcerik.aspx.cs" Inherits="BuyuNot.NotIcerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/NotIcerik.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rp_Notlar" runat="server">
        <ItemTemplate>
            <div class="Notici">
                <h3 style="min-height:50px;"><%# Eval("Baslik") %></h3>
                <div class="yazarKategori">
                    Kategori: <%# Eval("Kategori") %>  | Yazar: <%# Eval("Yazar") %>
                </div>
                <div class="ozet">
                    <%# Eval ("Icerik") %>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
    <div class="yorumPanel">
        <h2 class="yorumbaslik">Yorumlar</h2>
        <asp:Panel ID="pnl_girisvar" runat="server" CssClass="girisvar">
            <asp:TextBox ID="tb_yorum" runat="server" TextMode="MultiLine" CssClass="forminput"></asp:TextBox><br />
            <br />
            <asp:LinkButton ID="lbtn_yorumyap" runat="server" CssClass="formbutton" OnClick="lbtn_yorumyap_Click">Yorum Yap</asp:LinkButton>
        </asp:Panel>
        <asp:Panel ID="pnl_girisyok" runat="server" CssClass="girisyok">Yorum Yapmak için lütfen
            <asp:LinkButton ID="lbtn_girisyonlendir" runat="server" OnClick="lbtn_girisyonlendir_Click">Giriş</asp:LinkButton>
            Yapınız
        </asp:Panel>
        <asp:Panel ID="pnl_paylasildi" runat="server" CssClass="paylasildi" Visible="false">
            <label>Yorumunuz Paylaşıldı</label>
        </asp:Panel>
        <asp:Panel ID="pnl_paylasilmadi" runat="server" CssClass="paylasilmadi" Visible="false">
            <label>
                <asp:Label ID="lbl_mesaj" runat="server"></asp:Label>
            </label>
        </asp:Panel>
        <asp:Repeater ID="rp_yorumlar" runat="server">
            <ItemTemplate>
                <div class="yorum">
                    <div class="yorumuye">
                        <strong>Üye :</strong>
                        <label><%# Eval("Uye") %></label>&nbsp; | &nbsp; <%# Eval("YorumTarihi") %><br />
                    </div>
                    <strong>Yorumu</strong>
                    <br />
                    <%# Eval("Icerik") %>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
