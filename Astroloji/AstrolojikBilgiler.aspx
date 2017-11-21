<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="AstrolojikBilgiler.aspx.cs" Inherits="Astroloji.AstrolojikBilgiler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-md-6 col-md-offset-3">
            <div class="page-header">
                <h1>Astrolojik Bilgiler</h1>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Kim için bakıyorsunuz?</label>
                <asp:DropDownList ID="kimSec" runat="server" CssClass="form-control">
                    <asp:ListItem> Kendim için bakıyorum. </asp:ListItem>
                    <asp:ListItem>Bir arkadaşa bakıp çkcm .s</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Cinsiyetiniz?</label>
                <asp:DropDownList ID="cinsiyetSec" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Erkek" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Kadın" Value="2"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Burcunuz?</label>
                <asp:DropDownList ID="burcSec" runat="server" CssClass="form-control">
                    <asp:ListItem Value="1">Koç(21 Mart-20 Nisan)</asp:ListItem>
                    <asp:ListItem Value="2">Boğa (21 Nisan- 20 Mayıs)</asp:ListItem>
                    <asp:ListItem Value="3">İkizler (21 Mayıs- 21 Haziran)</asp:ListItem>
                    <asp:ListItem Value="4">Yengeç (22 Haziran- 22 Temmuz)</asp:ListItem>
                    <asp:ListItem Value="5">Aslan (23 Temmuz- 22 Ağustos)</asp:ListItem>
                    <asp:ListItem Value="6">Başak (23 Ağustos- 22 Eylül)</asp:ListItem>
                    <asp:ListItem Value="7">Terazi (23 Eylül- 23 Ekim)</asp:ListItem>
                    <asp:ListItem Value="8">Akrep (24 Ekim- 22 Kasım) </asp:ListItem>
                    <asp:ListItem Value="9">Yay (23 Kasım- 21 Aralık)</asp:ListItem>
                    <asp:ListItem Value="10">Oğlak (23 Kasım- 21 Aralık)</asp:ListItem>
                    <asp:ListItem Value="11">Kova (21 Ocak- 21 Şubat)</asp:ListItem>
                    <asp:ListItem Value="12">Balık (22 Şubat- 20 Mart)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <center> <asp:Button runat="server" ID="btnFilmOner" CssClass="btn btn-success" Text="Film Önerilerini Göster" OnClick="btnFilmOner_Click" />
            <asp:Button runat="server" ID="btnHediyeOner" CssClass="btn btn-danger" Text="Hediye Önerilerini Göster" OnClick="btnHediyeOner_Click" /></center>
        </div>
    </div>
</asp:Content>
