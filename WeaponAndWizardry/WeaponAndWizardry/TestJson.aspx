<%@ Page Title="TestJson" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestJson.aspx.cs" Inherits="WeaponAndWizardry.TestJson" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script src='Scripts/sounds.js'></script>

    <script>
        BGM.play('Contents/bgm_crystal_waver.mp3');
    </script>

    <h2>Test<%: Title %>Json</h2>
    <h2>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Load Json" />
    </h2>
    <p>&nbsp;</p>
    <p>Test Area</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </p>
    
</asp:Content>