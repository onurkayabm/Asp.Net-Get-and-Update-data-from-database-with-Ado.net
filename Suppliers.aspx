<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="_20170511_OdevMasterPage.Suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Suppliers ID<asp:DropDownList  ID="ddSuppliers" runat="server" Height="36px" Width="127px"  AutoPostBack="True" OnSelectedIndexChanged="ddSupliers_SelectedIndexChanged" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Supplier No:<asp:TextBox ID="txtSupplierID" runat="server" Enabled="false"></asp:TextBox>
       Company Name: <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
       Contact  Name:  <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
            <asp:Button ID="btnSuppliersGuncelle" runat="server" Text="Güncelle" OnClick="btnSuppliersGuncelle_Click"  />
        </div>
       
    </div>
</asp:Content>
