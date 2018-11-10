<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_NET_Project._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Table ID="Table1" runat="server" Height ="100" BackColor="YellowGreen"></asp:Table>
        <h1 class="text-center" style="height: 105px">Welcome to my website.</h1>
        <p class="lead" style="text-align: justify; margin-left: 48px; height: 65px;">Here recorded the memories of my life and bit by bit between college life.</p>
        <p class="text-right" style="width: 653px"><a href="" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>My Resume</h2>
            <p>
                我的履歷表
            </p>
            <p>
                <a class="btn btn-default" href="">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>My Contact</h2>
            <p>
                我的聯絡方式
            </p>
            <p>
                <a class="btn btn-default" href="Contact">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>My Blog</h2>
            <p>
                我的部落格
            </p>
            <p>
                <a class="btn btn-default" href="">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
