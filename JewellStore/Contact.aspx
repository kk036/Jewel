<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="JewellStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    
    <br />
    <br />
    
    <h1 class="display1"> <b>Contact Us </b></h1>
    <hr />
    <div class="container">

        <div class="row">
            <div class="col-md-12">
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Enter Name " Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtName" runat="server" Class="form-control col-md-10" placeholder="Enter Name" required=""></asp:TextBox>
                    </div>

                
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Email" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" Class="form-control col-md-10" placeholder="Enter Email " required=""> </asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Contact No " Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="TxtContact" runat="server" Class="form-control col-md-10" placeholder="Enter Contact" TextMode="Number"  required=""> </asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Message" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="TxtMessage" runat="server" Class="form-control col-md-10" placeholder="Enter Message "  required=""> </asp:TextBox>
                    </div>

                   



                    <div class="form-group">

                        <asp:Button ID="BtnMsg" runat="server" Text="Send Message" Class="btn btn-primary" OnClick="BtnMsg_Click"/>
                    </div>

            </div>
            </div>
        </div>
    
            <h1 id="result" runat="server"> </h1>

</asp:Content>
