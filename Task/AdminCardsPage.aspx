<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminCardsPage.aspx.cs" Inherits="Task.AdminCardsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
                <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <h2 style="text-align:center">Power Of Library Owner </h2>
            <div style="display:flex;justify-content:center;align-items:center">
            <div class="card" style="width: 18rem; ">
  
  <div class="card-body">
    <h5 class="card-title">Add Books</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    
      <asp:Button ID="AddBooks" runat="server" Text="Add" OnClick="AddBooks_Click" />
  </div>
</div>

            <div class="card" style="width: 18rem;">
  
  <div class="card-body">
    <h5 class="card-title">Add meeting room</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
   
     <asp:Button ID="AddRoom" runat="server" Text="Add" OnClick="AddRoom_Click" />
  </div>
</div>



                            <div class="card" style="width: 18rem;">
  
  <div class="card-body">
    <h5 class="card-title">Edit Books</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
   
     <asp:Button ID="EditBooks" runat="server" Text="Edit" OnClick="EditBooks_Click" />
  </div>
</div>

        </div>
        </div>
    </form>
</body>
</html>
