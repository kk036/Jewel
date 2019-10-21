using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JewellStore
{
    public partial class Contact : Page
    {

        dbClass obj = new dbClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnMsg_Click(object sender, EventArgs e)
        {
            //result.InnerHtml = "<script>alert('ok');</script>";
            //send the data to the admin for feed back 
           String query = "insert into Contact(Name,Email,Contact,Message) values('" + txtName.Text + "','" + txtEmail.Text + "','" + TxtContact.Text + "','" + TxtMessage.Text + "')";
            obj.record(query);
            result.InnerHtml = "We will Contact you soon regarding your query";
            txtEmail.Text = "";
            TxtContact.Text = "";
            TxtMessage.Text = "";
            txtName.Text = "";

        }
    }
}