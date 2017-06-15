<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="_20170511_OdevMasterPage.Orders" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Order ID<asp:DropDownList  ID="ddOrder" runat="server" Height="36px" Width="127px"  AutoPostBack="True" OnSelectedIndexChanged="ddOrder_SelectedIndexChanged" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Order No:<asp:TextBox ID="txtOrderID" runat="server" Enabled="false"></asp:TextBox>
       Ship Via: <asp:TextBox ID="txtShipVia" runat="server"></asp:TextBox>
       Freight:  <asp:TextBox ID="txtFreight" runat="server"></asp:TextBox>
            <asp:Button ID="btnOrderGuncelle" runat="server" Text="Güncelle" OnClick="btnOrderGuncelle_Click"  />
        </div>
       
    </div>

</asp:Content>
