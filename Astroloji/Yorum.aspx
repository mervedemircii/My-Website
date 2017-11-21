<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Yorum.aspx.cs" Inherits="Astroloji.Yorum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater runat="server" ID="dtRepeter">
        <HeaderTemplate>
            <div class="container">
                <h2>Ziyaretçi Yorumları</h2>
                <p>Ziyaretçilerimizin yaptıkları yorumları görün!</p>
                <table class="table table-striped">
                    <thead>
                        <tr>
                            <th>Adı Soyadı</th>
                            <th>Email</th>
                            <th>Yorum</th>
                            <th>Durum</th>
                        </tr>
                    </thead>
                    <tbody>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("AdSoyad") %></td>
                <td><%#Eval("EPosta") %></td>
                <td><%#Eval("Yorum") %></td>
                <td><%#Eval("MemnunMu") %></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </tbody>
            </table>
        </div>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>

