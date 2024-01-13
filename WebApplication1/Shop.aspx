<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="WebApplication1.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Shop</h1>
    <asp:Label ID="lblNaziv" runat="server" Text="Naziv:"></asp:Label>
    <asp:TextBox ID="txbNaziv" runat="server"></asp:TextBox><br />
    <asp:Label ID="lblOpis" runat="server" Text="Opis:"></asp:Label>
    <asp:TextBox ID="txbOpis" runat="server"></asp:TextBox>
    <br />

    <br />
    <asp:Button ID="btnSpremi" runat="server" Text="Spremi" OnClick="buttonSpremi_Click"/>

    <br />

    <br />

    <asp:Label ID="lblGreska" runat="server"></asp:Label>
    <br />

    <asp:GridView ID="gridProducts" runat="server">
    </asp:GridView>

</asp:Content>
