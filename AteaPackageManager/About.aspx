<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AteaPackageManager.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <a runat="server" href="Pages/NewFilm.aspx" class="btn btn-success" >Add</a>
         <a href="Pages/NewFilm.aspx?id=<%# Film.Id %>" class="btn btn-danger" >Edit</a>
    </div>
    <div class="form-group">
        <label for="name">Name</label>
        <label id="name"><%: Film?.Name??"No Film" %></label>
    </div>
    <div class="form-group">
        <label for="name">Producer</label>
        <label id="name"><%: Film?.Producer?.Name %></label>
    </div>
    <div class="form-group">
        <label for="name">Category</label>
        <label id="name"><%: Film?.Category %></label>
    </div>
</asp:Content>
