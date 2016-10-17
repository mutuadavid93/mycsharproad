<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BankingQueue.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;font-weight:bolder; ">
            <h2>BANKING QUEUE SYSTEM</h2>
        </div>
    <div class="col-xs-12 col-sm-10 col-sm-offset-1 col-md-10 col-md-offset-1">
        <table class="table" style="font-family: Arial; border: 1px solid black; text-align: center;background-color:papayawhip;">
            <tr>
                <td>
                    <b>Counter 1</b>
                </td>
                <td>

                </td>
                <td>
                    <b>Counter 2</b>
                </td>
                <td>

                </td>
                <td>
                    <b>Counter 3</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="TextCounter1" CssClass="form-control" runat="server" BackColor="#0000CC" Font-Size="Large" ForeColor="White" Width="100%"></asp:TextBox>
                </td>
                <td>

                </td>
                <td>
                    <asp:TextBox ID="TextCounter2" CssClass="form-control" runat="server" BackColor="#0000CC" Font-Size="Large" ForeColor="White" Width="100%"></asp:TextBox>
                </td>
                <td>

                </td>
                <td>
                    <asp:TextBox ID="TextCounter3" CssClass="form-control" runat="server" BackColor="#0000CC" Font-Size="Large" ForeColor="White" Width="100%"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnCounter1" CssClass="btn btn-success btn-block" runat="server" Text="Next"  OnClick="btnCounter1_Click" />
                </td>
                <td>

                </td>
                <td>
                    <asp:Button ID="btnCounter2" CssClass="btn btn-success btn-block" runat="server" Text="Next"  OnClick="btnCounter2_Click" />
                </td>
                <td>

                </td>
                <td>
                    <asp:Button ID="btnCounter3" CssClass="btn btn-success btn-block" runat="server" Text="Next"  OnClick="btnCounter3_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:TextBox ID="txtDisplay" CssClass="form-control" runat="server" BackColor="#006600" Font-Size="Large" ForeColor="White" Width="100%" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:ListBox ID="listTokens"  Font-Size="Large" runat="server" Width="100px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td colspan="5" class="auto-style1">
                    <asp:Button ID="btnToken" CssClass="btn btn-primary" runat="server" Text="Print Token" OnClick="btnToken_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Label ID="lblStatus" runat="server" Text="Dear customer, please print your token number."></asp:Label>
                </td>
            </tr>
            <tr>
                <td>

                </td>
            </tr>
        </table>
    </div>
    </form>

    <script src="Bootstrap/js/jquery.min.js"></script>
    <script src="Bootstrap/js/bootstrap.min.js"></script>
</body>
</html>
