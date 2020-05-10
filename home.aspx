<%@ Page Title="" Language="C#" MasterPageFile="~/stjup.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="stjup.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
		
	<div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-t-30 p-b-50">
				<span class="login100-form-title p-b-41">
					Account Home Page
				</span>

	                    <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnlogin" runat="server" class="login100-form-btn" Text="Login" OnClick="btnlogin_Click" >                           
						</asp:Button>	
                        </div>
                
                        <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btncreate" runat="server" class="login100-form-btn" Text="Register Account" OnClick="btncreate_Click" >                           
						</asp:Button>	
					    </div>				

				</div>
		</div>
	</div>	
</asp:Content>
