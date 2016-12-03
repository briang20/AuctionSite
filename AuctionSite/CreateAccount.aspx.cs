using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AuctionLib;

namespace AuctionSite
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int success=0;
            User user = new User();

            user.userName = txtUsername.Text;
            user.firstName = txtFirstName.Text;
            user.lastName = txtLastName.Text;
            user.password = txtPassword.Text;
            user.addressOne = txtAdd1.Text;
            user.addressTwo = txtAdd2.Text;
            user.city = txtCity.Text;
            user.state = ddlStates.SelectedValue;
            user.zip = txtZip.Text;

            success= user.CreateNewUser(user);

            switch (success)
            {
                case -1:
                    lblError.Text = "Connection Issue!";
                    lblError.Visible = true;
                    break;

                case 0:
                    lblError.Text = "User Account Already Exists!";
                    lblError.Visible = true;
                    break;

                case 1:
                    lblError.Text = "User Account Created!";
                    lblError.Visible = true;
                    btnSubmit.Enabled = false;
                    break;

                default:
                    lblError.Text = "You Should see this";
                    lblError.Visible = true;
                    break;
            }



        }
    }
}