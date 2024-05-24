<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmpMangSystem_WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">




    <table style="width: 100%; border: 2px solid #000000; background-color: #CEFBFD">
        <tr>
            <td colspan="6" style="border: thin solid #FF0000; height: 40px; text-align: center; font-family: Arial; font-size: large; font-weight: bold; color: #000000; background-color: #CCFF99;">CRUD operations on Employee with MS-SQL using StoreProcudures</td>
        </tr>
        <tr>
            <td style="height: 21px; text-align: center; font-weight: bold; font-family: Arial;" colspan="6"></td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; height: 27px; border-collapse: collapse;" colspan="6"></td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">EmployeeId</td>
            <td style="border: thin solid #7F0000; " colspan="3">
                <asp:TextBox ID="TextBox1" runat="server" Width="216px" Font-Bold="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">EmployeeName</td>
            <td style="border: thin solid #7F0000; " colspan="3">
                <asp:TextBox ID="TextBox2" runat="server" Width="216px" Font-Bold="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">Email</td>
            <td style="border: thin solid #7F0000; " colspan="3">
                <asp:TextBox ID="TextBox3" runat="server" Width="216px" Font-Bold="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">Salary</td>
            <td style="border: thin solid #7F0000; " colspan="3">
                <asp:TextBox ID="TextBox4" runat="server" Width="216px" Font-Bold="True"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">Gender</td>
            <td colspan="3" style="border: thin solid #7F0000; ">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" BorderColor="Silver" BorderWidth="2px" Font-Bold="True" RepeatDirection="Horizontal" style="margin-left: 0px" Width="220px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; padding-left: 150px; width: 2px; font-weight: bold; font-size: large;" colspan="3">Role</td>
            <td aria-orientation="horizontal" colspan="3" style="border: thin solid #7F0000; ">
                <asp:DropDownList ID="DropDownList1" runat="server" Font-Bold="True" Width="222px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem>Backend Developer</asp:ListItem>
                    <asp:ListItem>Frontend Developer</asp:ListItem>
                    <asp:ListItem>FullStack Developer</asp:ListItem>
                    <asp:ListItem>Manager</asp:ListItem>
                    <asp:ListItem>H.R</asp:ListItem>
                    <asp:ListItem>CEO</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; border-collapse: collapse; height: 25px;" colspan="6"></td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000; text-align: center; vertical-align: middle;" draggable="true">
                <asp:Button ID="Button1" runat="server" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="32px" Text="Insert" Width="83px" OnClick="Insert_Click" />
            </td>
            <td style="border: thin solid #7F0000; text-align: center; vertical-align: middle;" draggable="true">
                <asp:Button ID="Button2" runat="server" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="32px" Text="Update" Width="83px" OnClick="Update_Click" />
            </td>
            <td style="border: thin solid #7F0000; text-align: center; vertical-align: middle;" colspan="2" draggable="true">
                <asp:Button ID="Button3" runat="server" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="32px" Text="Fetch" Width="83px" OnClick="Fetch_Click" />
            </td>
            <td style="border: thin solid #7F0000; text-align: center; vertical-align: middle;" draggable="true">
                <asp:Button ID="Button4" runat="server" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="32px" Text="Delete" Width="83px" OnClick="Delete_Click" OnClientClick="return confirm('Are you sure to delete?')" />
            </td>
            <td style="border: thin solid #7F0000; text-align: center; vertical-align: middle;" draggable="true">
                <asp:Button ID="Button5" runat="server" BackColor="#FFCCFF" BorderStyle="Groove" Font-Bold="True" Font-Size="Large" Height="32px" OnClick="Clear_Click" Text="Clear" Width="83px" />
            </td>
        </tr>
        <tr>
            <td style="border: thin solid #7F0000;" colspan="6"></td>
        </tr>
        <tr>
            <td style="height: 153px; " colspan="6">
                <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#FFFFCC" BorderStyle="Solid" BorderWidth="4px" CellPadding="3" CellSpacing="2" HorizontalAlign="Center" Width="645px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <AlternatingRowStyle BackColor="#FFFF99" />
                    <EditRowStyle BorderStyle="Solid" BorderWidth="2px" />
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#FF9966" Font-Bold="True" ForeColor="White" BorderStyle="Solid" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="border-color: Hex=; border-width: thin; border-style: solid; height: 26px; " colspan="6">
            </td>
        </tr>
    </table>

    <br /><br /><br />
    <hr />
    <br /><br /><br />


</asp:Content>
