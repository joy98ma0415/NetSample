<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ishopping_website.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <script type="text/javascript">
        function getWidth() {
            var intViewportWidth = window.innerWidth;
            var w = window.innerWidth;
            var h = window.innerHeight;
            var ow = window.outerWidth; //including toolbars and status bar etc.
            var oh = window.outerHeight;
            if (window.matchMedia("(min-width: 400px)").matches) {
                /* the viewport is at least 400 pixels wide */
            }
            else {
                /* the viewport is less than 400 pixels wide */
            }
            if (self.innerWidth) {

                return self.innerWidth;
            }



            if (document.documentElement && document.documentElement.clientWidth) {
                return document.documentElement.clientWidth;
            }

            if (document.body) {
                return document.body.clientWidth;

            }
        }
    </script>

        <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.3.js"></script>
    <script type="text/javascript">

        $(function () {
            // See if this is a touch device
            if ('ontouchstart' in window) {
                // Set the correct body class
                $('body').removeClass('no-touch').addClass('touch');

                // Add the touch toggle to show text
                $('div.boxInner img').click(function () {
                    $(this).closest('.boxInner').toggleClass('touchFocus');
                });
            }
        });
    </script>

    <div>
        <br />
        <asp:Table ID="Table2" runat="server" class="col-md-12">
            <asp:TableRow runat="server" Height="100px" Style="background-color: aqua">
            </asp:TableRow>
        </asp:Table>

        <div class="textAlign" style="font-family: Corbel; color: #0000FF; text-decoration: underline; text-align: right;">
            <script src="time.js"></script>
        </div>

        <div class="text-left">

            <h1 class="textAlign">緊眶跪來 俗擱大碗 嚨底甲 </h1>
            <p class="textAlign"> </p>
        </div>

                <table class="col-md-12" style="width: 100%">

            <tr>
                <td class="col-md-1" style="background-color: palevioletred; width: 60px;">
                    <h4><a runat="server" href="~/Home.aspx" style="color: darkblue;">首頁</a></h4>
                    <h4><a runat="server" href="~/Default.aspx" style="color: darkblue;">全部商品</a></h4>
                    <h4><a runat="server" href="~/product.aspx" style="color: darkblue;">依商品類別</a></h4>
                    <h4><a runat="server" href="~/Supplyer.aspx" style="color: darkblue;">依商品廠商</a></h4>
                    <h4><a runat="server" href="~/price.aspx" style="color: darkblue;">依商品價格</a></h4>
                    <h4><a runat="server" href="~/Discount.aspx" style="color: darkblue;">折扣商品</a></h4>
                    <h4><a runat="server" href="~/Hot_Sell_Item.aspx" style="color: darkblue;">最新商品</a></h4>
                    <h4><a runat="server" href="~/talk.aspx" style="color: darkblue;">聊天室</a></h4>
                    <h4><a runat="server" href="~/OnlineService.aspx" style="color: darkblue;">線上客服</a></h4>
                    <h4><a runat="server" href="~/ShoppingCart.aspx" style="color: darkblue;">前往購物車</a></h4>
                    <h4><a runat="server" href="~/Shipping.aspx" style="color: darkblue;">寄送商品</a></h4>
                    <h4><a runat="server" href="~/How-To-Use.aspx" style="color: darkblue;">如何使用</a></h4>
                    <h4><a runat="server" href="~/About Us.aspx" style="color: darkblue;">關於我們</a></h4>
                    <h4><a runat="server" href="~/Contant.aspx" style="color: darkblue;">聯絡我們</a></h4>
                    <h4><a runat="server" href="~/index.htm" style="color: darkblue;">留言版</a></h4>
                    <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" 
                        Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                        <DayHeaderStyle BackColor="#99FFCC" Font-Bold="True" Font-Size="8pt" ForeColor="#990033" Height="8pt" HorizontalAlign="Center" 
                            VerticalAlign="Middle" Wrap="True" />
                        <DayStyle BackColor="#99CCFF" BorderColor="#993366" BorderStyle="Solid" ForeColor="#663300" HorizontalAlign="Center" VerticalAlign="Middle" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>

                    <br />

                    <br />

                </td>

                <td style="background-image:url('images/5-120601094P5-50.gif')" class="col-md-10">

                    <div class="wrap">
                        <asp:Panel runat="server" ID="Panel2" HorizontalAlign="Center">
                            <asp:Panel runat="server" ID="Panel1" HorizontalAlign="Center">
                                
                            </asp:Panel>
                        </asp:Panel>

                        <asp:ListView ID="ListView2" runat="server" DataSourceID="SqlDataSource1" GroupItemCount="4" Style="width: 100%" OnLoad="Page_Load">
                            <AlternatingItemTemplate>
                                <div class="box">
                                    <div class="boxInner">
                                        <asp:Image ID="Image_商品圖片" runat="server" ImageAlign="middle" CssClass="img-responsive" Style="height: 70%"
                                            ImageUrl='<%# Eval("商品名稱", "~/images/{0}.jpg") %>' />
                                        <asp:HyperLink ID="HyperLink_商品編號" runat="server" Font-Size="Small"
                                            NavigateUrl='<%# Eval("商品編號", "DetailsItem.aspx?Id={0}") %>'
                                            Text='<%# Eval("商品編號") %>'></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="商品名稱_Label" runat="server" Font-Size="Small" role="menuitem" Text='<%# Eval("商品名稱") %>'></asp:Label>
                                        <br />
                                        特價  :
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Small" Text='<%# Eval("商品售價") %>'>></asp:Label>
                                        <div class="titleBox">
                                            原價 : <%# Eval("商品原價") %>
                                        </div>

                                    </div>
                                </div>
                            </AlternatingItemTemplate>
                            <ItemTemplate>
                                <div class="box">
                                    <div class="boxInner">
                                        <asp:Image ID="Image_商品圖片" runat="server" ImageAlign="middle" CssClass="img-responsive" Style="height: 70%"
                                            ImageUrl='<%# Eval("商品名稱", "~/images/{0}.jpg") %>' />
                                        <asp:HyperLink ID="HyperLink_商品編號" runat="server" Font-Size="Small"
                                            NavigateUrl='<%# Eval("商品編號", "DetailsItem.aspx?Id={0}") %>'
                                            Text='<%# Eval("商品編號") %>'></asp:HyperLink>
                                        <br />
                                        <asp:Label ID="商品名稱_Label" runat="server" Font-Size="Small" role="menuitem" Text='<%# Eval("商品名稱") %>'></asp:Label>
                                        <br />
                                        特價  :
                                        <asp:Label ID="商品售價_Label" runat="server" Font-Size="Small" Text='<%# Eval("商品售價") %>'>></asp:Label>

                                        <div class="titleBox">
                                            原價 : <%# Eval("商品原價") %>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                            <GroupTemplate>
                                <div id="itemPlaceholderContainer" runat="server">
                                    <div id="itemPlaceholder" runat="server">
                                    </div>
                                </div>
                            </GroupTemplate>
                            <LayoutTemplate>
                                <div runat="server" class="wrap" id="groupPlaceholderContainer">
                                    <div class="box" id="groupPlaceholder" runat="server">
                                        <div class="titleBox"></div>
                                    </div>
                                </div>
                                <div style="text-align: center">
                                    <asp:DataPager ID="DataPager1" runat="server" PageSize="12">
                                        <Fields>
                                            <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True"
                                                ShowLastPageButton="True" />
                                        </Fields>
                                    </asp:DataPager>
                                </div>
                            </LayoutTemplate>
                        </asp:ListView>
                    </div>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                        ConnectionString="<%$ ConnectionStrings:Joy's database %>"
                        ProviderName="<%$ ConnectionStrings:Joy's database.ProviderName %>"
                        SelectCommand="SELECT DISTINCT * FROM [資料表1]"></asp:SqlDataSource>
    </table>

    </div>

</asp:Content>
