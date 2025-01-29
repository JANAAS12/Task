<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="Task.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <label>Name:</label>
                <asp:TextBox ID="userName" runat="server" CssClass="form-control" ReadOnly="true"/>
                <label>Email:</label>
                <asp:TextBox ID="userEmail" runat="server" CssClass="form-control" ReadOnly="true" />
                <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnUpdate_Click" />
                 <asp:Button ID="Save" runat="server" Text="Save" CssClass="btn btn-primary" Visible="false" OnClick="Save_Click" />
            </div>
        </div>
    </form>
</body>
</html>
