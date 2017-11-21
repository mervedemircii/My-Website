<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="HediyeBilgiGetir.aspx.cs" Inherits="Astroloji.HediyeBilgiGetir" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Repeater runat="server" id="rptBilgiler">

        <HeaderTemplate>
              <h2>Hediye Önerileri</h2>
        </HeaderTemplate>
        <ItemTemplate>
                <div class="panel-group col-sm-6 col-md-4 col-lg-3">
                <div class="panel panel-warning">
                    <div class="panel-heading"><span class="glyphicon glyphicon-gift" aria-hidden="true"></span> Hediye Önerileri</div>
                    <div class="panel-body"><center><%#Eval("HediyeAdi") %></center></div>
                </div>
                </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
