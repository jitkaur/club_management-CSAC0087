﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="Applied_project.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <p>
        CLUB MANAGEMENT</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p>
        Welcome</p>
    <p>
        My Profile</p>
    <p style="background-color: lightblue; width: 430px;">
        Users</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <form id="form1" runat="server">
    <p style="font-size: large">
        USERS</p>
        <p style="text-align: right">
            <asp:LinkButton ID="LinkButton1" class="btn" runat="server" OnClick="LinkButton1_Click"><i class="fa fa-eye">View</i></asp:LinkButton>&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" class="btn" runat="server" OnClick="LinkButton2_Click"><i class="fa fa-pencil">Edit</i></asp:LinkButton>&nbsp;</p>
        <br />
        Department
        <asp:DropDownList ID="DropDownList1" class="DropDownList" runat="server" Width="174px">
            <asp:ListItem>All</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <i class="fa fa-search" style="border-color: #FFFFFF; background-color: #FFFFFF; "></i>
        &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" class="button" runat="server" Text="Search" />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [User_Id], [First_Name], [Last_Name], [Access_Type], [Department] FROM [auser]"></asp:SqlDataSource>
        &nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="User_Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="995px" AllowSorting="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <EditItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" cssclass="mycheckbox" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="User_Id" HeaderText="User_Id" ReadOnly="True" SortExpression="User_Id" />
                <asp:BoundField DataField="First_Name" HeaderText="First_Name" SortExpression="First_Name" />
                <asp:BoundField DataField="Last_Name" HeaderText="Last_Name" SortExpression="Last_Name" />
                <asp:BoundField DataField="Access_Type" HeaderText="Access_Type" SortExpression="Access_Type" />
                <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
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
        <br />
    </form>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder4" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder5" runat="server">
</asp:Content>
