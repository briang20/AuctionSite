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
            if (!Page.IsPostBack)
            {
                ddlStates.DataSource = StatesList().Keys;
                ddlStates.DataBind();
            }
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
                    lblError.Text = "User Account Already Exists!";
                    lblError.Visible = true;
                    break;

                case -2:
                    lblError.Text = "Connection Issue!";
                    lblError.Visible = true;
                    break;

                case 1:
                    lblError.Text = "User Account Created!";
                    lblError.Visible = true;
                    btnSubmit.Enabled = false;
                    btnCancel.Text = "Close";
                    break;

                default:
                    lblError.Text = "";
                    lblError.Visible = false;
                    break;
            }

        }

        public Dictionary<string, string> StatesList()
        {
            Dictionary<string, string> states = new Dictionary<string, string>();

            states.Add("AL", "Alabama");
            states.Add("AK", "Alaska");
            states.Add("AZ", "Arizona");
            states.Add("AR", "Arkansas");
            states.Add("CA", "California");
            states.Add("CO", "Colorado");
            states.Add("CT", "Connecticut");
            states.Add("DE", "Delaware");
            states.Add("DC", "District of Columbia");
            states.Add("FL", "Florida");
            states.Add("GA", "Georgia");
            states.Add("HI", "Hawaii");
            states.Add("ID", "Idaho");
            states.Add("IL", "Illinois");
            states.Add("IN", "Indiana");
            states.Add("IA", "Iowa");
            states.Add("KS", "Kansas");
            states.Add("KY", "Kentucky");
            states.Add("LA", "Louisiana");
            states.Add("ME", "Maine");
            states.Add("MD", "Maryland");
            states.Add("MA", "Massachusetts");
            states.Add("MI", "Michigan");
            states.Add("MN", "Minnesota");
            states.Add("MS", "Mississippi");
            states.Add("MO", "Missouri");
            states.Add("MT", "Montana");
            states.Add("NE", "Nebraska");
            states.Add("NV", "Nevada");
            states.Add("NH", "New Hampshire");
            states.Add("NJ", "New Jersey");
            states.Add("NM", "New Mexico");
            states.Add("NY", "New York");
            states.Add("NC", "North Carolina");
            states.Add("ND", "North Dakota");
            states.Add("OH", "Ohio");
            states.Add("OK", "Oklahoma");
            states.Add("OR", "Oregon");
            states.Add("PA", "Pennsylvania");
            states.Add("RI", "Rhode Island");
            states.Add("SC", "South Carolina");
            states.Add("SD", "South Dakota");
            states.Add("TN", "Tennessee");
            states.Add("TX", "Texas");
            states.Add("UT", "Utah");
            states.Add("VT", "Vermont");
            states.Add("VA", "Virginia");
            states.Add("WA", "Washington");
            states.Add("WV", "West Virginia");
            states.Add("WI", "Wisconsin");
            states.Add("WY", "Wyoming");

            return states;
        }
    }
}