<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBooks.aspx.cs" Inherits="Task.AddBooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Id</label><br />
            <asp:TextBox ID="BookId" runat="server"></asp:TextBox><br />  
            <label>Book Name</label><br />
            <asp:TextBox ID="BookName" runat="server"></asp:TextBox><br />
            <label>Kind</label><br />
            <asp:TextBox ID="Kind" runat="server"></asp:TextBox><br />
            <label>Level</label><br />
            <asp:TextBox ID="Level" runat="server"></asp:TextBox><br />
            <asp:Button ID="AddBook" runat="server" Text="Add" OnClick="AddBook_Click" />
        </div>
    </form>
</body>
</html>
