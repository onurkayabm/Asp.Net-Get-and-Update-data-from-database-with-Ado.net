<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="_20170511_OdevMasterPage.Employees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div style="margin-top: 100px; margin-left: 350px; margin-bottom: 100px;">

         Employee ID<asp:DropDownList  ID="ddEmployee" runat="server" Height="36px" Width="127px"  AutoPostBack="True" OnSelectedIndexChanged="ddEmployee_SelectedIndexChanged" >

    </asp:DropDownList>
        <div style="width: 150px; height: 300px; margin-left: 300px;">
             Employee No:<asp:TextBox ID="txtEmployeeID" runat="server" Enabled="false"></asp:TextBox>
       ÇAlışan Adı: <asp:TextBox ID="txtEmployeeFirstName" runat="server"></asp:TextBox>
       Çalışan Soyadı:  <asp:TextBox ID="txtEmployeeLastName" runat="server"></asp:TextBox>
            <asp:Button ID="btnEmployeeGuncelle" runat="server" Text="Güncelle" OnClick="btnEmployeeGuncelle_Click"  />
        </div>
       
    </div>

</asp:Content>
