<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelpDesk._Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<title></title>
<style type="text/css" media="screen">
@import "styles.css";
</style>
<script type="text/javascript" src="clear.js">
</script>
</head>
<body>
<asp:PlaceHolder ID="phForm" runat="server" Visible="true">
<form id="form1" runat="server">
<div class="row">
<label for="firstName">First Name:</label>    
<asp:TextBox ID="fnameTB" runat="server" />
</div>
<div class="row">
<label for="lastName">Last Name:</label>
<asp:TextBox ID="lnameTB" runat="server" />
</div>
<div class="row">
<label for="email">Email:</label>
<asp:TextBox ID="emailTB" runat="server" />
</div>
<div class="row">
<label for="severity">Severity:</label>
<asp:DropDownList ID="ddlSeverity" runat="server" />
</div>
<div class="row">
<label for="status">Status:</label>
<asp:DropDownList ID="ddlStatus" runat="server" />
</div>
<div class="row">
<label for="department">Department:</label>
<asp:DropDownList ID="ddlDept" runat="server" />
</div>
<div class="row">
<label for="employee">Assigned to:</label>
<asp:DropDownList ID="ddlEmp" runat="server" />
</div>
<div class="row">
<label for="comments">Comments:</label>
<asp:TextBox ID="commentsTB" runat="server" TextMode="MultiLine" />
</div>
<div class="row">
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
<asp:Button ID="btnClear" runat="server" Text="Clear" OnClientClick="clear_Fields();" />
</div>
</form>
</asp:PlaceHolder>
<asp:PlaceHolder ID="phSuccess" runat="server" Visible="false">
<p>Ticket submitted successfully.</p>
<p><a href="Default.aspx">Submit another ticket</a></p>
</asp:PlaceHolder>
</body>
</html>