<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="upload.aspx.cs" Inherits="PicX.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <center style="font-size: x-large; color: #800000">Upload your picture </center></p>
    
    <div style="margin-left:60px; font-size: x-large;">
        Select your Picture:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:FileUpload ID="FU" runat="server" Width="220px" />
        <br />
        <br />
        Picture Title:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_pictitle" runat="server" 
            Width="166px"></asp:TextBox>
        <br />
        <br />
        Picture Description:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="tb_picdesc" runat="server" 
            Height="42px" TextMode="MultiLine" Width="218px"></asp:TextBox>
        <br />
        <br />
        Select Category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList_category" 
            runat="server" Height="24px" Width="136px" DataSourceID="SqlDataSource1" 
            DataTextField="pcat" DataValueField="pcat">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:PhotosConnectionString %>" 
            SelectCommand="SELECT [pcat] FROM [Pics]"></asp:SqlDataSource>
        <br />
        <br />
        Select Album:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:DropDownList ID="DropDownList_album" 
            runat="server" Height="21px" Width="129px" DataSourceID="SqlDataSource2" 
            DataTextField="aname" DataValueField="aname">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:PhotosConnectionString %>" 
            SelectCommand="SELECT [atype] FROM [Albums]"></asp:SqlDataSource>
        &nbsp;&nbsp;
        <i><asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Createalbum.aspx">Create New Album</asp:HyperLink></i>
        <br />
        <br />
        <asp:Button ID="btn_uploadsubmit" runat="server" Text="Submit" 
            class="insideButton" onclick="btn_uploadsubmit_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_uploadreset" runat="server" Text="Reset" 
            class="insideButton" />
    
    
    </div>
</asp:Content>
