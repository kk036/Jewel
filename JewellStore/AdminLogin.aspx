<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="JewellStore.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    
    <h1 class="display1"> <b>Admin Login </b></h1>
    <hr />
    <div class="container">

        <div class="row">
            <div class="col-md-12">

                
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Enter User Name" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtName" runat="server" Class="form-control col-md-10" placeholder="Enter user Name"></asp:TextBox>
                    </div>

                
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Enter Password" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" Class="form-control col-md-10" placeholder="Enter Password" TextMode="Password"> </asp:TextBox>
                    </div>

                    <div class="form-group">

                        <asp:Button ID="BtnSubmit" runat="server" Text="Login " Class="btn btn-primary" OnClick="BtnSubmit_Click" />
                    </div>

            </div>

        </div>
        <h1 id="result" runat="server"></h1>
    </div>
</asp:Content>
