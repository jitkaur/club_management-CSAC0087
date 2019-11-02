<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Applied_project.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Club Management</title>
    <script type="text/javascript" src="jquery.min.js"></script>
	<script type="text/javascript" src="main.js"></script>

    <link rel="stylesheet" href="StyleSheet1.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
</head>
<body>
    <form id="form1" runat="server">
      <header>
            <p>
    CLUB MANAGEMENT</p>
        </header>
        <nav>
        <p>
            Email Address <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Email should be in valid format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </p>
        <p>
            Password <asp:TextBox ID="TextBox2" type="password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password must be unique" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            Confirm Password <asp:TextBox ID="TextBox3" type="password" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password must be same" ForeColor="Red"></asp:CompareValidator>
        </p>
        <p>
            First Name&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="First name must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        
        <p>
            Last Name <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Last name must be filled" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
       <p>
            Date of Birth <asp:TextBox ID="TextBox6" type="date" runat="server"></asp:TextBox>
           <i class="fa fa-calendar">&nbsp;</i><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" ErrorMessage="Date should be in MM/DD/YYYY format" ForeColor="Red"></asp:RequiredFieldValidator>
       </p>
    <br />       
        </nav>
        <main>
            <p style="margin-top:110px;">
                <botdetect:WebFormsCaptcha ID="captchaBox" runat="server"></botdetect:WebFormsCaptcha>
            </p>
         <p>
             <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        </p>
        </main> 
        <article>            
             <p style="margin-top:150px;">
                 <asp:Button ID="Button1" runat="server" CssClass="button" Text="Sign up" OnClick="Button1_Click" />
             </p> 
        </article>
    </form>
</body>
</html>