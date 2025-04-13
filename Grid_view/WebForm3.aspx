<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Grid_view.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" ShowHeader="true" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="username">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("username") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="passward">
                       <ItemTemplate>
                          <asp:Label ID="Label2" runat="server" Text='<%# Eval("pwd") %>'></asp:Label>
                       </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Email">
                      <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("email") %>'></asp:Label>
                      </ItemTemplate>
                   </asp:TemplateField>

                    <asp:TemplateField HeaderText="phone">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Eval("phno") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
         
        </div>
    </form>
</body>
</html>
