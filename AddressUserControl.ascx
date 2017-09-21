<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddressUserControl.ascx.cs" Inherits="StudentRegistrationAssignment.AddressUserControl" %>
<p>
    <asp:Label ID="lblTemporaryAddress" runat="server" Text="Temporary Address"></asp:Label>
</p>
<p>
    <asp:Label ID="lblState" runat="server" Text="State"></asp:Label>
&nbsp;<asp:TextBox ID="txtTState" runat="server" style="margin-left: 48px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
    <asp:TextBox ID="txtTCity" runat="server" style="margin-left: 55px"></asp:TextBox>
</p>
<asp:Label ID="lblZipcode" runat="server" Text="Zipcode"></asp:Label>
<asp:TextBox ID="txtTZipcode" runat="server" style="margin-left: 31px"></asp:TextBox>
<p>
    &nbsp;</p>
<asp:Label ID="lblPermanentAddress" runat="server" Text="Permanent Address"></asp:Label>
<p>
    <asp:Label ID="lblPState" runat="server" Text="State"></asp:Label>
    <asp:TextBox ID="txtPState" runat="server" style="margin-left: 44px"></asp:TextBox>
</p>
<asp:Label ID="lblPCity" runat="server" Text="City"></asp:Label>
<asp:TextBox ID="txtPCity" runat="server" style="margin-left: 51px"></asp:TextBox>
<p>
    <asp:Label ID="lblPZipcode" runat="server" Text="Zipcode"></asp:Label>
    <asp:TextBox ID="txtPZipcode" runat="server" style="margin-left: 26px"></asp:TextBox>
</p>

