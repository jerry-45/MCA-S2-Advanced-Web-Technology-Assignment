using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

public partial class RegistrationForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;

            // Save the registration data or perform any other necessary actions

            Response.Redirect("RegistrationConfirmation.aspx?fullName=" + Server.UrlEncode(fullName) + "&email=" + Server.UrlEncode(email));
        }
    }
}
