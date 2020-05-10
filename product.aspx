<%@ Page Title="" Language="C#" MasterPageFile="~/stjup.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="stjup.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div>
	
	<div class="limiter">
		<div class="container-login100" style="background-image: url('images/bg-01.jpg');">
			<div class="wrap-login100 p-t-30 p-b-50">
				<span class="login100-form-title p-b-41">
					Stationery Categories
				</span>
				<div class="login100-form validate-form p-b-33 p-t-5">

				  <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnbooks" runat="server" class="login100-form-btn" Text="Books" OnClick="btnbooks_Click">                           
						</asp:Button>	
                        </div>

                    	<div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnpens" runat="server" class="login100-form-btn" Text="Pens" OnClick="btnpens_Click">                           
						</asp:Button>	
                        </div>


                        <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnbags" runat="server" class="login100-form-btn" Text="Bags" OnClick="btnbags_Click">                           
						</asp:Button>	
                        </div>

                        <div class="container-login100-form-btn m-t-32">
						<asp:Button ID="btnnotebooks" runat="server" class="login100-form-btn" Text="Notebooks" OnClick="btnnotebooks_Click">                           
						</asp:Button>	
                        </div>





                        <div runat="server" id ="report"></div>
                        </div>
                     
					</div>

				</div>
			</div>
	</div>

</div>









</asp:Content>
