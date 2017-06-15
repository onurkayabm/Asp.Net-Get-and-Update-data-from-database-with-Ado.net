<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="_20170511_OdevMasterPage.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Category ID<asp:DropDownList  ID="ddCategories" runat="server" Height="36px" Width="127px" OnSelectedIndexChanged="ddCategories_SelectedIndexChanged" AutoPostBack="True" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Category No:<asp:TextBox ID="txtCategoryID" runat="server" Enabled="false"></asp:TextBox>
       Category Adı: <asp:TextBox ID="txtCategoryName" runat="server"></asp:TextBox>
       Category Açıklama:  <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            <asp:Button ID="btnGuncelle" runat="server" Text="Güncelle" OnClick="btnGuncelle_Click" />
        </div>
       
    </div>
   
</asp:Content>
