<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shippers.aspx.cs" Inherits="_20170511_OdevMasterPage.Shippers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Shipper ID<asp:DropDownList  ID="ddShippers" runat="server" Height="36px" Width="127px"  AutoPostBack="True" OnSelectedIndexChanged="ddShippers_SelectedIndexChanged" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Shipper No:<asp:TextBox ID="txtShippersID" runat="server" Enabled="false"></asp:TextBox>
       Şirket Adı: <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
       Telefon :  <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:Button ID="btnShippersGuncelle" runat="server" Text="Güncelle" OnClick="btnShippersGuncelle_Click"  />
        </div>
       
    </div>
</asp:Content>
