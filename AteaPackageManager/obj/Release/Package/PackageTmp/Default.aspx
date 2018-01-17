<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AteaPackageManager._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-10" >
            <h2>Films</h2>
            <asp:GridView CssClass="table table-stripped table-hover" ID="GridViewFilms" runat="server">
            </asp:GridView>
        </div>
    </div>

</asp:Content>
