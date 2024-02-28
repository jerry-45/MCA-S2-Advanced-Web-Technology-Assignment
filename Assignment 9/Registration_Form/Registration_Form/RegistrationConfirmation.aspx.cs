using System;

public partial class RegistrationConfirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string fullName = Request.QueryString["fullName"];
            string email = Request.QueryString["email"];

            lblFullName.Text = "Full Name: " + fullName;
            lblEmail.Text = "Email: " + email;
        }
    }
}
