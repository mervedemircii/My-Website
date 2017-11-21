<%@ Page Title="" Language="C#" MasterPageFile="~/index.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Astroloji.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row col-lg-10 col-lg-push-1">
        <div class="col-md-4 portfolio-item">
            <a href="/AstrolojikBilgiler.aspx">
                
            </a>
            <h3>
                <a href="/AstrolojikBilgiler.aspx">Astrolojik Bilgiler</a>
            </h3>
            <p>Bu sayfada; burcunuza göre film önerilerine bakabilir, kendi burcunuz veya bir başkası için hediye önerileri görebilirsiniz...</p>

        </div>
        <div class="col-md-4 portfolio-item">
            <a href="/Eglence.aspx">
              
            </a>
            <h3>
                <a href="/Eglence.aspx">Eğlence</a>
            </h3>
            <p>Bu sayfada; boş gününüzdesiniz ve yapacak bir şeyler arıyorsunuz. Size öneri olarak sunduğumuz seçenekleri görebilirsiniz. Ayrıca 'Mutluluk paylaştıkça güzel' başlığı ile birilerini sevindirmeye ne dersin :)</p>

        </div>
        <div class="col-md-4 portfolio-item">
            <div class="page-header">
                <h1>Ziyaretçi Anketi</h1>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">E-Posta Adresiniz</label>
                <div>
                    <asp:TextBox runat="server" ID="txtEposta" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Adınız ve Soyadınız</label>
                <div>
                    <asp:TextBox runat="server" ID="txtIsim" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Web Sitemizi Beğendiniz Mi?</label>
                <div>
                    <asp:DropDownList ID="EvetHayir" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Evet">Evet</asp:ListItem>
                    <asp:ListItem Value="Hayır">Hayır</asp:ListItem>
                </asp:DropDownList>
                </div>
            </div>
            <div class="form-group">
                <label for="exampleInputEmail1">Genel Yorumunuz</label>
                <div>
                    <asp:TextBox runat="server" ID="txtYorum" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div>
                <asp:Button runat="server" ID="btnGonder" Text="Gönder " OnClick="btnGonder_Click" CssClass="btn btn-success" />
            </div>
        </div>
    </div>
</asp:Content>
