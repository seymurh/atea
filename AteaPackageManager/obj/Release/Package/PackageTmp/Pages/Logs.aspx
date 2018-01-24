<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logs.aspx.cs" Inherits="AteaPackageManager.Pages.Logs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-10" >
            <h2>Films</h2>
            <asp:GridView DataKeyNames="Id" CssClass="table table-stripped table-hover" ID="GridViewFilms" DataSourceID="LogsDataSource" AllowCustomPaging ="true" AutoGenerateColumns ="false" PersistedSelection="true" PagerSettings-Mode="Numeric" runat="server" AllowPaging ="true" PageSize="2" >
                <Columns>
                      <asp:BoundField  HeaderText="User Id"  DataField="UserId" />
                    <asp:BoundField  HeaderText="Name" DataField="Name" />
                    <asp:BoundField  HeaderText="Description"  DataField="Description" />
                    <asp:BoundField  HeaderText="Log Date"  DataField="LogDate" />
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource runat="server"
                EnablePaging="true" 
                StartRowIndexParameterName="skip"
                MaximumRowsParameterName="take"
                TypeName="AteaPackageManager.Services.LogService" ID="LogsDataSource" SelectCountMethod="SelectCount" SelectMethod="GetData">

            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
