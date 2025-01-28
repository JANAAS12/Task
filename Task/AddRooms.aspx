<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRooms.aspx.cs" Inherits="Task.AddRooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Id</label><br />
             <asp:TextBox ID="RoomId" runat="server"></asp:TextBox><br />  
               <label>Room Name</label><br />
               <asp:TextBox ID="RoomName" runat="server"></asp:TextBox><br />
                 <label>Location</label><br />
                <asp:TextBox ID="Location" runat="server"></asp:TextBox><br />
                  <label>Capacity</label><br />
                    <asp:TextBox ID="Capacity" runat="server"></asp:TextBox><br />
                    <asp:Button ID="AddRoom" runat="server" Text="Add" OnClick="AddRoom_Click" />
        </div>
    </form>
</body>
</html>
