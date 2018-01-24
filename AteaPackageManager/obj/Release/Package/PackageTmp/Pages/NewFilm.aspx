<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewFilm.aspx.cs" Inherits="AteaPackageManager.Pages.NewFilm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="form-group">
            <label for="name">Name</label>
            <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" ID="txtName" aria-describedby="Name" placeholder="Enter name" />
            <small id="emailHelp" class="form-text text-muted">We'll never share your email with anyone else.</small>
        </div>
        <div class="form-group">
            <label for="category">Category</label>
            <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" ID="category" />
        </div>
        <div class="form-group">
            <label for="producer">Producer</label>
            <asp:DropDownList runat="server" ID="producer" DataTextField="Name" DataValueField="Id" SelectMethod="GetProducers" AutoPostBack="false"></asp:DropDownList>
        </div>
        <div class="form-group">
             <label for="releaseDate">Release Date</label>
            <asp:Calendar runat="server" ID="releaseDate" SelectedDate="<%# Film?.ReleaseDate %>"></asp:Calendar>
        </div>
        <asp:Button ID="Update" class="btn btn-primary" OnClick="InsertOrUpdateFilm" runat="server"
            CommandName="Update" Text="Save" />
    </div>
    <asp:ValidationSummary runat="server" ShowModelStateErrors="true"
        ForeColor="Red" HeaderText="Please check the following errors:" />
</asp:Content>
