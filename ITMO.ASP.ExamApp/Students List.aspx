<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students List.aspx.cs" Inherits="ITMO.ASP.ExamApp.Students_List" MasterPageFile="~/Site.Master"%>

<asp:Content ID="MainContent" ContentPlaceHolderID="ContentPlaceHolder1" 
runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1" Width="273px" AllowSorting="True">
        <Columns>
            <asp:BoundField DataField="LastName" HeaderText="Фамилия" ReadOnly="True" SortExpression="LastName" />
            <asp:BoundField DataField="FirstName" HeaderText="Имя" ReadOnly="True" SortExpression="FirstName" />
            <asp:BoundField DataField="Mark" HeaderText="Оценка" ReadOnly="True" SortExpression="Mark" />
        </Columns>
    </asp:GridView>
            <asp:Button ID="SumButton" runat="server" Text="Сумма балов" />
            <asp:Literal ID="SumLiteral" runat="server"></asp:Literal>
    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="SampleContext" EntityTypeName="" Select="new (FirstName, LastName, Mark)" TableName="Studentstable">
    </asp:LinqDataSource>
            
        </div>
</asp:Content>
