<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD_Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>具備CRUD的客戶系統</title>
    <style type="text/css">
        .新增樣式1 {
            font-size: 36px;
            text-align: center;
            font-family: 標楷體;
        }
        .auto-style1 {
            margin-left: 361px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="新增樣式1">具備CRUD的客戶系統</asp:Label>
            </strong>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLAzureConnection %>" DeleteCommand="DELETE FROM [CRUD] WHERE [客戶編號] = @客戶編號" InsertCommand="INSERT INTO [CRUD] ([客戶編號], [客戶姓名], [客戶性別], [客戶生日], [客戶電話], [客戶住址]) VALUES (@客戶編號, @客戶姓名, @客戶性別, @客戶生日, @客戶電話, @客戶住址)" SelectCommand="SELECT * FROM [CRUD]" UpdateCommand="UPDATE [CRUD] SET [客戶姓名] = @客戶姓名, [客戶性別] = @客戶性別, [客戶生日] = @客戶生日, [客戶電話] = @客戶電話, [客戶住址] = @客戶住址 WHERE [客戶編號] = @客戶編號">
            <DeleteParameters>
                <asp:Parameter Name="客戶編號" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="客戶編號" Type="String" />
                <asp:Parameter Name="客戶姓名" Type="String" />
                <asp:Parameter Name="客戶性別" Type="String" />
                <asp:Parameter Name="客戶生日" Type="String" />
                <asp:Parameter Name="客戶電話" Type="String" />
                <asp:Parameter Name="客戶住址" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="客戶姓名" Type="String" />
                <asp:Parameter Name="客戶性別" Type="String" />
                <asp:Parameter Name="客戶生日" Type="String" />
                <asp:Parameter Name="客戶電話" Type="String" />
                <asp:Parameter Name="客戶住址" Type="String" />
                <asp:Parameter Name="客戶編號" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="客戶編號" DataSourceID="SqlDataSource1" DefaultMode="Insert" Height="50px">
            <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="客戶編號" HeaderText="客戶編號" ReadOnly="True" SortExpression="客戶編號" />
                <asp:BoundField DataField="客戶姓名" HeaderText="客戶姓名" SortExpression="客戶姓名" />
                <asp:BoundField DataField="客戶性別" HeaderText="客戶性別" SortExpression="客戶性別" />
                <asp:BoundField DataField="客戶生日" HeaderText="客戶生日" SortExpression="客戶生日" />
                <asp:BoundField DataField="客戶電話" HeaderText="客戶電話" SortExpression="客戶電話" />
                <asp:BoundField DataField="客戶住址" HeaderText="客戶住址" SortExpression="客戶住址" />
                <asp:CommandField ButtonType="Button" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        </asp:DetailsView>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="客戶編號" DataSourceID="SqlDataSource1" PageSize="5">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
                <asp:BoundField DataField="客戶編號" HeaderText="客戶編號" ReadOnly="True" SortExpression="客戶編號" />
                <asp:BoundField DataField="客戶姓名" HeaderText="客戶姓名" SortExpression="客戶姓名" />
                <asp:BoundField DataField="客戶性別" HeaderText="客戶性別" SortExpression="客戶性別" />
                <asp:BoundField DataField="客戶生日" HeaderText="客戶生日" SortExpression="客戶生日" />
                <asp:BoundField DataField="客戶電話" HeaderText="客戶電話" SortExpression="客戶電話" />
                <asp:BoundField DataField="客戶住址" HeaderText="客戶住址" SortExpression="客戶住址" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    </form>
</body>
</html>
