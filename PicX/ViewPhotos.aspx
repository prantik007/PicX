<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPhotos.aspx.cs" Inherits="PicX.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1><strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; View Album</strong></h1>
<h4>&nbsp;</h4><div style="font-size: large; color: #993300">
    <p>
    <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_viewalb" runat="server" Text="View Album" 
            class="insideButton" onclick="btn_viewalb_Click" Width="282px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="View All Public Albums" 
            class="insideButton" Width="282px" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="View All Shared Albums" 
            class="insideButton" Width="282px" />
    </div>
    </p>
    <p>
        &nbsp;</p>
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_selectalbum" runat="server" Text="Select Your Album :"></asp:Label>
        &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_album" runat="server" Height="18px" 
            Width="110px" 
            onselectedindexchanged="DropDownList_album_SelectedIndexChanged" 
            DataSourceID="SqlDataSource1" DataTextField="atype" DataValueField="atype">
        </asp:DropDownList>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:PhotosConnectionString %>" 
            SelectCommand="SELECT [atype] FROM [Albums]"></asp:SqlDataSource>
    
    </div>
    
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_filter" runat="server" Text="Filter By Category :"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_category" runat="server" Height="18px" 
        Width="110px">
        </asp:DropDownList>
    
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_view" runat="server" Text="View" class="insideButton" 
        onclick="btn_view_Click" />
    <br />
    
    </div>
</asp:Content>
