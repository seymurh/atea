<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AteaPackageManager.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <a runat="server" href="Pages/NewFilm.aspx" class="btn btn-success" >Add</a>
        <asp:Button runat="server" CssClass="btn btn-danger" Text="Edit" OnClick="Unnamed_Click" />
    </div>
    <div class="form-group">
        <label for="name">Name:</label>
        <span id="name"><%: Film?.Name??"No Film" %></span>
    </div>
    <div class="form-group">
        <label for="name">Producer:</label>
        <span id="name"><%: Film?.Producer?.Name %></span>
    </div>
    <div class="form-group">
        <label for="name">Category:</label>
        <span id="name"><%: Film?.Category %></span>
    </div>
    <div class="form-group">
        <label for="name">Release Date:</label>
        <span id="name"><%: Film?.ReleaseDate?.ToString("dd.M.yyyy") %></span>
    </div>
    <div class="form-group">
        <label for="name">Description:</label>
        <p id="name"><%: Film?.Description %></p>
    </div>
</asp:Content>
