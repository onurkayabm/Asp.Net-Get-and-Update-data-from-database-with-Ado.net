<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="_20170511_OdevMasterPage.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Product ID<asp:DropDownList  ID="ddProduct" runat="server" Height="36px" Width="127px"  AutoPostBack="True" OnSelectedIndexChanged="ddProduct_SelectedIndexChanged" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Product No:<asp:TextBox ID="txtProductID" runat="server" Enabled="false"></asp:TextBox>
       Product Adı: <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
       Fiyat :  <asp:TextBox ID="txtUnitPrice" runat="server"></asp:TextBox>
            <asp:Button ID="btnProductGuncelle" runat="server" Text="Güncelle" OnClick="btnProductGuncelle_Click"  />
        </div>
       
    </div>
</asp:Content>
