<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Temp.WebTemplate.Edu.jhbae.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlFruits" runat="server" DataTextField="FruitName" DataValueField="FruitID"></asp:DropDownList>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="선택 확인" OnClick="btnSubmit_Click" />
            <br />
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
        
    </form>
</body>
</html>
