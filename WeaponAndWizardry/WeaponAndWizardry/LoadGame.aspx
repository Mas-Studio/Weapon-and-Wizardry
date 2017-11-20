<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LoadGame.aspx.cs" Inherits="WeaponAndWizardry.LoadGame" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    <div style="background:url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0;height:100% 0; background-position: right center; min-height:650px;">
        <div>
            <div class ="row center">
                <img alt="logo" longdesc="MA's Weapons&amp;Wizardry" src="Content/Images/ui/logo_3.png" style="width: 100%;" />
            </div>
        </div>

        <table style="width: 100%">
            <tr><td><div class="row"></div></td></tr>
            <tr><td><div class="row"></div></td></tr>
            <tr><td><div class="row"></div></td></tr>
            <tr>
            </tr>
            <tr>
                <td style="width: 50%">
                 <asp:Button ID="Button_Load_Back" CssClass="image_button_back" runat="server" Text="Back" PostBackUrl="~/MainMenu.aspx"/>
                </td>
                <td style="width: 50%">
                    <asp:Button ID="Button_Load_Game" CssClass="image_button_load" runat="server" Text="Load Game"/>
                </td>
            </tr>
            <tr><td><div class="row"><br /><br /><br /><br /><br /><br /><br /></div></td></tr>
        </table>
    </div>
</asp:Content>
