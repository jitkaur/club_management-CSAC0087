<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm12.aspx.cs" Inherits="Applied_project.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    <p>
        CLUB MANAGEMENT</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Welcome</p>
    <p>
        My Profile</p>
    <p style="background-color: lightblue; width: 430px;">
        Users</p>
    <p>
        Access Requests</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <form id="form1" runat="server">
    <p style="font-size: large">
        ACCESS REQUESTS</p>
        <br />
        <br />
        <br />
        <br />
        Department&nbsp;
        <asp:DropDownList ID="DropDownList1" Class="DropDownList" runat="server" Width="174px">
            <asp:ListItem>All</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <i class="fa fa-search" style="border-color: #FFFFFF; background-color: #FFFFFF; "></i>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" class= "button" runat="server" Text="Search" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" class= "button" runat="server" Text="Approve" />
&nbsp;<asp:Button ID="Button3" class= "button" runat="server" Text="Decline" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Request Id] AS Request_Id, [First Name] AS First_Name, [Last Name] AS Last_Name, [Department], [Request Status] AS Request_Status FROM [accessuser]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Request_Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" style="margin-right: 0px" Width="995px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Request_Id" HeaderText="Request_Id" ReadOnly="True" SortExpression="Request_Id" />
                <asp:BoundField DataField="First_Name" HeaderText="First_Name" SortExpression="First_Name" />
                <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" SortExpression="Last_Name" />
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                <asp:BoundField DataField="Request_Status" HeaderText="Request_Status" SortExpression="Request_Status" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
