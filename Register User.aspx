<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register User.aspx.cs" Inherits="stjup.Register_User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> WITS STATIONERY AND GIFTS</title>
    <style type="text/css">
        .auto-style2 {
            height: 778px;
            width: 1366px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-login100" style="background-image: none; background-color: #333333;"> 
            <br />
        </div> 
        <div style="background-color: #333333; background-repeat: repeat; color: #CC0000; " class="auto-style2">
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;<br />
            <br />
            If you alredy have the account please log in at the LOGIN PAGE&nbsp;&nbsp;&nbsp; <asp:LinkButton ID="LinkButton1" runat="server" Text ="login" OnClick="LinkButton1_Click"></asp:LinkButton>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your Personal Details 
         <table class="style1" style="color: #000000"> 
            <tr>
                <td style="color: #FF0000;">FIRST NAME:</td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="color: #FF0000;">LAST NAME:</td>
                <td>
                    <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="color: #FF0000;">E-MAIL:</td>
                <td>
                    <asp:TextBox ID="TxtEMAIL" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td style="color: #FF0000;">TELEPHONE:</td>
                <td>
                    <asp:TextBox ID="TxtTelephone" runat="server"></asp:TextBox>
                </td>
            </tr>
             <tr>
                <td style="color: #FF0000;">PASSWORD:</td>
                <td>
                    <asp:TextBox ID="TextPassword" runat="server"
                                 TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="color: #FF0000;">CORNFIRM PASSWORD:</td>
                <td>
                    <asp:TextBox ID="TxtRePassword" runat="server"
                                 TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="color: #FF0000;">ADDESS:</td>
                <td>
                    <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="color: #FF0000;">AGE:</td>
                <td>
                    <asp:TextBox ID="TxtAge" runat="server" ForeColor="#9999FF" Width="120px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                
                <td style="color: #FF0000;">GENDER:</td>
                <td>
                <asp:DropDownList ID="DropDownList1" runat="server"
                                  AppendDataBoundItems="true" Width="96px">
                <asp:ListItem Value="-1">Select</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                </asp:DropDownList>
                </td>
            </tr>
        </table>                        
        <asp:Button ID="Button1" runat ="server" Text="REGISTER"
                                 onclick="Btt1_Click" ForeColor="#CC0000" style="margin-bottom: 0px" Width="200px" BorderColor="#CC0000" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your personal data will be used to support your experience<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; throughout this website to manage access to your account.<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>


    </form>
    </body>
</html>
