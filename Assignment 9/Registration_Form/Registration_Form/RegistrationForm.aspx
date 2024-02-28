<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrationForm.aspx.cs" Inherits="RegistrationForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .form-group {
            margin-bottom: 20px;
        }
        .label {
            display: block;
            margin-bottom: 5px;
            font-weight: bold;
        }
        .error-message {
            color: red;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Registration Form</h2>
    <div class="form-group">
        <span class="label">Full Name:</span>
        <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvFullName" runat="server" ControlToValidate="txtFullName"
            ErrorMessage="Please enter your full name" ValidationGroup="registration" CssClass="error-message"></asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <span class="label">Email:</span>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Please enter your email" ValidationGroup="registration" CssClass="error-message"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Please enter a valid email address" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"
            ValidationGroup="registration" CssClass="error-message"></asp:RegularExpressionValidator>
    </div>
    <div class="form-group">
        <asp:Button ID="btnRegister" runat="server" Text="Register" ValidationGroup="registration" OnClick="btnRegister_Click" />
    </div>
</asp:Content>
