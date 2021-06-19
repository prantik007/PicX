<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PicX.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <center style="font-size: xx-large; text-decoration: underline"> REGISTER YOUR 
        ACCOUNT </center>
    <p style="color: #993300; font-size: x-large; font-weight: bold; text-align:left; margin-left:20px;">
    
        <br />
        First Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_fname" runat="server" Width="224px"></asp:TextBox>
        <br />
        <br />
        Last Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_lname" runat="server" Width="229px"></asp:TextBox>
        <br />
        <br />
        Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_addr" runat="server" Width="347px" TextMode="MultiLine"></asp:TextBox>
        <br />
        <br />
        Contact Number: <asp:TextBox ID="tb_cntno" runat="server" Width="229px"></asp:TextBox>
        <br />
        <br />
        Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_email" runat="server" Width="227px"></asp:TextBox>
        <br />
        <br />
        UserID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_userid" runat="server" Width="226px"></asp:TextBox>
        <br />
        <br />
        Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_pw" runat="server" Width="223px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Retype Password: <asp:TextBox ID="tb_repw" runat="server" Width="216px" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        Security Question:<asp:DropDownList ID="DropDownList_SQ" runat="server" 
            Height="32px" Width="212px">
            <asp:ListItem Selected="True">What is your pet name</asp:ListItem>
            <asp:ListItem>What is your birthday</asp:ListItem>
            <asp:ListItem>What city you live in?</asp:ListItem>
        </asp:DropDownList>
    
    
    
    </p>
    <p style="color: #993300; font-size: x-large; font-weight: bold; text-align:left; margin-left:20px;">
    
    
    
        Answer:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tb_sa" runat="server" Width="216px"></asp:TextBox>
    
    </p>
    <p style="color: #993300; font-size: x-large; font-weight: bold; text-align:left; margin-left:20px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_reg" runat="server" onclick="btn_reg_Click" 
            Text="Register" class="insideButton"  />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_clear" runat="server" Text="Clear" class="insideButton" 
            onclick="btn_clear_Click" />
        <br />
    
    </p>
    <p style="color: red; font-size: x-large; font-weight: bold; text-align:left; margin-left:20px;">
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lbl_error" runat="server" Text="Label"></asp:Label>
        <br />
    
    </p>
</asp:Content>
