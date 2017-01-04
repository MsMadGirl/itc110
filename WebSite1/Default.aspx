<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Order Menu</h1>
        <h2>Entrees</h2>
        <asp:checkboxlist ID="CBLEntree" runat="server">

        </asp:checkboxlist>
        <h2>Drinks</h2>
        <asp:CheckBoxList ID="CBLDrinks" runat="server" OnClick="Button1_Click"></asp:CheckBoxList>
   
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </p>
        
        
    </form> 
    </div>
</body>
</html>

