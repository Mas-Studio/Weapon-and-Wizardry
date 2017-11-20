<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainScene.aspx.cs" Inherits="WeaponAndWizardry.MainScene" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Content/styles/MainMenu.css" rel="stylesheet" type="text/css" />

    <div style="background: url(../Content/Images/backgrounds/main_menu_bg.png) no-repeat; width: 100% 0; height: 100% 0; background-position: right center;">
        <div class="wrapper">
            <div class="row">
                <div class="col-md-8">
                <asp:Panel ID="ImageDisplay" runat="server" Style="min-height: 600px; min-width: 800px">
                </asp:Panel>

                <%--<div class="button_warpper" style="position: absolute; z-index: 10; left: 50%; top: 30%;">
                    <div class="row">
                        <asp:Button ID="ButtonChoice1" CssClass="btn btn-default" runat="server" Text="Choice1" OnClick="ButtonChoice1_Click" style="background-color:rgba(150,150,150,0.7)" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice2" CssClass="btn btn-default" runat="server" Text="Choice2" OnClick="ButtonChoice2_Click" style="background-color:rgba(150,150,150,0.7)" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice3" CssClass="btn btn-default" runat="server" Text="Choice3" OnClick="ButtonChoice3_Click" style="background-color:rgba(150,150,150,0.7)" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice4" CssClass="btn btn-default" runat="server" Text="Choice4" OnClick="ButtonChoice4_Click" style="background-color:rgba(150,150,150,0.7)" />
                    </div>
                </div>--%>
                </div>
                <div class="col-md-4" style="min-height:600px; background-color:rgba(255, 255, 255, 0.9)">
                    <asp:Label ID="Label_Status" runat="server" Text="Status" Font-Size="Large" style="font-weight:bold"></asp:Label> <br />
                    <asp:Label ID="Label_HP" runat="server" Text="HP: " Font-Size="Medium"></asp:Label> <br />
                    <asp:Label ID="Label_Str" runat="server" Text="Str: " Font-Size="Medium"></asp:Label> <br />
                    <asp:Label ID="Label_Dex" runat="server" Text="Dex: " Font-Size="Medium"></asp:Label>  <br />
                    <asp:Label ID="Label_Int" runat="server" Text="Int: " Font-Size="Medium"></asp:Label>  <br />
                    <asp:Label ID="Label_Luck" runat="server" Text="Luck: " Font-Size="Medium"></asp:Label>  <br />
                    <br /><br /><br /><br /><br /><br /><br /><br /><br />
                    <br /><br /><br /><br /><br /><br /><br /><br />
                    <asp:Button ID="Button_Save" runat="server" Text="Save" style="width:100%;" />
                    <asp:Button ID="Button_Load" runat="server" Text="Load" style="width:100%;" />
                    <asp:Button ID="Button_Back" runat="server" Text="Quit" PostBackUrl="~/MainMenu.aspx" style="width:100%;" OnClick="Button_Back_Click" />
                </div>
                <asp:TextBox ID="TextDisplay" runat="server" TextMode="MultiLine" style="width:97.5%;margin-left:15px;min-height:200px;min-width:800px;color: white; background-color: rgba(128, 128, 128, 0.6);"></asp:TextBox>
                <script type="text/javascript">
                    window.onload = function () {
                        var textarea = document.getElementById('<%=TextDisplay.ClientID %>');
                        textarea.scrollTop = textarea.scrollHeight - 1;
                    }
                </script>
                <div class="row" style="width:94%;margin:auto;">
                    <div class="row">
                        <asp:Button ID="ButtonChoice1" CssClass="btn btn-primary" runat="server" Text="Choice1" OnClick="ButtonChoice1_Click" style="width:100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice2" CssClass="btn btn-primary" runat="server" Text="Choice2" OnClick="ButtonChoice2_Click" style="width:100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice3" CssClass="btn btn-primary" runat="server" Text="Choice3" OnClick="ButtonChoice3_Click" style="width:100%" />
                    </div>
                    <div class="row">
                        <asp:Button ID="ButtonChoice4" CssClass="btn btn-primary" runat="server" Text="Choice4" OnClick="ButtonChoice4_Click" style="width:100%" />
                    </div>
                </div>
            </div>
            </div>
        </div>
</asp:Content>