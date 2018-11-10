<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_NET_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Table ID="Table1" runat="server" Height ="100" BackColor="YellowGreen"></asp:Table>
        <h1 class="text-center" style="height: 105px">My Contact</h1>
        <p class="lead" style="text-align: center; margin-left: 48; height: 65px;">我的聯絡方式</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>
                <asp:Image ID="Image1" runat="server" Height="50" Width="50" ImageUrl="~/images/icons8-phone-50.png" />
                Mobile Phone</h2>
            <p class="text-center">
                0932-139-830</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>
                <asp:Image ID="Image2" runat="server" Height="50" Width="50" ImageUrl="~/images/icons8-email-filled-50.png" />
                Email</h2>
            <p class="text-center">
                &nbsp;<a href="mailto:joy51744@gmail.com">joy51744@gmail.com</a>  / <a href="mailto:misssu1004@gmail.com">misssu1004@gmail.com</a></p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>
                <asp:Image ID="Image3" runat="server" Height="50" Width="50" ImageUrl="~/images/icons8-line-50.png" />
                Line</h2>
            <p class="text-center">
                joyma840531</p>
            <p>
                &nbsp;</p>
        </div>
    </div>

</asp:Content>
