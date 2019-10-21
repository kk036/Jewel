<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addProduct.aspx.cs" Inherits="JewellStore.addProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    
    <br />
    <br />
    
    <h1 class="display1"> <b>Add Jewellery </b></h1>
    <hr />
    <div class="container">

        <div class="row">
            <div class="col-md-12">

                
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Enter category" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtCat" runat="server" Class="form-control col-md-10" placeholder="Enter Category" required=""></asp:TextBox>
                    </div>

                
                    <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="Description" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="txtDescription" runat="server" Class="form-control col-md-10" placeholder="Enter Description " required=""> </asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="size" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="TxtSize" runat="server" Class="form-control col-md-10" placeholder="Enter Size " required=""> </asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label4" runat="server" Text="Price" Class="col-md-2"></asp:Label>
                        <asp:TextBox ID="TxtPrice" runat="server" Class="form-control col-md-10" placeholder="Enter price " TextMode="Number" required=""> </asp:TextBox>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label5" runat="server" Text="Upload Photo" Class="col-md-2"></asp:Label>


                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </div>




                    <div class="form-group">

                        <asp:Button ID="BtnAdd" runat="server" Text="Add Product" Class="btn btn-primary" OnClick="BtnAdd_Click" />
                    </div>

            </div>

        </div>
        <h1 id="result" runat="server"></h1>
    </div>
</asp:Content>
