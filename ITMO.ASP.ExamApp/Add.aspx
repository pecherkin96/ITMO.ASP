<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="ITMO.ASP.ExamApp.Add" UnobtrusiveValidationMode="None" MasterPageFile="~/Site.Master" %>
<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" 
runat="server">
            <div>
                   <label>Имя студента:</label>
        <asp:TextBox ID="firstname" runat="server"></asp:TextBox> 
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="firstname" ErrorMessage="Заполните Имя" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
</div> 
<div> 
    <label>Фамилия студента:</label>
    <asp:TextBox ID="lastname" runat="server"></asp:TextBox> 
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="lastname" ErrorMessage="Заполните Фамилию" ForeColor="Red">Не оставляйте поле пустым</asp:RequiredFieldValidator>
</div> 
<div> 
    <label>Оценка студента:</label>
    <asp:TextBox ID="mark" runat="server"></asp:TextBox> 
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="mark" ErrorMessage="Оценка вне диапозона значений" ForeColor="#CC0000" MaximumValue="5" MinimumValue="1">Укажите бал от 1 до 5</asp:RangeValidator>
</div> 
<div> 
    <button type="submit">Занести студента в журнал</button> 
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" Height="64px" ForeColor="Red" />
            </div>
</asp:Content>


