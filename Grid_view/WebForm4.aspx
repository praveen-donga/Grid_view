<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Grid_view.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                     <asp:TemplateField HeaderText="Id">
                         <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("id") %>'></asp:Label>
                         </ItemTemplate>
                      </asp:TemplateField>

                     <asp:TemplateField HeaderText="Images">
                         <ItemTemplate>
                            <image src='<%# Eval("Imageurl") %>' runat="server" alt="image" Width="100" Height="100" />
                         </ItemTemplate>
                     </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
