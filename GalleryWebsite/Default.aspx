<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Website._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>گالری عکس اژدها</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 137px;
        }
        .style4
        {
            width: 351px;
        }
        .style5
        {
            width: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1" dir="rtl">
            <tr>
                <td colspan="3">
                <center>
                    <asp:Image ID="Image1" runat="server" ImageUrl="logo.png" />
                </center>
                </td>
            </tr>
            <tr>
                <td class="style4">
                <table>
                <tr>
                <td>
                    <asp:Button ID="Button3" runat="server" Text="جدیدترین عکس ها" 
                        onclick="Button3_Click" />
                </td>
                <td>
                    <asp:Button ID="Button4" runat="server" Text="سرگرمی" onclick="Button4_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="علمی" />
                    </td>
                    <td>
                        <asp:Button ID="Button6" runat="server" onclick="Button6_Click" Text="ورزشی" />
                    </td>
                </tr>
                </table>
                </td>
                <td class="style3">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="style5">
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="جستجو" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    <asp:Label ID="Label1" runat="server">جدیدترین عکس ها</asp:Label>
                </td>
                <td class="style3">
                    آدرس عکس:</td>
                <td class="style5">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="style4" rowspan="4">
                <table>
                <tr>
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="ID" 
                        style="margin-bottom: 0px">
                        <ItemTemplate>
                            <td runat="server">
                                <asp:Label ID="Label2" runat="server" Text="نام: "></asp:Label><asp:Label ID="namLabel" runat="server" Text='<%# Eval("nam") %>' />
                                <br />
                                <asp:Image ID="Image2" runat="server" Height="100px" 
                                    ImageUrl='<%# Bind("url") %>' Width="100px" />
                                <br />
                                <asp:Label ID="Label3" runat="server" Text="موضوع: "></asp:Label>
                                <asp:Label ID="subLabel" runat="server" Text='<%# Eval("sub") %>' />
                                <br />
                            </td>
                        </ItemTemplate>
                    </asp:ListView>
                </tr>
                </table>
                </td>
                <td class="style3">
                    نام عکس:</td>
                <td class="style5">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    موضوع عکس:</td>
                <td class="style5">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem Selected="True">موضوع عکس را انتخاب کنید</asp:ListItem>
                        <asp:ListItem>سرگرمی</asp:ListItem>
                        <asp:ListItem>علمی</asp:ListItem>
                        <asp:ListItem>ورزشی</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    <asp:Button ID="Button1" runat="server" Text="آپلود" onclick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4" rowspan="4">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td align="center" class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style5">
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
