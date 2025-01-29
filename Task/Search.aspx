<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Task.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="display:flex;">
            <asp:TextBox ID="searchBookId" runat="server" placeholder="Enter Book ID" CssClass="form-control" style="width:30%"/>
<asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary" OnClick="Search_Click" />
                </div>
            <br />
            <br />
             <h2>Books List</h2>
 <table class="table table-bordered">
     <thead>
         <tr>
             <th>ID</th>
             <th>Name</th>
             <th>Kind</th>
             <th>Level</th>
         </tr>
     </thead>
     <tbody id="booksTableBody" runat="server">
         <!-- Data will be dynamically populated here -->
     </tbody>
 </table>

        </div>
    </form>
</body>
</html>
