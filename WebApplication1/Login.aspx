<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Login</h1>
<asp:Label ID="lblKorisnickoIme" runat="server" Text="Korisničko ime:"></asp:Label>
<asp:TextBox ID="txbKorisnickoIme" runat="server"></asp:TextBox><br />
<asp:Label ID="lblLozinka" runat="server" Text="Lozinka:"></asp:Label>
<asp:TextBox ID="txbLozinka" runat="server" TextMode="Password"></asp:TextBox><br />
<asp:Button ID="btnPrijava" runat="server" Text="Prijava" OnClick="buttonLogin_Click"/>

<br />
<br />
    
<asp:Label ID="lblGreska" runat="server"></asp:Label>

</asp:Content>
