<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="AstrolojiBilgiGetir.aspx.cs" Inherits="Astroloji.AstrolojiBilgiGetir" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" id="rptBilgiler">

        <HeaderTemplate>
              <h2>Film Önerileri</h2>
        </HeaderTemplate>
        <ItemTemplate>
                <div class="panel-group col-sm-6 col-md-4 col-lg-3">
                <div class="panel panel-success">
                    <div class="panel-heading"><center><%#Eval("FilmAdi") %></center></div>
                    <div class="panel-body"><a href="#" class="thumbnail"><img src="img/film/film görselleri/<%#Eval("FilmID") %>.jpg" width="187" height="270" /></a></div>
                </div>
                </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
