<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AteaPackageManager._Default" %>
<%@ Import Namespace="AteaPackageManager.Entities" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-10" >
            <h2>Films</h2>
            <asp:GridView CssClass="table table-stripped table-hover" ID="GridViewFilms" DataSourceID="FilmsDataSource" AllowCustomPaging ="true" AutoGenerateColumns ="false" PersistedSelection="true" PagerSettings-Mode="Numeric" runat="server" AllowPaging ="true" PageSize="2" >
                <Columns>
                    <asp:BoundField  HeaderText="Name" DataField="Name" />
                    <asp:BoundField  HeaderText="Category"  DataField="Category" />
                    <asp:BoundField  HeaderText="Release Date"  DataField="ReleaseDate" />
                    <asp:HyperLinkField Visible="true" Text="Details" DataNavigateUrlFormatString="~/About.aspx?id={0}" DataNavigateUrlFields="Id" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource runat="server"
                EnablePaging="true" 
                StartRowIndexParameterName="skip"
                MaximumRowsParameterName="take"
                TypeName="AteaPackageManager.Services.FilmService" ID="FilmsDataSource" SelectCountMethod="SelectCount" SelectMethod="GetData">

            </asp:ObjectDataSource>
        </div>
    </div>

</asp:Content>
