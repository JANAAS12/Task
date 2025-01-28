<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBooks.aspx.cs" Inherits="Task.EditBooks" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Edit Books</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2>Books List</h2>
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Kind</th>
                        <th>Level</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody id="booksTableBody" runat="server">
                    <!-- Data will be dynamically populated here -->
                </tbody>
            </table>

            <!-- Edit Form (Hidden by Default) -->
            <div id="editForm" runat="server" style="display: none; margin-top: 20px;">
                <h3>Edit Book</h3>
                <div class="mb-3">
                    <label for="bookId" class="form-label">Book ID</label>
                    <asp:TextBox ID="bookId" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="bookName" class="form-label">Book Name</label>
                    <asp:TextBox ID="bookName" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="bookKind" class="form-label">Kind</label>
                    <asp:TextBox ID="bookKind" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="bookLevel" class="form-label">Level</label>
                    <asp:TextBox ID="bookLevel" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <asp:Button ID="SaveChangesButton" runat="server" CssClass="btn btn-success" Text="Save Changes" OnClick="SaveChanges_Click" />
            </div>
        </div>
    </form>
</body>
</html>
