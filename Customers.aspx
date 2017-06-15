<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="_20170511_OdevMasterPage.Customers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Customer ID<asp:DropDownList  ID="ddCustomers" runat="server" Height="36px" Width="127px" OnSelectedIndexChanged="ddCustomers_SelectedIndexChanged" AutoPostBack="True" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Customers No:<asp:TextBox ID="txtCustomerID" runat="server" Enabled="false"></asp:TextBox>
       Company Name: <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
      
            <asp:Button ID="btnCustomersGuncelle" runat="server" Text="Güncelle" OnClick="btnCustomersGuncelle_Click"  />
        </div>
       
    </div>


</asp:Content>
