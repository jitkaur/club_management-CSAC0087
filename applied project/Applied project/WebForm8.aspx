<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="Applied_project.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p>
        CLUB MANAGEMENT</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Welcome</p>
    <p style="background-color: lightblue; width: 430px;">
        My Profile</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <form id="form1" runat="server">
    
        <h2>USER PROFILE</h2>
        <p> 
            Email Address
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password
            <asp:TextBox ID="TextBox2" type="password" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            Date of Birth <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
           <i class="fa fa-calendar">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </i>
            <asp:Button ID="Button2" runat="server" Text="Request Elevated Access" OnClick="Button2_Click" />
    </p>
        <p>
            Access Type
            <asp:DropDownList ID="DropDownList1" class="DropDownList" runat="server">
                <asp:ListItem>Management</asp:ListItem>
                <asp:ListItem>Member</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Label1" runat="server" Font-Size="13px"></asp:Label>
        </p>
        <p>
            Phone Number <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </p>
        <p>
            Department
            <asp:DropDownList ID="DropDownList2" Class="DropDownList" runat="server">
                <asp:ListItem>Technology</asp:ListItem>
                <asp:ListItem>Soccer</asp:ListItem>
                <asp:ListItem>Adventure Sports</asp:ListItem>
                <asp:ListItem>Computer</asp:ListItem>
                <asp:ListItem>Medical</asp:ListItem>
                <asp:ListItem>Commerce</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            Address <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" class="button" runat="server" Text="Edit" Width="108px" OnClick="Button1_Click" />
        </p>
    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
