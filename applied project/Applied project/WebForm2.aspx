<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Applied_project.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    CLUB MANAGEMENT</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server" onsubmit="validateCaptcha()">
        <p>
            Email Address <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Confirm Password <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            First Name&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>            
        </p>
        
        <p>
            Last Name <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>            
        </p>
       <p>
            Date of Birth <input type ="date" id="date" >
           <i class="fa fa-calendar"></i>
       </p>
    <br />
        <p>
        <asp:Button ID="Button1" runat="server" class= "button" Text="Button" />
    </p> 
    </form>    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">           
          <div id="captcha" style="margin-left:262px; text-align:center; width:240px; 
            background-color: Lightgray;">
           </div>
         <p>
          <input type="text" placeholder="Type the Characters you see" id="cpatchaTextBox"
              style= "margin-left:262px;"/>
        </p>
</asp:Content>
