<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registracija.aspx.cs" Inherits="WebApplication1.Registracija2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Registriraj se</h1>
<asp:Label ID="lblKorisnickoIme" runat="server" Text="Korisničko ime:"></asp:Label>
<asp:TextBox ID="txbKorisnickoIme" runat="server"></asp:TextBox><br />
<asp:Label ID="lblPunoIme" runat="server" Text="Puno ime:"></asp:Label>
<asp:TextBox ID="txbPunoIme" runat="server"></asp:TextBox><br />
<asp:Label ID="lblLozinka" runat="server" Text="Lozinka:"></asp:Label>
<asp:TextBox ID="txbLozinka" runat="server" TextMode="Password"></asp:TextBox><br />
<asp:Label ID="lblPonovljenaLozinka" runat="server" Text="Ponovljena lozinka:"></asp:Label>
<asp:TextBox ID="txbPonovljenaLozinka" runat="server" TextMode="Password"></asp:TextBox><br />
<asp:Button ID="btnRegistriraj" runat="server" Text="Registriraj" OnClick="buttonReg_Click"/>

<br />
<br />
    
<asp:Label ID="lblGreska" runat="server"></asp:Label>

</asp:Content>
