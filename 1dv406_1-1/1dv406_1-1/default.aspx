<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1dv406_1_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
    <link href="~/Style.css" rel="stylesheet" />
</head>
<body>
    <form id="MyForm" runat="server">
        <div id="maincontainer">
            <h1>
                <asp:Label ID="TitleLabel" runat="server" Text="Hur många versaler?" CssClass="header"></asp:Label>
            </h1>
            <div>
                <asp:TextBox ID="TextBoxArea" TextMode="multiline" Columns="70" Rows="10" runat="server" CssClass="textarea"></asp:TextBox>
            </div>
            <p>
                <asp:Label ID="ResultInfo" runat="server" Visible="false"></asp:Label>
            </p>
            <p>
                <asp:Button ID="SendButton" runat="server" Text="Beräkna antalet versaler" OnClick="SendButton_Click" />
            </p>
        </div>
    </form>
</body>
</html>
