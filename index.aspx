<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="index.aspx.vb" Inherits="sunday_school_ms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>System Access Portal</title>
    <link runat="server" rel="stylesheet" href="../CSS/style-login.css" />
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="anonymous" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="background-container">
            <div class="login-logo-style">
                <img src="../Images/logo.png" alt="Sunday School Management System" />
                <p>古晋真道堂儿童主日学<br />资料管理系统</p>
            </div>
            <div class="btn-align">
                <asp:Button ID="BtnGeneralAccess" runat="server"
                    CssClass="btn-style"
                    Text="一般访问" />
                <asp:Button ID="BtnLogin" runat="server"
                    CssClass="btn-style"
                    ClientIDMode="Static"
                    Text="用户登录" />
            </div>
        </div>
    </form>
</body>
</html>
