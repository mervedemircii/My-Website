<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="Eglence.aspx.cs" Inherits="Astroloji.Eglence" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Bugün Ne Yapsam?</h2>
        <div class="alert alert-success alert-dismissible">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <asp:Label runat="server" ID="lblYazi" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </div>

        <h2>Hayat Paylaştıkça Güzel!</h2>
        <div class="alert alert-success alert-dismissible">
            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
            <asp:Label runat="server" ID="paylasmalbl" Font-Bold="True" Font-Size="Medium"></asp:Label>
        </div>
    </div>
</asp:Content>
