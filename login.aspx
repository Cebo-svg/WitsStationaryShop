<%@ Page Title="" Language="C#" MasterPageFile="~/stjup.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="stjup.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div>
	
	<div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-t-30 p-b-50">
				<span class="login100-form-title p-b-41">
					Account Login
				</span>
				<div class="login100-form validate-form p-b-33 p-t-5">

					<div class="wrap-input100 validate-input" data-validate = "Enter username">
						<input ID="txtusername" runat="server" class="input100" type="text" name="username" placeholder="User name">
					
					</div>

					<div class="wrap-input100 validate-input" data-validate="Enter password">
						<input ID="txtpass" runat="server"  class="input100" type="password" name="pass" placeholder="Password">
				
					</div>

				  <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnlogin" runat="server" class="login100-form-btn" Text="Login" OnClick="btnlogin_Click">                           
						</asp:Button>	
                        </div>

                    	  <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btncreate" runat="server" class="login100-form-btn" Text="Create Acount" OnClick="btncreate_Click">                           
						</asp:Button>	
                        <div runat="server" id ="report"></div>
                        </div>
                     
					</div>

				</div>
			</div>
	</div>

</div>

</asp:Content>
