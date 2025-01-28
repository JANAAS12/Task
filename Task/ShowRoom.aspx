<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowRoom.aspx.cs" Inherits="Task.ShowRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div class="container mt-5">
     <h2>Room List</h2>
     <table class="table table-bordered">
         <thead>
             <tr>
                 <th>ID</th>
                 <th>Name</th>
                 <th>Location</th>
                 <th>Capacity</th>
             </tr>
         </thead>
         <tbody id="RoomTableBody" runat="server">
             <!-- Data will be dynamically populated here -->
         </tbody>
     </table>
 </div>
    </form>
</body>
</html>
